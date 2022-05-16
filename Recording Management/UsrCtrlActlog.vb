Public Class UsrCtrlActlog
    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub RptActlog_Load(sender As Object, e As EventArgs) Handles RptActlog.Load
        Me.RptActlog.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_activitylogTableAdapter.Fill(Me.record_management_systemDataSet.tbl_activitylog)
        Me.RptActlog.RefreshReport()
    End Sub
End Class
