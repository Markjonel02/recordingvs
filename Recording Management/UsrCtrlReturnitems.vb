Public Class UsrCtrlReturnitems
    Dim itemcode, qty As Integer
    Private Sub DGV_item_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_item.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGV_item.Rows(e.RowIndex)
            TXTNAME.Text = row.Cells(1).Value
            TXTIN.Text = row.Cells(5).Value
            TXTBORR.Text = row.Cells(7).Value
            qty = row.Cells(6).Value
            itemcode = row.Cells(0).Value
            TXTBORR.Enabled = True
            TXTNAME.Enabled = True
            btnCancel.Enabled = True
            btnReturn.Enabled = True

        End If
    End Sub

    Private Sub UsrCtrlReturnitems_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Tbl_transactionTableAdapter.FillBydate_returned(Me.Record_management_systemDataSet.tbl_transaction, "")
    End Sub

    Private Sub chkeclearsearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkeclearsearch.CheckedChanged
        TXTSEARCH.Text = String.Empty
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        If TXTSEARCH.Text = "" Then

            chkeclearsearch.Visible = False
        Else
            TbltransactionBindingSource.Filter = "fullname like '%" + TXTSEARCH.Text + "%' "

            chkeclearsearch.Visible = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        TXTIN.Text = ""
        TXTNAME.Text = ""
        TXTBORR.Text = ""
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
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim astock, updatedstock
        'updating transaction / returned date
        opencon()
        cmd.CommandText = "Update tbl_transaction set date_returned =@drt where item_name= @in"

        With cmd.Parameters
            .Clear()
            .AddWithValue("drt", Format(Date.Now, "dd MM yyyy"))
            .AddWithValue("in", TXTIN.Text)

        End With

        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Item has been returned!", vbOKOnly + vbInformation, " Returned Successful")
        Act = "Item Returned "
        ACTLOG()
        opencon()
        cmd.CommandText = "select * from tbl_items where itemcode=@itc"
        With cmd.Parameters
            .Clear()
            .AddWithValue("itc", itemcode)
        End With
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        dr.Read()
        astock = dr(3)

        con.Close()
        'for updating stock
        opencon()
        cmd.CommandText = "Update tbl_items set available_stock=@as where itemcode= @itc"
        updatedstock = astock + qty

        With cmd.Parameters
            .Clear()
            .AddWithValue("as", updatedstock)
            .AddWithValue("itc", itemcode)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        Me.Tbl_transactionTableAdapter.FillBydate_returned(Me.Record_management_systemDataSet.tbl_transaction, "")
        TXTIN.Text = ""
        TXTNAME.Text = ""
        TXTBORR.Text = ""
    End Sub
End Class
