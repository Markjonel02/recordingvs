<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMLOGIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.pnlsidenav = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.picsurs = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTNINSTA = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnback = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BTNFB = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnsignin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PNLLOGMAIN = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.pnlmainpanel = New System.Windows.Forms.Panel()
        Me.lblpara = New System.Windows.Forms.Label()
        Me.lblabout = New System.Windows.Forms.Label()
        Me.lblgreet = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pics = New System.Windows.Forms.PictureBox()
        Me.pnlsidenav.SuspendLayout()
        CType(Me.picsurs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLLOGMAIN.SuspendLayout()
        Me.pnlmainpanel.SuspendLayout()
        CType(Me.pics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlsidenav
        '
        Me.pnlsidenav.Controls.Add(Me.picsurs)
        Me.pnlsidenav.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnlsidenav.Controls.Add(Me.BTNINSTA)
        Me.pnlsidenav.Controls.Add(Me.btnback)
        Me.pnlsidenav.Controls.Add(Me.BTNFB)
        Me.pnlsidenav.Controls.Add(Me.btnsignin)
        Me.pnlsidenav.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlsidenav.FillColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlsidenav.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlsidenav.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.pnlsidenav.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pnlsidenav.Location = New System.Drawing.Point(410, 0)
        Me.pnlsidenav.Name = "pnlsidenav"
        Me.pnlsidenav.ShadowDecoration.Parent = Me.pnlsidenav
        Me.pnlsidenav.Size = New System.Drawing.Size(187, 500)
        Me.pnlsidenav.TabIndex = 25
        '
        'picsurs
        '
        Me.picsurs.BackColor = System.Drawing.Color.Transparent
        Me.picsurs.Image = Global.Recording_Management.My.Resources.Resources.University_of_Rizal_System_logo_4227AA5058_seeklogo_com
        Me.picsurs.Location = New System.Drawing.Point(46, 59)
        Me.picsurs.Name = "picsurs"
        Me.picsurs.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.picsurs.ShadowDecoration.Parent = Me.picsurs
        Me.picsurs.Size = New System.Drawing.Size(101, 115)
        Me.picsurs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picsurs.TabIndex = 4
        Me.picsurs.TabStop = False
        Me.picsurs.Visible = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.MistyRose
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(50, 303)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(97, 18)
        Me.Guna2HtmlLabel1.TabIndex = 30
        Me.Guna2HtmlLabel1.Text = "Follow us on "
        '
        'BTNINSTA
        '
        Me.BTNINSTA.AutoRoundedCorners = True
        Me.BTNINSTA.BackColor = System.Drawing.Color.Transparent
        Me.BTNINSTA.BorderRadius = 20
        Me.BTNINSTA.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BTNINSTA.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BTNINSTA.CheckedState.Parent = Me.BTNINSTA
        Me.BTNINSTA.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNINSTA.CustomImages.Parent = Me.BTNINSTA
        Me.BTNINSTA.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BTNINSTA.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BTNINSTA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNINSTA.ForeColor = System.Drawing.Color.White
        Me.BTNINSTA.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BTNINSTA.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BTNINSTA.HoverState.Parent = Me.BTNINSTA
        Me.BTNINSTA.Image = Global.Recording_Management.My.Resources.Resources.instagram
        Me.BTNINSTA.ImageOffset = New System.Drawing.Point(-10, 0)
        Me.BTNINSTA.Location = New System.Drawing.Point(17, 393)
        Me.BTNINSTA.Name = "BTNINSTA"
        Me.BTNINSTA.PressedColor = System.Drawing.Color.Aqua
        Me.BTNINSTA.ShadowDecoration.Parent = Me.BTNINSTA
        Me.BTNINSTA.Size = New System.Drawing.Size(158, 42)
        Me.BTNINSTA.TabIndex = 29
        Me.BTNINSTA.Text = "Instagram"
        Me.BTNINSTA.TextOffset = New System.Drawing.Point(-2, 0)
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.Image = Global.Recording_Management.My.Resources.Resources.left
        Me.btnback.ImageActive = Nothing
        Me.btnback.Location = New System.Drawing.Point(17, 12)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(32, 29)
        Me.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnback.TabIndex = 28
        Me.btnback.TabStop = False
        Me.btnback.Zoom = 10
        '
        'BTNFB
        '
        Me.BTNFB.AutoRoundedCorners = True
        Me.BTNFB.BackColor = System.Drawing.Color.Transparent
        Me.BTNFB.BorderRadius = 20
        Me.BTNFB.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BTNFB.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BTNFB.CheckedState.Parent = Me.BTNFB
        Me.BTNFB.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNFB.CustomImages.Parent = Me.BTNFB
        Me.BTNFB.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BTNFB.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BTNFB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNFB.ForeColor = System.Drawing.Color.White
        Me.BTNFB.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BTNFB.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.BTNFB.HoverState.Parent = Me.BTNFB
        Me.BTNFB.Image = Global.Recording_Management.My.Resources.Resources.facebook__1_
        Me.BTNFB.ImageOffset = New System.Drawing.Point(-10, 0)
        Me.BTNFB.Location = New System.Drawing.Point(17, 332)
        Me.BTNFB.Name = "BTNFB"
        Me.BTNFB.PressedColor = System.Drawing.Color.Aqua
        Me.BTNFB.ShadowDecoration.Parent = Me.BTNFB
        Me.BTNFB.Size = New System.Drawing.Size(158, 42)
        Me.BTNFB.TabIndex = 27
        Me.BTNFB.Text = "Facebook"
        Me.BTNFB.TextOffset = New System.Drawing.Point(-2, 0)
        '
        'btnsignin
        '
        Me.btnsignin.AutoRoundedCorners = True
        Me.btnsignin.BackColor = System.Drawing.Color.Transparent
        Me.btnsignin.BorderRadius = 20
        Me.btnsignin.CheckedState.Parent = Me.btnsignin
        Me.btnsignin.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsignin.CustomImages.Parent = Me.btnsignin
        Me.btnsignin.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnsignin.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnsignin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnsignin.ForeColor = System.Drawing.Color.White
        Me.btnsignin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnsignin.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnsignin.HoverState.Parent = Me.btnsignin
        Me.btnsignin.Location = New System.Drawing.Point(17, 236)
        Me.btnsignin.Name = "btnsignin"
        Me.btnsignin.PressedColor = System.Drawing.Color.Aqua
        Me.btnsignin.ShadowDecoration.Parent = Me.btnsignin
        Me.btnsignin.Size = New System.Drawing.Size(158, 42)
        Me.btnsignin.TabIndex = 26
        Me.btnsignin.Text = "Sign in"
        '
        'PNLLOGMAIN
        '
        Me.PNLLOGMAIN.Controls.Add(Me.pnlsidenav)
        Me.PNLLOGMAIN.Controls.Add(Me.pnlmainpanel)
        Me.PNLLOGMAIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNLLOGMAIN.FillColor = System.Drawing.Color.White
        Me.PNLLOGMAIN.FillColor2 = System.Drawing.Color.White
        Me.PNLLOGMAIN.Location = New System.Drawing.Point(0, 0)
        Me.PNLLOGMAIN.Name = "PNLLOGMAIN"
        Me.PNLLOGMAIN.ShadowDecoration.Parent = Me.PNLLOGMAIN
        Me.PNLLOGMAIN.Size = New System.Drawing.Size(597, 500)
        Me.PNLLOGMAIN.TabIndex = 0
        '
        'pnlmainpanel
        '
        Me.pnlmainpanel.BackColor = System.Drawing.Color.Transparent
        Me.pnlmainpanel.Controls.Add(Me.lblpara)
        Me.pnlmainpanel.Controls.Add(Me.lblabout)
        Me.pnlmainpanel.Controls.Add(Me.lblgreet)
        Me.pnlmainpanel.Controls.Add(Me.pics)
        Me.pnlmainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlmainpanel.Location = New System.Drawing.Point(0, 0)
        Me.pnlmainpanel.Name = "pnlmainpanel"
        Me.pnlmainpanel.Size = New System.Drawing.Size(597, 500)
        Me.pnlmainpanel.TabIndex = 26
        '
        'lblpara
        '
        Me.lblpara.Location = New System.Drawing.Point(36, 358)
        Me.lblpara.Name = "lblpara"
        Me.lblpara.Size = New System.Drawing.Size(335, 63)
        Me.lblpara.TabIndex = 3
        Me.lblpara.Text = "Lorem Ipsum Nedir?Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır meti" &
    "nlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir"
        Me.lblpara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblabout
        '
        Me.lblabout.AutoSize = True
        Me.lblabout.Location = New System.Drawing.Point(180, 331)
        Me.lblabout.Name = "lblabout"
        Me.lblabout.Size = New System.Drawing.Size(49, 13)
        Me.lblabout.TabIndex = 2
        Me.lblabout.Text = "About us"
        '
        'lblgreet
        '
        Me.lblgreet.AutoSize = False
        Me.lblgreet.BackColor = System.Drawing.Color.Transparent
        Me.lblgreet.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgreet.Location = New System.Drawing.Point(36, 267)
        Me.lblgreet.Name = "lblgreet"
        Me.lblgreet.Size = New System.Drawing.Size(356, 50)
        Me.lblgreet.TabIndex = 1
        Me.lblgreet.Text = "Welcome To Our Project"
        '
        'pics
        '
        Me.pics.Image = Global.Recording_Management.My.Resources.Resources.workplace
        Me.pics.Location = New System.Drawing.Point(102, 36)
        Me.pics.Name = "pics"
        Me.pics.Size = New System.Drawing.Size(217, 217)
        Me.pics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pics.TabIndex = 0
        Me.pics.TabStop = False
        '
        'FRMLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(597, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.PNLLOGMAIN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMLOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.pnlsidenav.ResumeLayout(False)
        Me.pnlsidenav.PerformLayout()
        CType(Me.picsurs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLLOGMAIN.ResumeLayout(False)
        Me.pnlmainpanel.ResumeLayout(False)
        Me.pnlmainpanel.PerformLayout()
        CType(Me.pics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlsidenav As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents BTNFB As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnsignin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PNLLOGMAIN As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnlmainpanel As Panel
    Friend WithEvents pics As PictureBox
    Friend WithEvents lblpara As Label
    Friend WithEvents lblabout As Label
    Friend WithEvents lblgreet As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnback As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BTNINSTA As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents picsurs As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
