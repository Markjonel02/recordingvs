Module modECIT
    Public Sub ExitButton()
        Dim close = MsgBox("Are you sure you want to close this application ?", vbYesNo + vbQuestion, "System Exit")
        If close = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Module
