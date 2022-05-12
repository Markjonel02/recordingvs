<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrctrlBORROWERS_PROFILE
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlusrBORR = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXTMID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXTCN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CBOBORR = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXTLN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTFNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSF = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DGV_borr = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Record_management_systemDataSet = New Recording_Management.record_management_systemDataSet()
        Me.TblborrowerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_borrowerTableAdapter = New Recording_Management.record_management_systemDataSetTableAdapters.tbl_borrowerTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddlenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowertypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlusrBORR.SuspendLayout()
        CType(Me.DGV_borr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Record_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblborrowerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlusrBORR
        '
        Me.pnlusrBORR.Controls.Add(Me.DGV_borr)
        Me.pnlusrBORR.Controls.Add(Me.Guna2HtmlLabel7)
        Me.pnlusrBORR.Controls.Add(Me.TXTMID)
        Me.pnlusrBORR.Controls.Add(Me.btnCancel)
        Me.pnlusrBORR.Controls.Add(Me.btnEdit)
        Me.pnlusrBORR.Controls.Add(Me.btnSave)
        Me.pnlusrBORR.Controls.Add(Me.btnAdd)
        Me.pnlusrBORR.Controls.Add(Me.Guna2HtmlLabel6)
        Me.pnlusrBORR.Controls.Add(Me.TXTCN)
        Me.pnlusrBORR.Controls.Add(Me.Guna2HtmlLabel5)
        Me.pnlusrBORR.Controls.Add(Me.CBOBORR)
        Me.pnlusrBORR.Controls.Add(Me.Guna2HtmlLabel3)
        Me.pnlusrBORR.Controls.Add(Me.Guna2HtmlLabel2)
        Me.pnlusrBORR.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnlusrBORR.Controls.Add(Me.TXTLN)
        Me.pnlusrBORR.Controls.Add(Me.TXTFNAME)
        Me.pnlusrBORR.Controls.Add(Me.txtSF)
        Me.pnlusrBORR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlusrBORR.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlusrBORR.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pnlusrBORR.ForeColor = System.Drawing.Color.White
        Me.pnlusrBORR.Location = New System.Drawing.Point(0, 0)
        Me.pnlusrBORR.Name = "pnlusrBORR"
        Me.pnlusrBORR.ShadowDecoration.Parent = Me.pnlusrBORR
        Me.pnlusrBORR.Size = New System.Drawing.Size(832, 493)
        Me.pnlusrBORR.TabIndex = 0
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(451, 76)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(73, 17)
        Me.Guna2HtmlLabel7.TabIndex = 20
        Me.Guna2HtmlLabel7.Text = "Middle name"
        '
        'TXTMID
        '
        Me.TXTMID.AutoRoundedCorners = True
        Me.TXTMID.BackColor = System.Drawing.Color.Transparent
        Me.TXTMID.BorderRadius = 15
        Me.TXTMID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTMID.DefaultText = ""
        Me.TXTMID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTMID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTMID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTMID.DisabledState.Parent = Me.TXTMID
        Me.TXTMID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTMID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTMID.FocusedState.Parent = Me.TXTMID
        Me.TXTMID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTMID.HoverState.Parent = Me.TXTMID
        Me.TXTMID.Location = New System.Drawing.Point(528, 67)
        Me.TXTMID.Name = "TXTMID"
        Me.TXTMID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTMID.PlaceholderText = ""
        Me.TXTMID.SelectedText = ""
        Me.TXTMID.ShadowDecoration.Parent = Me.TXTMID
        Me.TXTMID.Size = New System.Drawing.Size(253, 32)
        Me.TXTMID.TabIndex = 19
        Me.TXTMID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnCancel.Location = New System.Drawing.Point(631, 160)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(141, 45)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "CANCEL"
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
        Me.btnEdit.Location = New System.Drawing.Point(442, 160)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(141, 45)
        Me.btnEdit.TabIndex = 15
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
        Me.btnSave.Location = New System.Drawing.Point(64, 160)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(141, 45)
        Me.btnSave.TabIndex = 13
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
        Me.btnAdd.Location = New System.Drawing.Point(253, 160)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(141, 45)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "ADD"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(50, 70)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(91, 17)
        Me.Guna2HtmlLabel6.TabIndex = 11
        Me.Guna2HtmlLabel6.Text = "Contact Number"
        '
        'TXTCN
        '
        Me.TXTCN.AutoRoundedCorners = True
        Me.TXTCN.BackColor = System.Drawing.Color.Transparent
        Me.TXTCN.BorderRadius = 17
        Me.TXTCN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTCN.DefaultText = ""
        Me.TXTCN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTCN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTCN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCN.DisabledState.Parent = Me.TXTCN
        Me.TXTCN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTCN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCN.FocusedState.Parent = Me.TXTCN
        Me.TXTCN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCN.HoverState.Parent = Me.TXTCN
        Me.TXTCN.Location = New System.Drawing.Point(151, 61)
        Me.TXTCN.Name = "TXTCN"
        Me.TXTCN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTCN.PlaceholderText = ""
        Me.TXTCN.SelectedText = ""
        Me.TXTCN.ShadowDecoration.Parent = Me.TXTCN
        Me.TXTCN.Size = New System.Drawing.Size(251, 36)
        Me.TXTCN.TabIndex = 10
        Me.TXTCN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(60, 112)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(85, 17)
        Me.Guna2HtmlLabel5.TabIndex = 9
        Me.Guna2HtmlLabel5.Text = "Borrowers Type"
        '
        'CBOBORR
        '
        Me.CBOBORR.AutoRoundedCorners = True
        Me.CBOBORR.BackColor = System.Drawing.Color.Transparent
        Me.CBOBORR.BorderRadius = 17
        Me.CBOBORR.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOBORR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOBORR.FocusedColor = System.Drawing.Color.Empty
        Me.CBOBORR.FocusedState.Parent = Me.CBOBORR
        Me.CBOBORR.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBOBORR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBOBORR.FormattingEnabled = True
        Me.CBOBORR.HoverState.Parent = Me.CBOBORR
        Me.CBOBORR.ItemHeight = 30
        Me.CBOBORR.Items.AddRange(New Object() {"Student", "Faculty"})
        Me.CBOBORR.ItemsAppearance.Parent = Me.CBOBORR
        Me.CBOBORR.Location = New System.Drawing.Point(151, 103)
        Me.CBOBORR.Name = "CBOBORR"
        Me.CBOBORR.ShadowDecoration.Parent = Me.CBOBORR
        Me.CBOBORR.Size = New System.Drawing.Size(253, 36)
        Me.CBOBORR.TabIndex = 8
        Me.CBOBORR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(461, 117)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(57, 17)
        Me.Guna2HtmlLabel3.TabIndex = 6
        Me.Guna2HtmlLabel3.Text = "Last name"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(459, 34)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(58, 17)
        Me.Guna2HtmlLabel2.TabIndex = 5
        Me.Guna2HtmlLabel2.Text = "First name"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(9, 31)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(136, 17)
        Me.Guna2HtmlLabel1.TabIndex = 4
        Me.Guna2HtmlLabel1.Text = "Student /Faculty number"
        '
        'TXTLN
        '
        Me.TXTLN.AutoRoundedCorners = True
        Me.TXTLN.BackColor = System.Drawing.Color.Transparent
        Me.TXTLN.BorderRadius = 15
        Me.TXTLN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTLN.DefaultText = ""
        Me.TXTLN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTLN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTLN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTLN.DisabledState.Parent = Me.TXTLN
        Me.TXTLN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTLN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTLN.FocusedState.Parent = Me.TXTLN
        Me.TXTLN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTLN.HoverState.Parent = Me.TXTLN
        Me.TXTLN.Location = New System.Drawing.Point(529, 106)
        Me.TXTLN.Name = "TXTLN"
        Me.TXTLN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTLN.PlaceholderText = ""
        Me.TXTLN.SelectedText = ""
        Me.TXTLN.ShadowDecoration.Parent = Me.TXTLN
        Me.TXTLN.Size = New System.Drawing.Size(253, 32)
        Me.TXTLN.TabIndex = 2
        Me.TXTLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTFNAME
        '
        Me.TXTFNAME.AutoRoundedCorners = True
        Me.TXTFNAME.BackColor = System.Drawing.Color.Transparent
        Me.TXTFNAME.BorderRadius = 17
        Me.TXTFNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTFNAME.DefaultText = ""
        Me.TXTFNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTFNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTFNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTFNAME.DisabledState.Parent = Me.TXTFNAME
        Me.TXTFNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTFNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTFNAME.FocusedState.Parent = Me.TXTFNAME
        Me.TXTFNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTFNAME.HoverState.Parent = Me.TXTFNAME
        Me.TXTFNAME.Location = New System.Drawing.Point(527, 24)
        Me.TXTFNAME.Name = "TXTFNAME"
        Me.TXTFNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTFNAME.PlaceholderText = ""
        Me.TXTFNAME.SelectedText = ""
        Me.TXTFNAME.ShadowDecoration.Parent = Me.TXTFNAME
        Me.TXTFNAME.Size = New System.Drawing.Size(253, 36)
        Me.TXTFNAME.TabIndex = 1
        Me.TXTFNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSF
        '
        Me.txtSF.AutoRoundedCorners = True
        Me.txtSF.BackColor = System.Drawing.Color.Transparent
        Me.txtSF.BorderRadius = 17
        Me.txtSF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSF.DefaultText = ""
        Me.txtSF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSF.DisabledState.Parent = Me.txtSF
        Me.txtSF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSF.FocusedState.Parent = Me.txtSF
        Me.txtSF.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSF.HoverState.Parent = Me.txtSF
        Me.txtSF.Location = New System.Drawing.Point(151, 19)
        Me.txtSF.Name = "txtSF"
        Me.txtSF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSF.PlaceholderText = ""
        Me.txtSF.SelectedText = ""
        Me.txtSF.ShadowDecoration.Parent = Me.txtSF
        Me.txtSF.Size = New System.Drawing.Size(253, 36)
        Me.txtSF.TabIndex = 0
        Me.txtSF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGV_borr
        '
        Me.DGV_borr.AllowUserToAddRows = False
        Me.DGV_borr.AllowUserToDeleteRows = False
        Me.DGV_borr.AllowUserToResizeColumns = False
        Me.DGV_borr.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.DGV_borr.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_borr.AutoGenerateColumns = False
        Me.DGV_borr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_borr.BackgroundColor = System.Drawing.Color.White
        Me.DGV_borr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_borr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_borr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_borr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_borr.ColumnHeadersHeight = 17
        Me.DGV_borr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.FirstnameDataGridViewTextBoxColumn, Me.MiddlenameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.BorrowertypeDataGridViewTextBoxColumn, Me.ContactnumberDataGridViewTextBoxColumn})
        Me.DGV_borr.DataSource = Me.TblborrowerBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_borr.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_borr.EnableHeadersVisualStyles = False
        Me.DGV_borr.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_borr.Location = New System.Drawing.Point(50, 229)
        Me.DGV_borr.Name = "DGV_borr"
        Me.DGV_borr.ReadOnly = True
        Me.DGV_borr.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_borr.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_borr.RowHeadersVisible = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.DGV_borr.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DGV_borr.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DGV_borr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_borr.Size = New System.Drawing.Size(737, 230)
        Me.DGV_borr.TabIndex = 21
        Me.DGV_borr.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DGV_borr.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_borr.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_borr.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGV_borr.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_borr.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_borr.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_borr.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_borr.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_borr.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_borr.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_borr.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_borr.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_borr.ThemeStyle.HeaderStyle.Height = 17
        Me.DGV_borr.ThemeStyle.ReadOnly = True
        Me.DGV_borr.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_borr.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_borr.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_borr.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_borr.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_borr.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_borr.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Record_management_systemDataSet
        '
        Me.Record_management_systemDataSet.DataSetName = "record_management_systemDataSet"
        Me.Record_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblborrowerBindingSource
        '
        Me.TblborrowerBindingSource.DataMember = "tbl_borrower"
        Me.TblborrowerBindingSource.DataSource = Me.Record_management_systemDataSet
        '
        'Tbl_borrowerTableAdapter
        '
        Me.Tbl_borrowerTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "stud_facultyno"
        Me.DataGridViewTextBoxColumn1.HeaderText = "stud_facultyno"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MiddlenameDataGridViewTextBoxColumn
        '
        Me.MiddlenameDataGridViewTextBoxColumn.DataPropertyName = "middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.HeaderText = "middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.Name = "MiddlenameDataGridViewTextBoxColumn"
        Me.MiddlenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowertypeDataGridViewTextBoxColumn
        '
        Me.BorrowertypeDataGridViewTextBoxColumn.DataPropertyName = "borrower_type"
        Me.BorrowertypeDataGridViewTextBoxColumn.HeaderText = "borrower_type"
        Me.BorrowertypeDataGridViewTextBoxColumn.Name = "BorrowertypeDataGridViewTextBoxColumn"
        Me.BorrowertypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactnumberDataGridViewTextBoxColumn
        '
        Me.ContactnumberDataGridViewTextBoxColumn.DataPropertyName = "contact_number"
        Me.ContactnumberDataGridViewTextBoxColumn.HeaderText = "contact_number"
        Me.ContactnumberDataGridViewTextBoxColumn.Name = "ContactnumberDataGridViewTextBoxColumn"
        Me.ContactnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'usrctrlBORROWERS_PROFILE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlusrBORR)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "usrctrlBORROWERS_PROFILE"
        Me.Size = New System.Drawing.Size(832, 493)
        Me.pnlusrBORR.ResumeLayout(False)
        Me.pnlusrBORR.PerformLayout()
        CType(Me.DGV_borr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Record_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblborrowerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlusrBORR As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents TXTFNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSF As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXTLN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXTCN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CBOBORR As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents StudfacultynoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXTMID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DGV_borr As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddlenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowertypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblborrowerBindingSource As BindingSource
    Friend WithEvents Record_management_systemDataSet As record_management_systemDataSet
    Friend WithEvents Tbl_borrowerTableAdapter As record_management_systemDataSetTableAdapters.tbl_borrowerTableAdapter
End Class
