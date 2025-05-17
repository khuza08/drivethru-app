Imports MySql.Data.MySqlClient
Public Class FormLogin
    Private Sub loginBack_Click(sender As Object, e As EventArgs) Handles loginBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click

        Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=db_drivethru")
        Dim cmd As New MySqlCommand("SELECT * FROM users WHERE username=@username AND password=@password", conn)

        cmd.Parameters.AddWithValue("@username", tbuser.Text)
        cmd.Parameters.AddWithValue("@password", tbpw.Text)

        Try
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Login sukses!")

            Else
                MessageBox.Show("lu admin apa member woy!")
            End If
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Terdeteksi Suki: " & ex.Message)
        End Try


    End Sub

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbpw_TextChanged(sender As Object, e As EventArgs) Handles tbpw.TextChanged
        tbpw.UseSystemPasswordChar = True

    End Sub
End Class