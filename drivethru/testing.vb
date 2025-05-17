Public Class testing
    Private Sub testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPage1.Text = "Burgers"
        TabPage2.Text = "Sides"
        TabPage3.Text = "Drinks"
        TabPage4.Text = "Combos"

        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        ' panel as container
        Panel1.AutoScroll = True
        Panel1.Dock = DockStyle.Fill
        Panel1.Padding = New Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0) ' agar scrollbar tidak menutupi isi

        ' TableLayoutPanel di dalam Panel
        TableLayoutPanel1.AutoSize = False
        TableLayoutPanel1.Dock = DockStyle.Top ' atau Fill jika ingin memenuhi panel
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddRows


        ' Kode List view
        pembelian.View = View.Details
        pembelian.Columns.Add("Item", 150, HorizontalAlignment.Left)
        pembelian.Columns.Add("Qty", 50, HorizontalAlignment.Center)
        pembelian.Columns.Add("Price", 70, HorizontalAlignment.Right)
        pembelian.Columns.Add("Total", 70, HorizontalAlignment.Right)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub doublebeef_Click(sender As Object, e As EventArgs) Handles doublebeef.Click
        Dim menuNama As String = "Double Beef"
        Dim hargaSatuan As Integer = 10
        Dim found As Boolean = False

        ' Cek apakah item sudah ada
        For Each item As ListViewItem In pembelian.Items
            If item.Text = menuNama Then
                ' Tambah qty
                Dim qty As Integer = Integer.Parse(item.SubItems(1).Text)
                qty += 1
                item.SubItems(1).Text = qty.ToString()

                ' Update total harga
                Dim totalHarga As Integer = qty * hargaSatuan
                item.SubItems(2).Text = "$" & totalHarga.ToString()
                found = True
                Exit For
            End If
        Next

        ' Kalau belum ada, tambahkan item baru
        If Not found Then
            Dim newItem As New ListViewItem(menuNama)
            newItem.SubItems.Add("1")
            newItem.SubItems.Add("$" & hargaSatuan.ToString())
            pembelian.Items.Add(newItem)
            tbtotal.Text = hargaSatuan

        End If
    End Sub

    Private Sub pembelian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pembelian.SelectedIndexChanged
        ' Setup kolom ListView jika belum
        pembelian.View = View.Details
        pembelian.Columns.Add("Menu", 150)
        pembelian.Columns.Add("Price", 70)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        pembelian.Items.Clear()
    End Sub

    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total.Click

    End Sub

    Private Sub tbtotal_TextChanged(sender As Object, e As EventArgs) Handles tbtotal.TextChanged

    End Sub
End Class