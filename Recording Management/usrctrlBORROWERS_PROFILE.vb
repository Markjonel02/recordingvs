Public Class usrctrlBORROWERS_PROFILE

    Private Sub function_enabled()
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnEdit.Enabled = False
        txtSF.Enabled = True
        TXTFNAME.Enabled = True
        TXTLN.Enabled = True
        CBOBORR.Enabled = True
        TXTCN.Enabled = True
        TXTMID.Enabled = True
        txtSF.Focus()


    End Sub
    Private Sub funtion_disabled()
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnEdit.Enabled = False
        TXTCN.Enabled = False
        TXTMID.Enabled = False
        TXTFNAME.Enabled = False
        TXTLN.Enabled = False
        CBOBORR.Enabled = False
        txtSF.Enabled = False
    End Sub

    Private Sub usrctrlBORROWERS_PROFILE_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Tbl_borrowerTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_borrower)
        funtion_disabled()
    End Sub

    Private Sub pnlusrBORR_Paint(sender As Object, e As PaintEventArgs) Handles pnlusrBORR.Paint

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        function_enabled()
        TXTCN.Enabled = True
        TXTFNAME.Enabled = True
        TXTLN.Enabled = True
        CBOBORR.Enabled = True
        txtSF.Enabled = True
        TXTLN.Text = String.Empty
    End Sub
    Private Sub ACTLOG()
        con.Close()
        con.Open()
        cmd.CommandText = "insert into tbl_activitylog values (@un, @act, @dt)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", FRMMAINMENU.lblgreet.Text)
            .AddWithValue("act", Act)
            .AddWithValue("dt", Date.Now())
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtSF.Text = "" Or TXTFNAME.Text = "" Or TXTLN.Text = "" Or CBOBORR.Text = "" Or TXTCN.Text = "" Or TXTCN.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbExclamation, "Error Saving")
            txtSF.Focus()
            Exit Sub
        End If

        opencon()
        cmd.CommandText = "Select * from tbl_borrower where stud_facultyno = '" & txtSF.Text & "' "
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            MsgBox("Sorry this number already exist!", vbOKOnly + vbCritical, "Error Saving")
            con.Close()
            txtSF.Text = ""
            txtSF.Focus()
            Exit Sub
        End If
        con.Close()

        'Saving code
        opencon()
        cmd.CommandText = "insert into tbl_borrower values(@sf, @fn, @ln, @md,  @brt, @cn)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("sf", txtSF.Text)
            .AddWithValue("fn", TXTFNAME.Text)
            .AddWithValue("ln", TXTLN.Text)
            .AddWithValue("md", TXTMID.Text)
            .AddWithValue("brt", CBOBORR.Text)
            .AddWithValue("cn", TXTCN.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New record ha been saved!", vbOKOnly + vbInformation, "Saving Successful")
        Act = "created borrowers profile"
        ACTLOG()
        funtion_disabled()
        txtSF.Text = ""
        TXTFNAME.Text = ""
        TXTLN.Text = ""
        TXTMID.Text = ""
        TXTCN.Text = ""
        CBOBORR.SelectedIndex = -1
        refreshgrid()
    End Sub
    Private Sub refreshgrid()
        Me.Tbl_borrowerTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_borrower)

    End Sub
    Private Sub DGV_borr_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_borr.CellContentClick
        function_enabled()
        btnEdit.Enabled = True
        btnAdd.Enabled = False

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGV_borr.Rows(e.RowIndex)
            txtSF.Text = row.Cells(0).Value
            TXTFNAME.Text = row.Cells(1).Value
            TXTMID.Text = row.Cells(2).Value
            TXTLN.Text = row.Cells(3).Value
            CBOBORR.Text = row.Cells(4).Value
            TXTCN.Text = row.Cells(5).Value
            txtSF.Enabled = False
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "EDIT" Then
            If TXTFNAME.Text = "" Or TXTMID.Text = "" Or TXTLN.Text = "" Or CBOBORR.Text = "" Or TXTCN.Text = "" Then
                MsgBox("All Fields are required!", vbOKOnly + vbCritical, "Error Editing")
                Exit Sub
            End If
            function_enabled()
            btnSave.Enabled = False
            btnEdit.Enabled = True
            txtSF.Enabled = False

            TXTFNAME.Focus()
            'Error trapping

            'code for upate
            opencon()
            cmd.CommandText = "Update tbl_borrower set stud_facultyno =@sf, firstname=@fn, middlename=@md, lastname=@ln, borrower_type=@bt, contact_number=@cn where stud_facultyno= @sf"
            With cmd.Parameters
                .Clear()

                .AddWithValue("sf", txtSF.Text)
                .AddWithValue("fn", TXTFNAME.Text)
                .AddWithValue("md", TXTMID.Text)
                .AddWithValue("ln", TXTLN.Text)
                .AddWithValue("bt", CBOBORR.Text)
                .AddWithValue("cn", TXTCN.Text)

            End With

            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing    Successful")
            Act = "updated a profile"
            ACTLOG()
            btnEdit.Text = "EDIT"
            function_enabled()
            txtSF.Text = String.Empty
            TXTFNAME.Text = String.Empty
            TXTMID.Text = String.Empty
            TXTLN.Text = String.Empty
            TXTCN.Text = String.Empty
            CBOBORR.SelectedIndex = -1
            refreshgrid()
        End If

    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = False
        txtSF.Enabled = False
        TXTFNAME.Enabled = False
        TXTMID.Enabled = False
        CBOBORR.Enabled = False
        TXTCN.Enabled = False

        TXTLN.Enabled = False
        txtSF.Text = ""
        TXTFNAME.Text = ""
        TXTMID.Text = ""
        TXTLN.Text = ""
        TXTCN.Text = ""
        CBOBORR.SelectedIndex = -1
    End Sub

    Private Sub txtSF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSF.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOBORR.SelectedIndexChanged

    End Sub
End Class
