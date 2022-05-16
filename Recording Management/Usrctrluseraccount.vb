Public Class Usrctrluseraccount
    Private Sub RptuserAcc_Load(sender As Object, e As EventArgs) Handles RptuserAcc.Load
        Me.RptuserAcc.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_userTableAdapter.Fill(Me.record_management_systemDataSet.tbl_user)
        Me.RptuserAcc.RefreshReport()

    End Sub

    Private Sub Usrctrluseraccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
