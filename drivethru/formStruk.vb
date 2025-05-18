Public Class formStruk


    Private Sub formStruk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvStruk.View = View.Details
        lvStruk.Columns.Clear()
        lvStruk.Columns.Add("Item", 150, HorizontalAlignment.Left)
        lvStruk.Columns.Add("Qty", 60, HorizontalAlignment.Center)
        lvStruk.Columns.Add("Price", 120, HorizontalAlignment.Right)
        lvStruk.Columns.Add("Total", 120, HorizontalAlignment.Right)

        Dim itemHeight As Integer = If(lvStruk.Items.Count > 0, lvStruk.Items(0).Bounds.Height, 20)
        lvStruk.Height = itemHeight * lvStruk.Items.Count + 30 ' +30 untuk header


        lvStruk.BackColor = Me.BackColor
        lvStruk.BorderStyle = BorderStyle.None

        ' form var
        Me.Size = New Size(480, 666)
        Me.MaximizeBox = False
        Me.MinimizeBox = False

    End Sub

    Public Sub SetData(items As ListView.ListViewItemCollection, subtotal As String, tax As String, total As String)
        lvStruk.Items.Clear()

        For Each item As ListViewItem In items
            lvStruk.Items.Add(CType(item.Clone(), ListViewItem))
        Next

        lblSubtotal.Text = subtotal
        lblTax.Text = tax
        lblTotal.Text = total
    End Sub

End Class