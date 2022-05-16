<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsrCtrlITEM
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.RptITEM = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.record_management_systemDataSet = New Recording_Management.record_management_systemDataSet()
        Me.tbl_itemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_itemsTableAdapter = New Recording_Management.record_management_systemDataSetTableAdapters.tbl_itemsTableAdapter()
        CType(Me.record_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_itemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RptITEM
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbl_itemsBindingSource
        Me.RptITEM.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptITEM.LocalReport.ReportEmbeddedResource = "Recording_Management.RptITEM.rdlc"
        Me.RptITEM.Location = New System.Drawing.Point(42, 107)
        Me.RptITEM.Name = "RptITEM"
        Me.RptITEM.ServerReport.BearerToken = Nothing
        Me.RptITEM.Size = New System.Drawing.Size(608, 324)
        Me.RptITEM.TabIndex = 1
        '
        'record_management_systemDataSet
        '
        Me.record_management_systemDataSet.DataSetName = "record_management_systemDataSet"
        Me.record_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_itemsBindingSource
        '
        Me.tbl_itemsBindingSource.DataMember = "tbl_items"
        Me.tbl_itemsBindingSource.DataSource = Me.record_management_systemDataSet
        '
        'tbl_itemsTableAdapter
        '
        Me.tbl_itemsTableAdapter.ClearBeforeFill = True
        '
        'UsrCtrlITEM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RptITEM)
        Me.Name = "UsrCtrlITEM"
        Me.Size = New System.Drawing.Size(696, 491)
        CType(Me.record_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_itemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RptITEM As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_itemsBindingSource As BindingSource
    Friend WithEvents record_management_systemDataSet As record_management_systemDataSet
    Friend WithEvents tbl_itemsTableAdapter As record_management_systemDataSetTableAdapters.tbl_itemsTableAdapter
End Class
