Public Class usrctrlLOGIN
    Dim astat As String = "Active"

    Dim n
    Private Sub disable()
        FRMMAINMENU.BTNADDITEM.Enabled = False
        FRMMAINMENU.BTNITEM.Enabled = False
        FRMMAINMENU.BTNMANAGE.Enabled = False
        FRMMAINMENU.BTNSYSTEMSET.Enabled = False
    End Sub


    Private Sub BTNLOGIN_Click(sender As Object, e As EventArgs) Handles BTNLOGIN.Click
        opencon()
        cmd.CommandText = "Select * from tbl_user where username = '" & TXTUSN.Text & "' and password = '" & TXTPASS.Text & "' and status = '" & astat & "'"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()

            If dr(3) = "gso" Then
                FRMMAINMENU.lblgreet.Text = "gso"
                FRMMAINMENU.Show()
                FRMLOGIN.pnlmainpanel.Dock = DockStyle.None
                Me.Controls.Clear()
                n = Nothing
            ElseIf dr(3) = "staff" Then
                FRMMAINMENU.lblgreet.Text = "staff"
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

    End Sub

    Private Sub CHKEYE_CheckedChanged(sender As Object, e As EventArgs) Handles CHKEYE.CheckedChanged
        If CHKEYE.Checked = False Then
            TXTPASS.UseSystemPasswordChar = True
        Else
            TXTPASS.UseSystemPasswordChar = False
        End If
    End Sub


End Class

