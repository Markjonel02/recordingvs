Public Class usrctrlLOGIN
    Dim astat As String = "Active"
    Dim admin As String = "Gso"
    Dim Staff As String = "Staff"
    Public a
    Private Sub usrctrlLOGIN_Invalidated(sender As Object, e As InvalidateEventArgs) Handles Me.Invalidated

    End Sub
    Private Sub disable()
        FRMMAINMENU.BTNADDITEM.Visible = False
        FRMMAINMENU.BTNITEM.Visible = False
        FRMMAINMENU.BTNMANAGE.Visible = False
        FRMMAINMENU.BTNSYSTEMSET.Visible = False

        FRMMAINMENU.BTNBORRPROF.Location = New Point(0, 254)
        FRMMAINMENU.BTNTRANSAC.Location = New Point(0, 292)
        FRMMAINMENU.BTNREP.Location = New Point(0, 330)

    End Sub

    Private Sub ACTLOG()
        con.Close()
        con.Open()
        cmd.CommandText = "insert into tbl_activitylog values (@un, @act, @dt)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", TXTUSN.Text)
            .AddWithValue("act", Act)
            .AddWithValue("dt", Date.Now())
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub BTNLOGIN_Click(sender As Object, e As EventArgs) Handles BTNLOGIN.Click
        If TXTUSN.Text = "" Or TXTPASS.Text = "" Then
            MsgBox("all fields are required")
            TXTPASS.Text=""
            TXTUSN.Text = ""
            TXTUSN.Focus()
        Else
            opencon()
            cmd.CommandText = "Select * from tbl_user where username = '" & TXTUSN.Text & "' and password = '" & TXTPASS.Text & "' and status = '" & astat & "'"
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()

                If dr(3) = admin Then
                    Act = "Logged-in"
                    ACTLOG()
                    a = TXTUSN.Text
                    FRMMAINMENU.lblgreet.Text = a
                    FRMMAINMENU.Show()


                ElseIf dr(3) = Staff Then
                    Act = "Logged-in"
                    ACTLOG()
                    a = TXTUSN.Text
                    FRMMAINMENU.lblgreet.Text = a
                    FRMMAINMENU.Show()
                    disable()

                End If
            Else
                MsgBox("Sorry wrong username and password", vbOKOnly + vbCritical, "Error login")
                TXTUSN.Text = String.Empty
                TXTPASS.Text = String.Empty
                TXTUSN.Focus()
            End If
            con.Close()
        End If


    End Sub

    Private Sub CHKEYE_CheckedChanged(sender As Object, e As EventArgs) Handles CHKEYE.CheckedChanged
        If CHKEYE.Checked = False Then
            TXTPASS.UseSystemPasswordChar = True
        Else
            TXTPASS.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub lblforgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        'Dim ctrldash As Integer
        'For ctrldash = 0 To 0
        '    pnlmainmenu.Controls.RemoveAt(ctrldash)
        'Next
        'Dim D As New usrctrlDashboard()
        'D.Parent = pnlmainmenu
        'D.Show()
        'D.Dock = DockStyle.Fill

    End Sub
End Class

