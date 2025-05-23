Imports drivethru.adminpanel
Imports Guna.UI2.Native.WinApi
Imports MySql.Data.MySqlClient

Public Class formPembayaran
    Private db As New database() ' ✅ Inisialisasi langsung
    Private currentAmount As Decimal = 0
    Private transactionTotal As Decimal = 0
    Private transactionId As String = ""

    ' --- Update UI uang masuk ---
    Private Sub UpdateDisplay()
        lblJumlahUang.Text = "Rp " & currentAmount.ToString("N0")
    End Sub

    ' --- Form Load ---
    Private Sub formPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvTotal.View = View.Details
        lvTotal.Columns.Clear()
        lvTotal.Columns.Add("Item", 240, HorizontalAlignment.Left)
        lvTotal.Columns.Add("Qty", 70, HorizontalAlignment.Center)
        lvTotal.Columns.Add("Price", 180, HorizontalAlignment.Right)

        ' Set Tag tombol angka
        For i As Integer = 0 To 9
            Controls.Find("btn" & i.ToString(), True)(0).Tag = i.ToString()
        Next

        currentAmount = 0
        transactionTotal = 0
        UpdateDisplay()
        lblTotalPembelian.Text = "Rp 0"

        LoadTotalPembelian()
        LoadListView()
    End Sub

    ' --- Load Data dari DB ke ListView ---
    Private Sub LoadListView()
        lvTotal.Items.Clear()

        db.Connect()
        If db.conn Is Nothing OrElse db.conn.State <> ConnectionState.Open Then Exit Sub

        Dim query As String = "
        SELECT item, qty, harga_satuan 
        FROM transaksi_detail 
        WHERE id_transaksi = @id


    "

        Try
            Dim cmd As New MySqlCommand(query, db.conn)
            cmd.Parameters.AddWithValue("@id", lblIdTransaksi.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim item As New ListViewItem(reader("item").ToString())
                item.SubItems.Add(reader("qty").ToString())

                Dim harga As Decimal = Convert.ToDecimal(reader("harga_satuan")) / 100
                item.SubItems.Add("Rp " & harga.ToString("N0", New Globalization.CultureInfo("id-ID")))


                lvTotal.Items.Add(item)
            End While


            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal load data transaksi: " & ex.Message)
        Finally
            db.conn.Close()
        End Try
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



    ' --- Tombol Angka ---
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

    ' --- Tombol Delete ---
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

    ' --- Tombol Enter (Bayar) ---
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnPembayaranEnter.Click
        If currentAmount <= 0 Then
            MessageBox.Show("Masukkan jumlah pembayaran yang valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If lvTotal.Items.Count = 0 Then
            MessageBox.Show("Belum ada item transaksi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Hitung total transaksi dari ListView
        transactionTotal = 0
        For Each item As ListViewItem In lvTotal.Items
            Dim hargaStr = item.SubItems(2).Text.Replace("Rp", "").Trim()
            Dim harga = Convert.ToDecimal(hargaStr)
            transactionTotal += harga
        Next

        If currentAmount >= transactionTotal Then
            Dim kembalian = currentAmount - transactionTotal
            MessageBox.Show($"Pembayaran berhasil! Kembalian: Rp {kembalian:N0}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset
            currentAmount = 0
            transactionTotal = 0
            transactionId = ""
            UpdateDisplay()
            lblTotalPembelian.Text = "Rp 0"
            lvTotal.Items.Clear()
        Else
            Dim kurang = transactionTotal - currentAmount
            MessageBox.Show($"Pembayaran kurang! Kurang: Rp {kurang:N0}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
