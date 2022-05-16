<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsrCtrlActlog
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
        Me.tbl_activitylogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.record_management_systemDataSet = New Recording_Management.record_management_systemDataSet()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.RptActlog = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_activitylogTableAdapter = New Recording_Management.record_management_systemDataSetTableAdapters.tbl_activitylogTableAdapter()
        CType(Me.tbl_activitylogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.record_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_activitylogBindingSource
        '
        Me.tbl_activitylogBindingSource.DataMember = "tbl_activitylog"
        Me.tbl_activitylogBindingSource.DataSource = Me.record_management_systemDataSet
        '
        'record_management_systemDataSet
        '
        Me.record_management_systemDataSet.DataSetName = "record_management_systemDataSet"
        Me.record_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.RptActlog)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(696, 491)
        Me.Guna2CustomGradientPanel1.TabIndex = 1
        '
        'RptActlog
        '
        ReportDataSource1.Name = "DataSet_actlog"
        ReportDataSource1.Value = Me.tbl_activitylogBindingSource
        Me.RptActlog.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptActlog.LocalReport.ReportEmbeddedResource = "Recording_Management.RptActlog.rdlc"
        Me.RptActlog.Location = New System.Drawing.Point(38, 73)
        Me.RptActlog.Name = "RptActlog"
        Me.RptActlog.ServerReport.BearerToken = Nothing
        Me.RptActlog.Size = New System.Drawing.Size(608, 246)
        Me.RptActlog.TabIndex = 0
        '
        'tbl_activitylogTableAdapter
        '
        Me.tbl_activitylogTableAdapter.ClearBeforeFill = True
        '
        'UsrCtrlActlog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Name = "UsrCtrlActlog"
        Me.Size = New System.Drawing.Size(696, 491)
        CType(Me.tbl_activitylogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.record_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents RptActlog As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_activitylogBindingSource As BindingSource
    Friend WithEvents record_management_systemDataSet As record_management_systemDataSet
    Friend WithEvents tbl_activitylogTableAdapter As record_management_systemDataSetTableAdapters.tbl_activitylogTableAdapter
End Class
