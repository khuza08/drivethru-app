<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStruk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TableLayoutPanel1 = New TableLayoutPanel()
        lvStruk = New ListView()
        Item = New ColumnHeader()
        Qty = New ColumnHeader()
        Price = New ColumnHeader()
        Total = New ColumnHeader()
        tblStruk = New TableLayoutPanel()
        Label19 = New Label()
        Label18 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblSubtotal = New Label()
        lblTax = New Label()
        lblTotal = New Label()
        lblpaymentbox = New Label()
        Label21 = New Label()
        Label20 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        lblKasir = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        lblTanggal = New Label()
        lblWaktu = New Label()
        lblTransaksi = New Label()
        dot = New Label()
        kasier = New Label()
        Label13 = New Label()
        Label14 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label17 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label15 = New Label()
        lblTy = New Label()
        btnExit = New Guna.UI2.WinForms.Guna2Button()
        TableLayoutPanel1.SuspendLayout()
        tblStruk.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(lvStruk, 0, 3)
        TableLayoutPanel1.Controls.Add(tblStruk, 0, 5)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel1.Controls.Add(Label13, 0, 2)
        TableLayoutPanel1.Controls.Add(Label14, 0, 4)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 0, 7)
        TableLayoutPanel1.Controls.Add(btnExit, 0, 8)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 9
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 17F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 46F))
        TableLayoutPanel1.Size = New Size(845, 746)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' lvStruk
        ' 
        lvStruk.BackColor = SystemColors.ButtonHighlight
        lvStruk.Columns.AddRange(New ColumnHeader() {Item, Qty, Price, Total})
        lvStruk.Font = New Font("Courier New", 11F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lvStruk.HeaderStyle = ColumnHeaderStyle.Nonclickable
        lvStruk.HideSelection = True
        lvStruk.Location = New Point(3, 231)
        lvStruk.Name = "lvStruk"
        lvStruk.Size = New Size(639, 71)
        lvStruk.TabIndex = 0
        lvStruk.UseCompatibleStateImageBehavior = False
        ' 
        ' Item
        ' 
        Item.Width = 150
        ' 
        ' Price
        ' 
        Price.Width = 80
        ' 
        ' Total
        ' 
        Total.Width = 90
        ' 
        ' tblStruk
        ' 
        tblStruk.BackColor = Color.Transparent
        tblStruk.ColumnCount = 3
        tblStruk.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 88.39286F))
        tblStruk.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.6071424F))
        tblStruk.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 207F))
        tblStruk.Controls.Add(Label19, 1, 2)
        tblStruk.Controls.Add(Label18, 1, 1)
        tblStruk.Controls.Add(Label4, 0, 4)
        tblStruk.Controls.Add(Label3, 0, 2)
        tblStruk.Controls.Add(Label2, 0, 1)
        tblStruk.Controls.Add(Label1, 0, 0)
        tblStruk.Controls.Add(lblSubtotal, 2, 0)
        tblStruk.Controls.Add(lblTax, 2, 1)
        tblStruk.Controls.Add(lblTotal, 2, 2)
        tblStruk.Controls.Add(lblpaymentbox, 2, 4)
        tblStruk.Controls.Add(Label21, 1, 0)
        tblStruk.Controls.Add(Label20, 1, 4)
        tblStruk.Location = New Point(3, 328)
        tblStruk.Name = "tblStruk"
        tblStruk.RowCount = 5
        tblStruk.RowStyles.Add(New RowStyle())
        tblStruk.RowStyles.Add(New RowStyle())
        tblStruk.RowStyles.Add(New RowStyle(SizeType.Absolute, 27F))
        tblStruk.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tblStruk.RowStyles.Add(New RowStyle(SizeType.Absolute, 43F))
        tblStruk.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tblStruk.Size = New Size(680, 216)
        tblStruk.TabIndex = 4
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(421, 56)
        Label19.Name = "Label19"
        Label19.Size = New Size(20, 20)
        Label19.TabIndex = 15
        Label19.Text = ":"
        Label19.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(421, 28)
        Label18.Name = "Label18"
        Label18.Size = New Size(20, 20)
        Label18.TabIndex = 14
        Label18.Text = ":"
        Label18.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Courier New", 12F)
        Label4.Location = New Point(3, 103)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 27)
        Label4.TabIndex = 8
        Label4.Text = "Pembayaran"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Courier New", 12F)
        Label3.Location = New Point(3, 56)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 27)
        Label3.TabIndex = 7
        Label3.Text = "Total"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Courier New", 12F)
        Label2.Location = New Point(3, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 27)
        Label2.TabIndex = 6
        Label2.Text = "Tax"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Courier New", 12F)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 27)
        Label1.TabIndex = 5
        Label1.Text = "Subtotal"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Font = New Font("Courier New", 12F, FontStyle.Bold Or FontStyle.Italic)
        lblSubtotal.Location = New Point(475, 0)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(194, 28)
        lblSubtotal.TabIndex = 1
        lblSubtotal.Text = "hasilSubtotal"
        lblSubtotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTax
        ' 
        lblTax.AutoSize = True
        lblTax.Font = New Font("Courier New", 12F, FontStyle.Bold Or FontStyle.Italic)
        lblTax.Location = New Point(475, 28)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(194, 28)
        lblTax.TabIndex = 2
        lblTax.Text = "hasilFanumTax"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Courier New", 12F, FontStyle.Bold Or FontStyle.Italic)
        lblTotal.Location = New Point(475, 56)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(152, 27)
        lblTotal.TabIndex = 3
        lblTotal.Text = "hasilTotal"
        ' 
        ' lblpaymentbox
        ' 
        lblpaymentbox.AutoSize = True
        lblpaymentbox.Font = New Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblpaymentbox.Location = New Point(475, 103)
        lblpaymentbox.Name = "lblpaymentbox"
        lblpaymentbox.Size = New Size(110, 27)
        lblpaymentbox.TabIndex = 9
        lblpaymentbox.Text = "sukicau"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(421, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(20, 20)
        Label21.TabIndex = 13
        Label21.Text = ":"
        Label21.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(421, 103)
        Label20.Name = "Label20"
        Label20.Size = New Size(20, 20)
        Label20.TabIndex = 16
        Label20.Text = ":"
        Label20.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 88.54626F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.4537449F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 224F))
        TableLayoutPanel3.Controls.Add(lblKasir, 2, 3)
        TableLayoutPanel3.Controls.Add(Label12, 1, 2)
        TableLayoutPanel3.Controls.Add(Label11, 1, 1)
        TableLayoutPanel3.Controls.Add(Label10, 1, 0)
        TableLayoutPanel3.Controls.Add(Label7, 0, 0)
        TableLayoutPanel3.Controls.Add(Label8, 0, 1)
        TableLayoutPanel3.Controls.Add(Label9, 0, 2)
        TableLayoutPanel3.Controls.Add(lblTanggal, 2, 0)
        TableLayoutPanel3.Controls.Add(lblWaktu, 2, 1)
        TableLayoutPanel3.Controls.Add(lblTransaksi, 2, 2)
        TableLayoutPanel3.Controls.Add(dot, 1, 3)
        TableLayoutPanel3.Controls.Add(kasier, 0, 3)
        TableLayoutPanel3.Location = New Point(3, 113)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 4
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0626545F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0626583F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0626583F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 24.8120327F))
        TableLayoutPanel3.Size = New Size(680, 92)
        TableLayoutPanel3.TabIndex = 6
        ' 
        ' lblKasir
        ' 
        lblKasir.AutoSize = True
        lblKasir.Font = New Font("Courier New", 12F, FontStyle.Bold Or FontStyle.Italic)
        lblKasir.Location = New Point(458, 69)
        lblKasir.Name = "lblKasir"
        lblKasir.Size = New Size(0, 23)
        lblKasir.TabIndex = 10
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Courier New", 9F)
        Label12.Location = New Point(406, 46)
        Label12.Name = "Label12"
        Label12.Size = New Size(20, 20)
        Label12.TabIndex = 8
        Label12.Text = ":"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Courier New", 9F)
        Label11.Location = New Point(406, 23)
        Label11.Name = "Label11"
        Label11.Size = New Size(20, 20)
        Label11.TabIndex = 7
        Label11.Text = ":"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Courier New", 9F)
        Label10.Location = New Point(406, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(20, 20)
        Label10.TabIndex = 6
        Label10.Text = ":"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Courier New", 12F)
        Label7.Location = New Point(3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 23)
        Label7.TabIndex = 0
        Label7.Text = "Tanggal"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Courier New", 12F)
        Label8.Location = New Point(3, 23)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 23)
        Label8.TabIndex = 1
        Label8.Text = "Waktu"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Courier New", 12F)
        Label9.Location = New Point(3, 46)
        Label9.Name = "Label9"
        Label9.Size = New Size(180, 23)
        Label9.TabIndex = 2
        Label9.Text = "ID Transaksi"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Courier New", 12F, FontStyle.Bold Or FontStyle.Italic)
        lblTanggal.Location = New Point(458, 0)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(152, 23)
        lblTanggal.TabIndex = 4
        lblTanggal.Text = "lblTanggal"
        ' 
        ' lblWaktu
        ' 
        lblWaktu.AutoSize = True
        lblWaktu.Font = New Font("Courier New", 12F, FontStyle.Bold Or FontStyle.Italic)
        lblWaktu.Location = New Point(458, 23)
        lblWaktu.Name = "lblWaktu"
        lblWaktu.Size = New Size(124, 23)
        lblWaktu.TabIndex = 3
        lblWaktu.Text = "lblWaktu"
        ' 
        ' lblTransaksi
        ' 
        lblTransaksi.AutoSize = True
        lblTransaksi.Font = New Font("Courier New", 12F, FontStyle.Bold Or FontStyle.Italic)
        lblTransaksi.Location = New Point(458, 46)
        lblTransaksi.Name = "lblTransaksi"
        lblTransaksi.Size = New Size(180, 23)
        lblTransaksi.TabIndex = 5
        lblTransaksi.Text = "lblTransaksi"
        ' 
        ' dot
        ' 
        dot.AutoSize = True
        dot.Font = New Font("Courier New", 9F)
        dot.Location = New Point(406, 69)
        dot.Name = "dot"
        dot.Size = New Size(20, 20)
        dot.TabIndex = 11
        dot.Text = ":"
        ' 
        ' kasier
        ' 
        kasier.AutoSize = True
        kasier.Font = New Font("Courier New", 12F)
        kasier.Location = New Point(3, 69)
        kasier.Name = "kasier"
        kasier.Size = New Size(82, 23)
        kasier.TabIndex = 9
        kasier.Text = "Kasir"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Courier New", 9F, FontStyle.Bold Or FontStyle.Italic)
        Label13.Location = New Point(3, 208)
        Label13.Name = "Label13"
        Label13.Size = New Size(680, 20)
        Label13.TabIndex = 7
        Label13.Text = "============================================================="
        Label13.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Courier New", 9F, FontStyle.Bold Or FontStyle.Italic)
        Label14.Location = New Point(3, 305)
        Label14.Name = "Label14"
        Label14.Size = New Size(680, 20)
        Label14.TabIndex = 8
        Label14.Text = "============================================================="
        Label14.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(Label17, 0, 1)
        TableLayoutPanel2.Controls.Add(Label6, 0, 3)
        TableLayoutPanel2.Controls.Add(Label5, 0, 2)
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 4
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle())
        TableLayoutPanel2.RowStyles.Add(New RowStyle())
        TableLayoutPanel2.RowStyles.Add(New RowStyle())
        TableLayoutPanel2.Size = New Size(680, 104)
        TableLayoutPanel2.TabIndex = 5
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top
        Label17.AutoSize = True
        Label17.Font = New Font("Courier New", 13F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(189, 20)
        Label17.Name = "Label17"
        Label17.Size = New Size(301, 29)
        Label17.TabIndex = 2
        Label17.Text = "Ambafood DriveThru"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Courier New", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(233, 74)
        Label6.Name = "Label6"
        Label6.Size = New Size(214, 23)
        Label6.TabIndex = 1
        Label6.Text = "Telp: 08388453463"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Courier New", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(145, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(389, 25)
        Label5.TabIndex = 0
        Label5.Text = "Jl. Suki Timur, No. 08, Ngawi"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(Label15, 0, 0)
        TableLayoutPanel4.Controls.Add(lblTy, 0, 1)
        TableLayoutPanel4.Location = New Point(162, 567)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(520, 60)
        TableLayoutPanel4.TabIndex = 11
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label15.AutoSize = True
        Label15.Location = New Point(231, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(57, 30)
        Label15.TabIndex = 9
        Label15.Text = "★☆★"
        ' 
        ' lblTy
        ' 
        lblTy.Anchor = AnchorStyles.Top
        lblTy.AutoSize = True
        lblTy.Font = New Font("Courier New", 11F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTy.Location = New Point(176, 30)
        lblTy.Name = "lblTy"
        lblTy.Size = New Size(168, 25)
        lblTy.TabIndex = 10
        lblTy.Text = "Terimakasih!"
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnExit.Animated = True
        btnExit.AnimatedGIF = True
        btnExit.AutoRoundedCorners = True
        btnExit.BorderRadius = 54
        btnExit.CustomizableEdges = CustomizableEdges3
        btnExit.DefaultAutoSize = True
        btnExit.DisabledState.BorderColor = Color.DarkGray
        btnExit.DisabledState.CustomBorderColor = Color.DarkGray
        btnExit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnExit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnExit.FillColor = SystemColors.ControlDark
        btnExit.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.Black
        btnExit.Location = New Point(3, 633)
        btnExit.Name = "btnExit"
        btnExit.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnExit.Size = New Size(839, 110)
        btnExit.TabIndex = 12
        btnExit.Text = "CLOSE RECEIPT"
        ' 
        ' formStruk
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(845, 746)
        Controls.Add(TableLayoutPanel1)
        Name = "formStruk"
        StartPosition = FormStartPosition.CenterScreen
        Text = "formStruk"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        tblStruk.ResumeLayout(False)
        tblStruk.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lvStruk As ListView
    Friend WithEvents Item As ColumnHeader
    Friend WithEvents Qty As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Total As ColumnHeader
    Friend WithEvents tblStruk As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblpaymentbox As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblTransaksi As Label
    Friend WithEvents lblWaktu As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblTy As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblKasir As Label
    Friend WithEvents dot As Label
    Friend WithEvents kasier As Label
End Class
