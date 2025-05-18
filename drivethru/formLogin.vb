
Public Class FormLogin
    Private Sub loginBack_Click(sender As Object, e As EventArgs) Handles loginBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub tbpw_TextChanged(sender As Object, e As EventArgs) Handles tbpw.TextChanged
        tbpw.UseSystemPasswordChar = True

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim db As New database()
        Dim user As String = tbuser.Text
        Dim pass As String = tbpw.Text

        If db.Login(user, pass) Then
            MessageBox.Show(" suki berhasil login !")
            ' lanjut ke form utama
            Me.Hide()

        Else
            MessageBox.Show("Username atau suki salah!")
        End If
    End Sub
End Class