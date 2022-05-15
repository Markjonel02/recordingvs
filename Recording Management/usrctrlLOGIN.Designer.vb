<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrctrlLOGIN
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
        Dim lblforgot As System.Windows.Forms.LinkLabel
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.ctrlpanel = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CHKEYE = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.lblgreet = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXTUSN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTPASS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNLOGIN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.seplogin = New Guna.UI2.WinForms.Guna2Separator()
        lblforgot = New System.Windows.Forms.LinkLabel()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.ctrlpanel.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.ctrlpanel)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(421, 500)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'ctrlpanel
        '
        Me.ctrlpanel.BackColor = System.Drawing.Color.Transparent
        Me.ctrlpanel.Controls.Add(lblforgot)
        Me.ctrlpanel.Controls.Add(Me.Guna2PictureBox1)
        Me.ctrlpanel.Controls.Add(Me.CHKEYE)
        Me.ctrlpanel.Controls.Add(Me.lblgreet)
        Me.ctrlpanel.Controls.Add(Me.TXTUSN)
        Me.ctrlpanel.Controls.Add(Me.TXTPASS)
        Me.ctrlpanel.Controls.Add(Me.BTNLOGIN)
        Me.ctrlpanel.Controls.Add(Me.seplogin)
        Me.ctrlpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctrlpanel.Location = New System.Drawing.Point(0, 0)
        Me.ctrlpanel.Name = "ctrlpanel"
        Me.ctrlpanel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ctrlpanel.Size = New System.Drawing.Size(421, 500)
        Me.ctrlpanel.TabIndex = 28
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Recording_Management.My.Resources.Resources.hacker
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(172, 134)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(104, 101)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 36
        Me.Guna2PictureBox1.TabStop = False
        '
        'CHKEYE
        '
        Me.CHKEYE.BackColor = System.Drawing.Color.Transparent
        Me.CHKEYE.CheckedState.Image = Global.Recording_Management.My.Resources.Resources.visible_opened_eye_interface_option
        Me.CHKEYE.CheckedState.Parent = Me.CHKEYE
        Me.CHKEYE.HoverState.Parent = Me.CHKEYE
        Me.CHKEYE.Image = Global.Recording_Management.My.Resources.Resources.invisible
        Me.CHKEYE.Location = New System.Drawing.Point(288, 327)
        Me.CHKEYE.Name = "CHKEYE"
        Me.CHKEYE.PressedState.Parent = Me.CHKEYE
        Me.CHKEYE.Size = New System.Drawing.Size(61, 37)
        Me.CHKEYE.TabIndex = 35
        Me.CHKEYE.UseTransparentBackground = True
        '
        'lblgreet
        '
        Me.lblgreet.AutoSize = False
        Me.lblgreet.BackColor = System.Drawing.Color.Transparent
        Me.lblgreet.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgreet.ForeColor = System.Drawing.Color.Lavender
        Me.lblgreet.Location = New System.Drawing.Point(83, 49)
        Me.lblgreet.Name = "lblgreet"
        Me.lblgreet.Size = New System.Drawing.Size(291, 44)
        Me.lblgreet.TabIndex = 32
        Me.lblgreet.Text = "Login Your Account "
        Me.lblgreet.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTUSN
        '
        Me.TXTUSN.Animated = True
        Me.TXTUSN.AutoRoundedCorners = True
        Me.TXTUSN.BackColor = System.Drawing.Color.Transparent
        Me.TXTUSN.BorderRadius = 17
        Me.TXTUSN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTUSN.DefaultText = ""
        Me.TXTUSN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTUSN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTUSN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTUSN.DisabledState.Parent = Me.TXTUSN
        Me.TXTUSN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTUSN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTUSN.FocusedState.Parent = Me.TXTUSN
        Me.TXTUSN.ForeColor = System.Drawing.Color.Black
        Me.TXTUSN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTUSN.HoverState.Parent = Me.TXTUSN
        Me.TXTUSN.IconLeft = Global.Recording_Management.My.Resources.Resources.user__4_
        Me.TXTUSN.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.TXTUSN.Location = New System.Drawing.Point(102, 272)
        Me.TXTUSN.Name = "TXTUSN"
        Me.TXTUSN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTUSN.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.TXTUSN.PlaceholderText = "Username"
        Me.TXTUSN.SelectedText = ""
        Me.TXTUSN.ShadowDecoration.Parent = Me.TXTUSN
        Me.TXTUSN.Size = New System.Drawing.Size(247, 37)
        Me.TXTUSN.TabIndex = 33
        Me.TXTUSN.TextOffset = New System.Drawing.Point(45, 0)
        '
        'TXTPASS
        '
        Me.TXTPASS.Animated = True
        Me.TXTPASS.AutoRoundedCorners = True
        Me.TXTPASS.BackColor = System.Drawing.Color.Transparent
        Me.TXTPASS.BorderRadius = 17
        Me.TXTPASS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTPASS.DefaultText = ""
        Me.TXTPASS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTPASS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTPASS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPASS.DisabledState.Parent = Me.TXTPASS
        Me.TXTPASS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTPASS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPASS.FocusedState.Parent = Me.TXTPASS
        Me.TXTPASS.ForeColor = System.Drawing.Color.Black
        Me.TXTPASS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPASS.HoverState.Parent = Me.TXTPASS
        Me.TXTPASS.IconLeft = Global.Recording_Management.My.Resources.Resources.password
        Me.TXTPASS.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TXTPASS.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.TXTPASS.Location = New System.Drawing.Point(102, 327)
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPASS.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.TXTPASS.PlaceholderText = "Password"
        Me.TXTPASS.SelectedText = ""
        Me.TXTPASS.ShadowDecoration.Parent = Me.TXTPASS
        Me.TXTPASS.Size = New System.Drawing.Size(247, 37)
        Me.TXTPASS.TabIndex = 34
        Me.TXTPASS.TextOffset = New System.Drawing.Point(45, 0)
        Me.TXTPASS.UseSystemPasswordChar = True
        '
        'BTNLOGIN
        '
        Me.BTNLOGIN.AutoRoundedCorners = True
        Me.BTNLOGIN.BackColor = System.Drawing.Color.Transparent
        Me.BTNLOGIN.BorderRadius = 17
        Me.BTNLOGIN.CheckedState.Parent = Me.BTNLOGIN
        Me.BTNLOGIN.CustomImages.Parent = Me.BTNLOGIN
        Me.BTNLOGIN.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BTNLOGIN.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BTNLOGIN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOGIN.ForeColor = System.Drawing.Color.White
        Me.BTNLOGIN.HoverState.Parent = Me.BTNLOGIN
        Me.BTNLOGIN.Location = New System.Drawing.Point(149, 381)
        Me.BTNLOGIN.Name = "BTNLOGIN"
        Me.BTNLOGIN.PressedColor = System.Drawing.Color.Aqua
        Me.BTNLOGIN.ShadowDecoration.Parent = Me.BTNLOGIN
        Me.BTNLOGIN.Size = New System.Drawing.Size(143, 37)
        Me.BTNLOGIN.TabIndex = 31
        Me.BTNLOGIN.Text = "Login"
        '
        'seplogin
        '
        Me.seplogin.BackColor = System.Drawing.Color.Transparent
        Me.seplogin.FillColor = System.Drawing.Color.White
        Me.seplogin.Location = New System.Drawing.Point(32, 245)
        Me.seplogin.Name = "seplogin"
        Me.seplogin.Size = New System.Drawing.Size(355, 21)
        Me.seplogin.TabIndex = 30
        '
        'lblforgot
        '
        lblforgot.AutoSize = True
        lblforgot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblforgot.Location = New System.Drawing.Point(177, 434)
        lblforgot.Name = "lblforgot"
        lblforgot.Size = New System.Drawing.Size(91, 13)
        lblforgot.TabIndex = 37
        lblforgot.TabStop = True
        lblforgot.Text = "Forgot password?"
        AddHandler lblforgot.LinkClicked, AddressOf Me.lblforgot_LinkClicked
        '
        'usrctrlLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Name = "usrctrlLOGIN"
        Me.Size = New System.Drawing.Size(421, 500)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.ctrlpanel.ResumeLayout(False)
        Me.ctrlpanel.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents ctrlpanel As Panel
    Friend WithEvents CHKEYE As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents lblgreet As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXTUSN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTPASS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNLOGIN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents seplogin As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
