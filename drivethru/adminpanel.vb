Imports MySql.Data.MySqlClient
Imports System.IO

Public Class adminpanel
    Dim WithEvents laporanRefreshTimer As New Timer()
    Dim lastTransaksiCount As Integer = -1
    Dim selectedMenuId As Integer = -1
    Dim selectedKasirId As Integer = -1

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=killvoid;database=db_ambafood")

    Private Sub adminpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKategori()
        LoadMenu()
        LoadKasir()
        LoadLaporan()
        laporanRefreshTimer.Interval = 3000 ' setiap 3 detik
        laporanRefreshTimer.Start()
    End Sub

    Private Sub LoadMenu()
        Try
            conn.Open()
            Dim query As String = "SELECT id_menu, nama_menu, kategori, harga FROM menu"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvMenu.DataSource = table
            dgvMenu.Columns("id_menu").Visible = True
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
        cmbKategori.Items.Clear()
        cmbKategori.Items.Add("Burgers")
        cmbKategori.Items.Add("Sides")
        cmbKategori.Items.Add("Drinks")
        cmbKategori.Items.Add("Combos")
        cmbKategori.Items.Add("Special")
    End Sub

    Private Sub LoadKasir()
        Try
            conn.Open()
            Dim query As String = "SELECT id_kasir, username, password FROM kasir"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvKasir.DataSource = table
            dgvKasir.Columns("id_kasir").Visible = False
            dgvKasir.Columns("username").HeaderText = "Username"
            dgvKasir.Columns("password").HeaderText = "Password"


            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data kasir: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim ofd As New OpenFileDialog With {.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"}

        If ofd.ShowDialog = DialogResult.OK Then
            gambarMenu.Image = Image.FromFile(ofd.FileName)
            gambarMenu.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If tbNama.Text.Trim = "" Or tbHarga.Text.Trim = "" Or cmbKategori.Text = "" Or gambarMenu.Image Is Nothing Then
            MessageBox.Show("Lengkapi semua data.")
            Exit Sub
        End If

        Dim harga As Decimal
        If Not Decimal.TryParse(tbHarga.Text, harga) Then
            MessageBox.Show("Harga tidak valid.")
            Exit Sub
        End If

        Dim imgBytes As Byte()
        Using ms As New MemoryStream
            gambarMenu.Image.Save(ms, Imaging.ImageFormat.Png)
            imgBytes = ms.ToArray
        End Using

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO menu (nama_menu, harga, kategori, gambar) VALUES (@nama, @harga, @kategori, @gambar)", conn)
            cmd.Parameters.AddWithValue("@nama", tbNama.Text.Trim)
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

    Private Sub ResetForm()
        tbNama.Clear()
        tbHarga.Clear()
        cmbKategori.SelectedIndex = -1
        gambarMenu.Image = Nothing
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedMenuId = -1 Then
            MessageBox.Show("Pilih item menu dulu dari tabel.")
            Exit Sub
        End If

        Dim nama = tbNama.Text.Trim
        Dim kategori = cmbKategori.Text
        Dim harga As Decimal

        If Not Decimal.TryParse(tbHarga.Text, harga) Then
            MessageBox.Show("Harga tidak valid.")
            Exit Sub
        End If

        Dim imgBytes As Byte() = Nothing
        If gambarMenu.Image IsNot Nothing Then
            Dim ms As New MemoryStream
            gambarMenu.Image.Save(ms, Imaging.ImageFormat.Png)
            imgBytes = ms.ToArray
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

        Dim confirm = MessageBox.Show("Yakin ingin menghapus menu ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
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

    Public Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub dgvMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvMenu.Rows(e.RowIndex)
            selectedMenuId = Convert.ToInt32(row.Cells("id_menu").Value)
            tbNama.Text = row.Cells("nama_menu").Value.ToString
            cmbKategori.Text = row.Cells("kategori").Value.ToString
            tbHarga.Text = row.Cells("harga").Value.ToString

            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT gambar FROM menu WHERE id_menu = @id_menu", conn)
                cmd.Parameters.AddWithValue("@id_menu", selectedMenuId)
                Dim result = cmd.ExecuteScalar
                conn.Close()

                If result IsNot Nothing AndAlso Not Convert.IsDBNull(result) Then
                    Dim imgBytes = CType(result, Byte())
                    Using ms As New MemoryStream(imgBytes)
                        gambarMenu.Image = Image.FromStream(ms)
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
        Dim confirm As DialogResult = MessageBox.Show("Are you sure?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Exit Sub

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnTambahKasir_Click(sender As Object, e As EventArgs) Handles btnkasirTambah.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Lengkapi data kasir.")
            Exit Sub
        End If

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO kasir (username, password) VALUES (@user, @pass)", conn)
            cmd.Parameters.AddWithValue("@user", txtUsername.Text)
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Kasir ditambahkan.")
            ResetKasirForm()
            LoadKasir()
        Catch ex As Exception
            MessageBox.Show("Gagal tambah kasir: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub dgvKasir_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKasir.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvKasir.Rows(e.RowIndex)
            selectedKasirId = CInt(row.Cells("id_kasir").Value)
            txtUsername.Text = row.Cells("username").Value.ToString()
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub btnUpdateKasir_Click(sender As Object, e As EventArgs) Handles btnkasirUpdate.Click
        If selectedKasirId = -1 Then
            MessageBox.Show("Pilih kasir dahulu.")
            Exit Sub
        End If

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE kasir SET username=@user" & If(txtPassword.Text <> "", ", password=@pass", "") & " WHERE id_kasir=@id", conn)
            cmd.Parameters.AddWithValue("@user", txtUsername.Text)
            If txtPassword.Text <> "" Then cmd.Parameters.AddWithValue("@pass", txtPassword.Text)
            cmd.Parameters.AddWithValue("@id", selectedKasirId)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data kasir diupdate.")
            ResetKasirForm()
            LoadKasir()
            selectedKasirId = -1
        Catch ex As Exception
            MessageBox.Show("Gagal update kasir: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnHapusKasir_Click(sender As Object, e As EventArgs) Handles btnkasirHapus.Click
        If selectedKasirId = -1 Then
            MessageBox.Show("Pilih kasir dahulu.")
            Exit Sub
        End If

        Dim confirm = MessageBox.Show("Yakin hapus kasir ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Exit Sub

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM kasir WHERE id_kasir=@id", conn)
            cmd.Parameters.AddWithValue("@id", selectedKasirId)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Kasir dihapus.")
            ResetKasirForm()
            LoadKasir()
            selectedKasirId = -1
        Catch ex As Exception
            MessageBox.Show("Gagal hapus kasir: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnResetKasir_Click(sender As Object, e As EventArgs) Handles btnkasirReset.Click
        ResetKasirForm()
    End Sub

    Private Sub ResetKasirForm()
        txtUsername.Clear()
        txtPassword.Clear()
        selectedKasirId = -1
    End Sub

    Private Sub laporanRefreshTimer_Tick(sender As Object, e As EventArgs) Handles laporanRefreshTimer.Tick
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM transaksi", conn)
            Dim currentCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            conn.Close()

            If currentCount <> lastTransaksiCount Then
                lastTransaksiCount = currentCount
                LoadLaporan()
            End If
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    'laporan
    Public Class Transaksi
        Public Property ID_Transaksi As String
        Public Property Tanggal_Waktu As DateTime
        Public Property Nama_Kasir As String
        Public Property Item As String
        Public Property Qty As Integer
        Public Property Harga_Satuan As Decimal
        Public Property Total As Decimal
        Public Property Total_Bayar As Decimal
        Public Property Metode_Bayar As String
    End Class



    Private Sub LoadLaporan()
        Try
            conn.Open()
            Dim query As String = "SELECT t.id_transaksi, t.tanggal, t.nama_kasir, 
                                    GROUP_CONCAT(td.item SEPARATOR ', ') AS items,
                                    SUM(td.total) AS subtotal,
                                    t.total_bayar,
                                    (t.total_bayar - SUM(td.total)) AS tax,
                                    t.metode_bayar
                             FROM transaksi t
                             JOIN transaksi_detail td ON t.id_transaksi = td.id_transaksi
                             GROUP BY t.id_transaksi, t.tanggal, t.nama_kasir, t.total_bayar, t.metode_bayar
                             ORDER BY t.tanggal DESC"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            conn.Close()

            dgvLaporan.DataSource = dt

            dgvLaporan.Columns("id_transaksi").HeaderText = "ID Transaksi"
            dgvLaporan.Columns("tanggal").HeaderText = "Tanggal/Waktu"
            dgvLaporan.Columns("nama_kasir").HeaderText = "Nama Kasir"
            dgvLaporan.Columns("items").HeaderText = "Items"
            dgvLaporan.Columns("subtotal").HeaderText = "Subtotal"
            dgvLaporan.Columns("tax").HeaderText = "Tax"
            dgvLaporan.Columns("total_bayar").HeaderText = "Total Bayar"
            dgvLaporan.Columns("metode_bayar").HeaderText = "Metode Bayar"

        Catch ex As Exception
            MessageBox.Show("Gagal load laporan: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


End Class
