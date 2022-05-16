Public Class UsrCtrlITEM
    Private Sub UsrCtrlITEM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RptITEM.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_itemsTableAdapter.Fill(Me.record_management_systemDataSet.tbl_items)
        Me.RptITEM.RefreshReport()
    End Sub

    Private Sub RptITEM_Load(sender As Object, e As EventArgs) Handles RptITEM.Load

    End Sub
End Class
