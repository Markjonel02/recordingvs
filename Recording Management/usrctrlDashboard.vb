Public Class usrctrlDashboard


    Private Sub usrctrlDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmclock.Enabled = True
    End Sub

    Private Sub tmclock_Tick(sender As Object, e As EventArgs) Handles tmclock.Tick
        lbltime.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

End Class
