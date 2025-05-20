Imports MySql.Data.MySqlClient
Imports System.IO

Public Class adminpanel
    Dim selectedMenuId As Integer = -1
    Dim conn As New MySqlConnection("server=localhost;user id=root;password=killvoid;database=db_ambafood")

    'load function
    Private Sub adminpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKategori()
        LoadMenu()
    End Sub
    Private Sub LoadMenu()
        Try
            conn.Open()
            Dim query As String = "SELECT id_menu, nama_menu, kategori, harga FROM menu"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvMenu.DataSource = table
            dgvMenu.Columns("id_menu").Visible = False
            dgvMenu.Columns("nama_menu").HeaderText = "Nama Menu"
            dgvMenu.Columns("kategori").HeaderText = "Kategori"
            dgvMenu.Columns("harga").HeaderText = "Harga"

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data menu: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Private Sub LoadKategori()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT DISTINCT kategori FROM menu", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            cmbKategori.Items.Clear()
            While reader.Read()
                cmbKategori.Items.Add(reader("kategori").ToString())
            End While

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat kategori: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Upload gambar ke PictureBox
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim ofd As New OpenFileDialog() With {
            .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        }

        If ofd.ShowDialog() = DialogResult.OK Then
            gambarMenu.Image = Image.FromFile(ofd.FileName)
            gambarMenu.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    ' Tambah menu ke database
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If tbNama.Text.Trim() = "" Or tbHarga.Text.Trim() = "" Or cmbKategori.Text = "" Or gambarMenu.Image Is Nothing Then
            MessageBox.Show("Lengkapi semua data.")
            Exit Sub
        End If

        Dim harga As Decimal
        If Not Decimal.TryParse(tbHarga.Text, harga) Then
            MessageBox.Show("Harga tidak valid.")
            Exit Sub
        End If

        Dim imgBytes As Byte()
        Using ms As New MemoryStream()
            gambarMenu.Image.Save(ms, Imaging.ImageFormat.Png)
            imgBytes = ms.ToArray()
        End Using

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO menu (nama_menu, harga, kategori, gambar) VALUES (@nama, @harga, @kategori, @gambar)", conn)
            cmd.Parameters.AddWithValue("@nama", tbNama.Text.Trim())
            cmd.Parameters.AddWithValue("@harga", harga)
            cmd.Parameters.AddWithValue("@kategori", cmbKategori.Text)
            cmd.Parameters.AddWithValue("@gambar", imgBytes)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Menu berhasil ditambahkan.")
            ResetForm()
            LoadMenu()
        Catch ex As Exception
            MessageBox.Show("Gagal menambahkan menu: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Reset semua input
    Private Sub ResetForm()
        tbNama.Clear()
        tbHarga.Clear()
        cmbKategori.SelectedIndex = -1
        gambarMenu.Image = Nothing
    End Sub

    ' placeholder untuk Update, Hapus, Reset
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedMenuId = -1 Then
            MessageBox.Show("Pilih item menu dulu dari tabel.")
            Exit Sub
        End If

        Dim nama As String = tbNama.Text.Trim()
        Dim kategori As String = cmbKategori.Text
        Dim harga As Decimal

        If Not Decimal.TryParse(tbHarga.Text, harga) Then
            MessageBox.Show("Harga tidak valid.")
            Exit Sub
        End If

        Dim imgBytes As Byte() = Nothing
        If gambarMenu.Image IsNot Nothing Then
            Dim ms As New IO.MemoryStream()
            gambarMenu.Image.Save(ms, Imaging.ImageFormat.Png)
            imgBytes = ms.ToArray()
        End If

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE menu SET nama_menu=@nama, kategori=@kategori, harga=@harga, gambar=@gambar WHERE id_menu=@id_menu", conn)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@kategori", kategori)
            cmd.Parameters.AddWithValue("@harga", harga)
            cmd.Parameters.AddWithValue("@gambar", imgBytes)
            cmd.Parameters.AddWithValue("@id_menu", selectedMenuId)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Menu berhasil diupdate.")
            ResetForm()
            LoadMenu()
            selectedMenuId = -1
        Catch ex As Exception
            MessageBox.Show("Gagal update menu: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedMenuId = -1 Then
            MessageBox.Show("Pilih item menu dulu dari tabel.")
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show("Yakin ingin menghapus menu ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Exit Sub

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM menu WHERE id_menu = @id_menu", conn)
            cmd.Parameters.AddWithValue("@id_menu", selectedMenuId)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Menu berhasil dihapus.")
            ResetForm()
            LoadMenu()
            selectedMenuId = -1
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus menu: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub cmbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKategori.SelectedIndexChanged
        ' Optional: saat kategori berubah
    End Sub

    Private Sub dgvMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvMenu.Rows(e.RowIndex)
            selectedMenuId = Convert.ToInt32(row.Cells("id_menu").Value)
            tbNama.Text = row.Cells("nama_menu").Value.ToString()
            cmbKategori.Text = row.Cells("kategori").Value.ToString()
            tbHarga.Text = row.Cells("harga").Value.ToString()

            ' Tampilkan gambar dari DB
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT gambar FROM menu WHERE id_menu = @id_menu", conn)
                cmd.Parameters.AddWithValue("@id_menu", selectedMenuId)
                Dim result = cmd.ExecuteScalar()
                conn.Close()

                If result IsNot Nothing AndAlso Not Convert.IsDBNull(result) Then
                    Dim imgBytes As Byte() = CType(result, Byte())
                    Using ms As New MemoryStream(imgBytes)
                        Dim img As Image = Image.FromStream(ms)
                        gambarMenu.Image = img
                        gambarMenu.SizeMode = PictureBoxSizeMode.Zoom
                    End Using
                Else
                    gambarMenu.Image = Nothing
                End If

            Catch ex As Exception
                MessageBox.Show("Gagal ambil gambar: " & ex.Message)
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
