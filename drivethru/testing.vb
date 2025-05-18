Public Class testing

    ' form load
    Private Sub testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AturTabMenu()
        AturFullscreen()
        AturPanelKontainer()
        AturTabelMenu()
        AturListViewPembelian()
    End Sub

    ' konfigurasi ui (use code/object grouping for better efficiency)
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
                item.SubItems(3).Text = (qty * price).ToString("C2")
                found = True
                Exit For
            End If
        Next

        If Not found Then
            Dim newItem As New ListViewItem(itemName)
            newItem.SubItems.Add("1")
            newItem.SubItems.Add(price.ToString("C2"))
            newItem.SubItems.Add(price.ToString("C2"))
            pembelian.Items.Add(newItem)
        End If

        UpdateTotal()
    End Sub

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

    ' tombol items (event handler)
    Private Sub doublebeef_Click(sender As Object, e As EventArgs) Handles doublebeef.Click
        AddToOrder("Double Beef", 10D)
    End Sub

    Private Sub cheeseburger_Click(sender As Object, e As EventArgs) Handles cheeseburger.Click
        AddToOrder("Cheese Burger", 5.99D)
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        pembelian.Items.Clear()
        labelsubtotal.Text = "$0.00"
        labeltax.Text = "$0.00"
        labeltotal.Text = "$0.00"
    End Sub


    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        Dim formStruk As New formStruk()
        formStruk.SetData(pembelian.Items, labelsubtotal.Text, labeltax.Text, labeltotal.Text)
        formStruk.ShowDialog()
    End Sub

End Class
