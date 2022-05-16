Imports MySql.Data
Imports MySql.Data.MySqlClient
Module connection

    Public con As New MySqlClient.MySqlConnection
    Public cmd As New MySqlClient.MySqlCommand
    Public dr As MySqlClient.MySqlDataReader
    Public Act As String
    Sub opencon()
        con.ConnectionString = My.Settings.record_management_systemConnectionString
        con.Open()
        cmd.Connection = con
    End Sub
End Module
