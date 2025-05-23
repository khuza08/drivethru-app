Public Class formIdTransaksi
    Private Sub formIdTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnEnter
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim id As String = tbInput.Text.Trim()

        If String.IsNullOrEmpty(id) Then
            MessageBox.Show("Masukkan ID Transaksi terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim pembayaranForm As New formPembayaran()
        pembayaranForm.lblIdTransaksi.Text = id
        pembayaranForm.ShowDialog()

        formPembayaran.Show()
    End Sub
End Class