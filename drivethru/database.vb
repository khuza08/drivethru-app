﻿Imports MySql.Data.MySqlClient

Public Class database

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader

    Public Userlevel As String
    Public Nama As String

    ' Koneksi ke database
    Public Sub Connect()
        conn = New MySqlConnection("server=localhost;user id=root;password=killvoid;database=db_ambafood")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Gagal koneksi: " & ex.Message)
        End Try
    End Sub

    ' Fungsi login
    Public Function Login(username As String, password As String) As Boolean
        Connect()
        Dim query As String = "SELECT * FROM users WHERE username=@username AND password=@password"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)

        reader = cmd.ExecuteReader()
        If reader.Read() Then
            Userlevel = reader("level").ToString()
            Nama = reader("username").ToString()
            reader.Close()
            conn.Close()
            Return True
        Else
            reader.Close()
            conn.Close()
            Return False
        End If
    End Function

End Class
