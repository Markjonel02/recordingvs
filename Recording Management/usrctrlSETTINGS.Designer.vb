<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrpnlSet
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
        Me.TblsettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Record_management_systemDataSet = New Recording_Management.record_management_systemDataSet()
        Me.Tbl_settingsTableAdapter = New Recording_Management.record_management_systemDataSetTableAdapters.tbl_settingsTableAdapter()
        Me.DGV_set = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ItemcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTENTERCAT = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.TblsettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Record_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_set, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TblsettingsBindingSource
        '
        Me.TblsettingsBindingSource.DataMember = "tbl_settings"
        Me.TblsettingsBindingSource.DataSource = Me.Record_management_systemDataSet
        '
        'Record_management_systemDataSet
        '
        Me.Record_management_systemDataSet.DataSetName = "record_management_systemDataSet"
        Me.Record_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_settingsTableAdapter
        '
        Me.Tbl_settingsTableAdapter.ClearBeforeFill = True
        '
        'DGV_set
        '
        Me.DGV_set.AllowUserToAddRows = False
        Me.DGV_set.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_set.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_set.AutoGenerateColumns = False
        Me.DGV_set.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_set.BackgroundColor = System.Drawing.Color.White
        Me.DGV_set.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_set.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_set.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_set.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_set.ColumnHeadersHeight = 21
        Me.DGV_set.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemcodeDataGridViewTextBoxColumn, Me.ItemcategoryDataGridViewTextBoxColumn})
        Me.DGV_set.DataSource = Me.TblsettingsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_set.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_set.EnableHeadersVisualStyles = False
        Me.DGV_set.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_set.Location = New System.Drawing.Point(272, 213)
        Me.DGV_set.Name = "DGV_set"
        Me.DGV_set.ReadOnly = True
        Me.DGV_set.RowHeadersVisible = False
        Me.DGV_set.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_set.Size = New System.Drawing.Size(339, 212)
        Me.DGV_set.TabIndex = 10
        Me.DGV_set.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DGV_set.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_set.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_set.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_set.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_set.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_set.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_set.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_set.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_set.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_set.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGV_set.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_set.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_set.ThemeStyle.HeaderStyle.Height = 21
        Me.DGV_set.ThemeStyle.ReadOnly = True
        Me.DGV_set.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_set.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_set.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGV_set.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_set.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_set.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_set.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ItemcodeDataGridViewTextBoxColumn
        '
        Me.ItemcodeDataGridViewTextBoxColumn.DataPropertyName = "item_code"
        Me.ItemcodeDataGridViewTextBoxColumn.HeaderText = "item_code"
        Me.ItemcodeDataGridViewTextBoxColumn.Name = "ItemcodeDataGridViewTextBoxColumn"
        Me.ItemcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemcategoryDataGridViewTextBoxColumn
        '
        Me.ItemcategoryDataGridViewTextBoxColumn.DataPropertyName = "item_category"
        Me.ItemcategoryDataGridViewTextBoxColumn.HeaderText = "item_category"
        Me.ItemcategoryDataGridViewTextBoxColumn.Name = "ItemcategoryDataGridViewTextBoxColumn"
        Me.ItemcategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(363, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ENTER NEW CATEGORY"
        '
        'TXTENTERCAT
        '
        Me.TXTENTERCAT.AutoRoundedCorners = True
        Me.TXTENTERCAT.BackColor = System.Drawing.Color.Transparent
        Me.TXTENTERCAT.BorderRadius = 17
        Me.TXTENTERCAT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTENTERCAT.DefaultText = ""
        Me.TXTENTERCAT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTENTERCAT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTENTERCAT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTENTERCAT.DisabledState.Parent = Me.TXTENTERCAT
        Me.TXTENTERCAT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTENTERCAT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTENTERCAT.FocusedState.Parent = Me.TXTENTERCAT
        Me.TXTENTERCAT.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTENTERCAT.HoverState.Parent = Me.TXTENTERCAT
        Me.TXTENTERCAT.Location = New System.Drawing.Point(301, 43)
        Me.TXTENTERCAT.Name = "TXTENTERCAT"
        Me.TXTENTERCAT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTENTERCAT.PlaceholderText = ""
        Me.TXTENTERCAT.SelectedText = ""
        Me.TXTENTERCAT.ShadowDecoration.Parent = Me.TXTENTERCAT
        Me.TXTENTERCAT.Size = New System.Drawing.Size(270, 36)
        Me.TXTENTERCAT.TabIndex = 12
        Me.TXTENTERCAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnSave)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.TXTENTERCAT)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.DGV_set)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.DarkGray
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(832, 493)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
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
        Me.btnSave.Location = New System.Drawing.Point(366, 132)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(141, 45)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "SAVE"
        '
        'usrpnlSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Name = "usrpnlSet"
        Me.Size = New System.Drawing.Size(832, 493)
        CType(Me.TblsettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Record_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_set, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TblsettingsBindingSource As BindingSource
    Friend WithEvents Record_management_systemDataSet As record_management_systemDataSet
    Friend WithEvents Tbl_settingsTableAdapter As record_management_systemDataSetTableAdapters.tbl_settingsTableAdapter
    Friend WithEvents DGV_set As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ItemcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemcategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTENTERCAT As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
End Class
