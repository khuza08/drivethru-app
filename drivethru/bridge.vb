Public Class bridge
    Private Sub bridge_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        formIdTransaksi.Show()
    End Sub
    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        daliyReport.Show()
    End Sub
End Class