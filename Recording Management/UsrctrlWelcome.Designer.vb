<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsrctrlWelcome
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblgreet = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblpara = New System.Windows.Forms.Label()
        Me.lblabout = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pics = New System.Windows.Forms.PictureBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.pics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.lblpara)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblabout)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.pics)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.White
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(421, 500)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'lblgreet
        '
        Me.lblgreet.AutoSize = False
        Me.lblgreet.BackColor = System.Drawing.Color.Transparent
        Me.lblgreet.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgreet.Location = New System.Drawing.Point(32, 312)
        Me.lblgreet.Name = "lblgreet"
        Me.lblgreet.Size = New System.Drawing.Size(356, 50)
        Me.lblgreet.TabIndex = 5
        Me.lblgreet.Text = "Welcome To Our Project"
        '
        'lblpara
        '
        Me.lblpara.Location = New System.Drawing.Point(32, 379)
        Me.lblpara.Name = "lblpara"
        Me.lblpara.Size = New System.Drawing.Size(335, 63)
        Me.lblpara.TabIndex = 7
        Me.lblpara.Text = "Lorem Ipsum Nedir?Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır meti" &
    "nlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir"
        Me.lblpara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblabout
        '
        Me.lblabout.AutoSize = True
        Me.lblabout.Location = New System.Drawing.Point(176, 352)
        Me.lblabout.Name = "lblabout"
        Me.lblabout.Size = New System.Drawing.Size(49, 13)
        Me.lblabout.TabIndex = 6
        Me.lblabout.Text = "About us"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(32, 288)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(356, 50)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "Welcome To Our Project"
        '
        'pics
        '
        Me.pics.Image = Global.Recording_Management.My.Resources.Resources.workplace
        Me.pics.Location = New System.Drawing.Point(98, 57)
        Me.pics.Name = "pics"
        Me.pics.Size = New System.Drawing.Size(217, 217)
        Me.pics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pics.TabIndex = 4
        Me.pics.TabStop = False
        '
        'UsrctrlWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Name = "UsrctrlWelcome"
        Me.Size = New System.Drawing.Size(421, 500)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.pics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblgreet As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblpara As Label
    Friend WithEvents lblabout As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pics As PictureBox
End Class
