<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usrctrluseraccount
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
        Me.tbl_userBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.record_management_systemDataSet = New Recording_Management.record_management_systemDataSet()
        Me.RptuserAcc = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbl_userTableAdapter = New Recording_Management.record_management_systemDataSetTableAdapters.tbl_userTableAdapter()
        CType(Me.tbl_userBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.record_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_userBindingSource
        '
        Me.tbl_userBindingSource.DataMember = "tbl_user"
        Me.tbl_userBindingSource.DataSource = Me.record_management_systemDataSet
        '
        'record_management_systemDataSet
        '
        Me.record_management_systemDataSet.DataSetName = "record_management_systemDataSet"
        Me.record_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RptuserAcc
        '
        ReportDataSource1.Name = "DataSet_UsrAcc"
        ReportDataSource1.Value = Me.tbl_userBindingSource
        Me.RptuserAcc.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptuserAcc.LocalReport.ReportEmbeddedResource = "Recording_Management.rptUSER.rdlc"
        Me.RptuserAcc.Location = New System.Drawing.Point(13, 64)
        Me.RptuserAcc.Name = "RptuserAcc"
        Me.RptuserAcc.ServerReport.BearerToken = Nothing
        Me.RptuserAcc.Size = New System.Drawing.Size(668, 360)
        Me.RptuserAcc.TabIndex = 0
        '
        'tbl_userTableAdapter
        '
        Me.tbl_userTableAdapter.ClearBeforeFill = True
        '
        'Usrctrluseraccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RptuserAcc)
        Me.Name = "Usrctrluseraccount"
        Me.Size = New System.Drawing.Size(696, 491)
        CType(Me.tbl_userBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.record_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RptuserAcc As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_userBindingSource As BindingSource
    Friend WithEvents record_management_systemDataSet As record_management_systemDataSet
    Friend WithEvents tbl_userTableAdapter As record_management_systemDataSetTableAdapters.tbl_userTableAdapter
End Class
