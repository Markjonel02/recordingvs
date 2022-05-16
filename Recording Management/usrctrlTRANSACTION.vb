Public Class usrctrlTRANSACTION
    Dim switch As Boolean = True
    Private Sub usrctrlTRANSACTION_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Tbl_borrowerTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_borrower)
        Me.Tbl_addtocartTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_addtocart)
        Me.Tbl_itemsTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_items)
        checkcartGrid()
    End Sub
    Private Sub disabled()
        TXTFULLN.Enabled = False
        TXTIC.Enabled = False
        TXTIN.Enabled = False
        TXTAVAILS.Enabled = False
        TXTSTUDF.Enabled = False
        TXTBORR.Enabled = False
        btnBrowse.Enabled = False
        btnbrowse2.Enabled = False
    End Sub
    'enabled 
    Private Sub enable()
        btnBrowse.Enabled = True
        btnbrowse2.Enabled = True
        btnADDtocart.Enabled = True

    End Sub

    Private Sub checkcartGrid()
        If DGV_cart.Rows.Count = 0 Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub
    Private Sub Getmax()
        opencon()
        cmd.CommandText = "Select * from tbl_transaction"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            opencon()
            cmd.CommandText = "Select Max(transaction_id) from tbl_transaction"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            TXTID.Text = getno + 1
        Else
            TXTID.Text = 1
            con.Close()
        End If
    End Sub



    Private Sub Getmaxcart()
        opencon()
        cmd.CommandText = "Select * from tbl_addtocart"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            opencon()
            cmd.CommandText = "Select Max(transaction_id) from tbl_addtocart"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            TXTID.Text = getno + 1
        Else
            TXTID.Text = 1
            con.Close()
        End If
    End Sub



    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        DGV_borrow.Visible = True
        DGV_borrow.Location = New Point(13, 8)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If switch = False Then
            Getmaxcart()
        Else
            Getmax()
            switch = False
        End If

        enable()

    End Sub

    Private Sub ACTLOG()
        con.Close()
        con.Open()
        cmd.CommandText = "insert into tbl_activitylog values (@un, @act, @dt)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", FRMMAINMENU.lblgreet.Text)
            .AddWithValue("act", Act)
            .AddWithValue("dt", Date.Now())
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub




    'save 
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim i As Integer

        'transactionid increment 


        ' insert to tbl_transaction

        For i = 0 To DGV_cart.Rows.Count - 1

            con.Open()
            cmd.CommandText = "insert into tbl_transaction values(@tid, @fn, @bt, @sfn, @ic, @in, @qt, @db, @drd )"
            With cmd.Parameters
                .Clear()
                .AddWithValue("tid", DGV_cart.Rows(i).Cells(0).Value.ToString)
                .AddWithValue("fn", DGV_cart.Rows(i).Cells(1).Value.ToString)
                .AddWithValue("sfn", DGV_cart.Rows(i).Cells(3).Value.ToString)
                .AddWithValue("ic", DGV_cart.Rows(i).Cells(4).Value.ToString)
                .AddWithValue("in", DGV_cart.Rows(i).Cells(5).Value.ToString)
                .AddWithValue("bt", DGV_cart.Rows(i).Cells(2).Value.ToString)
                .AddWithValue("qt", DGV_cart.Rows(i).Cells(6).Value.ToString)
                .AddWithValue("db", Format(Date.Now, "dd MM yyyy"))
                .AddWithValue("drd", "")

            End With
            cmd.ExecuteNonQuery()
            con.Close()


        Next
        ' Fetch available stocks
        Dim qty, updatedstock As Integer
        Dim availstock As ArrayList = New ArrayList()

        For i = 0 To DGV_cart.Rows.Count - 1
            con.Open()
            cmd.CommandText = "select available_stock from tbl_items where itemcode=@itc"
            With cmd.Parameters
                .Clear()
                .AddWithValue("itc", Val(DGV_cart.Rows(i).Cells(4).Value))
            End With
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader


            dr.Read()

            availstock.Add(dr(0))

            con.Close()
        Next
        For Each i In availstock
            Console.WriteLine("{0}", i)
        Next i

        For i = 0 To DGV_cart.Rows.Count - 1
            con.Open()
            cmd.CommandText = "Update tbl_items set available_stock=@as where itemcode= @itc"
            qty = Val(DGV_cart.Rows(i).Cells(6).Value)
            updatedstock = availstock(i) - qty

            With cmd.Parameters
                .Clear()
                .AddWithValue("as", updatedstock)
                .AddWithValue("itc", Val(DGV_cart.Rows(i).Cells(4).Value))
            End With
            cmd.ExecuteNonQuery()
            con.Close()
        Next

        'delete to cart after save 

        con.Open()
        cmd.CommandText = "delete from tbl_addtocart"
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Items successfully borrowed!", vbOKOnly + vbInformation)
        Act = "items borrowed "
        ACTLOG()


        TXTID.Text = ""
        TXTIC.Text = ""
        TXTSTUDF.Text = ""
        TXTIN.Text = ""
        TXTSTUDF.Text = ""
        TXTFULLN.Text = ""
        TXTBORR.Text = ""
        TXTQTY.Text = ""
        TXTAVAILS.Text = ""
        refreshgrid()
        disabled()
        switch = True
    End Sub





    Private Sub refreshgrid()
        Me.Tbl_borrowerTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_borrower)
        Me.Tbl_addtocartTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_addtocart)
        Me.Tbl_itemsTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_items)
    End Sub
    Private Sub DGV_borrow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_borrow.CellContentClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGV_borrow.Rows(e.RowIndex)
            TXTSTUDF.Text = row.Cells(0).Value
            TXTFULLN.Text = row.Cells(1).Value + " " + row.Cells(2).Value + " " + row.Cells(3).Value
            TXTBORR.Text = row.Cells(4).Value
            refreshgrid()
            DGV_borrow.Visible = False
        End If
    End Sub


    Private Sub btnbrowse2_Click(sender As Object, e As EventArgs) Handles btnbrowse2.Click
        DGV_items.Visible = True
        DGV_items.Location = New Point(13, 8)
    End Sub

    Private Sub DGV_items_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_items.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGV_items.Rows(e.RowIndex)
            TXTIC.Text = row.Cells(0).Value
            TXTIN.Text = row.Cells(1).Value
            Dim stock = row.Cells(3).Value
            If stock = 0 Then
                TXTAVAILS.Text = "Out of Stock"
            Else
                TXTAVAILS.Text = row.Cells(3).Value
            End If

            refreshgrid()
            DGV_items.Visible = False
            TXTQTY.Enabled = True
            TXTQTY.Focus()
        End If
    End Sub

    Private Sub btnADDtocart_Click(sender As Object, e As EventArgs) Handles btnADDtocart.Click
        Dim qty = Val(TXTQTY.Text)
        Dim avs = Val(TXTAVAILS.Text)
        If TXTBORR.Text = "" Or TXTFULLN.Text = "" Or TXTIC.Text = "" Or TXTIN.Text = "" Or TXTAVAILS.Text = "" Or TXTSTUDF.Text = "" Or TXTQTY.Text = "" Then
            MsgBox("all fields are required", vbOKOnly + vbCritical, "Error")
            Exit Sub
        ElseIf TXTAVAILS.Text = "Out of Stock" Then
            MsgBox("Item Out of Stock!", vbOKOnly + vbExclamation, "Error")
            Exit Sub
        ElseIf qty > avs Then
            MsgBox("Item quantity exceeded!", vbOKOnly + vbExclamation, "Error")
            Exit Sub
        End If
        ' ADD to cart

        opencon()
        cmd.CommandText = "insert into tbl_addtocart values(@tid, @fn, @bt, @sfn, @ic, @in, @qt)"
        Dim quantity = Val(TXTQTY.Text)
        Dim stock = Val(TXTAVAILS.Text)
        Dim result = quantity - stock
        Dim tid = Val(TXTID.Text)

        With cmd.Parameters
            .Clear()
            .AddWithValue("tid", tid)
            .AddWithValue("fn", TXTFULLN.Text)
            .AddWithValue("sfn", TXTSTUDF.Text)
            .AddWithValue("ic", TXTIC.Text)
            .AddWithValue("in", TXTIN.Text)
            .AddWithValue("bt", TXTBORR.Text)
            .AddWithValue("qt", quantity)

        End With
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("Successfully added to cart!", vbOKOnly + vbInformation, "Added Successful")
        Act = "cart added"
        ACTLOG()
        TXTIC.Text = ""
        TXTSTUDF.Text = ""
        TXTIN.Text = ""
        TXTSTUDF.Text = ""
        TXTFULLN.Text = ""
        TXTBORR.Text = ""
        TXTQTY.Text = ""
        TXTAVAILS.Text = ""
        disabled()
        refreshgrid()
        checkcartGrid()
    End Sub

    Private Sub TXTQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTQTY.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DGV_cart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_cart.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGV_cart.Rows(e.RowIndex)
            Dim itemno = row.Cells(4).Value
            'TXTIC.Text = row.Cells(1).Value
            Dim remove = MsgBox("Remove item from the cart? ", vbYesNo + vbQuestion, "deleting item")
            If remove = DialogResult.Yes Then
                opencon()
                cmd.CommandText = "Delete from tbl_addtocart Where item_code=@ic  "
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("ic", itemno)
                End With
                cmd.ExecuteNonQuery()
                con.Close()
                refreshgrid()
                checkcartGrid()
                MsgBox(" Item Removed ", vbOKOnly + vbInformation)

            End If

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        TXTID.Text = ""
        TXTIC.Text = ""
        TXTSTUDF.Text = ""
        TXTIN.Text = ""
        TXTSTUDF.Text = ""
        TXTFULLN.Text = ""
        TXTBORR.Text = ""
        TXTQTY.Text = ""
        TXTAVAILS.Text = ""
        disabled()
    End Sub

    Private Sub TXTQTY_TextChanged(sender As Object, e As EventArgs) Handles TXTQTY.TextChanged
        If TXTQTY.Text = String.Empty Then
            btnCancel.Enabled = False
        Else
            btnCancel.Enabled = True
        End If
    End Sub

    Private Sub pnlusrTrans_Paint(sender As Object, e As PaintEventArgs) Handles pnlusrTrans.Paint

    End Sub
End Class
