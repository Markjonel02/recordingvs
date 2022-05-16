<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsrCtrlborrow
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_borrowerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.record_management_systemDataSet = New Recording_Management.record_management_systemDataSet()
        Me.rptborr = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_borrowerTableAdapter = New Recording_Management.record_management_systemDataSetTableAdapters.tbl_borrowerTableAdapter()
        CType(Me.tbl_borrowerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.record_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_borrowerBindingSource
        '
        Me.tbl_borrowerBindingSource.DataMember = "tbl_borrower"
        Me.tbl_borrowerBindingSource.DataSource = Me.record_management_systemDataSet
        '
        'record_management_systemDataSet
        '
        Me.record_management_systemDataSet.DataSetName = "record_management_systemDataSet"
        Me.record_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptborr
        '
        ReportDataSource1.Name = "DataSet_borr"
        ReportDataSource1.Value = Me.tbl_borrowerBindingSource
        Me.rptborr.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptborr.LocalReport.ReportEmbeddedResource = "Recording_Management.RptBorr.rdlc"
        Me.rptborr.Location = New System.Drawing.Point(57, 160)
        Me.rptborr.Name = "rptborr"
        Me.rptborr.ServerReport.BearerToken = Nothing
        Me.rptborr.Size = New System.Drawing.Size(607, 264)
        Me.rptborr.TabIndex = 0
        '
        'tbl_borrowerTableAdapter
        '
        Me.tbl_borrowerTableAdapter.ClearBeforeFill = True
        '
        'UsrCtrlborrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rptborr)
        Me.Name = "UsrCtrlborrow"
        Me.Size = New System.Drawing.Size(696, 491)
        CType(Me.tbl_borrowerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.record_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rptborr As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_borrowerBindingSource As BindingSource
    Friend WithEvents record_management_systemDataSet As record_management_systemDataSet
    Friend WithEvents tbl_borrowerTableAdapter As record_management_systemDataSetTableAdapters.tbl_borrowerTableAdapter
End Class
