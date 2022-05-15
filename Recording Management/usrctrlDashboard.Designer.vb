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
        Me.tggles = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.LBLSTOCKCOUNT = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.tmclock = New System.Windows.Forms.Timer(Me.components)
        Me.pnldash.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnldash
        '
        Me.pnldash.BackColor = System.Drawing.Color.Transparent
        Me.pnldash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnldash.Controls.Add(Me.tggles)
        Me.pnldash.Controls.Add(Me.Guna2Separator2)
        Me.pnldash.Controls.Add(Me.LBLSTOCKCOUNT)
        Me.pnldash.Controls.Add(Me.Label3)
        Me.pnldash.Controls.Add(Me.Label2)
        Me.pnldash.Controls.Add(Me.Label1)
        Me.pnldash.Controls.Add(Me.Guna2PictureBox2)
        Me.pnldash.Controls.Add(Me.BunifuCustomLabel1)
        Me.pnldash.Controls.Add(Me.Guna2Separator1)
        Me.pnldash.Controls.Add(Me.lbltime)
        Me.pnldash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnldash.FillColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnldash.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnldash.Location = New System.Drawing.Point(0, 0)
        Me.pnldash.Name = "pnldash"
        Me.pnldash.ShadowDecoration.Parent = Me.pnldash
        Me.pnldash.Size = New System.Drawing.Size(832, 493)
        Me.pnldash.TabIndex = 0
        '
        'tggles
        '
        Me.tggles.BackColor = System.Drawing.Color.Transparent
        Me.tggles.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tggles.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tggles.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.tggles.CheckedState.InnerColor = System.Drawing.Color.White
        Me.tggles.CheckedState.Parent = Me.tggles
        Me.tggles.Location = New System.Drawing.Point(758, 32)
        Me.tggles.Name = "tggles"
        Me.tggles.ShadowDecoration.Parent = Me.tggles
        Me.tggles.Size = New System.Drawing.Size(35, 20)
        Me.tggles.TabIndex = 25
        Me.tggles.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tggles.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tggles.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.tggles.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.tggles.UncheckedState.Parent = Me.tggles
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.FillColor = System.Drawing.Color.White
        Me.Guna2Separator2.FillThickness = 2
        Me.Guna2Separator2.Location = New System.Drawing.Point(112, 65)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(603, 18)
        Me.Guna2Separator2.TabIndex = 24
        '
        'LBLSTOCKCOUNT
        '
        Me.LBLSTOCKCOUNT.AutoSize = True
        Me.LBLSTOCKCOUNT.BackColor = System.Drawing.Color.Transparent
        Me.LBLSTOCKCOUNT.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSTOCKCOUNT.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LBLSTOCKCOUNT.Location = New System.Drawing.Point(100, 251)
        Me.LBLSTOCKCOUNT.Name = "LBLSTOCKCOUNT"
        Me.LBLSTOCKCOUNT.Size = New System.Drawing.Size(82, 17)
        Me.LBLSTOCKCOUNT.TabIndex = 23
        Me.LBLSTOCKCOUNT.Text = "Stock Count"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("alarm clock", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(563, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 123)
        Me.Label3.TabIndex = 21
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("alarm clock", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(288, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 123)
        Me.Label2.TabIndex = 20
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("alarm clock", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(13, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 123)
        Me.Label1.TabIndex = 19
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.Recording_Management.My.Resources.Resources.University_of_Rizal_System_logo_4227AA5058_seeklogo_com
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(679, 103)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(77, 89)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 18
        Me.Guna2PictureBox2.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Info
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(123, 90)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Padding = New System.Windows.Forms.Padding(10)
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(559, 112)
        Me.BunifuCustomLabel1.TabIndex = 16
        Me.BunifuCustomLabel1.Text = "RECORD MANAGEMENT SYSTEM FOR GENERAL SERVICES OFFICE"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.White
        Me.Guna2Separator1.FillThickness = 2
        Me.Guna2Separator1.Location = New System.Drawing.Point(41, 208)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(727, 18)
        Me.Guna2Separator1.TabIndex = 15
        '
        'lbltime
        '
        Me.lbltime.BackColor = System.Drawing.Color.Transparent
        Me.lbltime.Font = New System.Drawing.Font("alarm clock", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbltime.Location = New System.Drawing.Point(199, 15)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(426, 48)
        Me.lbltime.TabIndex = 11
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Size = New System.Drawing.Size(832, 493)
        Me.pnldash.ResumeLayout(False)
        Me.pnldash.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnldash As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents tmclock As Timer
    Friend WithEvents lbltime As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LBLSTOCKCOUNT As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents tggles As Guna.UI2.WinForms.Guna2ToggleSwitch
End Class
