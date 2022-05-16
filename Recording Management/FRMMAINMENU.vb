Public Class FRMMAINMENU


    Private Sub FRMMAINMENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FRMLOGIN.Close()
        Dim ctrldash As Integer
        For ctrldash = 0 To 0
            pnlmainmenu.Controls.RemoveAt(ctrldash)
        Next
        Dim D As New usrctrlDashboard()
        D.Parent = pnlmainmenu
        D.Show()
        D.Dock = DockStyle.Fill


    End Sub





    Private Sub BTNDASHOARD_Click(sender As Object, e As EventArgs) Handles BTNDASHOARD.Click
        Dim ctrldash As Integer
        For ctrldash = 0 To 0
            pnlmainmenu.Controls.RemoveAt(ctrldash)
        Next
        Dim D As New usrctrlDashboard()
        D.Parent = pnlmainmenu
        D.Show()
        D.Dock = DockStyle.Fill


    End Sub

    Private Sub BTNDASHOARD_Leave(sender As Object, e As EventArgs) Handles BTNDASHOARD.Leave

        BTNDASHOARD.FillColor = Color.Transparent
        BTNDASHOARD.FillColor2 = Color.Transparent
        BTNDASHOARD.ForeColor = Color.White
        BTNDASHOARD.CustomBorderColor = Color.Transparent
    End Sub

    Private Sub BTNDASHOARD_GotFocus(sender As Object, e As EventArgs) Handles BTNDASHOARD.GotFocus

        BTNDASHOARD.FillColor = Color.WhiteSmoke
        BTNDASHOARD.FillColor2 = Color.WhiteSmoke
        BTNDASHOARD.ForeColor = Color.RoyalBlue
        BTNDASHOARD.CustomBorderColor = Color.RoyalBlue

    End Sub

    Private Sub BNTMANAGE_Click(sender As Object, e As EventArgs) Handles BTNMANAGE.Click
        Dim ctrlmanage As Integer
        For ctrlmanage = 0 To 0
            pnlmainmenu.Controls.RemoveAt(ctrlmanage)
        Next
        Dim D As New UsrctrlMANAGE_ACCOUNT()
        D.Parent = pnlmainmenu
        D.Show()
        D.Dock = DockStyle.Fill

        BTNMANAGE.FillColor = Color.WhiteSmoke
        BTNMANAGE.FillColor2 = Color.WhiteSmoke
        BTNMANAGE.ForeColor = Color.RoyalBlue
        BTNMANAGE.CustomBorderColor = Color.RoyalBlue

    End Sub

    Private Sub BTNMANAGE_Leave(sender As Object, e As EventArgs) Handles BTNMANAGE.Leave
        BTNMANAGE.FillColor = Color.Transparent
        BTNMANAGE.FillColor2 = Color.Transparent
        BTNMANAGE.ForeColor = Color.White
        BTNMANAGE.CustomBorderColor = Color.Transparent
    End Sub

    Private Sub BTNITEM_Click(sender As Object, e As EventArgs) Handles BTNITEM.Click
        Dim item As Integer
        For item = 0 To 0
            pnlmainmenu.Controls.RemoveAt(item)
        Next
        Dim D As New usrcrtlITEM1()
        D.Parent = pnlmainmenu
        D.Show()
        D.Dock = DockStyle.Fill
        BTNITEM.FillColor = Color.WhiteSmoke
        BTNITEM.FillColor2 = Color.WhiteSmoke
        BTNITEM.ForeColor = Color.RoyalBlue
        BTNITEM.CustomBorderColor = Color.RoyalBlue
    End Sub


    Private Sub BTNITEM_Leave(sender As Object, e As EventArgs) Handles BTNITEM.Leave
        BTNITEM.FillColor = Color.Transparent
        BTNITEM.FillColor2 = Color.Transparent
        BTNITEM.ForeColor = Color.White
        BTNITEM.CustomBorderColor = Color.Transparent
    End Sub


    Private Sub BTNADDITEM_Click(sender As Object, e As EventArgs) Handles BTNADDITEM.Click
        Dim ctrl As Integer
        For ctrl = 0 To 0
            pnlmainmenu.Controls.RemoveAt(ctrl)
        Next
        Dim D As New usrctrlADD_ITEM()
        D.Parent = pnlmainmenu
        D.Show()
        D.Dock = DockStyle.Fill
        BTNADDITEM.FillColor = Color.WhiteSmoke
        BTNADDITEM.FillColor2 = Color.WhiteSmoke
        BTNADDITEM.ForeColor = Color.RoyalBlue
        BTNADDITEM.CustomBorderColor = Color.RoyalBlue
    End Sub

    Private Sub BTNADDITEM_Leave(sender As Object, e As EventArgs) Handles BTNADDITEM.Leave
        BTNADDITEM.FillColor = Color.Transparent
        BTNADDITEM.FillColor2 = Color.Transparent
        BTNADDITEM.ForeColor = Color.White
        BTNADDITEM.CustomBorderColor = Color.Transparent
    End Sub

    Private Sub BTNBORRPROF_Click(sender As Object, e As EventArgs) Handles BTNBORRPROF.Click
        Dim ctrl As Integer
        For ctrl = 0 To 0
            pnlmainmenu.Controls.RemoveAt(ctrl)
        Next
        Dim D As New usrctrlBORROWERS_PROFILE()
        D.Parent = pnlmainmenu
        D.Show()
        D.Dock = DockStyle.Fill
        BTNBORRPROF.FillColor = Color.WhiteSmoke
        BTNBORRPROF.FillColor2 = Color.WhiteSmoke
        BTNBORRPROF.ForeColor = Color.RoyalBlue
        BTNBORRPROF.CustomBorderColor = Color.RoyalBlue
    End Sub

    Private Sub BTNBORRPROF_Leave(sender As Object, e As EventArgs) Handles BTNBORRPROF.Leave
        BTNBORRPROF.FillColor = Color.Transparent
        BTNBORRPROF.FillColor2 = Color.Transparent
        BTNBORRPROF.ForeColor = Color.White
        BTNBORRPROF.CustomBorderColor = Color.Transparent
    End Sub
    Private Sub BTNLOGOUT_Click(sender As Object, e As EventArgs) Handles BTNLOGOUT.Click
        Dim close = MsgBox("Log out your acount?", vbYesNo + vbCritical, "logout account")

        If DialogResult.Yes = close Then
            Act = "logged-out "
            ACTLOG()

            FRMLOGIN.Show()
            Me.Close()
        End If
    End Sub
    Private Sub ACTLOG()
        con.Close()
        con.Open()
        cmd.CommandText = "insert into tbl_activitylog values (@un, @act, @dt)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", lblgreet.Text)
            .AddWithValue("act", Act)
            .AddWithValue("dt", Date.Now())
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub BTNTRANSAC_Click(sender As Object, e As EventArgs) Handles BTNTRANSAC.Click
        Dim ctrl As Integer
        For ctrl = 0 To 0
            pnlmainmenu.Controls.RemoveAt(ctrl)
        Next
        Dim D As New usrctrlTRANSACTION()
        D.Parent = pnlmainmenu
        D.Show()
        D.Dock = DockStyle.Fill
        BTNTRANSAC.FillColor = Color.WhiteSmoke
        BTNTRANSAC.FillColor2 = Color.WhiteSmoke
        BTNTRANSAC.ForeColor = Color.RoyalBlue
        BTNTRANSAC.CustomBorderColor = Color.RoyalBlue
    End Sub


    Private Sub BTNTRANSAC_Leave(sender As Object, e As EventArgs) Handles BTNTRANSAC.Leave
        BTNTRANSAC.FillColor = Color.Transparent
        BTNTRANSAC.FillColor2 = Color.Transparent
        BTNTRANSAC.ForeColor = Color.White
        BTNTRANSAC.CustomBorderColor = Color.Transparent
    End Sub

    Private Sub BTNSYSTEMSET_Click(sender As Object, e As EventArgs) Handles BTNSYSTEMSET.Click
        Dim ctrl As Integer
        For ctrl = 0 To 0
            pnlmainmenu.Controls.RemoveAt(ctrl)
        Next
        Dim D As New usrpnlSet()
        D.Parent = pnlmainmenu
        D.Show()
        D.Dock = DockStyle.Fill
        BTNSYSTEMSET.FillColor = Color.WhiteSmoke
        BTNSYSTEMSET.FillColor2 = Color.WhiteSmoke
        BTNSYSTEMSET.ForeColor = Color.RoyalBlue
        BTNSYSTEMSET.CustomBorderColor = Color.RoyalBlue
    End Sub

    Private Sub BTNSYSTEMSET_Leave(sender As Object, e As EventArgs) Handles BTNSYSTEMSET.Leave
        BTNSYSTEMSET.FillColor = Color.Transparent
        BTNSYSTEMSET.FillColor2 = Color.Transparent
        BTNSYSTEMSET.ForeColor = Color.White
        BTNSYSTEMSET.CustomBorderColor = Color.Transparent
    End Sub

    Private Sub BTNREP_Click(sender As Object, e As EventArgs) Handles BTNREP.Click
        Frm_reports.ShowDialog()

        '    Dim ctrl As Integer
        '    For ctrl = 0 To 0
        '        pnlmainmenu.Controls.RemoveAt(ctrl)
        '    Next
        '    Dim D As New usrctrlREPORTS()
        '    D.Parent = pnlmainmenu
        '    D.Show()
        '    D.Dock = DockStyle.Fill
        '    BTNREP.FillColor = Color.WhiteSmoke
        '    BTNREP.FillColor2 = Color.WhiteSmoke
        '    BTNREP.ForeColor = Color.RoyalBlue
        '    BTNREP.CustomBorderColor = Color.RoyalBlue
    End Sub


    Private Sub BTNREP_Leave(sender As Object, e As EventArgs) Handles BTNREP.Leave
        BTNREP.FillColor = Color.Transparent
        BTNREP.FillColor2 = Color.Transparent
        BTNREP.ForeColor = Color.White
        BTNREP.CustomBorderColor = Color.Transparent
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitButton()
    End Sub

    Private Sub BTNRETURN_Click(sender As Object, e As EventArgs) Handles BTNRETURN.Click

        Dim ctrl As Integer
        For ctrl = 0 To 0
            pnlmainmenu.Controls.RemoveAt(ctrl)
        Next
        Dim D As New UsrCtrlReturnitems()
        D.Parent = pnlmainmenu
        D.Show()
        D.Dock = DockStyle.Fill
        BTNRETURN.FillColor = Color.WhiteSmoke
        BTNRETURN.FillColor2 = Color.WhiteSmoke
        BTNRETURN.ForeColor = Color.RoyalBlue
        BTNRETURN.CustomBorderColor = Color.RoyalBlue
    End Sub

    Private Sub BTNRETURN_Leave(sender As Object, e As EventArgs) Handles BTNRETURN.Leave
        BTNRETURN.FillColor = Color.Transparent
        BTNRETURN.FillColor2 = Color.Transparent
        BTNRETURN.ForeColor = Color.White
        BTNRETURN.CustomBorderColor = Color.Transparent

    End Sub

    Private Sub lblgreet_Click(sender As Object, e As EventArgs) Handles lblgreet.Click

    End Sub
End Class