<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(testing))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Panel1 = New Panel()
        tblburgers = New TableLayoutPanel()
        sandwich = New Button()
        chickenburger = New Button()
        doublebeef = New Button()
        cheeseburger = New Button()
        TabPage2 = New TabPage()
        Panel2 = New Panel()
        tblsides = New TableLayoutPanel()
        nugget = New Button()
        pie = New Button()
        onionring = New Button()
        fries = New Button()
        TabPage3 = New TabPage()
        Panel3 = New Panel()
        tbldrinks = New TableLayoutPanel()
        americano = New Button()
        matcha = New Button()
        mcflurry = New Button()
        cola = New Button()
        TabPage4 = New TabPage()
        Panel4 = New Panel()
        tblcombos = New TableLayoutPanel()
        kombonguwawor = New Button()
        kombocouple = New Button()
        starterpack = New Button()
        kombodeluxe = New Button()
        paymentbox = New ComboBox()
        pembelian = New ListView()
        Label1 = New Label()
        lbltotal = New Label()
        lbltax = New Label()
        lblsubtotal = New Label()
        reset = New Button()
        labelsubtotal = New Label()
        labeltax = New Label()
        labeltotal = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnorder = New Button()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel1.SuspendLayout()
        tblburgers.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel2.SuspendLayout()
        tblsides.SuspendLayout()
        TabPage3.SuspendLayout()
        Panel3.SuspendLayout()
        tbldrinks.SuspendLayout()
        TabPage4.SuspendLayout()
        Panel4.SuspendLayout()
        tblcombos.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Location = New Point(12, 11)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1403, 464)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.CausesValidation = False
        TabPage1.Controls.Add(Panel1)
        TabPage1.Cursor = Cursors.IBeam
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1395, 426)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(tblburgers)
        Panel1.Location = New Point(6, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1383, 635)
        Panel1.TabIndex = 0
        ' 
        ' tblburgers
        ' 
        tblburgers.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        tblburgers.ColumnCount = 2
        tblburgers.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tblburgers.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tblburgers.Controls.Add(sandwich, 1, 1)
        tblburgers.Controls.Add(chickenburger, 0, 1)
        tblburgers.Controls.Add(doublebeef, 1, 0)
        tblburgers.Controls.Add(cheeseburger, 0, 0)
        tblburgers.Location = New Point(3, 6)
        tblburgers.Name = "tblburgers"
        tblburgers.RowCount = 7
        tblburgers.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblburgers.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblburgers.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblburgers.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblburgers.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblburgers.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblburgers.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tblburgers.Size = New Size(545, 2456)
        tblburgers.TabIndex = 0
        ' 
        ' sandwich
        ' 
        sandwich.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        sandwich.AutoSize = True
        sandwich.BackgroundImage = CType(resources.GetObject("sandwich.BackgroundImage"), Image)
        sandwich.BackgroundImageLayout = ImageLayout.Zoom
        sandwich.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sandwich.Location = New Point(275, 409)
        sandwich.Name = "sandwich"
        sandwich.Size = New Size(267, 400)
        sandwich.TabIndex = 3
        sandwich.Text = "Classic Sandwich Rp4.000"
        sandwich.TextAlign = ContentAlignment.BottomCenter
        sandwich.UseVisualStyleBackColor = True
        ' 
        ' chickenburger
        ' 
        chickenburger.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        chickenburger.AutoSize = True
        chickenburger.BackgroundImage = CType(resources.GetObject("chickenburger.BackgroundImage"), Image)
        chickenburger.BackgroundImageLayout = ImageLayout.Zoom
        chickenburger.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chickenburger.Location = New Point(3, 409)
        chickenburger.Name = "chickenburger"
        chickenburger.Size = New Size(266, 400)
        chickenburger.TabIndex = 2
        chickenburger.Text = "Chicken Burger Rp11.000"
        chickenburger.TextAlign = ContentAlignment.BottomCenter
        chickenburger.UseVisualStyleBackColor = True
        ' 
        ' doublebeef
        ' 
        doublebeef.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        doublebeef.AutoSize = True
        doublebeef.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        doublebeef.Image = CType(resources.GetObject("doublebeef.Image"), Image)
        doublebeef.Location = New Point(275, 3)
        doublebeef.Name = "doublebeef"
        doublebeef.Size = New Size(267, 400)
        doublebeef.TabIndex = 1
        doublebeef.Text = "Double Beef Rp14.000"
        doublebeef.TextAlign = ContentAlignment.BottomCenter
        doublebeef.UseVisualStyleBackColor = True
        ' 
        ' cheeseburger
        ' 
        cheeseburger.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cheeseburger.AutoSize = True
        cheeseburger.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cheeseburger.Image = My.Resources.Resources.cheeseburger1
        cheeseburger.Location = New Point(3, 3)
        cheeseburger.Name = "cheeseburger"
        cheeseburger.Size = New Size(266, 400)
        cheeseburger.TabIndex = 0
        cheeseburger.Text = "Cheese Burger Rp5.000"
        cheeseburger.TextAlign = ContentAlignment.BottomCenter
        cheeseburger.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Panel2)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1395, 448)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.Controls.Add(tblsides)
        Panel2.Location = New Point(6, 6)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1383, 635)
        Panel2.TabIndex = 1
        ' 
        ' tblsides
        ' 
        tblsides.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        tblsides.ColumnCount = 2
        tblsides.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tblsides.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tblsides.Controls.Add(nugget, 1, 1)
        tblsides.Controls.Add(pie, 0, 1)
        tblsides.Controls.Add(onionring, 1, 0)
        tblsides.Controls.Add(fries, 0, 0)
        tblsides.Location = New Point(3, 6)
        tblsides.Name = "tblsides"
        tblsides.RowCount = 7
        tblsides.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblsides.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblsides.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblsides.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblsides.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblsides.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblsides.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tblsides.Size = New Size(545, 2456)
        tblsides.TabIndex = 0
        ' 
        ' nugget
        ' 
        nugget.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        nugget.AutoSize = True
        nugget.BackgroundImage = CType(resources.GetObject("nugget.BackgroundImage"), Image)
        nugget.BackgroundImageLayout = ImageLayout.Zoom
        nugget.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nugget.Location = New Point(275, 409)
        nugget.Name = "nugget"
        nugget.Size = New Size(267, 400)
        nugget.TabIndex = 3
        nugget.Text = "Amba Nugget Rp27.000"
        nugget.TextAlign = ContentAlignment.BottomCenter
        nugget.UseVisualStyleBackColor = True
        ' 
        ' pie
        ' 
        pie.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pie.AutoSize = True
        pie.BackgroundImage = CType(resources.GetObject("pie.BackgroundImage"), Image)
        pie.BackgroundImageLayout = ImageLayout.Zoom
        pie.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pie.Location = New Point(3, 409)
        pie.Name = "pie"
        pie.Size = New Size(266, 400)
        pie.TabIndex = 2
        pie.Text = "Amba Pie Rp13.000"
        pie.TextAlign = ContentAlignment.BottomCenter
        pie.UseVisualStyleBackColor = True
        ' 
        ' onionring
        ' 
        onionring.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        onionring.AutoSize = True
        onionring.BackgroundImage = CType(resources.GetObject("onionring.BackgroundImage"), Image)
        onionring.BackgroundImageLayout = ImageLayout.Zoom
        onionring.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        onionring.Location = New Point(275, 3)
        onionring.Name = "onionring"
        onionring.Size = New Size(267, 400)
        onionring.TabIndex = 1
        onionring.Text = "Amba Ring Rp1.000"
        onionring.TextAlign = ContentAlignment.BottomCenter
        onionring.UseVisualStyleBackColor = True
        ' 
        ' fries
        ' 
        fries.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fries.AutoSize = True
        fries.BackgroundImage = CType(resources.GetObject("fries.BackgroundImage"), Image)
        fries.BackgroundImageLayout = ImageLayout.Zoom
        fries.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fries.Location = New Point(3, 3)
        fries.Name = "fries"
        fries.Size = New Size(266, 400)
        fries.TabIndex = 0
        fries.Text = "Amba Fries Rp1.000"
        fries.TextAlign = ContentAlignment.BottomCenter
        fries.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Panel3)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1395, 448)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.Controls.Add(tbldrinks)
        Panel3.Location = New Point(6, 6)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1383, 635)
        Panel3.TabIndex = 1
        ' 
        ' tbldrinks
        ' 
        tbldrinks.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        tbldrinks.ColumnCount = 2
        tbldrinks.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tbldrinks.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tbldrinks.Controls.Add(americano, 1, 1)
        tbldrinks.Controls.Add(matcha, 0, 1)
        tbldrinks.Controls.Add(mcflurry, 1, 0)
        tbldrinks.Controls.Add(cola, 0, 0)
        tbldrinks.Location = New Point(3, 6)
        tbldrinks.Name = "tbldrinks"
        tbldrinks.RowCount = 7
        tbldrinks.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tbldrinks.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tbldrinks.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tbldrinks.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tbldrinks.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tbldrinks.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tbldrinks.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tbldrinks.Size = New Size(545, 2456)
        tbldrinks.TabIndex = 0
        ' 
        ' americano
        ' 
        americano.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        americano.AutoSize = True
        americano.BackgroundImage = CType(resources.GetObject("americano.BackgroundImage"), Image)
        americano.BackgroundImageLayout = ImageLayout.Zoom
        americano.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        americano.Location = New Point(275, 409)
        americano.Name = "americano"
        americano.Size = New Size(267, 400)
        americano.TabIndex = 3
        americano.Text = "Americano Ireng Rp10.000"
        americano.TextAlign = ContentAlignment.BottomCenter
        americano.UseVisualStyleBackColor = True
        ' 
        ' matcha
        ' 
        matcha.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        matcha.AutoSize = True
        matcha.BackgroundImage = CType(resources.GetObject("matcha.BackgroundImage"), Image)
        matcha.BackgroundImageLayout = ImageLayout.Zoom
        matcha.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        matcha.Location = New Point(3, 409)
        matcha.Name = "matcha"
        matcha.Size = New Size(266, 400)
        matcha.TabIndex = 2
        matcha.Text = "Matchaa Latte Rp15.000"
        matcha.TextAlign = ContentAlignment.BottomCenter
        matcha.UseVisualStyleBackColor = True
        ' 
        ' mcflurry
        ' 
        mcflurry.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        mcflurry.AutoSize = True
        mcflurry.BackgroundImage = CType(resources.GetObject("mcflurry.BackgroundImage"), Image)
        mcflurry.BackgroundImageLayout = ImageLayout.Zoom
        mcflurry.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mcflurry.Location = New Point(275, 3)
        mcflurry.Name = "mcflurry"
        mcflurry.Size = New Size(267, 400)
        mcflurry.TabIndex = 1
        mcflurry.Text = "McFlurry Rp14.000"
        mcflurry.TextAlign = ContentAlignment.BottomCenter
        mcflurry.UseVisualStyleBackColor = True
        ' 
        ' cola
        ' 
        cola.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cola.AutoSize = True
        cola.BackgroundImage = CType(resources.GetObject("cola.BackgroundImage"), Image)
        cola.BackgroundImageLayout = ImageLayout.Zoom
        cola.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cola.Location = New Point(3, 3)
        cola.Name = "cola"
        cola.Size = New Size(266, 400)
        cola.TabIndex = 0
        cola.Text = "Coca Cola Rp10.000"
        cola.TextAlign = ContentAlignment.BottomCenter
        cola.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(Panel4)
        TabPage4.Location = New Point(4, 34)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(1395, 448)
        TabPage4.TabIndex = 3
        TabPage4.Text = "TabPage4"
        ' 
        ' Panel4
        ' 
        Panel4.AutoScroll = True
        Panel4.Controls.Add(tblcombos)
        Panel4.Location = New Point(6, 6)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1383, 635)
        Panel4.TabIndex = 1
        ' 
        ' tblcombos
        ' 
        tblcombos.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        tblcombos.ColumnCount = 2
        tblcombos.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tblcombos.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tblcombos.Controls.Add(kombonguwawor, 1, 1)
        tblcombos.Controls.Add(kombocouple, 0, 1)
        tblcombos.Controls.Add(starterpack, 1, 0)
        tblcombos.Controls.Add(kombodeluxe, 0, 0)
        tblcombos.Location = New Point(3, 6)
        tblcombos.Name = "tblcombos"
        tblcombos.RowCount = 7
        tblcombos.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblcombos.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblcombos.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblcombos.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblcombos.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblcombos.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        tblcombos.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tblcombos.Size = New Size(623, 2456)
        tblcombos.TabIndex = 0
        ' 
        ' kombonguwawor
        ' 
        kombonguwawor.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        kombonguwawor.AutoSize = True
        kombonguwawor.BackgroundImage = CType(resources.GetObject("kombonguwawor.BackgroundImage"), Image)
        kombonguwawor.BackgroundImageLayout = ImageLayout.Zoom
        kombonguwawor.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        kombonguwawor.Location = New Point(314, 409)
        kombonguwawor.Name = "kombonguwawor"
        kombonguwawor.Size = New Size(306, 400)
        kombonguwawor.TabIndex = 3
        kombonguwawor.Text = "Kombo Hemat Nguwawor Rp49.000"
        kombonguwawor.TextAlign = ContentAlignment.BottomCenter
        kombonguwawor.UseVisualStyleBackColor = True
        ' 
        ' kombocouple
        ' 
        kombocouple.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        kombocouple.AutoSize = True
        kombocouple.BackgroundImage = CType(resources.GetObject("kombocouple.BackgroundImage"), Image)
        kombocouple.BackgroundImageLayout = ImageLayout.Zoom
        kombocouple.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        kombocouple.Location = New Point(3, 409)
        kombocouple.Name = "kombocouple"
        kombocouple.Size = New Size(305, 400)
        kombocouple.TabIndex = 2
        kombocouple.Text = "Kombo Couple Rp80.000"
        kombocouple.TextAlign = ContentAlignment.BottomCenter
        kombocouple.UseVisualStyleBackColor = True
        ' 
        ' starterpack
        ' 
        starterpack.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        starterpack.AutoSize = True
        starterpack.BackgroundImage = CType(resources.GetObject("starterpack.BackgroundImage"), Image)
        starterpack.BackgroundImageLayout = ImageLayout.Zoom
        starterpack.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        starterpack.Location = New Point(314, 3)
        starterpack.Name = "starterpack"
        starterpack.Size = New Size(306, 400)
        starterpack.TabIndex = 1
        starterpack.Text = " Kombo Starter Pack Rp22.000" & vbCrLf
        starterpack.TextAlign = ContentAlignment.BottomCenter
        starterpack.UseVisualStyleBackColor = True
        ' 
        ' kombodeluxe
        ' 
        kombodeluxe.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        kombodeluxe.AutoSize = True
        kombodeluxe.BackgroundImage = CType(resources.GetObject("kombodeluxe.BackgroundImage"), Image)
        kombodeluxe.BackgroundImageLayout = ImageLayout.Zoom
        kombodeluxe.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        kombodeluxe.Location = New Point(3, 3)
        kombodeluxe.Name = "kombodeluxe"
        kombodeluxe.Size = New Size(305, 400)
        kombodeluxe.TabIndex = 0
        kombodeluxe.Text = "Kombo Deluxe Rp55.000"
        kombodeluxe.TextAlign = ContentAlignment.BottomCenter
        kombodeluxe.UseVisualStyleBackColor = True
        ' 
        ' paymentbox
        ' 
        paymentbox.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        paymentbox.FormattingEnabled = True
        paymentbox.Items.AddRange(New Object() {"Tunai", "Kartu Kredit", "Kartu Debit", "Amba Card"})
        paymentbox.Location = New Point(1504, 340)
        paymentbox.Name = "paymentbox"
        paymentbox.Size = New Size(182, 33)
        paymentbox.TabIndex = 2
        ' 
        ' pembelian
        ' 
        pembelian.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        pembelian.Location = New Point(1310, 197)
        pembelian.Name = "pembelian"
        pembelian.Size = New Size(497, 113)
        pembelian.TabIndex = 5
        pembelian.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label1.Location = New Point(1310, 340)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 28)
        Label1.TabIndex = 6
        Label1.Text = "Payment Method:"
        ' 
        ' lbltotal
        ' 
        lbltotal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lbltotal.AutoSize = True
        lbltotal.Location = New Point(45, 68)
        lbltotal.Name = "lbltotal"
        lbltotal.Size = New Size(66, 35)
        lbltotal.TabIndex = 7
        lbltotal.Text = "Total:"
        lbltotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbltax
        ' 
        lbltax.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lbltax.AutoSize = True
        lbltax.Location = New Point(61, 34)
        lbltax.Name = "lbltax"
        lbltax.Size = New Size(50, 34)
        lbltax.TabIndex = 8
        lbltax.Text = "Tax:"
        lbltax.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblsubtotal
        ' 
        lblsubtotal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lblsubtotal.AutoSize = True
        lblsubtotal.Location = New Point(7, 0)
        lblsubtotal.Name = "lblsubtotal"
        lblsubtotal.Size = New Size(104, 34)
        lblsubtotal.TabIndex = 9
        lblsubtotal.Text = "SubTotal:"
        lblsubtotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' reset
        ' 
        reset.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        reset.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        reset.Location = New Point(1310, 120)
        reset.Name = "reset"
        reset.Size = New Size(497, 62)
        reset.TabIndex = 11
        reset.Text = "Reset Order"
        reset.UseVisualStyleBackColor = True
        ' 
        ' labelsubtotal
        ' 
        labelsubtotal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        labelsubtotal.AutoSize = True
        labelsubtotal.Location = New Point(160, 0)
        labelsubtotal.Name = "labelsubtotal"
        labelsubtotal.Size = New Size(66, 34)
        labelsubtotal.TabIndex = 14
        labelsubtotal.Text = "$0.00"
        labelsubtotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labeltax
        ' 
        labeltax.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        labeltax.AutoSize = True
        labeltax.Location = New Point(160, 34)
        labeltax.Name = "labeltax"
        labeltax.Size = New Size(66, 34)
        labeltax.TabIndex = 13
        labeltax.Text = "$0.00"
        labeltax.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labeltotal
        ' 
        labeltotal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        labeltotal.AutoSize = True
        labeltotal.Location = New Point(160, 68)
        labeltotal.Name = "labeltotal"
        labeltotal.Size = New Size(66, 35)
        labeltotal.TabIndex = 12
        labeltotal.Text = "$0.00"
        labeltotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(labelsubtotal, 1, 0)
        TableLayoutPanel2.Controls.Add(labeltotal, 1, 2)
        TableLayoutPanel2.Controls.Add(lbltotal, 0, 2)
        TableLayoutPanel2.Controls.Add(lbltax, 0, 1)
        TableLayoutPanel2.Controls.Add(lblsubtotal, 0, 0)
        TableLayoutPanel2.Controls.Add(labeltax, 1, 1)
        TableLayoutPanel2.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel2.Location = New Point(1575, 12)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Size = New Size(229, 103)
        TableLayoutPanel2.TabIndex = 15
        ' 
        ' btnorder
        ' 
        btnorder.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnorder.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnorder.Location = New Point(1310, 396)
        btnorder.Name = "btnorder"
        btnorder.Size = New Size(494, 75)
        btnorder.TabIndex = 16
        btnorder.Text = "Order Now"
        btnorder.UseVisualStyleBackColor = True
        ' 
        ' testing
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1822, 487)
        Controls.Add(btnorder)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(reset)
        Controls.Add(Label1)
        Controls.Add(pembelian)
        Controls.Add(paymentbox)
        Controls.Add(TabControl1)
        Name = "testing"
        StartPosition = FormStartPosition.CenterScreen
        Text = "testing"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        tblburgers.ResumeLayout(False)
        tblburgers.PerformLayout()
        TabPage2.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        tblsides.ResumeLayout(False)
        tblsides.PerformLayout()
        TabPage3.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        tbldrinks.ResumeLayout(False)
        tbldrinks.PerformLayout()
        TabPage4.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        tblcombos.ResumeLayout(False)
        tblcombos.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tblburgers As TableLayoutPanel
    Friend WithEvents paymentbox As ComboBox
    Friend WithEvents pembelian As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lbltax As Label
    Friend WithEvents lblsubtotal As Label
    Friend WithEvents reset As Button
    Friend WithEvents cheeseburger As Button
    Friend WithEvents chickenburger As Button
    Friend WithEvents doublebeef As Button
    Friend WithEvents labelsubtotal As Label
    Friend WithEvents labeltax As Label
    Friend WithEvents labeltotal As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tblsides As TableLayoutPanel
    Friend WithEvents onionring As Button
    Friend WithEvents fries As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tbldrinks As TableLayoutPanel
    Friend WithEvents mcflurry As Button
    Friend WithEvents cola As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tblcombos As TableLayoutPanel
    Friend WithEvents starterpack As Button
    Friend WithEvents kombodeluxe As Button
    Friend WithEvents btnorder As Button
    Friend WithEvents sandwich As Button
    Friend WithEvents nugget As Button
    Friend WithEvents pie As Button
    Friend WithEvents americano As Button
    Friend WithEvents matcha As Button
    Friend WithEvents kombonguwawor As Button
    Friend WithEvents kombocouple As Button
End Class
