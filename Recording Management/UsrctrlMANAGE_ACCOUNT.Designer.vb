<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsrctrlMANAGE_ACCOUNT
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
        Me.pnluser = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CBOUST = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBOLOGN = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXTPASS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTUSN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnluser.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnluser
        '
        Me.pnluser.Controls.Add(Me.DataGridView1)
        Me.pnluser.Controls.Add(Me.Guna2HtmlLabel3)
        Me.pnluser.Controls.Add(Me.Guna2HtmlLabel4)
        Me.pnluser.Controls.Add(Me.Guna2HtmlLabel2)
        Me.pnluser.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnluser.Controls.Add(Me.CBOUST)
        Me.pnluser.Controls.Add(Me.CBOLOGN)
        Me.pnluser.Controls.Add(Me.TXTPASS)
        Me.pnluser.Controls.Add(Me.TXTUSN)
        Me.pnluser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnluser.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnluser.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pnluser.Location = New System.Drawing.Point(0, 0)
        Me.pnluser.Name = "pnluser"
        Me.pnluser.ShadowDecoration.Parent = Me.pnluser
        Me.pnluser.Size = New System.Drawing.Size(800, 462)
        Me.pnluser.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(354, 206)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(444, 192)
        Me.DataGridView1.TabIndex = 13
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(13, 268)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(74, 16)
        Me.Guna2HtmlLabel3.TabIndex = 8
        Me.Guna2HtmlLabel3.Text = "password"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(13, 376)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(70, 16)
        Me.Guna2HtmlLabel4.TabIndex = 7
        Me.Guna2HtmlLabel4.Text = "usertype"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(13, 216)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(72, 16)
        Me.Guna2HtmlLabel2.TabIndex = 6
        Me.Guna2HtmlLabel2.Text = "username"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(13, 324)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(81, 16)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "login name"
        '
        'CBOUST
        '
        Me.CBOUST.AutoRoundedCorners = True
        Me.CBOUST.BackColor = System.Drawing.Color.Transparent
        Me.CBOUST.BorderRadius = 17
        Me.CBOUST.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOUST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOUST.FocusedColor = System.Drawing.Color.Empty
        Me.CBOUST.FocusedState.Parent = Me.CBOUST
        Me.CBOUST.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBOUST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBOUST.FormattingEnabled = True
        Me.CBOUST.HoverState.Parent = Me.CBOUST
        Me.CBOUST.ItemHeight = 30
        Me.CBOUST.ItemsAppearance.Parent = Me.CBOUST
        Me.CBOUST.Location = New System.Drawing.Point(107, 368)
        Me.CBOUST.Name = "CBOUST"
        Me.CBOUST.ShadowDecoration.Parent = Me.CBOUST
        Me.CBOUST.Size = New System.Drawing.Size(200, 36)
        Me.CBOUST.TabIndex = 3
        '
        'CBOLOGN
        '
        Me.CBOLOGN.AutoRoundedCorners = True
        Me.CBOLOGN.BackColor = System.Drawing.Color.Transparent
        Me.CBOLOGN.BorderRadius = 17
        Me.CBOLOGN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOLOGN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOLOGN.FocusedColor = System.Drawing.Color.Empty
        Me.CBOLOGN.FocusedState.Parent = Me.CBOLOGN
        Me.CBOLOGN.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBOLOGN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBOLOGN.FormattingEnabled = True
        Me.CBOLOGN.HoverState.Parent = Me.CBOLOGN
        Me.CBOLOGN.ItemHeight = 30
        Me.CBOLOGN.ItemsAppearance.Parent = Me.CBOLOGN
        Me.CBOLOGN.Location = New System.Drawing.Point(107, 314)
        Me.CBOLOGN.Name = "CBOLOGN"
        Me.CBOLOGN.ShadowDecoration.Parent = Me.CBOLOGN
        Me.CBOLOGN.Size = New System.Drawing.Size(200, 36)
        Me.CBOLOGN.TabIndex = 2
        '
        'TXTPASS
        '
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
        Me.TXTPASS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPASS.HoverState.Parent = Me.TXTPASS
        Me.TXTPASS.IconLeft = Global.Recording_Management.My.Resources.Resources.padlock
        Me.TXTPASS.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TXTPASS.Location = New System.Drawing.Point(107, 260)
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPASS.PlaceholderText = ""
        Me.TXTPASS.SelectedText = ""
        Me.TXTPASS.ShadowDecoration.Parent = Me.TXTPASS
        Me.TXTPASS.Size = New System.Drawing.Size(229, 36)
        Me.TXTPASS.TabIndex = 1
        '
        'TXTUSN
        '
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
        Me.TXTUSN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTUSN.HoverState.Parent = Me.TXTUSN
        Me.TXTUSN.IconLeft = Global.Recording_Management.My.Resources.Resources.user1
        Me.TXTUSN.IconLeftCursor = System.Windows.Forms.Cursors.No
        Me.TXTUSN.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TXTUSN.Location = New System.Drawing.Point(107, 206)
        Me.TXTUSN.Name = "TXTUSN"
        Me.TXTUSN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTUSN.PlaceholderText = ""
        Me.TXTUSN.SelectedText = ""
        Me.TXTUSN.ShadowDecoration.Parent = Me.TXTUSN
        Me.TXTUSN.Size = New System.Drawing.Size(229, 36)
        Me.TXTUSN.TabIndex = 0
        '
        'UsrctrlMANAGE_ACCOUNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnluser)
        Me.Name = "UsrctrlMANAGE_ACCOUNT"
        Me.Size = New System.Drawing.Size(800, 462)
        Me.pnluser.ResumeLayout(False)
        Me.pnluser.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnluser As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents CBOUST As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBOLOGN As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTPASS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTUSN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsertypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
