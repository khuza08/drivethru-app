Imports System.Reflection
Imports drivethru.adminpanel
Imports Guna.UI2.Native.WinApi
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI

Public Class formPembayaran
    Private db As New database()
    Private currentAmount As Decimal = 0
    Private transactionTotal As Decimal = 0
    Private transactionId As String = ""

    ' refresh
    Private Sub UpdateDisplay()
        lblJumlahUang.Text = "Rp " & currentAmount.ToString("N0")
    End Sub

    'form load
    Private Sub formPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New database()

        lvTotal.View = View.Details
        lvTotal.Columns.Clear()
        lvTotal.Columns.Add("Item", 240, HorizontalAlignment.Left)
        lvTotal.Columns.Add("Qty", 70, HorizontalAlignment.Center)
        lvTotal.Columns.Add("Price", 180, HorizontalAlignment.Right)

        ' btn angka pakai tag, efisiensi kode
        For i As Integer = 0 To 9
            Controls.Find("btn" & i.ToString(), True)(0).Tag = i.ToString()
        Next

        Me.KeyPreview = True

        currentAmount = 0
        transactionTotal = 0
        UpdateDisplay()
        lblTotalPembelian.Text = "Rp 0"
        lblKembalian.Text = "Rp 0"
        LoadTotalPembelian()
        LoadListView()
    End Sub

    ' load data listview dari database
    Private Sub LoadListView()
        lvTotal.Items.Clear()
        Dim subtotal As Decimal = 0

        db.Connect()
        If db.conn Is Nothing OrElse db.conn.State <> ConnectionState.Open Then Exit Sub

        Dim query As String = "
        SELECT item, qty, harga_satuan 
        FROM transaksi_detail 
        WHERE id_transaksi = @id "

        Try
            Dim cmd As New MySqlCommand(query, db.conn)
            cmd.Parameters.AddWithValue("@id", lblIdTransaksi.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim harga As Decimal = Convert.ToDecimal(reader("harga_satuan")) / 100
                Dim qty As Integer = Convert.ToInt32(reader("qty"))
                subtotal += harga * qty

                Dim item As New ListViewItem(reader("item").ToString())
                item.SubItems.Add(qty.ToString())
                item.SubItems.Add("Rp " & harga.ToString("N0", New Globalization.CultureInfo("id-ID")))
                lvTotal.Items.Add(item)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal load data transaksi: " & ex.Message)
        Finally
            db.conn.Close()
        End Try

        ' hitung tax dan total bayar
        Dim tax As Decimal = subtotal * 0.1D
        transactionTotal = subtotal + tax
        lblTotalPembelian.Text = "Rp " & transactionTotal.ToString("N0", New Globalization.CultureInfo("id-ID"))
    End Sub

    Private Sub LoadTotalPembelian()
        db.Connect()
        If db.conn Is Nothing OrElse db.conn.State <> ConnectionState.Open Then Exit Sub

        Dim query As String = "
        SELECT total_bayar 
        FROM transaksi 
        WHERE id_transaksi = @id
    "

        Try
            Dim cmd As New MySqlCommand(query, db.conn)
            cmd.Parameters.AddWithValue("@id", lblIdTransaksi.Text)

            Dim result = cmd.ExecuteScalar()
            Dim total As Decimal = If(IsDBNull(result), 0, Convert.ToDecimal(result))

            lblTotalPembelian.Text = "Rp " & (total / 100).ToString("N0", New Globalization.CultureInfo("id-ID"))
        Catch ex As Exception
            MessageBox.Show("Gagal ambil total pembelian: " & ex.Message)
        Finally
            db.conn.Close()
        End Try
    End Sub

    Private Sub formPembayaran_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.D0, Keys.NumPad0
                NumberButton_Click(Me.btn0, EventArgs.Empty)
            Case Keys.D1, Keys.NumPad1
                NumberButton_Click(Me.btn1, EventArgs.Empty)
            Case Keys.D2, Keys.NumPad2
                NumberButton_Click(Me.btn2, EventArgs.Empty)
            Case Keys.D3, Keys.NumPad3
                NumberButton_Click(Me.btn3, EventArgs.Empty)
            Case Keys.D4, Keys.NumPad4
                NumberButton_Click(Me.btn4, EventArgs.Empty)
            Case Keys.D5, Keys.NumPad5
                NumberButton_Click(Me.btn5, EventArgs.Empty)
            Case Keys.D6, Keys.NumPad6
                NumberButton_Click(Me.btn6, EventArgs.Empty)
            Case Keys.D7, Keys.NumPad7
                NumberButton_Click(Me.btn7, EventArgs.Empty)
            Case Keys.D8, Keys.NumPad8
                NumberButton_Click(Me.btn8, EventArgs.Empty)
            Case Keys.D9, Keys.NumPad9
                NumberButton_Click(Me.btn9, EventArgs.Empty)
        End Select
    End Sub

    ' tombol angka 1-0
    Private Sub NumberButton_Click(sender As Object, e As EventArgs) Handles _
        btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click,
        btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click

        Dim btn = DirectCast(sender, Guna.UI2.WinForms.Guna2Button)
        AddDigit(btn.Tag.ToString())
    End Sub

    Private Sub AddDigit(digit As String)
        Dim newValue As String = currentAmount.ToString().Replace(",", "").Replace("Rp", "").Trim()

        newValue = If(newValue = "0", digit, newValue & digit)

        If Decimal.TryParse(newValue, currentAmount) Then
            UpdateDisplay()
        End If
    End Sub


    ' button delete 
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnPembayaranDel.Click
        Dim text = currentAmount.ToString().Replace(",", "")
        If text.Length > 1 Then
            text = text.Substring(0, text.Length - 1)
            Decimal.TryParse(text, currentAmount)
        Else
            currentAmount = 0
        End If
        UpdateDisplay()
    End Sub

    ' button bayar
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnPembayaranEnter.Click
        If currentAmount <= 0 Then
            MessageBox.Show("Masukkan jumlah pembayaran yang valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If lvTotal.Items.Count = 0 Then
            MessageBox.Show("Belum ada item transaksi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If currentAmount >= transactionTotal Then
            Dim kembalian = currentAmount - transactionTotal
            lblKembalian.Text = "Rp " & kembalian.ToString("N0", New Globalization.CultureInfo("id-ID"))
            MessageBox.Show($"Pembayaran berhasil! Kembalian: Rp {kembalian:N0}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' show struk
            Try
                Dim formStruk As New formStruk()
                Dim cultureID As New Globalization.CultureInfo("id-ID")


                db.conn.Open()

                ' ambil data transaksi
                Dim cmdTrans As New MySqlCommand("SELECT tanggal, total_bayar, metode_bayar FROM transaksi WHERE id_transaksi = @id", db.conn)
                cmdTrans.Parameters.AddWithValue("@id", lblIdTransaksi.Text)
                Dim readerTrans = cmdTrans.ExecuteReader()

                Dim tanggal As String = ""
                Dim total_bayar As String = ""
                Dim metode_bayar As String = ""

                If readerTrans.Read() Then
                    tanggal = readerTrans("tanggal").ToString()

                    total_bayar = (Convert.ToDecimal(readerTrans("total_bayar")) / 100D).ToString("C2", cultureID)


                    metode_bayar = readerTrans("metode_bayar").ToString()
                End If
                readerTrans.Close()

                ' ambil detail item
                Dim cmdDetail As New MySqlCommand("SELECT item, qty, harga_satuan, total FROM transaksi_detail WHERE id_transaksi = @id", db.conn)
                cmdDetail.Parameters.AddWithValue("@id", lblIdTransaksi.Text)
                Dim readerDetail = cmdDetail.ExecuteReader()

                Dim dummyList As New ListView()
                dummyList.View = View.Details
                dummyList.Columns.Add("Item")
                dummyList.Columns.Add("Qty")
                dummyList.Columns.Add("Harga")
                dummyList.Columns.Add("Total")

                While readerDetail.Read()
                    Dim item As New ListViewItem(readerDetail("item").ToString())
                    item.SubItems.Add(readerDetail("qty").ToString())

                    Dim hargaSatuanDecimal As Decimal = Convert.ToDecimal(readerDetail("harga_satuan")) / 100D
                    Dim totalDecimal As Decimal = Convert.ToDecimal(readerDetail("total")) / 100D

                    item.SubItems.Add(hargaSatuanDecimal.ToString("C0", cultureID))
                    item.SubItems.Add(totalDecimal.ToString("C0", cultureID))

                    dummyList.Items.Add(item)
                End While
                readerDetail.Close()

                ' hitung tax & subtotal
                Dim totalDec = Decimal.Parse(total_bayar, Globalization.NumberStyles.Currency, cultureID)
                Dim subtotalDec = totalDec / 1.1D
                Dim taxDec = totalDec - subtotalDec

                formStruk.SetData(dummyList.Items, subtotalDec.ToString("C2", cultureID), taxDec.ToString("C2", cultureID), total_bayar, metode_bayar, lblIdTransaksi.Text, tanggal)
                formStruk.lblTy.Text = "LUNAS"
                formStruk.lblKasir.Text = session.KasirUsername
                formStruk.ShowDialog()
                Me.Hide()

            Catch ex As Exception
                MessageBox.Show("Gagal menampilkan struk: " & ex.Message)
            Finally
                If db.conn.State = ConnectionState.Open Then db.conn.Close()
            End Try


            ' reset lbl di form
            currentAmount = 0
            transactionTotal = 0
            UpdateDisplay()
            lblTotalPembelian.Text = "Rp 0"
            lvTotal.Items.Clear()
            lblKembalian.Text = "Rp 0"

        Else
            Dim kurang = transactionTotal - currentAmount
            MessageBox.Show($"Pembayaran kurang! Kurang: Rp {kurang:N0}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class