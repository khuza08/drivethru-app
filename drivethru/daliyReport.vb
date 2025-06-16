Imports MySql.Data.MySqlClient

Public Class daliyReport

    ' Koneksi database MySQL
    Dim connStr As String = "server=localhost;user id=root;password=killvoid;database=db_ambafood;"
    Dim conn As New MySqlConnection(connStr)

    Private Sub daliyReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = Date.Today.AddDays(-7)
        dtpTo.Value = Date.Today
        LoadTransaksi()
    End Sub

    Private Sub LoadTransaksi()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            Dim tanggalAwal As String = dtpFrom.Value.ToString("yyyy-MM-dd") & " 00:00:00"
            Dim tanggalAkhir As String = dtpTo.Value.ToString("yyyy-MM-dd") & " 23:59:59"

            Dim query As String = "SELECT id_transaksi, tanggal, nama_kasir, metode_bayar, total_bayar " &
                                  "FROM transaksi " &
                                  "WHERE tanggal BETWEEN @awal AND @akhir AND nama_kasir = @kasir " &
                                  "ORDER BY tanggal DESC"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@awal", tanggalAwal)
            cmd.Parameters.AddWithValue("@akhir", tanggalAkhir)
            cmd.Parameters.AddWithValue("@kasir", session.KasirNama)

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            ' Buat DataTable baru untuk tampilan (agar bisa custom value)
            Dim dtDisplay As New DataTable()
            dtDisplay.Columns.Add("Tanggal", GetType(String))
            dtDisplay.Columns.Add("Kasir", GetType(String))
            dtDisplay.Columns.Add("ID Transaksi", GetType(String))
            dtDisplay.Columns.Add("Metode Bayar", GetType(String))
            dtDisplay.Columns.Add("Total Bayar", GetType(String))

            Dim totalPenghasilan As Decimal = 0
            Dim cultureID As New Globalization.CultureInfo("id-ID")

            For Each row As DataRow In dt.Rows
                Dim totalBayarDecimal As Decimal = Convert.ToDecimal(row("total_bayar")) / 100D
                totalPenghasilan += totalBayarDecimal

                dtDisplay.Rows.Add(
                    row("tanggal").ToString(),
                    row("nama_kasir").ToString(),
                    row("id_transaksi").ToString(),
                    row("metode_bayar").ToString(),
                    totalBayarDecimal.ToString("C0", cultureID)
                )
            Next

            dgvLog.DataSource = dtDisplay




            lblTotal.Text = "Rp " & totalPenghasilan.ToString("N0", cultureID)

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        If dtpFrom.Value > dtpTo.Value Then dtpTo.Value = dtpFrom.Value
        LoadTransaksi()
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        If dtpTo.Value < dtpFrom.Value Then dtpFrom.Value = dtpTo.Value
        LoadTransaksi()
    End Sub

    Private Sub dgvLog_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvLog.DataBindingComplete
        If dgvLog.Columns.Contains("Tanggal") Then
            dgvLog.Columns("Tanggal").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            dgvLog.Columns("Tanggal").Width = 200
        End If
        If dgvLog.Columns.Contains("Kasir") Then
            dgvLog.Columns("Kasir").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            dgvLog.Columns("Kasir").Width = 110
        End If
        If dgvLog.Columns.Contains("ID Transaksi") Then
            dgvLog.Columns("ID Transaksi").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            dgvLog.Columns("ID Transaksi").Width = 100
        End If
        If dgvLog.Columns.Contains("Metode Bayar") Then
            dgvLog.Columns("Metode Bayar").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            dgvLog.Columns("Metode Bayar").Width = 100
        End If
        If dgvLog.Columns.Contains("Total Bayar") Then
            dgvLog.Columns("Total Bayar").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            dgvLog.Columns("Total Bayar").Width = 120
        End If
    End Sub




End Class
