Public Class items
    Public Event ItemClicked(namaMenu As String)

    ' === CHANGE: Buat event click untuk semua elemen terkait ===
    Private Sub Control_Click(sender As Object, e As EventArgs) _
        Handles pbItems.Click, lblNamaProduk.Click, lblHargaProduk.Click, Guna2ShadowPanel1.Click
        RaiseEvent ItemClicked(NamaMenu)
    End Sub

    ' === Property Nama Menu ===
    Public Property NamaMenu As String
        Get
            Return lblNamaProduk.Text
        End Get
        Set(value As String)
            lblNamaProduk.Text = value
        End Set
    End Property

    ' === Property Harga Menu ===
    Public Property HargaMenu As Decimal
        Get
            Return Decimal.Parse(lblHargaProduk.Tag.ToString())
        End Get
        Set(value As Decimal)
            lblHargaProduk.Text = value.ToString("C0", New Globalization.CultureInfo("id-ID"))
            lblHargaProduk.Tag = value
        End Set
    End Property

    ' === CHANGE: Property Gambar pakai BackgroundImage + Zoom ===
    Public Property GambarMenu As Image
        Get
            Return pbItems.BackgroundImage
        End Get
        Set(value As Image)
            pbItems.BackgroundImage = value
            pbItems.BackgroundImageLayout = ImageLayout.Zoom
            pbItems.SizeMode = PictureBoxSizeMode.Zoom ' biar gak ganggu layout
        End Set
    End Property

    ' === CHANGE: Atur background label transparan saat load ===
    Private Sub items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNamaProduk.BackColor = Color.Transparent
        lblHargaProduk.BackColor = Color.Transparent

        lblNamaProduk.Parent = pbItems
        lblHargaProduk.Parent = pbItems
    End Sub
End Class
