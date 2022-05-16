Public Class Frm_reports

    Private Sub BTNACCOUNTUSER_Click(sender As Object, e As EventArgs) Handles BTNACCOUNTUSER.Click
        Dim ctr As Integer
        For ctrldash = 0 To 0
            pnlmenu.Controls.RemoveAt(ctr)
        Next
        Dim D As New Usrctrluseraccount()
        D.Parent = pnlmenu
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    'Private Sub Frm_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim ctr As Integer
    '    For ctrldash = 0 To 0
    '        pnlmenu.Controls.RemoveAt(ctr)
    '    Next
    '    Dim D As New Usrctrluseraccount()
    '    D.Parent = pnlmenu
    '    D.Show()
    '    D.Dock = DockStyle.Fill
    'End Sub

    Private Sub BTNACTLOG_Click(sender As Object, e As EventArgs) Handles BTNACTLOG.Click
        Dim ctr As Integer
        For ctrldash = 0 To 0
            pnlmenu.Controls.RemoveAt(ctr)
        Next
        Dim D As New UsrCtrlActlog()
        D.Parent = pnlmenu
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNITEM_Click(sender As Object, e As EventArgs) Handles BTNITEM.Click
        Dim ctr As Integer
        For ctrldash = 0 To 0
            pnlmenu.Controls.RemoveAt(ctr)
        Next
        Dim D As New UsrCtrlITEM()
        D.Parent = pnlmenu
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNITEMS_Click(sender As Object, e As EventArgs) Handles BTNITEMS.Click
        Dim ctr As Integer
        For ctrldash = 0 To 0
            pnlmenu.Controls.RemoveAt(ctr)
        Next
        Dim D As New UsrCtrlITEMStock()
        D.Parent = pnlmenu
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNBORRPROF_Click(sender As Object, e As EventArgs) Handles BTNBORRPROF.Click
        Dim ctr As Integer
        For ctrldash = 0 To 0
            pnlmenu.Controls.RemoveAt(ctr)
        Next
        Dim D As New UsrCtrlborrow()
        D.Parent = pnlmenu
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNTRANS_Click(sender As Object, e As EventArgs) Handles BTNTRANS.Click
        Dim ctr As Integer
        For ctrldash = 0 To 0
            pnlmenu.Controls.RemoveAt(ctr)
        Next
        Dim D As New UsrCtrlTrans()
        D.Parent = pnlmenu
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

End Class