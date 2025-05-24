Public Class formStruk

    Private Sub formStruk_Load(sender As Object, args As EventArgs) Handles MyBase.Load
        ' Setup ListView
        lvStruk.View = View.Details
        lvStruk.Columns.Clear()
        lvStruk.Columns.Add("Item", 240, HorizontalAlignment.Left)
        lvStruk.Columns.Add("Qty", 70, HorizontalAlignment.Center)
        lvStruk.Columns.Add("Price", 180, HorizontalAlignment.Right)
        lvStruk.Columns.Add("Total", 180, HorizontalAlignment.Right)

        ' Hitung tinggi ListView
        Dim itemHeight As Integer = If(lvStruk.Items.Count > 0, lvStruk.Items(0).Bounds.Height, 20)
        lvStruk.Height = itemHeight * lvStruk.Items.Count + 50

        ' Hitung dan atur lebar form mengikuti ListView
        Dim totalWidth As Integer = lvStruk.Columns.Cast(Of ColumnHeader)().Sum(Function(col) col.Width)
        lvStruk.Width = totalWidth
        Me.Width = lvStruk.Left + totalWidth + 40

        ' Form setup
        Me.Size = New Size(Me.Width, 700)
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        ' ListView style
        lvStruk.FullRowSelect = False
        lvStruk.HideSelection = True
        lvStruk.BorderStyle = BorderStyle.None
        lvStruk.BackColor = Me.BackColor
        lvStruk.OwnerDraw = True

        ' Disable item selection
        AddHandler lvStruk.ItemSelectionChanged, Sub(senderObj, evt)
                                                     evt.Item.Selected = False
                                                 End Sub

        AddHandler lvStruk.MouseDown, Sub(senderObj, evt)
                                          lvStruk.SelectedItems.Clear()
                                      End Sub

        ' Custom header (bold + alignment)
        AddHandler lvStruk.DrawColumnHeader,
            Sub(senderObj, evt)
                evt.DrawBackground()
                Using headerFont As New Font(lvStruk.Font, FontStyle.Bold)
                    Dim format As New StringFormat With {.LineAlignment = StringAlignment.Center}
                    Select Case evt.ColumnIndex
                        Case 1 : format.Alignment = StringAlignment.Center
                        Case 2, 3 : format.Alignment = StringAlignment.Far
                        Case Else : format.Alignment = StringAlignment.Near
                    End Select
                    evt.Graphics.DrawString(evt.Header.Text, headerFont, Brushes.Black, evt.Bounds, format)
                End Using
            End Sub

        ' Custom item content
        AddHandler lvStruk.DrawSubItem,
            Sub(senderObj, evt)
                evt.DrawBackground()
                Dim format As New StringFormat With {.LineAlignment = StringAlignment.Center}
                Select Case evt.ColumnIndex
                    Case 1 : format.Alignment = StringAlignment.Center
                    Case 2, 3 : format.Alignment = StringAlignment.Far
                    Case Else : format.Alignment = StringAlignment.Near
                End Select
                evt.Graphics.DrawString(evt.SubItem.Text, lvStruk.Font, Brushes.Black, evt.Bounds, format)
            End Sub

        ' Kosong karena hanya DrawSubItem yang digunakan
        AddHandler lvStruk.DrawItem, Sub(senderObj, evt)
                                         ' Kosong
                                     End Sub
    End Sub

    ' 
    Public Sub SetData(items As ListView.ListViewItemCollection, subtotal As String, tax As String, total As String, paymentMethod As String, transactionId As String, tanggal As String)
        lvStruk.Items.Clear()
        For Each item As ListViewItem In items
            lvStruk.Items.Add(CType(item.Clone(), ListViewItem))
        Next

        lblSubtotal.Text = subtotal
        lblTax.Text = tax
        lblTotal.Text = total
        lblpaymentbox.Text = paymentMethod
        lblTanggal.Text = tanggal
        lblWaktu.Text = Now.ToString("HH:mm:ss")
        lblTransaksi.Text = transactionId

    End Sub

    ' Drag form code tetap sama...
    Private dragging As Boolean = False
    Private offset As Point

    Private Sub lvStruk_MouseDown(sender As Object, e As MouseEventArgs) Handles lvStruk.MouseDown
        If e.Button = MouseButtons.Left Then
            dragging = True
            offset = PointToClient(lvStruk.PointToScreen(e.Location))
        End If
    End Sub

    Private Sub lvStruk_MouseMove(sender As Object, e As MouseEventArgs) Handles lvStruk.MouseMove
        If dragging Then
            Dim screenPos = lvStruk.PointToScreen(e.Location)
            Dim newLocation = New Point(screenPos.X - offset.X, screenPos.Y - offset.Y)
            Location = newLocation
        End If
    End Sub

    Private Sub lvStruk_MouseUp(sender As Object, e As MouseEventArgs) Handles lvStruk.MouseUp
        dragging = False
    End Sub

    Private Sub formStruk_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            dragging = True
            offset = e.Location
        End If
    End Sub

    Private Sub formStruk_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If dragging Then
            Me.Location = New Point(Me.Location.X + e.X - offset.X, Me.Location.Y + e.Y - offset.Y)
        End If
    End Sub

    Private Sub formStruk_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        dragging = False
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Me.FormBorderStyle = FormBorderStyle.None
        Dim radius As Integer = 30
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        Me.Region = New Region(path)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Hide
    End Sub
End Class
