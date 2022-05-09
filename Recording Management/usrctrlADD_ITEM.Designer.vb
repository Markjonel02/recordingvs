<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrctrlADD_ITEM
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
        Me.pnlusrctrlAdditem = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTADDED = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBOADDEDST = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBOAVAILST = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXTITNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTITCODE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pnlusrctrlAdditem.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlusrctrlAdditem
        '
        Me.pnlusrctrlAdditem.Controls.Add(Me.Label5)
        Me.pnlusrctrlAdditem.Controls.Add(Me.TXTADDED)
        Me.pnlusrctrlAdditem.Controls.Add(Me.Label3)
        Me.pnlusrctrlAdditem.Controls.Add(Me.Label4)
        Me.pnlusrctrlAdditem.Controls.Add(Me.Label2)
        Me.pnlusrctrlAdditem.Controls.Add(Me.Label1)
        Me.pnlusrctrlAdditem.Controls.Add(Me.CBOADDEDST)
        Me.pnlusrctrlAdditem.Controls.Add(Me.CBOAVAILST)
        Me.pnlusrctrlAdditem.Controls.Add(Me.TXTITNAME)
        Me.pnlusrctrlAdditem.Controls.Add(Me.TXTITCODE)
        Me.pnlusrctrlAdditem.Controls.Add(Me.DataGridView1)
        Me.pnlusrctrlAdditem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlusrctrlAdditem.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlusrctrlAdditem.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.pnlusrctrlAdditem.Location = New System.Drawing.Point(0, 0)
        Me.pnlusrctrlAdditem.Name = "pnlusrctrlAdditem"
        Me.pnlusrctrlAdditem.ShadowDecoration.Parent = Me.pnlusrctrlAdditem
        Me.pnlusrctrlAdditem.Size = New System.Drawing.Size(800, 462)
        Me.pnlusrctrlAdditem.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(45, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 36)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Date Added"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTADDED
        '
        Me.TXTADDED.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTADDED.DefaultText = ""
        Me.TXTADDED.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTADDED.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTADDED.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTADDED.DisabledState.Parent = Me.TXTADDED
        Me.TXTADDED.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTADDED.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTADDED.FocusedState.Parent = Me.TXTADDED
        Me.TXTADDED.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTADDED.HoverState.Parent = Me.TXTADDED
        Me.TXTADDED.Location = New System.Drawing.Point(123, 327)
        Me.TXTADDED.Name = "TXTADDED"
        Me.TXTADDED.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTADDED.PlaceholderText = ""
        Me.TXTADDED.SelectedText = ""
        Me.TXTADDED.ShadowDecoration.Parent = Me.TXTADDED
        Me.TXTADDED.Size = New System.Drawing.Size(200, 36)
        Me.TXTADDED.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(45, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 36)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Available Stock"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(45, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 36)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Added Stock"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(45, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 36)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Item name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(45, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Item code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBOADDEDST
        '
        Me.CBOADDEDST.BackColor = System.Drawing.Color.Transparent
        Me.CBOADDEDST.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOADDEDST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOADDEDST.FocusedColor = System.Drawing.Color.Empty
        Me.CBOADDEDST.FocusedState.Parent = Me.CBOADDEDST
        Me.CBOADDEDST.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBOADDEDST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBOADDEDST.FormattingEnabled = True
        Me.CBOADDEDST.HoverState.Parent = Me.CBOADDEDST
        Me.CBOADDEDST.ItemHeight = 30
        Me.CBOADDEDST.ItemsAppearance.Parent = Me.CBOADDEDST
        Me.CBOADDEDST.Location = New System.Drawing.Point(123, 285)
        Me.CBOADDEDST.Name = "CBOADDEDST"
        Me.CBOADDEDST.ShadowDecoration.Parent = Me.CBOADDEDST
        Me.CBOADDEDST.Size = New System.Drawing.Size(200, 36)
        Me.CBOADDEDST.TabIndex = 4
        '
        'CBOAVAILST
        '
        Me.CBOAVAILST.BackColor = System.Drawing.Color.Transparent
        Me.CBOAVAILST.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOAVAILST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOAVAILST.FocusedColor = System.Drawing.Color.Empty
        Me.CBOAVAILST.FocusedState.Parent = Me.CBOAVAILST
        Me.CBOAVAILST.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBOAVAILST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBOAVAILST.FormattingEnabled = True
        Me.CBOAVAILST.HoverState.Parent = Me.CBOAVAILST
        Me.CBOAVAILST.ItemHeight = 30
        Me.CBOAVAILST.ItemsAppearance.Parent = Me.CBOAVAILST
        Me.CBOAVAILST.Location = New System.Drawing.Point(123, 243)
        Me.CBOAVAILST.Name = "CBOAVAILST"
        Me.CBOAVAILST.ShadowDecoration.Parent = Me.CBOAVAILST
        Me.CBOAVAILST.Size = New System.Drawing.Size(200, 36)
        Me.CBOAVAILST.TabIndex = 3
        '
        'TXTITNAME
        '
        Me.TXTITNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTITNAME.DefaultText = ""
        Me.TXTITNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTITNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTITNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTITNAME.DisabledState.Parent = Me.TXTITNAME
        Me.TXTITNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTITNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTITNAME.FocusedState.Parent = Me.TXTITNAME
        Me.TXTITNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTITNAME.HoverState.Parent = Me.TXTITNAME
        Me.TXTITNAME.Location = New System.Drawing.Point(123, 201)
        Me.TXTITNAME.Name = "TXTITNAME"
        Me.TXTITNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTITNAME.PlaceholderText = ""
        Me.TXTITNAME.SelectedText = ""
        Me.TXTITNAME.ShadowDecoration.Parent = Me.TXTITNAME
        Me.TXTITNAME.Size = New System.Drawing.Size(200, 36)
        Me.TXTITNAME.TabIndex = 2
        '
        'TXTITCODE
        '
        Me.TXTITCODE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTITCODE.DefaultText = ""
        Me.TXTITCODE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTITCODE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTITCODE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTITCODE.DisabledState.Parent = Me.TXTITCODE
        Me.TXTITCODE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTITCODE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTITCODE.FocusedState.Parent = Me.TXTITCODE
        Me.TXTITCODE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTITCODE.HoverState.Parent = Me.TXTITCODE
        Me.TXTITCODE.Location = New System.Drawing.Point(123, 159)
        Me.TXTITCODE.Name = "TXTITCODE"
        Me.TXTITCODE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTITCODE.PlaceholderText = ""
        Me.TXTITCODE.SelectedText = ""
        Me.TXTITCODE.ShadowDecoration.Parent = Me.TXTITCODE
        Me.TXTITCODE.Size = New System.Drawing.Size(200, 36)
        Me.TXTITCODE.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(338, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(439, 189)
        Me.DataGridView1.TabIndex = 0
        '
        'usrctrlADD_ITEM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlusrctrlAdditem)
        Me.Name = "usrctrlADD_ITEM"
        Me.Size = New System.Drawing.Size(800, 462)
        Me.pnlusrctrlAdditem.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlusrctrlAdditem As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents CBOADDEDST As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBOAVAILST As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTITNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTITCODE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTADDED As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
End Class
