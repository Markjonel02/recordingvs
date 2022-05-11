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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnluser = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TXTCONF = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CBOSTAT = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtLN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DGUSER = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbluserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Record_management_systemDataSet = New Recording_Management.record_management_systemDataSet()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CBOUST = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXTPASS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTUSN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTDUN = New System.Windows.Forms.TextBox()
        Me.Tbl_userTableAdapter = New Recording_Management.record_management_systemDataSetTableAdapters.tbl_userTableAdapter()
        Me.Guna2MouseStateHandler1 = New Guna.UI2.WinForms.Guna2MouseStateHandler(Me.components)
        Me.Guna2MouseStateHandler2 = New Guna.UI2.WinForms.Guna2MouseStateHandler(Me.components)
        Me.pnluser.SuspendLayout()
        CType(Me.DGUSER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Record_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnluser
        '
        Me.pnluser.BorderColor = System.Drawing.Color.White
        Me.pnluser.Controls.Add(Me.btnCancel)
        Me.pnluser.Controls.Add(Me.TXTCONF)
        Me.pnluser.Controls.Add(Me.Guna2HtmlLabel6)
        Me.pnluser.Controls.Add(Me.Guna2HtmlLabel5)
        Me.pnluser.Controls.Add(Me.CBOSTAT)
        Me.pnluser.Controls.Add(Me.txtLN)
        Me.pnluser.Controls.Add(Me.DGUSER)
        Me.pnluser.Controls.Add(Me.btnEdit)
        Me.pnluser.Controls.Add(Me.btnSave)
        Me.pnluser.Controls.Add(Me.btnAdd)
        Me.pnluser.Controls.Add(Me.Guna2HtmlLabel3)
        Me.pnluser.Controls.Add(Me.Guna2HtmlLabel4)
        Me.pnluser.Controls.Add(Me.Guna2HtmlLabel2)
        Me.pnluser.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnluser.Controls.Add(Me.CBOUST)
        Me.pnluser.Controls.Add(Me.TXTPASS)
        Me.pnluser.Controls.Add(Me.TXTUSN)
        Me.pnluser.Controls.Add(Me.TXTDUN)
        Me.pnluser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnluser.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnluser.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pnluser.Location = New System.Drawing.Point(0, 0)
        Me.pnluser.Name = "pnluser"
        Me.pnluser.ShadowDecoration.Parent = Me.pnluser
        Me.pnluser.Size = New System.Drawing.Size(800, 462)
        Me.pnluser.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.AutoRoundedCorners = True
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderColor = System.Drawing.Color.White
        Me.btnCancel.BorderRadius = 21
        Me.btnCancel.BorderThickness = 2
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.White
        Me.btnCancel.FillColor2 = System.Drawing.Color.White
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnCancel.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Image = Global.Recording_Management.My.Resources.Resources.cross
        Me.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancel.ImageOffset = New System.Drawing.Point(7, 0)
        Me.btnCancel.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnCancel.Location = New System.Drawing.Point(615, 173)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(141, 45)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "CANCEL"
        '
        'TXTCONF
        '
        Me.TXTCONF.AutoRoundedCorners = True
        Me.TXTCONF.BackColor = System.Drawing.Color.Transparent
        Me.TXTCONF.BorderRadius = 17
        Me.TXTCONF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTCONF.DefaultText = ""
        Me.TXTCONF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTCONF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTCONF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCONF.DisabledState.Parent = Me.TXTCONF
        Me.TXTCONF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCONF.Enabled = False
        Me.TXTCONF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCONF.FocusedState.Parent = Me.TXTCONF
        Me.TXTCONF.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCONF.HoverState.Parent = Me.TXTCONF
        Me.TXTCONF.Location = New System.Drawing.Point(527, 62)
        Me.TXTCONF.Name = "TXTCONF"
        Me.TXTCONF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTCONF.PlaceholderText = ""
        Me.TXTCONF.SelectedText = ""
        Me.TXTCONF.ShadowDecoration.Parent = Me.TXTCONF
        Me.TXTCONF.Size = New System.Drawing.Size(239, 36)
        Me.TXTCONF.TabIndex = 2
        Me.TXTCONF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXTCONF.UseSystemPasswordChar = True
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(384, 73)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(137, 16)
        Me.Guna2HtmlLabel6.TabIndex = 23
        Me.Guna2HtmlLabel6.Text = "CONFIRM PASSWORD"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(22, 120)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(52, 16)
        Me.Guna2HtmlLabel5.TabIndex = 21
        Me.Guna2HtmlLabel5.Text = "STATUS"
        '
        'CBOSTAT
        '
        Me.CBOSTAT.AutoRoundedCorners = True
        Me.CBOSTAT.BackColor = System.Drawing.Color.Transparent
        Me.CBOSTAT.BorderRadius = 17
        Me.CBOSTAT.BorderThickness = 0
        Me.CBOSTAT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOSTAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOSTAT.Enabled = False
        Me.CBOSTAT.FocusedColor = System.Drawing.Color.Empty
        Me.CBOSTAT.FocusedState.Parent = Me.CBOSTAT
        Me.CBOSTAT.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBOSTAT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBOSTAT.FormattingEnabled = True
        Me.CBOSTAT.HoverState.Parent = Me.CBOSTAT
        Me.CBOSTAT.ItemHeight = 30
        Me.CBOSTAT.Items.AddRange(New Object() {"Active", "Deactivate"})
        Me.CBOSTAT.ItemsAppearance.Parent = Me.CBOSTAT
        Me.CBOSTAT.Location = New System.Drawing.Point(98, 106)
        Me.CBOSTAT.Name = "CBOSTAT"
        Me.CBOSTAT.ShadowDecoration.Parent = Me.CBOSTAT
        Me.CBOSTAT.Size = New System.Drawing.Size(280, 36)
        Me.CBOSTAT.TabIndex = 5
        Me.CBOSTAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLN
        '
        Me.txtLN.AutoRoundedCorners = True
        Me.txtLN.BackColor = System.Drawing.Color.Transparent
        Me.txtLN.BorderRadius = 17
        Me.txtLN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLN.DefaultText = ""
        Me.txtLN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLN.DisabledState.Parent = Me.txtLN
        Me.txtLN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLN.Enabled = False
        Me.txtLN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLN.FocusedState.Parent = Me.txtLN
        Me.txtLN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLN.HoverState.Parent = Me.txtLN
        Me.txtLN.Location = New System.Drawing.Point(98, 62)
        Me.txtLN.Name = "txtLN"
        Me.txtLN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLN.PlaceholderText = ""
        Me.txtLN.SelectedText = ""
        Me.txtLN.ShadowDecoration.Parent = Me.txtLN
        Me.txtLN.Size = New System.Drawing.Size(280, 36)
        Me.txtLN.TabIndex = 3
        Me.txtLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGUSER
        '
        Me.DGUSER.AllowUserToAddRows = False
        Me.DGUSER.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGUSER.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGUSER.AutoGenerateColumns = False
        Me.DGUSER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGUSER.BackgroundColor = System.Drawing.Color.White
        Me.DGUSER.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGUSER.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGUSER.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGUSER.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGUSER.ColumnHeadersHeight = 30
        Me.DGUSER.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.StatusDataGridViewTextBoxColumn})
        Me.DGUSER.DataSource = Me.TbluserBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGUSER.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGUSER.EnableHeadersVisualStyles = False
        Me.DGUSER.GridColor = System.Drawing.Color.White
        Me.DGUSER.Location = New System.Drawing.Point(62, 240)
        Me.DGUSER.Name = "DGUSER"
        Me.DGUSER.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGUSER.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGUSER.RowHeadersVisible = False
        Me.DGUSER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGUSER.Size = New System.Drawing.Size(679, 200)
        Me.DGUSER.TabIndex = 18
        Me.DGUSER.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DGUSER.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGUSER.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGUSER.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGUSER.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGUSER.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGUSER.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGUSER.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.DGUSER.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.DGUSER.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGUSER.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGUSER.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGUSER.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGUSER.ThemeStyle.HeaderStyle.Height = 30
        Me.DGUSER.ThemeStyle.ReadOnly = True
        Me.DGUSER.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray
        Me.DGUSER.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGUSER.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGUSER.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGUSER.ThemeStyle.RowsStyle.Height = 22
        Me.DGUSER.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGUSER.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn1.HeaderText = "username"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn2.HeaderText = "password"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "loginame"
        Me.DataGridViewTextBoxColumn3.HeaderText = "loginame"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "usertype"
        Me.DataGridViewTextBoxColumn4.HeaderText = "usertype"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbluserBindingSource
        '
        Me.TbluserBindingSource.DataMember = "tbl_user"
        Me.TbluserBindingSource.DataSource = Me.Record_management_systemDataSet
        '
        'Record_management_systemDataSet
        '
        Me.Record_management_systemDataSet.DataSetName = "record_management_systemDataSet"
        Me.Record_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnEdit
        '
        Me.btnEdit.AutoRoundedCorners = True
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BorderColor = System.Drawing.Color.White
        Me.btnEdit.BorderRadius = 21
        Me.btnEdit.BorderThickness = 2
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.FillColor = System.Drawing.Color.White
        Me.btnEdit.FillColor2 = System.Drawing.Color.White
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnEdit.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Image = Global.Recording_Management.My.Resources.Resources.edit
        Me.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEdit.ImageOffset = New System.Drawing.Point(7, 0)
        Me.btnEdit.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEdit.Location = New System.Drawing.Point(426, 173)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(141, 45)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "EDIT"
        '
        'btnSave
        '
        Me.btnSave.AutoRoundedCorners = True
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderColor = System.Drawing.Color.White
        Me.btnSave.BorderRadius = 21
        Me.btnSave.BorderThickness = 2
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.White
        Me.btnSave.FillColor2 = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSave.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Image = Global.Recording_Management.My.Resources.Resources.floppy_disk
        Me.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSave.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnSave.Location = New System.Drawing.Point(48, 173)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(141, 45)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "SAVE"
        '
        'btnAdd
        '
        Me.btnAdd.AutoRoundedCorners = True
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderColor = System.Drawing.Color.White
        Me.btnAdd.BorderRadius = 21
        Me.btnAdd.BorderThickness = 2
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.White
        Me.btnAdd.FillColor2 = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnAdd.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Image = Global.Recording_Management.My.Resources.Resources.plus__2_
        Me.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdd.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnAdd.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAdd.Location = New System.Drawing.Point(237, 173)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(141, 45)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "ADD"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(430, 28)
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
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(433, 115)
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
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(15, 28)
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
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(10, 72)
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
        Me.CBOUST.BorderThickness = 0
        Me.CBOUST.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOUST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOUST.Enabled = False
        Me.CBOUST.FocusedColor = System.Drawing.Color.Empty
        Me.CBOUST.FocusedState.Parent = Me.CBOUST
        Me.CBOUST.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBOUST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBOUST.FormattingEnabled = True
        Me.CBOUST.HoverState.Parent = Me.CBOUST
        Me.CBOUST.ItemHeight = 30
        Me.CBOUST.Items.AddRange(New Object() {"gso", "staff"})
        Me.CBOUST.ItemsAppearance.Parent = Me.CBOUST
        Me.CBOUST.Location = New System.Drawing.Point(527, 106)
        Me.CBOUST.Name = "CBOUST"
        Me.CBOUST.ShadowDecoration.Parent = Me.CBOUST
        Me.CBOUST.Size = New System.Drawing.Size(233, 36)
        Me.CBOUST.TabIndex = 4
        Me.CBOUST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.TXTPASS.Enabled = False
        Me.TXTPASS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPASS.FocusedState.Parent = Me.TXTPASS
        Me.TXTPASS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPASS.HoverState.Parent = Me.TXTPASS
        Me.TXTPASS.IconLeft = Global.Recording_Management.My.Resources.Resources.padlock
        Me.TXTPASS.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TXTPASS.Location = New System.Drawing.Point(527, 18)
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPASS.PlaceholderText = ""
        Me.TXTPASS.SelectedText = ""
        Me.TXTPASS.ShadowDecoration.Parent = Me.TXTPASS
        Me.TXTPASS.Size = New System.Drawing.Size(239, 36)
        Me.TXTPASS.TabIndex = 1
        Me.TXTPASS.UseSystemPasswordChar = True
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
        Me.TXTUSN.Enabled = False
        Me.TXTUSN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTUSN.FocusedState.Parent = Me.TXTUSN
        Me.TXTUSN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTUSN.HoverState.Parent = Me.TXTUSN
        Me.TXTUSN.IconLeft = Global.Recording_Management.My.Resources.Resources.user1
        Me.TXTUSN.IconLeftCursor = System.Windows.Forms.Cursors.No
        Me.TXTUSN.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TXTUSN.Location = New System.Drawing.Point(98, 18)
        Me.TXTUSN.Name = "TXTUSN"
        Me.TXTUSN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTUSN.PlaceholderText = ""
        Me.TXTUSN.SelectedText = ""
        Me.TXTUSN.ShadowDecoration.Parent = Me.TXTUSN
        Me.TXTUSN.Size = New System.Drawing.Size(280, 36)
        Me.TXTUSN.TabIndex = 0
        Me.TXTUSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTDUN
        '
        Me.TXTDUN.Enabled = False
        Me.TXTDUN.Location = New System.Drawing.Point(606, 120)
        Me.TXTDUN.Name = "TXTDUN"
        Me.TXTDUN.Size = New System.Drawing.Size(100, 20)
        Me.TXTDUN.TabIndex = 22
        Me.TXTDUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXTDUN.Visible = False
        '
        'Tbl_userTableAdapter
        '
        Me.Tbl_userTableAdapter.ClearBeforeFill = True
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
        CType(Me.DGUSER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Record_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnluser As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents CBOUST As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTPASS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTUSN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsertypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DGUSER As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbluserBindingSource As BindingSource
    Friend WithEvents Record_management_systemDataSet As record_management_systemDataSet
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Tbl_userTableAdapter As record_management_systemDataSetTableAdapters.tbl_userTableAdapter
    Friend WithEvents Guna2MouseStateHandler1 As Guna.UI2.WinForms.Guna2MouseStateHandler
    Friend WithEvents Guna2MouseStateHandler2 As Guna.UI2.WinForms.Guna2MouseStateHandler
    Friend WithEvents txtLN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CBOSTAT As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTDUN As TextBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TXTCONF As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
