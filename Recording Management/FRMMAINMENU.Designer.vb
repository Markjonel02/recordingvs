<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMMAINMENU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMMAINMENU))
        Me.pnlfrmmainpanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblshowhide = New System.Windows.Forms.Label()
        Me.chkshowbutton = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.pnlfrmuser = New System.Windows.Forms.Panel()
        Me.BTNLOGOUT = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.BTNDASHOARD = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNREP = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNTRANSAC = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNSYSTEMSET = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNBORRPROF = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNADDITEM = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNITEM = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BTNMANAGE = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlback = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.pnlmainmenu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblgreet = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlfrmmainpanel.SuspendLayout()
        Me.pnlfrmuser.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlback.SuspendLayout()
        Me.pnlmainmenu.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlfrmmainpanel
        '
        Me.pnlfrmmainpanel.BackColor = System.Drawing.Color.Transparent
        Me.pnlfrmmainpanel.Controls.Add(Me.lblshowhide)
        Me.pnlfrmmainpanel.Controls.Add(Me.chkshowbutton)
        Me.pnlfrmmainpanel.Controls.Add(Me.pnlfrmuser)
        Me.pnlfrmmainpanel.Controls.Add(Me.BTNDASHOARD)
        Me.pnlfrmmainpanel.Controls.Add(Me.BTNREP)
        Me.pnlfrmmainpanel.Controls.Add(Me.BTNTRANSAC)
        Me.pnlfrmmainpanel.Controls.Add(Me.BTNSYSTEMSET)
        Me.pnlfrmmainpanel.Controls.Add(Me.BTNBORRPROF)
        Me.pnlfrmmainpanel.Controls.Add(Me.BTNADDITEM)
        Me.pnlfrmmainpanel.Controls.Add(Me.BTNITEM)
        Me.pnlfrmmainpanel.Controls.Add(Me.BTNMANAGE)
        Me.pnlfrmmainpanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlfrmmainpanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.pnlfrmmainpanel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlfrmmainpanel.Location = New System.Drawing.Point(0, 0)
        Me.pnlfrmmainpanel.Name = "pnlfrmmainpanel"
        Me.pnlfrmmainpanel.ShadowDecoration.Parent = Me.pnlfrmmainpanel
        Me.pnlfrmmainpanel.Size = New System.Drawing.Size(203, 527)
        Me.pnlfrmmainpanel.TabIndex = 0
        '
        'lblshowhide
        '
        Me.lblshowhide.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblshowhide.Location = New System.Drawing.Point(132, 146)
        Me.lblshowhide.Name = "lblshowhide"
        Me.lblshowhide.Size = New System.Drawing.Size(40, 23)
        Me.lblshowhide.TabIndex = 2
        '
        'chkshowbutton
        '
        Me.chkshowbutton.CheckedState.Image = Global.Recording_Management.My.Resources.Resources.down_arrow
        Me.chkshowbutton.CheckedState.Parent = Me.chkshowbutton
        Me.chkshowbutton.HoverState.Parent = Me.chkshowbutton
        Me.chkshowbutton.Image = Global.Recording_Management.My.Resources.Resources.arrow_up
        Me.chkshowbutton.Location = New System.Drawing.Point(178, 146)
        Me.chkshowbutton.Name = "chkshowbutton"
        Me.chkshowbutton.PressedState.Parent = Me.chkshowbutton
        Me.chkshowbutton.Size = New System.Drawing.Size(19, 19)
        Me.chkshowbutton.TabIndex = 2
        '
        'pnlfrmuser
        '
        Me.pnlfrmuser.BackgroundImage = Global.Recording_Management.My.Resources.Resources.urs
        Me.pnlfrmuser.Controls.Add(Me.BTNLOGOUT)
        Me.pnlfrmuser.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.pnlfrmuser.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlfrmuser.Location = New System.Drawing.Point(0, 0)
        Me.pnlfrmuser.Name = "pnlfrmuser"
        Me.pnlfrmuser.Size = New System.Drawing.Size(203, 140)
        Me.pnlfrmuser.TabIndex = 1
        '
        'BTNLOGOUT
        '
        Me.BTNLOGOUT.CheckedState.Parent = Me.BTNLOGOUT
        Me.BTNLOGOUT.CustomImages.Parent = Me.BTNLOGOUT
        Me.BTNLOGOUT.FillColor = System.Drawing.Color.Empty
        Me.BTNLOGOUT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNLOGOUT.ForeColor = System.Drawing.Color.White
        Me.BTNLOGOUT.HoverState.Parent = Me.BTNLOGOUT
        Me.BTNLOGOUT.Image = Global.Recording_Management.My.Resources.Resources.power_off
        Me.BTNLOGOUT.Location = New System.Drawing.Point(166, 3)
        Me.BTNLOGOUT.Name = "BTNLOGOUT"
        Me.BTNLOGOUT.ShadowDecoration.Parent = Me.BTNLOGOUT
        Me.BTNLOGOUT.Size = New System.Drawing.Size(34, 27)
        Me.BTNLOGOUT.TabIndex = 1
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.Recording_Management.My.Resources.Resources.user__1_
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(66, 53)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(79, 75)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 1
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'BTNDASHOARD
        '
        Me.BTNDASHOARD.BackColor = System.Drawing.Color.Transparent
        Me.BTNDASHOARD.CheckedState.CustomBorderColor = System.Drawing.Color.White
        Me.BTNDASHOARD.CheckedState.FillColor = System.Drawing.Color.White
        Me.BTNDASHOARD.CheckedState.FillColor2 = System.Drawing.Color.White
        Me.BTNDASHOARD.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BTNDASHOARD.CheckedState.Parent = Me.BTNDASHOARD
        Me.BTNDASHOARD.CustomImages.Parent = Me.BTNDASHOARD
        Me.BTNDASHOARD.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BTNDASHOARD.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNDASHOARD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNDASHOARD.ForeColor = System.Drawing.Color.White
        Me.BTNDASHOARD.HoverState.Parent = Me.BTNDASHOARD
        Me.BTNDASHOARD.Location = New System.Drawing.Point(0, 171)
        Me.BTNDASHOARD.Name = "BTNDASHOARD"
        Me.BTNDASHOARD.ShadowDecoration.Parent = Me.BTNDASHOARD
        Me.BTNDASHOARD.Size = New System.Drawing.Size(203, 31)
        Me.BTNDASHOARD.TabIndex = 8
        Me.BTNDASHOARD.Text = "DASHBOARD"
        '
        'BTNREP
        '
        Me.BTNREP.BackColor = System.Drawing.Color.Transparent
        Me.BTNREP.CheckedState.CustomBorderColor = System.Drawing.Color.White
        Me.BTNREP.CheckedState.FillColor = System.Drawing.Color.White
        Me.BTNREP.CheckedState.FillColor2 = System.Drawing.Color.White
        Me.BTNREP.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BTNREP.CheckedState.Parent = Me.BTNREP
        Me.BTNREP.CustomBorderColor = System.Drawing.Color.RosyBrown
        Me.BTNREP.CustomImages.Parent = Me.BTNREP
        Me.BTNREP.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BTNREP.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNREP.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNREP.ForeColor = System.Drawing.Color.White
        Me.BTNREP.HoverState.Parent = Me.BTNREP
        Me.BTNREP.Location = New System.Drawing.Point(0, 430)
        Me.BTNREP.Name = "BTNREP"
        Me.BTNREP.ShadowDecoration.Parent = Me.BTNREP
        Me.BTNREP.Size = New System.Drawing.Size(203, 31)
        Me.BTNREP.TabIndex = 7
        Me.BTNREP.Text = "REPORTS"
        Me.BTNREP.UseTransparentBackground = True
        '
        'BTNTRANSAC
        '
        Me.BTNTRANSAC.BackColor = System.Drawing.Color.Transparent
        Me.BTNTRANSAC.CheckedState.CustomBorderColor = System.Drawing.Color.White
        Me.BTNTRANSAC.CheckedState.FillColor = System.Drawing.Color.White
        Me.BTNTRANSAC.CheckedState.FillColor2 = System.Drawing.Color.White
        Me.BTNTRANSAC.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BTNTRANSAC.CheckedState.Parent = Me.BTNTRANSAC
        Me.BTNTRANSAC.CustomBorderColor = System.Drawing.Color.RosyBrown
        Me.BTNTRANSAC.CustomImages.Parent = Me.BTNTRANSAC
        Me.BTNTRANSAC.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BTNTRANSAC.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNTRANSAC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNTRANSAC.ForeColor = System.Drawing.Color.White
        Me.BTNTRANSAC.HoverState.Parent = Me.BTNTRANSAC
        Me.BTNTRANSAC.Location = New System.Drawing.Point(0, 356)
        Me.BTNTRANSAC.Name = "BTNTRANSAC"
        Me.BTNTRANSAC.ShadowDecoration.Parent = Me.BTNTRANSAC
        Me.BTNTRANSAC.Size = New System.Drawing.Size(203, 31)
        Me.BTNTRANSAC.TabIndex = 6
        Me.BTNTRANSAC.Text = "TRANSACTIONS"
        Me.BTNTRANSAC.UseTransparentBackground = True
        '
        'BTNSYSTEMSET
        '
        Me.BTNSYSTEMSET.BackColor = System.Drawing.Color.Transparent
        Me.BTNSYSTEMSET.CheckedState.CustomBorderColor = System.Drawing.Color.White
        Me.BTNSYSTEMSET.CheckedState.FillColor = System.Drawing.Color.White
        Me.BTNSYSTEMSET.CheckedState.FillColor2 = System.Drawing.Color.White
        Me.BTNSYSTEMSET.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BTNSYSTEMSET.CheckedState.Parent = Me.BTNSYSTEMSET
        Me.BTNSYSTEMSET.CustomBorderColor = System.Drawing.Color.RosyBrown
        Me.BTNSYSTEMSET.CustomImages.Parent = Me.BTNSYSTEMSET
        Me.BTNSYSTEMSET.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BTNSYSTEMSET.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNSYSTEMSET.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNSYSTEMSET.ForeColor = System.Drawing.Color.White
        Me.BTNSYSTEMSET.HoverState.Parent = Me.BTNSYSTEMSET
        Me.BTNSYSTEMSET.Location = New System.Drawing.Point(0, 393)
        Me.BTNSYSTEMSET.Name = "BTNSYSTEMSET"
        Me.BTNSYSTEMSET.ShadowDecoration.Parent = Me.BTNSYSTEMSET
        Me.BTNSYSTEMSET.Size = New System.Drawing.Size(203, 31)
        Me.BTNSYSTEMSET.TabIndex = 5
        Me.BTNSYSTEMSET.Text = "SYSTEM SETTINGS"
        Me.BTNSYSTEMSET.UseTransparentBackground = True
        '
        'BTNBORRPROF
        '
        Me.BTNBORRPROF.BackColor = System.Drawing.Color.Transparent
        Me.BTNBORRPROF.CheckedState.CustomBorderColor = System.Drawing.Color.White
        Me.BTNBORRPROF.CheckedState.FillColor = System.Drawing.Color.White
        Me.BTNBORRPROF.CheckedState.FillColor2 = System.Drawing.Color.White
        Me.BTNBORRPROF.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BTNBORRPROF.CheckedState.Parent = Me.BTNBORRPROF
        Me.BTNBORRPROF.CustomBorderColor = System.Drawing.Color.RosyBrown
        Me.BTNBORRPROF.CustomImages.Parent = Me.BTNBORRPROF
        Me.BTNBORRPROF.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BTNBORRPROF.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNBORRPROF.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNBORRPROF.ForeColor = System.Drawing.Color.White
        Me.BTNBORRPROF.HoverState.Parent = Me.BTNBORRPROF
        Me.BTNBORRPROF.Location = New System.Drawing.Point(0, 319)
        Me.BTNBORRPROF.Name = "BTNBORRPROF"
        Me.BTNBORRPROF.ShadowDecoration.Parent = Me.BTNBORRPROF
        Me.BTNBORRPROF.Size = New System.Drawing.Size(203, 31)
        Me.BTNBORRPROF.TabIndex = 4
        Me.BTNBORRPROF.Text = "BORROWERS PROFILE"
        Me.BTNBORRPROF.UseTransparentBackground = True
        '
        'BTNADDITEM
        '
        Me.BTNADDITEM.BackColor = System.Drawing.Color.Transparent
        Me.BTNADDITEM.CheckedState.CustomBorderColor = System.Drawing.Color.White
        Me.BTNADDITEM.CheckedState.FillColor = System.Drawing.Color.White
        Me.BTNADDITEM.CheckedState.FillColor2 = System.Drawing.Color.White
        Me.BTNADDITEM.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BTNADDITEM.CheckedState.Parent = Me.BTNADDITEM
        Me.BTNADDITEM.CustomBorderColor = System.Drawing.Color.RosyBrown
        Me.BTNADDITEM.CustomImages.Parent = Me.BTNADDITEM
        Me.BTNADDITEM.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BTNADDITEM.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNADDITEM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNADDITEM.ForeColor = System.Drawing.Color.White
        Me.BTNADDITEM.HoverState.Parent = Me.BTNADDITEM
        Me.BTNADDITEM.Location = New System.Drawing.Point(0, 282)
        Me.BTNADDITEM.Name = "BTNADDITEM"
        Me.BTNADDITEM.ShadowDecoration.Parent = Me.BTNADDITEM
        Me.BTNADDITEM.Size = New System.Drawing.Size(203, 31)
        Me.BTNADDITEM.TabIndex = 3
        Me.BTNADDITEM.Text = "ADD ITEM STOCK"
        Me.BTNADDITEM.UseTransparentBackground = True
        '
        'BTNITEM
        '
        Me.BTNITEM.BackColor = System.Drawing.Color.Transparent
        Me.BTNITEM.CheckedState.CustomBorderColor = System.Drawing.Color.White
        Me.BTNITEM.CheckedState.FillColor = System.Drawing.Color.White
        Me.BTNITEM.CheckedState.FillColor2 = System.Drawing.Color.White
        Me.BTNITEM.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BTNITEM.CheckedState.Parent = Me.BTNITEM
        Me.BTNITEM.CustomBorderColor = System.Drawing.Color.RosyBrown
        Me.BTNITEM.CustomImages.Parent = Me.BTNITEM
        Me.BTNITEM.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BTNITEM.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNITEM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNITEM.ForeColor = System.Drawing.Color.White
        Me.BTNITEM.HoverState.Parent = Me.BTNITEM
        Me.BTNITEM.Location = New System.Drawing.Point(0, 245)
        Me.BTNITEM.Name = "BTNITEM"
        Me.BTNITEM.ShadowDecoration.Parent = Me.BTNITEM
        Me.BTNITEM.Size = New System.Drawing.Size(203, 31)
        Me.BTNITEM.TabIndex = 2
        Me.BTNITEM.Text = "ITEM"
        Me.BTNITEM.UseTransparentBackground = True
        '
        'BTNMANAGE
        '
        Me.BTNMANAGE.BackColor = System.Drawing.Color.Transparent
        Me.BTNMANAGE.CheckedState.CustomBorderColor = System.Drawing.Color.White
        Me.BTNMANAGE.CheckedState.FillColor = System.Drawing.Color.White
        Me.BTNMANAGE.CheckedState.FillColor2 = System.Drawing.Color.White
        Me.BTNMANAGE.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BTNMANAGE.CheckedState.Parent = Me.BTNMANAGE
        Me.BTNMANAGE.CustomBorderColor = System.Drawing.Color.RoyalBlue
        Me.BTNMANAGE.CustomImages.Parent = Me.BTNMANAGE
        Me.BTNMANAGE.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BTNMANAGE.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNMANAGE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNMANAGE.ForeColor = System.Drawing.Color.White
        Me.BTNMANAGE.HoverState.CustomBorderColor = System.Drawing.Color.White
        Me.BTNMANAGE.HoverState.FillColor = System.Drawing.Color.SkyBlue
        Me.BTNMANAGE.HoverState.FillColor2 = System.Drawing.Color.SkyBlue
        Me.BTNMANAGE.HoverState.Parent = Me.BTNMANAGE
        Me.BTNMANAGE.Location = New System.Drawing.Point(0, 208)
        Me.BTNMANAGE.Name = "BTNMANAGE"
        Me.BTNMANAGE.ShadowDecoration.Parent = Me.BTNMANAGE
        Me.BTNMANAGE.Size = New System.Drawing.Size(203, 31)
        Me.BTNMANAGE.TabIndex = 1
        Me.BTNMANAGE.Text = "MANAGE USER ACCOUNT "
        Me.BTNMANAGE.UseTransparentBackground = True
        '
        'pnlback
        '
        Me.pnlback.Controls.Add(Me.Guna2GradientPanel1)
        Me.pnlback.Controls.Add(Me.pnlmainmenu)
        Me.pnlback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlback.Location = New System.Drawing.Point(203, 0)
        Me.pnlback.Name = "pnlback"
        Me.pnlback.ShadowDecoration.Parent = Me.pnlback
        Me.pnlback.Size = New System.Drawing.Size(818, 527)
        Me.pnlback.TabIndex = 1
        '
        'pnlmainmenu
        '
        Me.pnlmainmenu.BackgroundImage = CType(resources.GetObject("pnlmainmenu.BackgroundImage"), System.Drawing.Image)
        Me.pnlmainmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlmainmenu.Controls.Add(Me.Label1)
        Me.pnlmainmenu.GradientBottomLeft = System.Drawing.Color.White
        Me.pnlmainmenu.GradientBottomRight = System.Drawing.Color.White
        Me.pnlmainmenu.GradientTopLeft = System.Drawing.Color.White
        Me.pnlmainmenu.GradientTopRight = System.Drawing.Color.White
        Me.pnlmainmenu.Location = New System.Drawing.Point(10, 53)
        Me.pnlmainmenu.Name = "pnlmainmenu"
        Me.pnlmainmenu.Quality = 10
        Me.pnlmainmenu.Size = New System.Drawing.Size(800, 462)
        Me.pnlmainmenu.TabIndex = 2
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.btnExit)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblgreet)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(818, 43)
        Me.Guna2GradientPanel1.TabIndex = 3
        '
        'lblgreet
        '
        Me.lblgreet.AutoSize = False
        Me.lblgreet.BackColor = System.Drawing.Color.Transparent
        Me.lblgreet.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgreet.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblgreet.Location = New System.Drawing.Point(379, 0)
        Me.lblgreet.Name = "lblgreet"
        Me.lblgreet.Size = New System.Drawing.Size(140, 43)
        Me.lblgreet.TabIndex = 1
        Me.lblgreet.Text = "USER NAME"
        Me.lblgreet.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(775, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(43, 43)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FRMMAINMENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlback)
        Me.Controls.Add(Me.pnlfrmmainpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMMAINMENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMMAINMENU"
        Me.pnlfrmmainpanel.ResumeLayout(False)
        Me.pnlfrmuser.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlback.ResumeLayout(False)
        Me.pnlmainmenu.ResumeLayout(False)
        Me.pnlmainmenu.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlfrmmainpanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents BTNBORRPROF As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNADDITEM As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNITEM As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNMANAGE As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNREP As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNTRANSAC As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNSYSTEMSET As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BTNDASHOARD As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlfrmuser As Panel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents BTNLOGOUT As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents chkshowbutton As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents lblshowhide As Label
    Friend WithEvents pnlback As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblgreet As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlmainmenu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
End Class
