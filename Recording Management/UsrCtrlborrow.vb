Public Class UsrCtrlborrow
    Private Sub rptborr_Load(sender As Object, e As EventArgs) Handles rptborr.Load
        Me.rptborr.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_borrowerTableAdapter.Fill(Me.record_management_systemDataSet.tbl_borrower)
        Me.rptborr.RefreshReport()

    End Sub
End Class
