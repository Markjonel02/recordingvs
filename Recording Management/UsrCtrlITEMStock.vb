Public Class UsrCtrlITEMStock
    Private Sub UsrCtrlITEMStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RptStock.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_stockaddedTableAdapter.Fill(Me.record_management_systemDataSet.tbl_stockadded)

        Me.RptStock.RefreshReport()
    End Sub


End Class
