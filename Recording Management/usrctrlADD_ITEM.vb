Public Class usrctrlADD_ITEM
    Private Sub usrctrlADD_ITEM_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Tbl_itemsTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_items)
        Me.Tbl_stockaddedTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_stockadded)


    End Sub
    Private Sub dg_refresh()

        Me.Tbl_itemsTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_items)
        Me.Tbl_stockaddedTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_stockadded)
    End Sub

    Private Sub clear()

        TXTADDED.Text = ""
        TXTIName.Text = ""
        TXTITCODE.Text = ""
        TXTAVS.Text = ""
        TXTDATEADDED.Text = ""
    End Sub
    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        If TXTSEARCH.Text = "" Then
            TblstockaddedBindingSource.Filter = Nothing
            TblitemsBindingSource.Filter = Nothing
            chkeclearsearch.Visible = False
        Else
            TblitemsBindingSource.Filter = "itemname like '%" + TXTSEARCH.Text + "%' "
            TblstockaddedBindingSource.Filter = "itemname like '%" + TXTSEARCH.Text + "%' "
            chkeclearsearch.Visible = True
        End If

    End Sub


    Private Sub DG_items_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_items.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DG_items.Rows(e.RowIndex)
            TXTITCODE.Text = row.Cells(0).Value
            TXTIName.Text = row.Cells(1).Value
            TXTAVS.Text = row.Cells(3).Value
            TXTDATEADDED.Text = Format(Date.Now, "yyyy-MM-dd")
            TXTADDED.Enabled = True
            TXTADDED.Focus()
            btnAdd.Enabled = True
            btnCancel.Enabled = True



        End If
    End Sub


    Private Sub TXTADDED_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTADDED.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        btnAdd.Enabled = True


        TXTADDED.Enabled = False
        TXTIName.Enabled = False
        TXTITCODE.Enabled = False
        TXTAVS.Enabled = False
        TXTDATEADDED.Enabled = False
        clear()
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
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim stockadded = Val(TXTADDED.Text)
        Dim availableSt = Val(TXTAVS.Text)
        Dim updatedStocks = stockadded + availableSt
        Dim stockid As Integer
        If stockadded = 0 Then
            MsgBox("Indicate stocks to be added ", vbOKOnly + vbCritical, "Error adding")
            TXTADDED.Focus()
        Else
            opencon()
            cmd.CommandText = "Update tbl_items set available_stock =@as where itemname = @in"

            With cmd.Parameters
                .Clear()
                .AddWithValue("as", updatedStocks)
                .AddWithValue("in", TXTIName.Text)
            End With
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Stocks has been Added!", vbOKOnly + vbInformation, "Editing Successful")
            Act = "added a stock"
            ACTLOG()


            opencon()
            cmd.CommandText = "Select * from tbl_stockadded"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim getno As Integer
                con.Close()
                opencon()
                cmd.CommandText = "Select Max(item_code) from tbl_stockadded"
                getno = Convert.ToInt64(cmd.ExecuteScalar())
                con.Close()
                stockid = getno + 1
            Else
                stockid = 1
                con.Close()
            End If

            'inserting stock
            opencon()
            cmd.CommandText = "insert into tbl_stockadded values( @ic, @in, @as, @add  )"
            Dim itemcode = Val(TXTITCODE.Text)

            With cmd.Parameters
                .Clear()
                .AddWithValue("ic", stockid)

                .AddWithValue("in", TXTIName.Text)
                .AddWithValue("as", stockadded)
                .AddWithValue("add", TXTDATEADDED.Text)


            End With
            cmd.ExecuteNonQuery()
            con.Close()
            dg_refresh()
            clear()
        End If

    End Sub

    Private Sub chkeclearsearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkeclearsearch.CheckedChanged
        TXTSEARCH.Text = String.Empty

    End Sub

    Private Sub pnlusrctrlAdditem_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
