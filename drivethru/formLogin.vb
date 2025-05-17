Imports MySql.Data.MySqlClient
Public Class FormLogin
    Private Sub loginBack_Click(sender As Object, e As EventArgs) Handles loginBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click



    End Sub

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbpw_TextChanged(sender As Object, e As EventArgs) Handles tbpw.TextChanged
        tbpw.UseSystemPasswordChar = True

    End Sub
End Class