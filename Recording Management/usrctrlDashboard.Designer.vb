<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrctrlDashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnldash = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmclock = New System.Windows.Forms.Timer(Me.components)
        Me.pnldash.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnldash
        '
        Me.pnldash.BackColor = System.Drawing.Color.Transparent
        Me.pnldash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnldash.Controls.Add(Me.PictureBox1)
        Me.pnldash.Controls.Add(Me.lbltime)
        Me.pnldash.Controls.Add(Me.Label1)
        Me.pnldash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnldash.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnldash.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.pnldash.Location = New System.Drawing.Point(0, 0)
        Me.pnldash.Name = "pnldash"
        Me.pnldash.ShadowDecoration.Parent = Me.pnldash
        Me.pnldash.Size = New System.Drawing.Size(800, 462)
        Me.pnldash.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Recording_Management.My.Resources.Resources.alarm_clock
        Me.PictureBox1.Location = New System.Drawing.Point(34, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lbltime
        '
        Me.lbltime.BackColor = System.Drawing.Color.LightBlue
        Me.lbltime.ForeColor = System.Drawing.Color.Black
        Me.lbltime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbltime.Location = New System.Drawing.Point(34, 63)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(182, 43)
        Me.lbltime.TabIndex = 8
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(458, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'tmclock
        '
        '
        'usrctrlDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnldash)
        Me.Name = "usrctrlDashboard"
        Me.Size = New System.Drawing.Size(800, 462)
        Me.pnldash.ResumeLayout(False)
        Me.pnldash.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnldash As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lbltime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmclock As Timer
End Class
