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
        tabControl = New Guna.UI2.WinForms.Guna2TabControl()
        TabPage1 = New TabPage()
        flowpanelBurgers = New FlowLayoutPanel()
        TabPage2 = New TabPage()
        flowpanelSides = New FlowLayoutPanel()
        TabPage3 = New TabPage()
        flowpanelDrinks = New FlowLayoutPanel()
        TabPage4 = New TabPage()
        flowpanelCombos = New FlowLayoutPanel()
        TabPage5 = New TabPage()
        flowpanelSpecial = New FlowLayoutPanel()
        TableLayoutPanel2.SuspendLayout()
        tabControl.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        TabPage5.SuspendLayout()
        SuspendLayout()
        ' 
        ' paymentbox
        ' 
        paymentbox.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        paymentbox.FormattingEnabled = True
        paymentbox.Items.AddRange(New Object() {"Tunai", "Kartu Kredit", "Kartu Debit", "Amba Card"})
        paymentbox.Location = New Point(1103, 580)
        paymentbox.Name = "paymentbox"
        paymentbox.Size = New Size(182, 33)
        paymentbox.TabIndex = 2
        ' 
        ' pembelian
        ' 
        pembelian.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        pembelian.Location = New Point(920, 197)
        pembelian.Name = "pembelian"
        pembelian.Size = New Size(476, 353)
        pembelian.TabIndex = 5
        pembelian.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label1.Location = New Point(920, 580)
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
        reset.Location = New Point(920, 120)
        reset.Name = "reset"
        reset.Size = New Size(476, 62)
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
        TableLayoutPanel2.Location = New Point(1164, 12)
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
        btnorder.Location = New Point(920, 636)
        btnorder.Name = "btnorder"
        btnorder.Size = New Size(473, 75)
        btnorder.TabIndex = 16
        btnorder.Text = "Order Now"
        btnorder.UseVisualStyleBackColor = True
        ' 
        ' tabControl
        ' 
        tabControl.Alignment = TabAlignment.Left
        tabControl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tabControl.Controls.Add(TabPage1)
        tabControl.Controls.Add(TabPage2)
        tabControl.Controls.Add(TabPage3)
        tabControl.Controls.Add(TabPage4)
        tabControl.Controls.Add(TabPage5)
        tabControl.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabControl.ItemSize = New Size(200, 40)
        tabControl.Location = New Point(0, 0)
        tabControl.Name = "tabControl"
        tabControl.SelectedIndex = 0
        tabControl.Size = New Size(904, 729)
        tabControl.TabButtonHoverState.BorderColor = Color.Transparent
        tabControl.TabButtonHoverState.FillColor = Color.Firebrick
        tabControl.TabButtonHoverState.Font = New Font("Montserrat SemiBold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabControl.TabButtonHoverState.ForeColor = Color.White
        tabControl.TabButtonHoverState.InnerColor = Color.DarkGoldenrod
        tabControl.TabButtonIdleState.BorderColor = Color.Empty
        tabControl.TabButtonIdleState.FillColor = Color.Firebrick
        tabControl.TabButtonIdleState.Font = New Font("Montserrat SemiBold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabControl.TabButtonIdleState.ForeColor = Color.LightGray
        tabControl.TabButtonIdleState.InnerColor = Color.DarkGoldenrod
        tabControl.TabButtonSelectedState.BorderColor = Color.Transparent
        tabControl.TabButtonSelectedState.FillColor = Color.Firebrick
        tabControl.TabButtonSelectedState.Font = New Font("Montserrat SemiBold", 12.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabControl.TabButtonSelectedState.ForeColor = Color.White
        tabControl.TabButtonSelectedState.InnerColor = Color.Gold
        tabControl.TabButtonSize = New Size(200, 40)
        tabControl.TabButtonTextAlign = HorizontalAlignment.Left
        tabControl.TabIndex = 17
        tabControl.TabMenuBackColor = Color.Firebrick
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Transparent
        TabPage1.Controls.Add(flowpanelBurgers)
        TabPage1.Location = New Point(204, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(696, 721)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Burgers"
        ' 
        ' flowpanelBurgers
        ' 
        flowpanelBurgers.BackColor = Color.Transparent
        flowpanelBurgers.BackgroundImageLayout = ImageLayout.Zoom
        flowpanelBurgers.Location = New Point(3, 1)
        flowpanelBurgers.Name = "flowpanelBurgers"
        flowpanelBurgers.Size = New Size(691, 718)
        flowpanelBurgers.TabIndex = 1
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(flowpanelSides)
        TabPage2.Location = New Point(204, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(696, 721)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Sides"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' flowpanelSides
        ' 
        flowpanelSides.Location = New Point(3, 1)
        flowpanelSides.Name = "flowpanelSides"
        flowpanelSides.Size = New Size(691, 718)
        flowpanelSides.TabIndex = 1
        ' 
        ' TabPage3
        ' 
        TabPage3.BackgroundImageLayout = ImageLayout.Center
        TabPage3.Controls.Add(flowpanelDrinks)
        TabPage3.Location = New Point(204, 4)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(696, 721)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Drinks"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' flowpanelDrinks
        ' 
        flowpanelDrinks.Location = New Point(3, 3)
        flowpanelDrinks.Name = "flowpanelDrinks"
        flowpanelDrinks.Size = New Size(691, 718)
        flowpanelDrinks.TabIndex = 0
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(flowpanelCombos)
        TabPage4.Location = New Point(204, 4)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(696, 721)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Combos"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' flowpanelCombos
        ' 
        flowpanelCombos.Location = New Point(3, 1)
        flowpanelCombos.Name = "flowpanelCombos"
        flowpanelCombos.Size = New Size(691, 718)
        flowpanelCombos.TabIndex = 1
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(flowpanelSpecial)
        TabPage5.Location = New Point(204, 4)
        TabPage5.Name = "TabPage5"
        TabPage5.Size = New Size(696, 721)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Special"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' flowpanelSpecial
        ' 
        flowpanelSpecial.Location = New Point(3, 1)
        flowpanelSpecial.Name = "flowpanelSpecial"
        flowpanelSpecial.Size = New Size(691, 718)
        flowpanelSpecial.TabIndex = 2
        ' 
        ' testing
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1411, 727)
        Controls.Add(tabControl)
        Controls.Add(btnorder)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(reset)
        Controls.Add(Label1)
        Controls.Add(pembelian)
        Controls.Add(paymentbox)
        DoubleBuffered = True
        Name = "testing"
        StartPosition = FormStartPosition.CenterScreen
        Text = "testing"
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        tabControl.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        TabPage5.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents paymentbox As ComboBox
    Friend WithEvents pembelian As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lbltax As Label
    Friend WithEvents lblsubtotal As Label
    Friend WithEvents reset As Button
    Friend WithEvents labelsubtotal As Label
    Friend WithEvents labeltax As Label
    Friend WithEvents labeltotal As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnorder As Button
    Friend WithEvents tabControl As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents flowpanelDrinks As FlowLayoutPanel
    Friend WithEvents flowpanelBurgers As FlowLayoutPanel
    Friend WithEvents flowpanelSides As FlowLayoutPanel
    Friend WithEvents flowpanelCombos As FlowLayoutPanel
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents flowpanelSpecial As FlowLayoutPanel
End Class
