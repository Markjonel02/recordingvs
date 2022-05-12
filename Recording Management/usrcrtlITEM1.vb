Imports MySql.Data.MySqlClient

Public Class usrcrtlITEM1
    Private Sub funtion_disabled()
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        txtas.Enabled = False
        txtIC.Enabled = False
        txtIN.Enabled = False
        cboitem.Enabled = False
        DtAdded.Enabled = False
    End Sub

    Private Sub function_enabled()
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnEdit.Enabled = False
        txtIC.Enabled = True
        txtIN.Enabled = True
        txtas.Enabled = True
        cboitem.Enabled = True
        DtAdded.Enabled = True
    End Sub


    'load items
    Private Sub usrcrtlITEM1_Load(sender As Object, e As EventArgs) Handles Me.Load
        funtion_disabled()
        Me.Tbl_itemsTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_items)
        txtIC.ReadOnly = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        ExitButton()
    End Sub

    'refresh
    Private Sub DGV_Refresh()
        Me.Tbl_itemsTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_items)
    End Sub


    'save code w/ error trapping 
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtIN.Text = "" Or txtIN.Text = "" Or txtas.Text = "" Or cboitem.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbExclamation, "Error Saving")
            txtIN.Focus()
            Exit Sub
        End If

        If txtIN.Text = txtIN.Text Then
            opencon()
            cmd.CommandText = "Select * from tbl_items where itemname = '" & txtIN.Text & "' "
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Item already exist!", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                txtIN.Text = ""
                cboitem.SelectedIndex = -1
                txtas.Text = ""
                txtIN.Focus()

                Exit Sub
            End If
            con.Close()
        End If
        '     Saving code
        opencon()
        cmd.CommandText = "insert into tbl_items values(@ic, @in, @icat, @as, @add)"
        Dim AvailStock = Val(txtas.Text)
        With cmd.Parameters
            .Clear()
            .AddWithValue("ic", txtIC.Text)
            .AddWithValue("in", txtIN.Text)
            .AddWithValue("icat", cboitem.Text)
            .AddWithValue("as", AvailStock)
            .AddWithValue("add", DtAdded.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New record ha been saved!", vbOKOnly + vbInformation, "Saving Successful")

        txtIC.Text = ""
        txtas.Text = ""
        txtIN.Text = ""
        cboitem.SelectedIndex = -1


        DGV_Refresh()
    End Sub


    Private Sub Getmax()
        opencon()
        cmd.CommandText = "Select * from tbl_items"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            opencon()
            cmd.CommandText = "Select Max(itemcode) from tbl_items"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            txtIC.Text = getno + 1
        Else
            txtIC.Text = 1
            con.Close()
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        function_enabled()
        Getmax()
        txtIC.Enabled = True
        txtIN.Enabled = True
        txtas.Enabled = True
    End Sub

    Private Sub txtas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtas.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = False
        txtIC.Enabled = False
        txtIN.Enabled = False
        TXTCODE.Enabled = False
        txtas.Enabled = False
        CBOITEMCAT.Enabled = False
        cboitem.Enabled = False
        txtas.Text = ""
        txtIC.Text = ""
        txtIN.Text = ""
        TXTCODE.Text = ""
        cboitem.SelectedIndex = -1
        txtIN.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MsgBox("Do you really want to delete this item?", vbYesNo + vbQuestion, "Deleting item")
        If result = DialogResult.Yes Then
            opencon()
            cmd.CommandText = "Delete from tbl_items Where itemname=@in  "
            With cmd.Parameters
                .Clear()
                .AddWithValue("in", txtIN.Text)
            End With
            cmd.ExecuteNonQuery()
            con.Close()
            txtas.Text = ""
            txtIC.Text = ""
            txtIN.Text = ""
            cboitem.SelectedIndex = -1
            DGV_Refresh()
            funtion_disabled()
            MsgBox("Item has been Deleted", vbOKOnly + vbInformation)
        End If

    End Sub

    Private Sub DGV_item_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_item.CellContentClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGV_item.Rows(e.RowIndex)
            txtIC.Text = row.Cells(0).Value
            txtIN.Text = row.Cells(1).Value
            txtas.Text = row.Cells(3).Value
            cboitem.Text = row.Cells(2).Value
            DtAdded.Text = row.Cells(4).Value
            txtIC.Enabled = False
            function_enabled()
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False

        End If
    End Sub

    Private Sub pnlusrctrlITEM_Paint(sender As Object, e As PaintEventArgs) Handles pnlusrctrlITEM.Paint

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "EDIT" Then
            If txtIN.Text = "" Or txtas.Text = "" Or cboitem.Text = "" Then
                MsgBox("All Fields are required!", vbOKOnly + vbCritical, "Error Editing")
                Exit Sub
            End If
            function_enabled()
            btnSave.Enabled = False
            btnEdit.Enabled = True
            txtIC.Enabled = False
            btnEdit.Text = "UPDATE"
            txtIN.Focus()
            'Error trapping

            'code for upate
            opencon()
            cmd.CommandText = "Update tbl_items set itemname =@in, itemcategory=@itc, available_stock=@as where itemcode= @ic"
            Dim availstock = Val(txtas.Text)
            Dim itemcode = Val(txtIC.Text)
            With cmd.Parameters
                .Clear()
                .AddWithValue("ic", itemcode)
                .AddWithValue("in", txtIN.Text)
                .AddWithValue("itc", cboitem.Text)
                .AddWithValue("as", availstock)

            End With

            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing    Successful")
            btnEdit.Text = "EDIT"
            function_enabled()
            txtIN.Text = ""
            txtas.Text = ""
            txtIC.Text = ""
            cboitem.SelectedIndex = -1
            DGV_Refresh()
        End If

    End Sub

    Private Sub txtas_TextChanged(sender As Object, e As EventArgs) Handles txtas.TextChanged

    End Sub
End Class
