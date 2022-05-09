Public Class FRMLOGIN
    Dim n As Integer = 0

    Private Sub FRMLOGIN_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnback.Visible = False
        picsurs.Visible = True
        lblhome.Visible = False

    End Sub

    Public Sub Hide1()
        pics.Visible = False
        lblgreet.Visible = False
        lblabout.Visible = False
        lblpara.Visible = False
    End Sub
    Public Sub Show1()
        pics.Visible = True
        lblgreet.Visible = True
        lblabout.Visible = True
        lblpara.Visible = True


    End Sub


    Private Sub btnsignin_Click(sender As Object, e As EventArgs) Handles btnsignin.Click

        Dim ctrl As Integer
        For ctrl = 0 To 0
            pnlmainpanel.Controls.RemoveAt(ctrl)
        Next
        Dim D As New usrctrlLOGIN()
        D.Parent = pnlmainpanel
        D.Show()
        D.Dock = DockStyle.Fill
        Hide1()
        btnback.Visible = True
        lblhome.Visible = True



    End Sub




    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim ctrl As Integer
        For ctrl = 0 To 0
            pnlmainpanel.Controls.RemoveAt(ctrl)
        Next
        Dim D As New UsrctrlWelcome()
        D.Parent = pnlmainpanel
        D.Show()
        D.Dock = DockStyle.Fill
        picsurs.Visible = True
        lblhome.Visible = True

    End Sub

    Private Sub BTNINSTA_Click(sender As Object, e As EventArgs) Handles BTNINSTA.Click
        Process.Start("www.instagram.com")
    End Sub

    Private Sub BTNFB_Click(sender As Object, e As EventArgs) Handles BTNFB.Click
        Process.Start("www.facebook.com")
        'Process.Start("www.pinayflix.com")

    End Sub




    'End Sub
End Class