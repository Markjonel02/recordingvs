Public Class usrctrlDashboard


    Private Sub usrctrlDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmclock.Enabled = True
    End Sub

    Private Sub tmclock_Tick(sender As Object, e As EventArgs) Handles tmclock.Tick
        lbltime.Text = Date.Now.ToString("dd MMM yyyy     hh:mm:ss")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) 
        ExitButton()
    End Sub
End Class
