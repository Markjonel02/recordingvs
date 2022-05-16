<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsrCtrlTrans
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
        Me.tbl_transactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.record_management_systemDataSet = New Recording_Management.record_management_systemDataSet()
        Me.rpttrans = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_transactionTableAdapter = New Recording_Management.record_management_systemDataSetTableAdapters.tbl_transactionTableAdapter()
        CType(Me.tbl_transactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.record_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_transactionBindingSource
        '
        Me.tbl_transactionBindingSource.DataMember = "tbl_transaction"
        Me.tbl_transactionBindingSource.DataSource = Me.record_management_systemDataSet
        '
        'record_management_systemDataSet
        '
        Me.record_management_systemDataSet.DataSetName = "record_management_systemDataSet"
        Me.record_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpttrans
        '
        ReportDataSource1.Name = "DataSet_trans"
        ReportDataSource1.Value = Me.tbl_transactionBindingSource
        Me.rpttrans.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpttrans.LocalReport.ReportEmbeddedResource = "Recording_Management.rptTrans.rdlc"
        Me.rpttrans.Location = New System.Drawing.Point(23, 123)
        Me.rpttrans.Name = "rpttrans"
        Me.rpttrans.ServerReport.BearerToken = Nothing
        Me.rpttrans.Size = New System.Drawing.Size(627, 246)
        Me.rpttrans.TabIndex = 0
        '
        'tbl_transactionTableAdapter
        '
        Me.tbl_transactionTableAdapter.ClearBeforeFill = True
        '
        'UsrCtrlTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rpttrans)
        Me.Name = "UsrCtrlTrans"
        Me.Size = New System.Drawing.Size(696, 491)
        CType(Me.tbl_transactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.record_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpttrans As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_transactionBindingSource As BindingSource
    Friend WithEvents record_management_systemDataSet As record_management_systemDataSet
    Friend WithEvents tbl_transactionTableAdapter As record_management_systemDataSetTableAdapters.tbl_transactionTableAdapter
End Class
