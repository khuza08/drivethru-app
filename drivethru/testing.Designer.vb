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
        Button1 = New Button()
        Button2 = New Button()
        Button14 = New Button()
        Button15 = New Button()
        Button16 = New Button()
        Button17 = New Button()
        Button18 = New Button()
        Button19 = New Button()
        Button20 = New Button()
        Button21 = New Button()
        onionring = New Button()
        fries = New Button()
        TabPage3 = New TabPage()
        Panel3 = New Panel()
        tbldrinks = New TableLayoutPanel()
        Button24 = New Button()
        Button25 = New Button()
        Button26 = New Button()
        Button27 = New Button()
        Button28 = New Button()
        Button29 = New Button()
        Button30 = New Button()
        Button31 = New Button()
        Button32 = New Button()
        Button33 = New Button()
        Button34 = New Button()
        Button35 = New Button()
        TabPage4 = New TabPage()
        Panel4 = New Panel()
        tblcombos = New TableLayoutPanel()
        Button36 = New Button()
        Button37 = New Button()
        Button38 = New Button()
        Button39 = New Button()
        Button40 = New Button()
        Button41 = New Button()
        Button42 = New Button()
        Button43 = New Button()
        Button44 = New Button()
        Button45 = New Button()
        Button46 = New Button()
        Button47 = New Button()
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
        TabControl1.Size = New Size(1403, 486)
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
        TabPage1.Size = New Size(1395, 448)
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
        tblburgers.Size = New Size(805, 2456)
        tblburgers.TabIndex = 0
        ' 
        ' sandwich
        ' 
        sandwich.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        sandwich.AutoSize = True
        sandwich.BackgroundImage = CType(resources.GetObject("sandwich.BackgroundImage"), Image)
        sandwich.BackgroundImageLayout = ImageLayout.Zoom
        sandwich.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sandwich.Location = New Point(405, 409)
        sandwich.Name = "sandwich"
        sandwich.Size = New Size(397, 400)
        sandwich.TabIndex = 3
        sandwich.Text = "Classic Sandwich     Rp4.000"
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
        chickenburger.Size = New Size(396, 400)
        chickenburger.TabIndex = 2
        chickenburger.Text = "Chicken Burger      Rp11.000"
        chickenburger.TextAlign = ContentAlignment.BottomCenter
        chickenburger.UseVisualStyleBackColor = True
        ' 
        ' doublebeef
        ' 
        doublebeef.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        doublebeef.AutoSize = True
        doublebeef.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        doublebeef.Image = CType(resources.GetObject("doublebeef.Image"), Image)
        doublebeef.Location = New Point(405, 3)
        doublebeef.Name = "doublebeef"
        doublebeef.Size = New Size(397, 400)
        doublebeef.TabIndex = 1
        doublebeef.Text = "Double Beef          Rp14.000"
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
        cheeseburger.Size = New Size(396, 400)
        cheeseburger.TabIndex = 0
        cheeseburger.Text = "Cheese Burger         Rp5.000"
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
        tblsides.Controls.Add(Button1, 1, 5)
        tblsides.Controls.Add(Button2, 0, 5)
        tblsides.Controls.Add(Button14, 1, 4)
        tblsides.Controls.Add(Button15, 0, 4)
        tblsides.Controls.Add(Button16, 1, 3)
        tblsides.Controls.Add(Button17, 0, 3)
        tblsides.Controls.Add(Button18, 1, 2)
        tblsides.Controls.Add(Button19, 0, 2)
        tblsides.Controls.Add(Button20, 1, 1)
        tblsides.Controls.Add(Button21, 0, 1)
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
        tblsides.Size = New Size(805, 2456)
        tblsides.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.AutoSize = True
        Button1.Location = New Point(405, 2033)
        Button1.Name = "Button1"
        Button1.Size = New Size(397, 400)
        Button1.TabIndex = 11
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button2.AutoSize = True
        Button2.Location = New Point(3, 2033)
        Button2.Name = "Button2"
        Button2.Size = New Size(396, 400)
        Button2.TabIndex = 10
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button14.AutoSize = True
        Button14.Location = New Point(405, 1627)
        Button14.Name = "Button14"
        Button14.Size = New Size(397, 400)
        Button14.TabIndex = 9
        Button14.Text = "Button14"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button15.AutoSize = True
        Button15.Location = New Point(3, 1627)
        Button15.Name = "Button15"
        Button15.Size = New Size(396, 400)
        Button15.TabIndex = 8
        Button15.Text = "Button15"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button16.AutoSize = True
        Button16.Location = New Point(405, 1221)
        Button16.Name = "Button16"
        Button16.Size = New Size(397, 400)
        Button16.TabIndex = 7
        Button16.Text = "Button16"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button17
        ' 
        Button17.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button17.AutoSize = True
        Button17.Location = New Point(3, 1221)
        Button17.Name = "Button17"
        Button17.Size = New Size(396, 400)
        Button17.TabIndex = 6
        Button17.Text = "Button17"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' Button18
        ' 
        Button18.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button18.AutoSize = True
        Button18.Location = New Point(405, 815)
        Button18.Name = "Button18"
        Button18.Size = New Size(397, 400)
        Button18.TabIndex = 5
        Button18.Text = "Button18"
        Button18.UseVisualStyleBackColor = True
        ' 
        ' Button19
        ' 
        Button19.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button19.AutoSize = True
        Button19.Location = New Point(3, 815)
        Button19.Name = "Button19"
        Button19.Size = New Size(396, 400)
        Button19.TabIndex = 4
        Button19.Text = "Button19"
        Button19.UseVisualStyleBackColor = True
        ' 
        ' Button20
        ' 
        Button20.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button20.AutoSize = True
        Button20.Location = New Point(405, 409)
        Button20.Name = "Button20"
        Button20.Size = New Size(397, 400)
        Button20.TabIndex = 3
        Button20.Text = "Button20"
        Button20.UseVisualStyleBackColor = True
        ' 
        ' Button21
        ' 
        Button21.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button21.AutoSize = True
        Button21.Location = New Point(3, 409)
        Button21.Name = "Button21"
        Button21.Size = New Size(396, 400)
        Button21.TabIndex = 2
        Button21.Text = "Button21"
        Button21.UseVisualStyleBackColor = True
        ' 
        ' onionring
        ' 
        onionring.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        onionring.AutoSize = True
        onionring.BackgroundImage = CType(resources.GetObject("onionring.BackgroundImage"), Image)
        onionring.BackgroundImageLayout = ImageLayout.Zoom
        onionring.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        onionring.Location = New Point(405, 3)
        onionring.Name = "onionring"
        onionring.Size = New Size(397, 400)
        onionring.TabIndex = 1
        onionring.Text = "Onion Ring              Rp1.000"
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
        fries.Size = New Size(396, 400)
        fries.TabIndex = 0
        fries.Text = "Fries                         Rp1.000"
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
        tbldrinks.Controls.Add(Button24, 1, 5)
        tbldrinks.Controls.Add(Button25, 0, 5)
        tbldrinks.Controls.Add(Button26, 1, 4)
        tbldrinks.Controls.Add(Button27, 0, 4)
        tbldrinks.Controls.Add(Button28, 1, 3)
        tbldrinks.Controls.Add(Button29, 0, 3)
        tbldrinks.Controls.Add(Button30, 1, 2)
        tbldrinks.Controls.Add(Button31, 0, 2)
        tbldrinks.Controls.Add(Button32, 1, 1)
        tbldrinks.Controls.Add(Button33, 0, 1)
        tbldrinks.Controls.Add(Button34, 1, 0)
        tbldrinks.Controls.Add(Button35, 0, 0)
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
        tbldrinks.Size = New Size(1962, 2456)
        tbldrinks.TabIndex = 0
        ' 
        ' Button24
        ' 
        Button24.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button24.AutoSize = True
        Button24.Location = New Point(984, 2033)
        Button24.Name = "Button24"
        Button24.Size = New Size(975, 400)
        Button24.TabIndex = 11
        Button24.Text = "Button24"
        Button24.UseVisualStyleBackColor = True
        ' 
        ' Button25
        ' 
        Button25.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button25.AutoSize = True
        Button25.Location = New Point(3, 2033)
        Button25.Name = "Button25"
        Button25.Size = New Size(975, 400)
        Button25.TabIndex = 10
        Button25.Text = "Button25"
        Button25.UseVisualStyleBackColor = True
        ' 
        ' Button26
        ' 
        Button26.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button26.AutoSize = True
        Button26.Location = New Point(984, 1627)
        Button26.Name = "Button26"
        Button26.Size = New Size(975, 400)
        Button26.TabIndex = 9
        Button26.Text = "Button26"
        Button26.UseVisualStyleBackColor = True
        ' 
        ' Button27
        ' 
        Button27.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button27.AutoSize = True
        Button27.Location = New Point(3, 1627)
        Button27.Name = "Button27"
        Button27.Size = New Size(975, 400)
        Button27.TabIndex = 8
        Button27.Text = "Button27"
        Button27.UseVisualStyleBackColor = True
        ' 
        ' Button28
        ' 
        Button28.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button28.AutoSize = True
        Button28.Location = New Point(984, 1221)
        Button28.Name = "Button28"
        Button28.Size = New Size(975, 400)
        Button28.TabIndex = 7
        Button28.Text = "Button28"
        Button28.UseVisualStyleBackColor = True
        ' 
        ' Button29
        ' 
        Button29.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button29.AutoSize = True
        Button29.Location = New Point(3, 1221)
        Button29.Name = "Button29"
        Button29.Size = New Size(975, 400)
        Button29.TabIndex = 6
        Button29.Text = "Button29"
        Button29.UseVisualStyleBackColor = True
        ' 
        ' Button30
        ' 
        Button30.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button30.AutoSize = True
        Button30.Location = New Point(984, 815)
        Button30.Name = "Button30"
        Button30.Size = New Size(975, 400)
        Button30.TabIndex = 5
        Button30.Text = "Button30"
        Button30.UseVisualStyleBackColor = True
        ' 
        ' Button31
        ' 
        Button31.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button31.AutoSize = True
        Button31.Location = New Point(3, 815)
        Button31.Name = "Button31"
        Button31.Size = New Size(975, 400)
        Button31.TabIndex = 4
        Button31.Text = "Button31"
        Button31.UseVisualStyleBackColor = True
        ' 
        ' Button32
        ' 
        Button32.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button32.AutoSize = True
        Button32.Location = New Point(984, 409)
        Button32.Name = "Button32"
        Button32.Size = New Size(975, 400)
        Button32.TabIndex = 3
        Button32.Text = "Button32"
        Button32.UseVisualStyleBackColor = True
        ' 
        ' Button33
        ' 
        Button33.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button33.AutoSize = True
        Button33.Location = New Point(3, 409)
        Button33.Name = "Button33"
        Button33.Size = New Size(975, 400)
        Button33.TabIndex = 2
        Button33.Text = "Button33"
        Button33.UseVisualStyleBackColor = True
        ' 
        ' Button34
        ' 
        Button34.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button34.AutoSize = True
        Button34.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button34.Image = My.Resources.Resources.doublebeef
        Button34.Location = New Point(984, 3)
        Button34.Name = "Button34"
        Button34.Size = New Size(975, 400)
        Button34.TabIndex = 1
        Button34.Text = "Double Beef $10"
        Button34.TextAlign = ContentAlignment.BottomCenter
        Button34.UseVisualStyleBackColor = True
        ' 
        ' Button35
        ' 
        Button35.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button35.AutoSize = True
        Button35.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button35.Location = New Point(3, 3)
        Button35.Name = "Button35"
        Button35.Size = New Size(975, 400)
        Button35.TabIndex = 0
        Button35.Text = "Cheese Burger   $5.99"
        Button35.TextAlign = ContentAlignment.BottomCenter
        Button35.UseVisualStyleBackColor = True
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
        tblcombos.Controls.Add(Button36, 1, 5)
        tblcombos.Controls.Add(Button37, 0, 5)
        tblcombos.Controls.Add(Button38, 1, 4)
        tblcombos.Controls.Add(Button39, 0, 4)
        tblcombos.Controls.Add(Button40, 1, 3)
        tblcombos.Controls.Add(Button41, 0, 3)
        tblcombos.Controls.Add(Button42, 1, 2)
        tblcombos.Controls.Add(Button43, 0, 2)
        tblcombos.Controls.Add(Button44, 1, 1)
        tblcombos.Controls.Add(Button45, 0, 1)
        tblcombos.Controls.Add(Button46, 1, 0)
        tblcombos.Controls.Add(Button47, 0, 0)
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
        tblcombos.Size = New Size(3119, 2456)
        tblcombos.TabIndex = 0
        ' 
        ' Button36
        ' 
        Button36.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button36.AutoSize = True
        Button36.Location = New Point(1562, 2033)
        Button36.Name = "Button36"
        Button36.Size = New Size(1554, 400)
        Button36.TabIndex = 11
        Button36.Text = "Button36"
        Button36.UseVisualStyleBackColor = True
        ' 
        ' Button37
        ' 
        Button37.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button37.AutoSize = True
        Button37.Location = New Point(3, 2033)
        Button37.Name = "Button37"
        Button37.Size = New Size(1553, 400)
        Button37.TabIndex = 10
        Button37.Text = "Button37"
        Button37.UseVisualStyleBackColor = True
        ' 
        ' Button38
        ' 
        Button38.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button38.AutoSize = True
        Button38.Location = New Point(1562, 1627)
        Button38.Name = "Button38"
        Button38.Size = New Size(1554, 400)
        Button38.TabIndex = 9
        Button38.Text = "Button38"
        Button38.UseVisualStyleBackColor = True
        ' 
        ' Button39
        ' 
        Button39.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button39.AutoSize = True
        Button39.Location = New Point(3, 1627)
        Button39.Name = "Button39"
        Button39.Size = New Size(1553, 400)
        Button39.TabIndex = 8
        Button39.Text = "Button39"
        Button39.UseVisualStyleBackColor = True
        ' 
        ' Button40
        ' 
        Button40.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button40.AutoSize = True
        Button40.Location = New Point(1562, 1221)
        Button40.Name = "Button40"
        Button40.Size = New Size(1554, 400)
        Button40.TabIndex = 7
        Button40.Text = "Button40"
        Button40.UseVisualStyleBackColor = True
        ' 
        ' Button41
        ' 
        Button41.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button41.AutoSize = True
        Button41.Location = New Point(3, 1221)
        Button41.Name = "Button41"
        Button41.Size = New Size(1553, 400)
        Button41.TabIndex = 6
        Button41.Text = "Button41"
        Button41.UseVisualStyleBackColor = True
        ' 
        ' Button42
        ' 
        Button42.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button42.AutoSize = True
        Button42.Location = New Point(1562, 815)
        Button42.Name = "Button42"
        Button42.Size = New Size(1554, 400)
        Button42.TabIndex = 5
        Button42.Text = "Button42"
        Button42.UseVisualStyleBackColor = True
        ' 
        ' Button43
        ' 
        Button43.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button43.AutoSize = True
        Button43.Location = New Point(3, 815)
        Button43.Name = "Button43"
        Button43.Size = New Size(1553, 400)
        Button43.TabIndex = 4
        Button43.Text = "Button43"
        Button43.UseVisualStyleBackColor = True
        ' 
        ' Button44
        ' 
        Button44.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button44.AutoSize = True
        Button44.Location = New Point(1562, 409)
        Button44.Name = "Button44"
        Button44.Size = New Size(1554, 400)
        Button44.TabIndex = 3
        Button44.Text = "Button44"
        Button44.UseVisualStyleBackColor = True
        ' 
        ' Button45
        ' 
        Button45.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button45.AutoSize = True
        Button45.Location = New Point(3, 409)
        Button45.Name = "Button45"
        Button45.Size = New Size(1553, 400)
        Button45.TabIndex = 2
        Button45.Text = "Button45"
        Button45.UseVisualStyleBackColor = True
        ' 
        ' Button46
        ' 
        Button46.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button46.AutoSize = True
        Button46.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button46.Image = My.Resources.Resources.doublebeef
        Button46.Location = New Point(1562, 3)
        Button46.Name = "Button46"
        Button46.Size = New Size(1554, 400)
        Button46.TabIndex = 1
        Button46.Text = "Double Beef $10"
        Button46.TextAlign = ContentAlignment.BottomCenter
        Button46.UseVisualStyleBackColor = True
        ' 
        ' Button47
        ' 
        Button47.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button47.AutoSize = True
        Button47.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button47.Location = New Point(3, 3)
        Button47.Name = "Button47"
        Button47.Size = New Size(1553, 400)
        Button47.TabIndex = 0
        Button47.Text = "Cheese Burger   $5.99"
        Button47.TextAlign = ContentAlignment.BottomCenter
        Button47.UseVisualStyleBackColor = True
        ' 
        ' paymentbox
        ' 
        paymentbox.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        paymentbox.FormattingEnabled = True
        paymentbox.Items.AddRange(New Object() {"Tunai", "Kartu Kredit", "Kartu Debit", "Amba Card"})
        paymentbox.Location = New Point(1625, 362)
        paymentbox.Name = "paymentbox"
        paymentbox.Size = New Size(182, 33)
        paymentbox.TabIndex = 2
        ' 
        ' pembelian
        ' 
        pembelian.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        pembelian.Location = New Point(1310, 197)
        pembelian.Name = "pembelian"
        pembelian.Size = New Size(497, 135)
        pembelian.TabIndex = 5
        pembelian.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label1.Location = New Point(1445, 362)
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
        btnorder.Location = New Point(1310, 418)
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
        ClientSize = New Size(1822, 509)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents onionring As Button
    Friend WithEvents fries As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tbldrinks As TableLayoutPanel
    Friend WithEvents Button24 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents Button31 As Button
    Friend WithEvents Button32 As Button
    Friend WithEvents Button33 As Button
    Friend WithEvents Button34 As Button
    Friend WithEvents Button35 As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tblcombos As TableLayoutPanel
    Friend WithEvents Button36 As Button
    Friend WithEvents Button37 As Button
    Friend WithEvents Button38 As Button
    Friend WithEvents Button39 As Button
    Friend WithEvents Button40 As Button
    Friend WithEvents Button41 As Button
    Friend WithEvents Button42 As Button
    Friend WithEvents Button43 As Button
    Friend WithEvents Button44 As Button
    Friend WithEvents Button45 As Button
    Friend WithEvents Button46 As Button
    Friend WithEvents Button47 As Button
    Friend WithEvents btnorder As Button
    Friend WithEvents sandwich As Button
End Class
