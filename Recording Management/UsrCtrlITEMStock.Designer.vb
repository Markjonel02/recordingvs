<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsrCtrlITEMStock
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
        Me.RptStock = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.record_management_systemDataSet = New Recording_Management.record_management_systemDataSet()
        Me.tbl_stockaddedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_stockaddedTableAdapter = New Recording_Management.record_management_systemDataSetTableAdapters.tbl_stockaddedTableAdapter()
        CType(Me.record_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_stockaddedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RptStock
        '
        ReportDataSource1.Name = "DataSet_itemStock"
        ReportDataSource1.Value = Me.tbl_stockaddedBindingSource
        Me.RptStock.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptStock.LocalReport.ReportEmbeddedResource = "Recording_Management.rptstockadded.rdlc"
        Me.RptStock.Location = New System.Drawing.Point(66, 135)
        Me.RptStock.Name = "RptStock"
        Me.RptStock.ServerReport.BearerToken = Nothing
        Me.RptStock.Size = New System.Drawing.Size(525, 317)
        Me.RptStock.TabIndex = 0
        '
        'record_management_systemDataSet
        '
        Me.record_management_systemDataSet.DataSetName = "record_management_systemDataSet"
        Me.record_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_stockaddedBindingSource
        '
        Me.tbl_stockaddedBindingSource.DataMember = "tbl_stockadded"
        Me.tbl_stockaddedBindingSource.DataSource = Me.record_management_systemDataSet
        '
        'tbl_stockaddedTableAdapter
        '
        Me.tbl_stockaddedTableAdapter.ClearBeforeFill = True
        '
        'UsrCtrlITEMStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RptStock)
        Me.Name = "UsrCtrlITEMStock"
        Me.Size = New System.Drawing.Size(696, 491)
        CType(Me.record_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_stockaddedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RptStock As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_stockaddedBindingSource As BindingSource
    Friend WithEvents record_management_systemDataSet As record_management_systemDataSet
    Friend WithEvents tbl_stockaddedTableAdapter As record_management_systemDataSetTableAdapters.tbl_stockaddedTableAdapter
End Class
