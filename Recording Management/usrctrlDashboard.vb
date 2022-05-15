Public Class usrctrlDashboard


    Private Sub usrctrlDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmclock.Enabled = True

    End Sub

    Private Sub tmclock_Tick(sender As Object, e As EventArgs) Handles tmclock.Tick
        lbltime.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub tggles_CheckedChanged(sender As Object, e As EventArgs) Handles tggles.CheckedChanged
        'If tggles.Checked = True Then

        'End If
    End Sub

End Class
