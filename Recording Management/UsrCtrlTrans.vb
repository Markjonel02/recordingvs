Public Class UsrCtrlTrans
    Private Sub rpttrans_Load(sender As Object, e As EventArgs) Handles rpttrans.Load
        Me.rpttrans.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_transactionTableAdapter.Fill(Me.record_management_systemDataSet.tbl_transaction)
        Me.rpttrans.RefreshReport()

    End Sub
End Class
