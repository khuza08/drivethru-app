Public Class Form1
    Private Sub btnPreorder_Click(sender As Object, e As EventArgs) Handles btnPreorder.Click
        testing.Show()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        FormLogin.Show()
        Me.Hide()
    End Sub
End Class