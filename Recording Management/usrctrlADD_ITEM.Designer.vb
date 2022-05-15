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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlusrctrlAdditem = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.TXTDATEADDED = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TXTSEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DG_items = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ItemcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailablestockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateaddedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblitemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Record_management_systemDataSet = New Recording_Management.record_management_systemDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ItemnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockaddedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateaddedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemcodeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblstockaddedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TXTAVS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTADDED = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTIName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTITCODE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Tbl_itemsTableAdapter = New Recording_Management.record_management_systemDataSetTableAdapters.tbl_itemsTableAdapter()
        Me.Tbl_stockaddedTableAdapter = New Recording_Management.record_management_systemDataSetTableAdapters.tbl_stockaddedTableAdapter()
        Me.chkeclearsearch = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.pnlusrctrlAdditem.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DG_items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Record_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstockaddedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlusrctrlAdditem
        '
        Me.pnlusrctrlAdditem.Controls.Add(Me.chkeclearsearch)
        Me.pnlusrctrlAdditem.Controls.Add(Me.TXTDATEADDED)
        Me.pnlusrctrlAdditem.Controls.Add(Me.btnCancel)
        Me.pnlusrctrlAdditem.Controls.Add(Me.btnAdd)
        Me.pnlusrctrlAdditem.Controls.Add(Me.TXTSEARCH)
        Me.pnlusrctrlAdditem.Controls.Add(Me.TabControl1)
        Me.pnlusrctrlAdditem.Controls.Add(Me.TXTAVS)
        Me.pnlusrctrlAdditem.Controls.Add(Me.Label5)
        Me.pnlusrctrlAdditem.Controls.Add(Me.TXTADDED)
        Me.pnlusrctrlAdditem.Controls.Add(Me.Label3)
        Me.pnlusrctrlAdditem.Controls.Add(Me.Label4)
        Me.pnlusrctrlAdditem.Controls.Add(Me.Label2)
        Me.pnlusrctrlAdditem.Controls.Add(Me.Label1)
        Me.pnlusrctrlAdditem.Controls.Add(Me.TXTIName)
        Me.pnlusrctrlAdditem.Controls.Add(Me.TXTITCODE)
        Me.pnlusrctrlAdditem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlusrctrlAdditem.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlusrctrlAdditem.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.pnlusrctrlAdditem.Location = New System.Drawing.Point(0, 0)
        Me.pnlusrctrlAdditem.Name = "pnlusrctrlAdditem"
        Me.pnlusrctrlAdditem.ShadowDecoration.Parent = Me.pnlusrctrlAdditem
        Me.pnlusrctrlAdditem.Size = New System.Drawing.Size(832, 493)
        Me.pnlusrctrlAdditem.TabIndex = 1
        '
        'TXTDATEADDED
        '
        Me.TXTDATEADDED.AutoRoundedCorners = True
        Me.TXTDATEADDED.BackColor = System.Drawing.Color.Transparent
        Me.TXTDATEADDED.BorderRadius = 23
        Me.TXTDATEADDED.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTDATEADDED.DefaultText = ""
        Me.TXTDATEADDED.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTDATEADDED.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTDATEADDED.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTDATEADDED.DisabledState.Parent = Me.TXTDATEADDED
        Me.TXTDATEADDED.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTDATEADDED.Enabled = False
        Me.TXTDATEADDED.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTDATEADDED.FocusedState.Parent = Me.TXTDATEADDED
        Me.TXTDATEADDED.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDATEADDED.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTDATEADDED.HoverState.Parent = Me.TXTDATEADDED
        Me.TXTDATEADDED.Location = New System.Drawing.Point(616, 14)
        Me.TXTDATEADDED.Name = "TXTDATEADDED"
        Me.TXTDATEADDED.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTDATEADDED.PlaceholderText = ""
        Me.TXTDATEADDED.SelectedText = ""
        Me.TXTDATEADDED.ShadowDecoration.Parent = Me.TXTDATEADDED
        Me.TXTDATEADDED.Size = New System.Drawing.Size(210, 48)
        Me.TXTDATEADDED.TabIndex = 25
        Me.TXTDATEADDED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnCancel.Enabled = False
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
        Me.btnCancel.Location = New System.Drawing.Point(456, 425)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(141, 45)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "CANCEL"
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
        Me.btnAdd.Enabled = False
        Me.btnAdd.FillColor = System.Drawing.Color.White
        Me.btnAdd.FillColor2 = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnAdd.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Image = Global.Recording_Management.My.Resources.Resources.plus
        Me.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdd.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnAdd.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAdd.Location = New System.Drawing.Point(286, 425)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(141, 45)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "ADD"
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.AutoRoundedCorners = True
        Me.TXTSEARCH.BackColor = System.Drawing.Color.Transparent
        Me.TXTSEARCH.BorderRadius = 17
        Me.TXTSEARCH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTSEARCH.DefaultText = ""
        Me.TXTSEARCH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTSEARCH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTSEARCH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSEARCH.DisabledState.Parent = Me.TXTSEARCH
        Me.TXTSEARCH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSEARCH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSEARCH.FocusedState.Parent = Me.TXTSEARCH
        Me.TXTSEARCH.ForeColor = System.Drawing.Color.Black
        Me.TXTSEARCH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSEARCH.HoverState.Parent = Me.TXTSEARCH
        Me.TXTSEARCH.IconLeft = Global.Recording_Management.My.Resources.Resources.magnifier
        Me.TXTSEARCH.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.TXTSEARCH.Location = New System.Drawing.Point(591, 124)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSEARCH.PlaceholderText = "Search"
        Me.TXTSEARCH.SelectedText = ""
        Me.TXTSEARCH.ShadowDecoration.Parent = Me.TXTSEARCH
        Me.TXTSEARCH.Size = New System.Drawing.Size(200, 36)
        Me.TXTSEARCH.TabIndex = 21
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(40, 142)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(751, 264)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DG_items)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(743, 236)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Items"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DG_items
        '
        Me.DG_items.AllowUserToAddRows = False
        Me.DG_items.AllowUserToDeleteRows = False
        Me.DG_items.AllowUserToResizeColumns = False
        Me.DG_items.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DG_items.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_items.AutoGenerateColumns = False
        Me.DG_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_items.BackgroundColor = System.Drawing.Color.White
        Me.DG_items.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_items.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_items.ColumnHeadersHeight = 17
        Me.DG_items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemcodeDataGridViewTextBoxColumn, Me.ItemnameDataGridViewTextBoxColumn, Me.ItemcategoryDataGridViewTextBoxColumn, Me.AvailablestockDataGridViewTextBoxColumn, Me.DateaddedDataGridViewTextBoxColumn})
        Me.DG_items.DataSource = Me.TblitemsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_items.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG_items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_items.EnableHeadersVisualStyles = False
        Me.DG_items.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_items.Location = New System.Drawing.Point(3, 3)
        Me.DG_items.Name = "DG_items"
        Me.DG_items.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_items.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_items.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DG_items.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DG_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_items.Size = New System.Drawing.Size(737, 230)
        Me.DG_items.TabIndex = 0
        Me.DG_items.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DG_items.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DG_items.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DG_items.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DG_items.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DG_items.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DG_items.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DG_items.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_items.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_items.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_items.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_items.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DG_items.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DG_items.ThemeStyle.HeaderStyle.Height = 17
        Me.DG_items.ThemeStyle.ReadOnly = True
        Me.DG_items.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DG_items.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_items.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_items.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DG_items.ThemeStyle.RowsStyle.Height = 22
        Me.DG_items.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_items.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ItemcodeDataGridViewTextBoxColumn
        '
        Me.ItemcodeDataGridViewTextBoxColumn.DataPropertyName = "itemcode"
        Me.ItemcodeDataGridViewTextBoxColumn.HeaderText = "itemcode"
        Me.ItemcodeDataGridViewTextBoxColumn.Name = "ItemcodeDataGridViewTextBoxColumn"
        Me.ItemcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemnameDataGridViewTextBoxColumn
        '
        Me.ItemnameDataGridViewTextBoxColumn.DataPropertyName = "itemname"
        Me.ItemnameDataGridViewTextBoxColumn.HeaderText = "itemname"
        Me.ItemnameDataGridViewTextBoxColumn.Name = "ItemnameDataGridViewTextBoxColumn"
        Me.ItemnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemcategoryDataGridViewTextBoxColumn
        '
        Me.ItemcategoryDataGridViewTextBoxColumn.DataPropertyName = "itemcategory"
        Me.ItemcategoryDataGridViewTextBoxColumn.HeaderText = "itemcategory"
        Me.ItemcategoryDataGridViewTextBoxColumn.Name = "ItemcategoryDataGridViewTextBoxColumn"
        Me.ItemcategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AvailablestockDataGridViewTextBoxColumn
        '
        Me.AvailablestockDataGridViewTextBoxColumn.DataPropertyName = "available_stock"
        Me.AvailablestockDataGridViewTextBoxColumn.HeaderText = "available_stock"
        Me.AvailablestockDataGridViewTextBoxColumn.Name = "AvailablestockDataGridViewTextBoxColumn"
        Me.AvailablestockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateaddedDataGridViewTextBoxColumn
        '
        Me.DateaddedDataGridViewTextBoxColumn.DataPropertyName = "date_added"
        Me.DateaddedDataGridViewTextBoxColumn.HeaderText = "date_added"
        Me.DateaddedDataGridViewTextBoxColumn.Name = "DateaddedDataGridViewTextBoxColumn"
        Me.DateaddedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblitemsBindingSource
        '
        Me.TblitemsBindingSource.DataMember = "tbl_items"
        Me.TblitemsBindingSource.DataSource = Me.Record_management_systemDataSet
        '
        'Record_management_systemDataSet
        '
        Me.Record_management_systemDataSet.DataSetName = "record_management_systemDataSet"
        Me.Record_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Guna2DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(743, 236)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Recent Activities"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToAddRows = False
        Me.Guna2DataGridView1.AllowUserToDeleteRows = False
        Me.Guna2DataGridView1.AllowUserToResizeColumns = False
        Me.Guna2DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Guna2DataGridView1.AutoGenerateColumns = False
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.Guna2DataGridView1.ColumnHeadersHeight = 17
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemnameDataGridViewTextBoxColumn1, Me.StockaddedDataGridViewTextBoxColumn, Me.DateaddedDataGridViewTextBoxColumn1, Me.ItemcodeDataGridViewTextBoxColumn2})
        Me.Guna2DataGridView1.DataSource = Me.TblstockaddedBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.Guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.Guna2DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Guna2DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(737, 230)
        Me.Guna2DataGridView1.TabIndex = 1
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 17
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ItemnameDataGridViewTextBoxColumn1
        '
        Me.ItemnameDataGridViewTextBoxColumn1.DataPropertyName = "itemname"
        Me.ItemnameDataGridViewTextBoxColumn1.HeaderText = "itemname"
        Me.ItemnameDataGridViewTextBoxColumn1.Name = "ItemnameDataGridViewTextBoxColumn1"
        Me.ItemnameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'StockaddedDataGridViewTextBoxColumn
        '
        Me.StockaddedDataGridViewTextBoxColumn.DataPropertyName = "stock_added"
        Me.StockaddedDataGridViewTextBoxColumn.HeaderText = "stock_added"
        Me.StockaddedDataGridViewTextBoxColumn.Name = "StockaddedDataGridViewTextBoxColumn"
        Me.StockaddedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateaddedDataGridViewTextBoxColumn1
        '
        Me.DateaddedDataGridViewTextBoxColumn1.DataPropertyName = "date_added"
        Me.DateaddedDataGridViewTextBoxColumn1.HeaderText = "date_added"
        Me.DateaddedDataGridViewTextBoxColumn1.Name = "DateaddedDataGridViewTextBoxColumn1"
        Me.DateaddedDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ItemcodeDataGridViewTextBoxColumn2
        '
        Me.ItemcodeDataGridViewTextBoxColumn2.DataPropertyName = "item_code"
        Me.ItemcodeDataGridViewTextBoxColumn2.HeaderText = "item_code"
        Me.ItemcodeDataGridViewTextBoxColumn2.Name = "ItemcodeDataGridViewTextBoxColumn2"
        Me.ItemcodeDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'TblstockaddedBindingSource
        '
        Me.TblstockaddedBindingSource.DataMember = "tbl_stockadded"
        Me.TblstockaddedBindingSource.DataSource = Me.Record_management_systemDataSet
        '
        'TXTAVS
        '
        Me.TXTAVS.AutoRoundedCorners = True
        Me.TXTAVS.BackColor = System.Drawing.Color.Transparent
        Me.TXTAVS.BorderRadius = 20
        Me.TXTAVS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTAVS.DefaultText = ""
        Me.TXTAVS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTAVS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTAVS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTAVS.DisabledState.Parent = Me.TXTAVS
        Me.TXTAVS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTAVS.Enabled = False
        Me.TXTAVS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTAVS.FocusedState.Parent = Me.TXTAVS
        Me.TXTAVS.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAVS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTAVS.HoverState.Parent = Me.TXTAVS
        Me.TXTAVS.Location = New System.Drawing.Point(342, 15)
        Me.TXTAVS.Name = "TXTAVS"
        Me.TXTAVS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTAVS.PlaceholderText = ""
        Me.TXTAVS.SelectedText = ""
        Me.TXTAVS.ShadowDecoration.Parent = Me.TXTAVS
        Me.TXTAVS.Size = New System.Drawing.Size(209, 42)
        Me.TXTAVS.TabIndex = 14
        Me.TXTAVS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(549, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 36)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Date Added"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTADDED
        '
        Me.TXTADDED.AutoRoundedCorners = True
        Me.TXTADDED.BackColor = System.Drawing.Color.Transparent
        Me.TXTADDED.BorderRadius = 20
        Me.TXTADDED.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTADDED.DefaultText = ""
        Me.TXTADDED.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTADDED.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTADDED.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTADDED.DisabledState.Parent = Me.TXTADDED
        Me.TXTADDED.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTADDED.Enabled = False
        Me.TXTADDED.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTADDED.FocusedState.Parent = Me.TXTADDED
        Me.TXTADDED.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTADDED.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTADDED.HoverState.Parent = Me.TXTADDED
        Me.TXTADDED.Location = New System.Drawing.Point(342, 63)
        Me.TXTADDED.Name = "TXTADDED"
        Me.TXTADDED.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTADDED.PlaceholderText = ""
        Me.TXTADDED.SelectedText = ""
        Me.TXTADDED.ShadowDecoration.Parent = Me.TXTADDED
        Me.TXTADDED.Size = New System.Drawing.Size(209, 42)
        Me.TXTADDED.TabIndex = 9
        Me.TXTADDED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(264, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 36)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Available Stock"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(264, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 36)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Added Stock"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 42)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Item name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Item code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTIName
        '
        Me.TXTIName.AutoRoundedCorners = True
        Me.TXTIName.BackColor = System.Drawing.Color.Transparent
        Me.TXTIName.BorderRadius = 20
        Me.TXTIName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTIName.DefaultText = ""
        Me.TXTIName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTIName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTIName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTIName.DisabledState.Parent = Me.TXTIName
        Me.TXTIName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTIName.Enabled = False
        Me.TXTIName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTIName.FocusedState.Parent = Me.TXTIName
        Me.TXTIName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTIName.HoverState.Parent = Me.TXTIName
        Me.TXTIName.Location = New System.Drawing.Point(81, 62)
        Me.TXTIName.Name = "TXTIName"
        Me.TXTIName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTIName.PlaceholderText = ""
        Me.TXTIName.SelectedText = ""
        Me.TXTIName.ShadowDecoration.Parent = Me.TXTIName
        Me.TXTIName.Size = New System.Drawing.Size(184, 42)
        Me.TXTIName.TabIndex = 2
        Me.TXTIName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTITCODE
        '
        Me.TXTITCODE.AutoRoundedCorners = True
        Me.TXTITCODE.BackColor = System.Drawing.Color.Transparent
        Me.TXTITCODE.BorderRadius = 20
        Me.TXTITCODE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTITCODE.DefaultText = ""
        Me.TXTITCODE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTITCODE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTITCODE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTITCODE.DisabledState.Parent = Me.TXTITCODE
        Me.TXTITCODE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTITCODE.Enabled = False
        Me.TXTITCODE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTITCODE.FocusedState.Parent = Me.TXTITCODE
        Me.TXTITCODE.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTITCODE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTITCODE.HoverState.Parent = Me.TXTITCODE
        Me.TXTITCODE.Location = New System.Drawing.Point(81, 14)
        Me.TXTITCODE.Name = "TXTITCODE"
        Me.TXTITCODE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTITCODE.PlaceholderText = ""
        Me.TXTITCODE.SelectedText = ""
        Me.TXTITCODE.ShadowDecoration.Parent = Me.TXTITCODE
        Me.TXTITCODE.Size = New System.Drawing.Size(184, 42)
        Me.TXTITCODE.TabIndex = 1
        Me.TXTITCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tbl_itemsTableAdapter
        '
        Me.Tbl_itemsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_stockaddedTableAdapter
        '
        Me.Tbl_stockaddedTableAdapter.ClearBeforeFill = True
        '
        'chkeclearsearch
        '
        Me.chkeclearsearch.BackColor = System.Drawing.Color.Transparent
        Me.chkeclearsearch.CheckedState.Image = Global.Recording_Management.My.Resources.Resources.cross
        Me.chkeclearsearch.CheckedState.Parent = Me.chkeclearsearch
        Me.chkeclearsearch.HoverState.Parent = Me.chkeclearsearch
        Me.chkeclearsearch.Image = Global.Recording_Management.My.Resources.Resources.cross
        Me.chkeclearsearch.Location = New System.Drawing.Point(751, 130)
        Me.chkeclearsearch.Name = "chkeclearsearch"
        Me.chkeclearsearch.PressedState.Parent = Me.chkeclearsearch
        Me.chkeclearsearch.Size = New System.Drawing.Size(31, 23)
        Me.chkeclearsearch.TabIndex = 1
        Me.chkeclearsearch.UseTransparentBackground = True
        '
        'usrctrlADD_ITEM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlusrctrlAdditem)
        Me.Name = "usrctrlADD_ITEM"
        Me.Size = New System.Drawing.Size(832, 493)
        Me.pnlusrctrlAdditem.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DG_items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Record_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstockaddedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlusrctrlAdditem As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents TXTIName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTITCODE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTADDED As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTAVS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TXTSEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents DG_items As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ItemcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemcategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AvailablestockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateaddedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblitemsBindingSource As BindingSource
    Friend WithEvents Record_management_systemDataSet As record_management_systemDataSet
    Friend WithEvents ItemcodeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Tbl_itemsTableAdapter As record_management_systemDataSetTableAdapters.tbl_itemsTableAdapter

    Friend WithEvents TXTDATEADDED As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Tbl_stockaddedTableAdapter As record_management_systemDataSetTableAdapters.tbl_stockaddedTableAdapter
    Friend WithEvents ItemnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StockaddedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateaddedDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemcodeDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TblstockaddedBindingSource As BindingSource
    Friend WithEvents chkeclearsearch As Guna.UI2.WinForms.Guna2ImageCheckBox
End Class
