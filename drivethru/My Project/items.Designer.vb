<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class items
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        lblHargaProduk = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblNamaProduk = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pbItems = New PictureBox()
        Guna2ShadowPanel1.SuspendLayout()
        CType(pbItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        Guna2ShadowPanel1.Controls.Add(lblHargaProduk)
        Guna2ShadowPanel1.Controls.Add(lblNamaProduk)
        Guna2ShadowPanel1.Controls.Add(pbItems)
        Guna2ShadowPanel1.FillColor = Color.White
        Guna2ShadowPanel1.Location = New Point(3, 3)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.Radius = 10
        Guna2ShadowPanel1.ShadowColor = Color.Black
        Guna2ShadowPanel1.Size = New Size(288, 280)
        Guna2ShadowPanel1.TabIndex = 0
        ' 
        ' lblHargaProduk
        ' 
        lblHargaProduk.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lblHargaProduk.BackColor = Color.Transparent
        lblHargaProduk.Font = New Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHargaProduk.Location = New Point(179, 240)
        lblHargaProduk.Name = "lblHargaProduk"
        lblHargaProduk.Size = New Size(92, 33)
        lblHargaProduk.TabIndex = 2
        lblHargaProduk.Text = "Rp15.000"
        lblHargaProduk.TextAlignment = ContentAlignment.MiddleRight
        ' 
        ' lblNamaProduk
        ' 
        lblNamaProduk.AutoSize = False
        lblNamaProduk.AutoSizeHeightOnly = True
        lblNamaProduk.BackColor = Color.Transparent
        lblNamaProduk.Font = New Font("Montserrat SemiBold", 10F, FontStyle.Bold)
        lblNamaProduk.Location = New Point(15, 12)
        lblNamaProduk.Name = "lblNamaProduk"
        lblNamaProduk.Size = New Size(256, 32)
        lblNamaProduk.TabIndex = 1
        lblNamaProduk.Text = "Cheese Burger"
        ' 
        ' pbItems
        ' 
        pbItems.BackgroundImageLayout = ImageLayout.Zoom
        pbItems.Location = New Point(3, 0)
        pbItems.Name = "pbItems"
        pbItems.Size = New Size(282, 277)
        pbItems.TabIndex = 0
        pbItems.TabStop = False
        ' 
        ' items
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Guna2ShadowPanel1)
        Name = "items"
        Size = New Size(294, 286)
        Guna2ShadowPanel1.ResumeLayout(False)
        Guna2ShadowPanel1.PerformLayout()
        CType(pbItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents pbItems As PictureBox
    Friend WithEvents lblHargaProduk As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblNamaProduk As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
