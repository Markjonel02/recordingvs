Public Class usrpnlSet
    Dim itc As Integer
    Private Sub DGV_set_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_set.CellContentClick

    End Sub

    Private Sub usrpnlSet_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Tbl_settingsTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_settings)
    End Sub
    Private Sub refreshgrid()
        Me.Tbl_settingsTableAdapter.Fill(Me.Record_management_systemDataSet.tbl_settings)
    End Sub
    Private Sub Getmax()
        opencon()
        cmd.CommandText = "Select * from tbl_settings"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            opencon()
            cmd.CommandText = "Select Max(item_code) from tbl_settings"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            itc = getno + 1
        Else
            itc = 1
            con.Close()
        End If
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

        If TXTENTERCAT.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbExclamation, "Error Saving")
            TXTENTERCAT.Focus()
            Exit Sub
        End If


        opencon()
        cmd.CommandText = "Select * from tbl_settings where  item_category= '" & TXTENTERCAT.Text & "' "
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            MsgBox("Item already exist!", vbOKOnly + vbCritical, "Error Saving")
            con.Close()
            TXTENTERCAT.Text = ""

            TXTENTERCAT.Focus()


        End If
        con.Close()


        '     Saving code
        Getmax()
        opencon()
        cmd.CommandText = "insert into tbl_settings values(@cn, @ic)"

        With cmd.Parameters
            .Clear()
            .AddWithValue("ic", TXTENTERCAT.Text)
            .AddWithValue("cn", itc)
        End With
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("New Category has been Added", vbOKOnly + vbInformation, "Saving Successful")
        Act = "added a new category"
        ACTLOG()
        refreshgrid()
        TXTENTERCAT.Text = String.Empty
    End Sub
End Class
