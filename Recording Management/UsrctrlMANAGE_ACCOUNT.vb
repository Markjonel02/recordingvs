Public Class UsrctrlMANAGE_ACCOUNT
    Private Sub btnExit_Click(sender As Object, e As EventArgs) 
        ExitButton()
    End Sub
    Private Sub function_enabled()
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnEdit.Enabled = False
        TXTUSN.Enabled = True
        TXTPASS.Enabled = True
        txtLN.Enabled = True
        CBOUST.Enabled = True
        CBOSTAT.Enabled = True
        TXTCONF.Enabled = True

    End Sub

    Private Sub funtion_disabled()
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnEdit.Enabled = False


    End Sub


    Private Sub UsrctrlMANAGE_ACCOUNT_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Tbl_userTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_user)

        funtion_disabled()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        function_enabled()
        TXTUSN.Text = String.Empty
        TXTPASS.Text = String.Empty
        txtLN.Text = String.Empty
        CBOUST.Text = String.Empty
        TXTUSN.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TXTUSN.Text = "" Or TXTPASS.Text = "" Or TXTCONF.Text = "" Or txtLN.Text = "" Or CBOUST.Text = "" Or CBOSTAT.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbExclamation, "Error Saving")
            TXTUSN.Focus()
            Exit Sub
        End If
        If TXTPASS.Text <> TXTCONF.Text Then
            MsgBox("the Password you type is not matched!", vbOKOnly + vbExclamation, "Error Saving")
            TXTPASS.Focus()
            Exit Sub
        End If
        If TXTUSN.Text <> TXTDUN.Text Then
            opencon()
            cmd.CommandText = "Select * from tbl_user where username = '" & TXTUSN.Text & "' "
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Sorry username already exist!", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                TXTUSN.Text = ""
                TXTUSN.Focus()
                Exit Sub
            End If
            con.Close()
        End If
        'Saving code
        opencon()
        cmd.CommandText = "insert into tbl_user values(@un, @pw, @ln, @ut, @st)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", TXTUSN.Text)
            .AddWithValue("pw", TXTPASS.Text)
            .AddWithValue("ln", txtLN.Text)

            .AddWithValue("ut", CBOUST.Text)
            .AddWithValue("st", CBOSTAT.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New record ha been saved!", vbOKOnly + vbInformation, "Saving Successful")
        funtion_disabled()
        TXTUSN.Text = ""
        TXTPASS.Text = ""
        TXTCONF.Text = ""
        txtLN.Text = ""
        CBOUST.Text = ""
        CBOSTAT.Text = ""
        refreshgrid()
    End Sub
    Private Sub refreshgrid()
        Me.Tbl_userTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_user)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = False
        TXTUSN.Enabled = False
        TXTPASS.Enabled = False
        TXTCONF.Enabled = False
        CBOSTAT.Enabled = False
        CBOUST.Enabled = False
        txtLN.Enabled = False
        TXTUSN.Text = ""
        TXTPASS.Text = ""
        TXTCONF.Text = ""
        txtLN.Text = ""
        CBOSTAT.SelectedIndex = -1
        CBOUST.SelectedIndex = -1
        TXTUSN.Focus()
        MsgBox("all fields are cleared", vbInformation)
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUSER.CellContentClick
        function_enabled()
        btnEdit.Enabled = True
        btnAdd.Enabled = False

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGUSER.Rows(e.RowIndex)
            TXTUSN.Text = row.Cells(0).Value
            TXTPASS.Text = row.Cells(1).Value
            TXTCONF.Text = row.Cells(1).Value
            txtLN.Text = row.Cells(2).Value
            CBOUST.Text = row.Cells(3).Value
            CBOSTAT.Text = row.Cells(4).Value
            TXTUSN.Enabled = False
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "EDIT" Then
            If TXTUSN.Text = "" Or TXTPASS.Text = "" Or TXTCONF.Text = "" Or txtLN.Text = "" Or CBOUST.Text = "" Or CBOSTAT.Text = "" Then

                MsgBox("Please select a record to edit!", vbOKOnly + vbCritical, "Error Editing")
                Exit Sub
            End If
            function_enabled()
            btnSave.Enabled = False
            btnEdit.Enabled = True
            TXTUSN.Enabled = False
            btnEdit.Text = "UPDATE"
        ElseIf btnEdit.Text = "UPDATE" Then
            'Error trapping
            If TXTUSN.Text = "" Or TXTPASS.Text = "" Or TXTCONF.Text = "" Or txtLN.Text = "" Or CBOUST.Text = "" Or CBOSTAT.Text = "" Then
                MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
                TXTUSN.Focus()
                Exit Sub
            End If
            If TXTPASS.Text <> TXTCONF.Text Then
                MsgBox("Password should match!", vbOKOnly + vbCritical, "Error Saving")
                TXTPASS.Focus()
                Exit Sub
            End If
            'code for upate
            opencon()
            cmd.CommandText = "Update tbl_user set username =@un, password=@pw, loginame=@ln, usertype=@ut, status=@st where username= @un"
            With cmd.Parameters
                .Clear()
                .AddWithValue("un", TXTUSN.Text)
                .AddWithValue("pw", TXTPASS.Text)
                .AddWithValue("ln", txtLN.Text)
                .AddWithValue("ut", CBOUST.Text)
                .AddWithValue("st", CBOSTAT.Text)
            End With
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")
            btnEdit.Text = "EDIT"
            function_enabled()
            TXTUSN.Text = ""
            TXTPASS.Text = ""
            TXTCONF.Text = ""
            txtLN.Text = ""
            CBOUST.SelectedIndex = -1
            CBOSTAT.SelectedIndex = -1
            refreshgrid()
        End If

    End Sub

    Private Sub DGUSER_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGUSER.CellFormatting
        If e.ColumnIndex = 1 Then
            e.Value = New String("*", e.Value.ToString.Length)
        End If
    End Sub

    Private Sub TXTPASS_TextChanged(sender As Object, e As EventArgs) Handles TXTPASS.TextChanged
        If TXTPASS.Text = String.Empty Then
            TXTCONF.Text = ""

        End If


    End Sub


End Class
