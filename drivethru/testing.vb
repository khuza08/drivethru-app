Public Class testing
    Private Sub testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' tampilan menu tab
        TabPage1.Text = "Burgers"
        TabPage2.Text = "Sides"
        TabPage3.Text = "Drinks"
        TabPage4.Text = "Combos"

        ' fullscreen
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        ' panel kontainer
        Panel1.AutoScroll = True
        Panel1.Dock = DockStyle.Fill
        Panel1.Padding = New Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0)

        ' tabel layout menu
        TableLayoutPanel1.AutoSize = False
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddRows

        ' listview pembelian
        pembelian.View = View.Details
        pembelian.Columns.Add("Item", 150, HorizontalAlignment.Left)
        pembelian.Columns.Add("Qty", 60, HorizontalAlignment.Center)
        pembelian.Columns.Add("Price", 120, HorizontalAlignment.Right)
        pembelian.Columns.Add("Total", 160, HorizontalAlignment.Right)


    End Sub

    ' fungsi tambah item ke order
    Private Sub AddToOrder(itemName As String, price As Decimal)
        Dim found As Boolean = False

        For Each item As ListViewItem In pembelian.Items
            If item.SubItems(0).Text = itemName Then
                ' kalo tiem udah ada, tambah qty dan update total
                Dim qty As Integer = Integer.Parse(item.SubItems(1).Text) + 1
                item.SubItems(1).Text = qty.ToString()
                item.SubItems(3).Text = (qty * price).ToString("C2")
                found = True
                Exit For
            End If
        Next

        ' kalo item belum ada, tambahin
        If Not found Then
            Dim newItem As New ListViewItem(itemName)
            newItem.SubItems.Add("1")
            newItem.SubItems.Add(price.ToString("C2"))
            newItem.SubItems.Add(price.ToString("C2"))
            pembelian.Items.Add(newItem)
        End If

        ' update total listview
        UpdateTotal()
    End Sub

    ' update subtotal, taxx, total 
    Private Sub UpdateTotal()
        Dim subtotal As Decimal = 0

        For Each item As ListViewItem In pembelian.Items
            subtotal += Decimal.Parse(item.SubItems(3).Text, Globalization.NumberStyles.Currency)
        Next

        Dim tax As Decimal = subtotal * 0.1D
        Dim total As Decimal = subtotal + tax

        labelsubtotal.Text = subtotal.ToString("C2")
        labeltax.Text = tax.ToString("C2")
        labeltotal.Text = total.ToString("C2")

    End Sub


    Private Sub doublebeef_Click(sender As Object, e As EventArgs) Handles doublebeef.Click
        AddToOrder("Double Beef", 10D)
    End Sub

    ' Reset pesanan
    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        pembelian.Items.Clear()
        labelsubtotal.Text = "$0.00"
        labeltax.Text = "$0.00"
        labeltotal.Text = "$0.00"
    End Sub

End Class
