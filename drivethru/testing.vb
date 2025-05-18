Imports System.Globalization

Public Class testing

    ' Culture untuk format Rupiah
    Dim cultureID As New CultureInfo("id-ID")

    ' form load
    Private Sub testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AturTabMenu()
        AturFullscreen()
        AturPanelKontainer()
        AturTabelMenu()
        AturListViewPembelian()
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

    ' tombol items
    Private Sub doublebeef_Click(sender As Object, e As EventArgs) Handles doublebeef.Click
        AddToOrder("Double Beef", 14000)
    End Sub

    Private Sub cheeseburger_Click(sender As Object, e As EventArgs) Handles cheeseburger.Click
        AddToOrder("Cheese Burger", 5000)
    End Sub

    Private Sub chickenburger_Click(sender As Object, e As EventArgs) Handles chickenburger.Click
        AddToOrder("Chicken Burger", 11000)
    End Sub

    Private Sub sandwich_Click(sender As Object, e As EventArgs) Handles sandwich.Click
        AddToOrder("Classic Sandwich", 4000)
    End Sub

    Private Sub fries_Click(sender As Object, e As EventArgs) Handles fries.Click
        AddToOrder("Fries", 1000)
    End Sub

    Private Sub onionring_Click(sender As Object, e As EventArgs) Handles onionring.Click
        AddToOrder("Onion Ring", 1000)
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
            MessageBox.Show("Belum ada pesanan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If paymentbox.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih metode pembayaran terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Yakin pesanan sudah benar?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

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
