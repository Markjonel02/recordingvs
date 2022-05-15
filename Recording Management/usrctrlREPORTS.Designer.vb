<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrctrlREPORTS
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
        Me.pnlusrRep = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.SuspendLayout()
        '
        'pnlusrRep
        '
        Me.pnlusrRep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlusrRep.FillColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.pnlusrRep.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pnlusrRep.Location = New System.Drawing.Point(0, 0)
        Me.pnlusrRep.Name = "pnlusrRep"
        Me.pnlusrRep.ShadowDecoration.Parent = Me.pnlusrRep
        Me.pnlusrRep.Size = New System.Drawing.Size(832, 493)
        Me.pnlusrRep.TabIndex = 0
        '
        'usrctrlREPORTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlusrRep)
        Me.Name = "usrctrlREPORTS"
        Me.Size = New System.Drawing.Size(832, 493)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlusrRep As Guna.UI2.WinForms.Guna2GradientPanel
End Class
