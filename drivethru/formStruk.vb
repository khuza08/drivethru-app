Public Class formStruk

    Private Sub formStruk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set view dan kolom
        lvStruk.View = View.Details
        lvStruk.Columns.Clear()
        lvStruk.Columns.Add("Item", 150, HorizontalAlignment.Left)
        lvStruk.Columns.Add("Qty", 70, HorizontalAlignment.Center)
        lvStruk.Columns.Add("Price", 140, HorizontalAlignment.Right)
        lvStruk.Columns.Add("Total", 160, HorizontalAlignment.Right)

        Dim itemHeight As Integer = If(lvStruk.Items.Count > 0, lvStruk.Items(0).Bounds.Height, 20)
        lvStruk.Height = itemHeight * lvStruk.Items.Count + 50

        ' Form properties
        Me.Size = New Size(520, 700)
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        ' ListView tampilan
        lvStruk.FullRowSelect = False
        lvStruk.HideSelection = True
        lvStruk.BorderStyle = BorderStyle.None
        lvStruk.BackColor = Me.BackColor
        lvStruk.OwnerDraw = True

        ' Blok seleksi
        AddHandler lvStruk.ItemSelectionChanged, Sub(senderObj, args)
                                                     args.Item.Selected = False
                                                 End Sub
        AddHandler lvStruk.MouseDown, Sub(senderObj, args)
                                          lvStruk.SelectedItems.Clear()
                                      End Sub

        ' Header bold
        AddHandler lvStruk.DrawColumnHeader, Sub(senderObj, evt)
                                                 evt.DrawBackground()

                                                 Using headerFont As New Font(lvStruk.Font, FontStyle.Bold)
                                                     Dim format As New StringFormat() With {
                                                         .LineAlignment = StringAlignment.Center
                                                     }

                                                     Select Case evt.ColumnIndex
                                                         Case 1
                                                             format.Alignment = StringAlignment.Center
                                                         Case 2, 3
                                                             format.Alignment = StringAlignment.Far
                                                         Case Else
                                                             format.Alignment = StringAlignment.Near
                                                     End Select

                                                     evt.Graphics.DrawString(evt.Header.Text, headerFont, Brushes.Black, evt.Bounds, format)
                                                 End Using
                                             End Sub

        ' Item konten
        AddHandler lvStruk.DrawSubItem, Sub(senderObj, evt)
                                            evt.DrawBackground()

                                            Dim text As String = evt.SubItem.Text
                                            Dim format As New StringFormat() With {
                                                .LineAlignment = StringAlignment.Center
                                            }

                                            Select Case evt.ColumnIndex
                                                Case 1
                                                    format.Alignment = StringAlignment.Center
                                                Case 2, 3
                                                    format.Alignment = StringAlignment.Far
                                                Case Else
                                                    format.Alignment = StringAlignment.Near
                                            End Select

                                            evt.Graphics.DrawString(text, lvStruk.Font, Brushes.Black, evt.Bounds, format)
                                        End Sub

        ' Item (baris pertama kolom)
        AddHandler lvStruk.DrawItem, Sub(senderObj, evt)
                                         ' Tidak perlu isi apapun, biar DrawSubItem yang handle
                                     End Sub
    End Sub

    Public Sub SetData(items As ListView.ListViewItemCollection, subtotal As String, tax As String, total As String, paymentMethod As String, transactionId As String, tanggal As String)
        lvStruk.Items.Clear()

        For Each item As ListViewItem In items
            lvStruk.Items.Add(CType(item.Clone(), ListViewItem))
        Next

        lblSubtotal.Text = subtotal
        lblTax.Text = tax
        lblTotal.Text = total
        lblpaymentbox.Text = paymentMethod
        lblTanggal.Text = Now.ToString("dd MMMM yyyy")
        lblWaktu.Text = Now.ToString("HH:mm:ss")
        lblTransaksi.Text = "KHZX" & Now.ToString("yyyyMMddHHmmss")
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint
        ' Kosong
    End Sub

End Class
