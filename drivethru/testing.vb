Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class testing

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=killvoid;database=db_ambafood")


    ' pakai cultureID buat format Rupiah
    Dim cultureID As New CultureInfo("id-ID")

    ' form load
    Private Sub testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AturTabMenu()
        AturFullscreen()
        AturPanelKontainer()
        AturTabelMenu()
        AturListViewPembelian()


        'tag tombol buat handler event
        doublebeef.Tag = "Double Beef"
        cheeseburger.Tag = "Cheese Burger"
        chickenburger.Tag = "Chicken Burger"
        sandwich.Tag = "Classic Sandwich"
        fries.Tag = "Fries"
        onionring.Tag = "Onion Ring"
        pie.Tag = "Amba Pie"
        nugget.Tag = "Amba Nugget"
        cola.Tag = "Coca Cola"
        mcflurry.Tag = "McFlurry"
        matcha.Tag = "Matcha Latte"
        americano.Tag = "Americano Ireng"
        kombodeluxe.Tag = "Kombo Deluxe"
        starterpack.Tag = "Kombo Starter Pack"
        kombocouple.Tag = "Kombo Couple"
        kombonguwawor.Tag = "Kombo Nguwawor"

    End Sub

    ' konfigurasi ui
    Private Sub AturTabMenu()
        TabPage1.Text = "Burgers"
        TabPage2.Text = "Sides"
        TabPage3.Text = "Drinks"
        TabPage4.Text = "Combos"
    End Sub

    Private Sub AturFullscreen()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AturPanelKontainer()
        For Each panel As Panel In {Panel1, Panel2, Panel3, Panel4}
            panel.AutoScroll = True
            panel.Dock = DockStyle.Fill
            panel.Padding = New Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0)
        Next
    End Sub

    Private Sub AturTabelMenu()
        For Each tbl As TableLayoutPanel In {tblburgers, tblsides, tbldrinks, tblcombos}
            tbl.AutoSize = False
            tbl.Dock = DockStyle.Top
            tbl.GrowStyle = TableLayoutPanelGrowStyle.AddRows
        Next
    End Sub

    Private Sub AturListViewPembelian()
        pembelian.View = View.Details
        pembelian.Columns.Add("Item", 150, HorizontalAlignment.Left)
        pembelian.Columns.Add("Qty", 60, HorizontalAlignment.Center)
        pembelian.Columns.Add("Price", 120, HorizontalAlignment.Right)
        pembelian.Columns.Add("Total", 160, HorizontalAlignment.Right)
    End Sub

    ' logika order
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
            MessageBox.Show("gagal mengambil harga dari database: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        Return 0
    End Function


    ' handler tombol

    Private Sub Item_Click(sender As Object, e As EventArgs) Handles doublebeef.Click, cheeseburger.Click, chickenburger.Click,
            fries.Click, matcha.Click, nugget.Click, onionring.Click, sandwich.Click, americano.Click, pie.Click, cola.Click,
            kombocouple.Click, kombonguwawor.Click, kombodeluxe.Click

        Dim btn As Button = CType(sender, Button)
        Dim nama As String = btn.Tag.ToString()
        Dim harga = ambilHarga(nama)
        AddToOrder(nama, harga)
    End Sub


    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        pembelian.Items.Clear()
        labelsubtotal.Text = 0.ToString("C2", cultureID)
        labeltax.Text = 0.ToString("C2", cultureID)
        labeltotal.Text = 0.ToString("C2", cultureID)
    End Sub

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
            ' generate ID transaksi dan tanggal
            Dim transactionId As String = "TRX" & Now.ToString("yyyyMMddHHmmss")
            Dim tanggal As String = Now.ToString("dd MMMM yyyy HH:mm")

            Me.Hide()
            formStruk.SetData(pembelian.Items, labelsubtotal.Text, labeltax.Text, labeltotal.Text, paymentbox.Text, transactionId, tanggal)
            formStruk.ShowDialog()
        End If
    End Sub

End Class
