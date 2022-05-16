<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsrCtrlReturnitems
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnluserret = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.DGV_item = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TransactionidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowerstypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudfacultynoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateborrowedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatereturnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbltransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Record_management_systemDataSet = New Recording_Management.record_management_systemDataSet()
        Me.ASDASD = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXTIN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTBORR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXTNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chkeclearsearch = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.TXTSEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnReturn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Tbl_transactionTableAdapter = New Recording_Management.record_management_systemDataSetTableAdapters.tbl_transactionTableAdapter()
        Me.pnluserret.SuspendLayout()
        CType(Me.DGV_item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbltransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Record_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnluserret
        '
        Me.pnluserret.Controls.Add(Me.DGV_item)
        Me.pnluserret.Controls.Add(Me.ASDASD)
        Me.pnluserret.Controls.Add(Me.Guna2HtmlLabel2)
        Me.pnluserret.Controls.Add(Me.TXTIN)
        Me.pnluserret.Controls.Add(Me.TXTBORR)
        Me.pnluserret.Controls.Add(Me.Guna2HtmlLabel8)
        Me.pnluserret.Controls.Add(Me.TXTNAME)
        Me.pnluserret.Controls.Add(Me.chkeclearsearch)
        Me.pnluserret.Controls.Add(Me.TXTSEARCH)
        Me.pnluserret.Controls.Add(Me.btnCancel)
        Me.pnluserret.Controls.Add(Me.btnReturn)
        Me.pnluserret.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnluserret.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnluserret.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.pnluserret.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pnluserret.FillColor4 = System.Drawing.Color.DarkGray
        Me.pnluserret.Location = New System.Drawing.Point(0, 0)
        Me.pnluserret.Name = "pnluserret"
        Me.pnluserret.ShadowDecoration.Parent = Me.pnluserret
        Me.pnluserret.Size = New System.Drawing.Size(832, 493)
        Me.pnluserret.TabIndex = 1
        '
        'DGV_item
        '
        Me.DGV_item.AllowUserToAddRows = False
        Me.DGV_item.AllowUserToDeleteRows = False
        Me.DGV_item.AllowUserToResizeColumns = False
        Me.DGV_item.AllowUserToResizeRows = False
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        Me.DGV_item.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.DGV_item.AutoGenerateColumns = False
        Me.DGV_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_item.BackgroundColor = System.Drawing.Color.White
        Me.DGV_item.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_item.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_item.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_item.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.DGV_item.ColumnHeadersHeight = 17
        Me.DGV_item.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionidDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.BorrowerstypeDataGridViewTextBoxColumn, Me.StudfacultynoDataGridViewTextBoxColumn, Me.ItemcodeDataGridViewTextBoxColumn, Me.ItemnameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.DateborrowedDataGridViewTextBoxColumn, Me.DatereturnedDataGridViewTextBoxColumn})
        Me.DGV_item.DataSource = Me.TbltransactionBindingSource
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_item.DefaultCellStyle = DataGridViewCellStyle23
        Me.DGV_item.EnableHeadersVisualStyles = False
        Me.DGV_item.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_item.Location = New System.Drawing.Point(13, 240)
        Me.DGV_item.Name = "DGV_item"
        Me.DGV_item.ReadOnly = True
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_item.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.DGV_item.RowHeadersVisible = False
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGV_item.RowsDefaultCellStyle = DataGridViewCellStyle25
        Me.DGV_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_item.Size = New System.Drawing.Size(804, 230)
        Me.DGV_item.TabIndex = 48
        Me.DGV_item.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DGV_item.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_item.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_item.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_item.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_item.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_item.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_item.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_item.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_item.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_item.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_item.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_item.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_item.ThemeStyle.HeaderStyle.Height = 17
        Me.DGV_item.ThemeStyle.ReadOnly = True
        Me.DGV_item.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_item.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_item.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_item.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_item.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_item.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_item.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TransactionidDataGridViewTextBoxColumn
        '
        Me.TransactionidDataGridViewTextBoxColumn.DataPropertyName = "transaction_id"
        Me.TransactionidDataGridViewTextBoxColumn.HeaderText = "transaction_id"
        Me.TransactionidDataGridViewTextBoxColumn.Name = "TransactionidDataGridViewTextBoxColumn"
        Me.TransactionidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        Me.FullnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowerstypeDataGridViewTextBoxColumn
        '
        Me.BorrowerstypeDataGridViewTextBoxColumn.DataPropertyName = "borrowers_type"
        Me.BorrowerstypeDataGridViewTextBoxColumn.HeaderText = "borrowers_type"
        Me.BorrowerstypeDataGridViewTextBoxColumn.Name = "BorrowerstypeDataGridViewTextBoxColumn"
        Me.BorrowerstypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudfacultynoDataGridViewTextBoxColumn
        '
        Me.StudfacultynoDataGridViewTextBoxColumn.DataPropertyName = "stud_facultyno"
        Me.StudfacultynoDataGridViewTextBoxColumn.HeaderText = "stud_facultyno"
        Me.StudfacultynoDataGridViewTextBoxColumn.Name = "StudfacultynoDataGridViewTextBoxColumn"
        Me.StudfacultynoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemcodeDataGridViewTextBoxColumn
        '
        Me.ItemcodeDataGridViewTextBoxColumn.DataPropertyName = "item_code"
        Me.ItemcodeDataGridViewTextBoxColumn.HeaderText = "item_code"
        Me.ItemcodeDataGridViewTextBoxColumn.Name = "ItemcodeDataGridViewTextBoxColumn"
        Me.ItemcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemnameDataGridViewTextBoxColumn
        '
        Me.ItemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name"
        Me.ItemnameDataGridViewTextBoxColumn.HeaderText = "item_name"
        Me.ItemnameDataGridViewTextBoxColumn.Name = "ItemnameDataGridViewTextBoxColumn"
        Me.ItemnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateborrowedDataGridViewTextBoxColumn
        '
        Me.DateborrowedDataGridViewTextBoxColumn.DataPropertyName = "date_borrowed"
        Me.DateborrowedDataGridViewTextBoxColumn.HeaderText = "date_borrowed"
        Me.DateborrowedDataGridViewTextBoxColumn.Name = "DateborrowedDataGridViewTextBoxColumn"
        Me.DateborrowedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatereturnedDataGridViewTextBoxColumn
        '
        Me.DatereturnedDataGridViewTextBoxColumn.DataPropertyName = "date_returned"
        Me.DatereturnedDataGridViewTextBoxColumn.HeaderText = "date_returned"
        Me.DatereturnedDataGridViewTextBoxColumn.Name = "DatereturnedDataGridViewTextBoxColumn"
        Me.DatereturnedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbltransactionBindingSource
        '
        Me.TbltransactionBindingSource.DataMember = "tbl_transaction"
        Me.TbltransactionBindingSource.DataSource = Me.Record_management_systemDataSet
        '
        'Record_management_systemDataSet
        '
        Me.Record_management_systemDataSet.DataSetName = "record_management_systemDataSet"
        Me.Record_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ASDASD
        '
        Me.ASDASD.BackColor = System.Drawing.Color.Transparent
        Me.ASDASD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ASDASD.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ASDASD.Location = New System.Drawing.Point(638, 71)
        Me.ASDASD.Name = "ASDASD"
        Me.ASDASD.Size = New System.Drawing.Size(115, 19)
        Me.ASDASD.TabIndex = 44
        Me.ASDASD.Text = "DATE BORROWED"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(382, 71)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(76, 19)
        Me.Guna2HtmlLabel2.TabIndex = 43
        Me.Guna2HtmlLabel2.Text = "ITEM NAME"
        '
        'TXTIN
        '
        Me.TXTIN.AutoRoundedCorners = True
        Me.TXTIN.BackColor = System.Drawing.Color.Transparent
        Me.TXTIN.BorderRadius = 17
        Me.TXTIN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTIN.DefaultText = ""
        Me.TXTIN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTIN.DisabledState.Parent = Me.TXTIN
        Me.TXTIN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTIN.Enabled = False
        Me.TXTIN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTIN.FocusedState.Parent = Me.TXTIN
        Me.TXTIN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTIN.HoverState.Parent = Me.TXTIN
        Me.TXTIN.Location = New System.Drawing.Point(296, 29)
        Me.TXTIN.Name = "TXTIN"
        Me.TXTIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTIN.PlaceholderText = ""
        Me.TXTIN.ReadOnly = True
        Me.TXTIN.SelectedText = ""
        Me.TXTIN.ShadowDecoration.Parent = Me.TXTIN
        Me.TXTIN.Size = New System.Drawing.Size(245, 36)
        Me.TXTIN.TabIndex = 41
        Me.TXTIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTBORR
        '
        Me.TXTBORR.AutoRoundedCorners = True
        Me.TXTBORR.BackColor = System.Drawing.Color.Transparent
        Me.TXTBORR.BorderRadius = 17
        Me.TXTBORR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTBORR.DefaultText = ""
        Me.TXTBORR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTBORR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTBORR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBORR.DisabledState.Parent = Me.TXTBORR
        Me.TXTBORR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTBORR.Enabled = False
        Me.TXTBORR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBORR.FocusedState.Parent = Me.TXTBORR
        Me.TXTBORR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTBORR.HoverState.Parent = Me.TXTBORR
        Me.TXTBORR.Location = New System.Drawing.Point(562, 29)
        Me.TXTBORR.Name = "TXTBORR"
        Me.TXTBORR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTBORR.PlaceholderText = ""
        Me.TXTBORR.SelectedText = ""
        Me.TXTBORR.ShadowDecoration.Parent = Me.TXTBORR
        Me.TXTBORR.Size = New System.Drawing.Size(245, 36)
        Me.TXTBORR.TabIndex = 45
        Me.TXTBORR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(105, 71)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(117, 19)
        Me.Guna2HtmlLabel8.TabIndex = 46
        Me.Guna2HtmlLabel8.Text = "BORROWER NAME"
        '
        'TXTNAME
        '
        Me.TXTNAME.AutoRoundedCorners = True
        Me.TXTNAME.BackColor = System.Drawing.Color.Transparent
        Me.TXTNAME.BorderRadius = 17
        Me.TXTNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTNAME.DefaultText = ""
        Me.TXTNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNAME.DisabledState.Parent = Me.TXTNAME
        Me.TXTNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNAME.Enabled = False
        Me.TXTNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNAME.FocusedState.Parent = Me.TXTNAME
        Me.TXTNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNAME.HoverState.Parent = Me.TXTNAME
        Me.TXTNAME.Location = New System.Drawing.Point(30, 29)
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTNAME.PlaceholderText = ""
        Me.TXTNAME.SelectedText = ""
        Me.TXTNAME.ShadowDecoration.Parent = Me.TXTNAME
        Me.TXTNAME.Size = New System.Drawing.Size(245, 36)
        Me.TXTNAME.TabIndex = 47
        Me.TXTNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkeclearsearch
        '
        Me.chkeclearsearch.BackColor = System.Drawing.Color.Transparent
        Me.chkeclearsearch.CheckedState.Image = Global.Recording_Management.My.Resources.Resources.cross
        Me.chkeclearsearch.CheckedState.Parent = Me.chkeclearsearch
        Me.chkeclearsearch.HoverState.Parent = Me.chkeclearsearch
        Me.chkeclearsearch.Image = Global.Recording_Management.My.Resources.Resources.cross
        Me.chkeclearsearch.Location = New System.Drawing.Point(777, 204)
        Me.chkeclearsearch.Name = "chkeclearsearch"
        Me.chkeclearsearch.PressedState.Parent = Me.chkeclearsearch
        Me.chkeclearsearch.Size = New System.Drawing.Size(31, 23)
        Me.chkeclearsearch.TabIndex = 38
        Me.chkeclearsearch.UseTransparentBackground = True
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
        Me.TXTSEARCH.Location = New System.Drawing.Point(617, 198)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSEARCH.PlaceholderText = "Search"
        Me.TXTSEARCH.SelectedText = ""
        Me.TXTSEARCH.ShadowDecoration.Parent = Me.TXTSEARCH
        Me.TXTSEARCH.Size = New System.Drawing.Size(200, 36)
        Me.TXTSEARCH.TabIndex = 39
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
        Me.btnCancel.Location = New System.Drawing.Point(447, 134)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(141, 45)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "CANCEL"
        '
        'btnReturn
        '
        Me.btnReturn.AutoRoundedCorners = True
        Me.btnReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnReturn.BorderColor = System.Drawing.Color.White
        Me.btnReturn.BorderRadius = 21
        Me.btnReturn.BorderThickness = 2
        Me.btnReturn.CheckedState.Parent = Me.btnReturn
        Me.btnReturn.CustomImages.Parent = Me.btnReturn
        Me.btnReturn.Enabled = False
        Me.btnReturn.FillColor = System.Drawing.Color.White
        Me.btnReturn.FillColor2 = System.Drawing.Color.White
        Me.btnReturn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnReturn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnReturn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnReturn.HoverState.Parent = Me.btnReturn
        Me.btnReturn.Image = Global.Recording_Management.My.Resources.Resources.back_arrow
        Me.btnReturn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReturn.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnReturn.Location = New System.Drawing.Point(287, 134)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.ShadowDecoration.Parent = Me.btnReturn
        Me.btnReturn.Size = New System.Drawing.Size(141, 45)
        Me.btnReturn.TabIndex = 34
        Me.btnReturn.Text = "RETURN"
        '
        'Tbl_transactionTableAdapter
        '
        Me.Tbl_transactionTableAdapter.ClearBeforeFill = True
        '
        'UsrCtrlReturnitems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnluserret)
        Me.Name = "UsrCtrlReturnitems"
        Me.Size = New System.Drawing.Size(832, 493)
        Me.pnluserret.ResumeLayout(False)
        Me.pnluserret.PerformLayout()
        CType(Me.DGV_item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbltransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Record_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnluserret As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnReturn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents chkeclearsearch As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents TXTSEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ASDASD As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXTIN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTBORR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXTNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DGV_item As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TransactionidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowerstypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudfacultynoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateborrowedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatereturnedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbltransactionBindingSource As BindingSource
    Friend WithEvents Record_management_systemDataSet As record_management_systemDataSet
    Friend WithEvents Tbl_transactionTableAdapter As record_management_systemDataSetTableAdapters.tbl_transactionTableAdapter
End Class
