Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms

Public Class testing
    Dim WithEvents menuRefreshTimer As New Timer()
    Dim lastMenuCount As Integer = -1
    Dim conn As New MySqlConnection("server=localhost;user id=root;password=killvoid;database=db_ambafood")
    Dim cultureID As New CultureInfo("id-ID") ' Format mata uang Rupiah

    ' === Form Load ===
    Private Sub testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AturFullscreen()
        AturFlowPanel()
        AturListViewPembelian()
        LoadMenuDariDatabase()
        menuRefreshTimer.Interval = 2500
        menuRefreshTimer.Start()
    End Sub

    ' === Load kategori Drinks dari database ke FlowLayoutPanel ===
    ' -- [Custom Component Integration: items.vb - Future Proof] --
    ' Mengganti tombol biasa dengan komponen custom "items"
    ' Properti digunakan: NamaMenu, HargaMenu, GambarMenu
    ' Event digunakan: ItemClicked (handle untuk AddToOrder)
    ' ------------------------------------------------------------
    Public Sub LoadMenuDariDatabase()
        Try
            conn.Open()
            Dim query As String = "SELECT nama_menu, harga, gambar, kategori FROM menu"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim menuItem As New items()
                menuItem.NamaMenu = reader("nama_menu").ToString()
                menuItem.HargaMenu = Convert.ToDecimal(reader("harga"))

                If Not IsDBNull(reader("gambar")) Then
                    Dim bytes As Byte() = CType(reader("gambar"), Byte())
                    Using ms As New IO.MemoryStream(bytes)
                        menuItem.GambarMenu = Image.FromStream(ms)
                    End Using
                End If

                AddHandler menuItem.ItemClicked, AddressOf Item_Click

                ' Tentukan panel berdasarkan kategori
                Dim kategori As String = reader("kategori").ToString().ToLower()
                Select Case kategori
                    Case "burgers"
                        flowpanelBurgers.Controls.Add(menuItem)
                    Case "sides"
                        flowpanelSides.Controls.Add(menuItem)
                    Case "drinks"
                        flowpanelDrinks.Controls.Add(menuItem)
                    Case "combos"
                        flowpanelCombos.Controls.Add(menuItem)
                    Case "special"
                        flowpanelSpecial.Controls.Add(menuItem)

                End Select
            End While

            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat menu: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' === Set Fullscreen Form ===
    Private Sub AturFullscreen()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    ' === Atur FlowLayoutPanel ===
    Private Sub AturFlowPanel()
        'burgers
        flowpanelBurgers.Dock = DockStyle.Fill
        flowpanelBurgers.AutoScroll = True
        flowpanelBurgers.WrapContents = True
        flowpanelBurgers.FlowDirection = FlowDirection.LeftToRight

        'sides
        flowpanelSides.AutoScroll = True
        flowpanelSides.Dock = DockStyle.Fill
        flowpanelSides.WrapContents = True
        flowpanelSides.FlowDirection = FlowDirection.LeftToRight

        'drinks
        flowpanelDrinks.AutoScroll = True
        flowpanelDrinks.Dock = DockStyle.Fill
        flowpanelDrinks.WrapContents = True
        flowpanelDrinks.FlowDirection = FlowDirection.LeftToRight

        'combos
        flowpanelCombos.AutoScroll = True
        flowpanelCombos.Dock = DockStyle.Fill
        flowpanelCombos.WrapContents = True
        flowpanelCombos.FlowDirection = FlowDirection.LeftToRight

        'special
        flowpanelSpecial.AutoScroll = True
        flowpanelSpecial.Dock = DockStyle.Fill
        flowpanelSpecial.WrapContents = True
        flowpanelSpecial.FlowDirection = FlowDirection.LeftToRight
    End Sub

    ' === Atur ListView untuk daftar pembelian ===   
    Private Sub AturListViewPembelian()
        pembelian.View = View.Details
        pembelian.Columns.Add("Item", 150, HorizontalAlignment.Left)
        pembelian.Columns.Add("Qty", 60, HorizontalAlignment.Center)
        pembelian.Columns.Add("Price", 120, HorizontalAlignment.Right)
        pembelian.Columns.Add("Total", 142, HorizontalAlignment.Right)
    End Sub

    ' === Tambahkan item ke daftar pesanan ===
    Private Sub AddToOrder(itemName As String, price As Decimal)
        Dim found As Boolean = False

        For Each item As ListViewItem In pembelian.Items
            If item.SubItems(0).Text = itemName Then
                Dim qty As Integer = Integer.Parse(item.SubItems(1).Text) + 1
                item.SubItems(1).Text = qty.ToString()
                item.SubItems(3).Text = (qty * price).ToString("C2", cultureID)
                found = True
                Exit For
            End If
        Next

        If Not found Then
            Dim newItem As New ListViewItem(itemName)
            newItem.SubItems.Add("1")
            newItem.SubItems.Add(price.ToString("C2", cultureID))
            newItem.SubItems.Add(price.ToString("C2", cultureID))
            pembelian.Items.Add(newItem)
        End If

        UpdateTotal()
    End Sub
    'menuRefreshTimer buat refresh menu di form pas database udah di tambah/update/del items
    Private Sub menuRefreshTimer_Tick(sender As Object, e As EventArgs) Handles menuRefreshTimer.Tick
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM menu", conn)
            Dim currentCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            conn.Close()

            If currentCount <> lastMenuCount Then
                lastMenuCount = currentCount
                ReloadMenu()
            End If
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
    Private Sub ReloadMenu()
        'clear semua flowpanel
        flowpanelBurgers.Controls.Clear()
        flowpanelSides.Controls.Clear()
        flowpanelDrinks.Controls.Clear()
        flowpanelCombos.Controls.Clear()
        flowpanelSpecial.Controls.Clear()

        LoadMenuDariDatabase()
    End Sub



    ' === Update total keseluruhan dan pajak ===
    Private Sub UpdateTotal()
        Dim subtotal As Decimal = 0

        For Each item As ListViewItem In pembelian.Items
            subtotal += Decimal.Parse(item.SubItems(3).Text, NumberStyles.Currency, cultureID)
        Next

        Dim tax As Decimal = subtotal * 0.1D
        Dim total As Decimal = subtotal + tax

        labelsubtotal.Text = subtotal.ToString("C2", cultureID)
        labeltax.Text = tax.ToString("C2", cultureID)
        labeltotal.Text = total.ToString("C2", cultureID)
    End Sub

    ' === Ambil harga dari database berdasarkan nama menu ===
    Private Function ambilHarga(namaMenu As String) As Decimal
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT harga FROM menu WHERE nama_menu = @nama", conn)
            cmd.Parameters.AddWithValue("@nama", namaMenu)

            Dim harga As Object = cmd.ExecuteScalar()
            conn.Close()

            If harga IsNot Nothing Then
                Return Convert.ToDecimal(harga)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil harga dari database: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return 0
    End Function

    ' === Event klik dari komponen item (custom button) ===
    Private Sub Item_Click(namaMenu As String)
        Dim harga = ambilHarga(namaMenu)
        AddToOrder(namaMenu, harga)
    End Sub

    ' === Reset daftar pesanan ===
    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        pembelian.Items.Clear()
        labelsubtotal.Text = 0.ToString("C2", cultureID)
        labeltax.Text = 0.ToString("C2", cultureID)
        labeltotal.Text = 0.ToString("C2", cultureID)
    End Sub

    ' === Proses pesanan dan tampilkan form struk ===
    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        Dim formStruk As New formStruk()

        If pembelian.Items.Count = 0 Then
            MessageBox.Show("Belum ada pesanan.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If paymentbox.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih metode pembayaran terlebih dahulu.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Yakin pesananmu sudah benar?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Dim transactionId As String = "TRX" & Now.ToString("yyyyMMddHHmmss")
            Dim tanggal As String = Now.ToString("dd MMMM yyyy HH:mm")

            Me.Hide()
            formStruk.SetData(pembelian.Items, labelsubtotal.Text, labeltax.Text, labeltotal.Text, paymentbox.Text, transactionId, tanggal)
            formStruk.ShowDialog()
        End If
    End Sub

    ' === Kosong untuk Designer event ===
    Private Sub flowpanelDrinks_Paint(sender As Object, e As PaintEventArgs) Handles flowpanelDrinks.Paint
    End Sub

End Class
