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
        lvStruk = New ListView()
        Item = New ColumnHeader()
        Qty = New ColumnHeader()
        Price = New ColumnHeader()
        Total = New ColumnHeader()
        lblSubtotal = New Label()
        lblTax = New Label()
        lblTotal = New Label()
        tblStruk = New TableLayoutPanel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        tblStruk.SuspendLayout()
        SuspendLayout()
        ' 
        ' lvStruk
        ' 
        lvStruk.BackColor = SystemColors.ButtonHighlight
        lvStruk.Columns.AddRange(New ColumnHeader() {Item, Qty, Price, Total})
        lvStruk.Font = New Font("Courier New", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lvStruk.Location = New Point(12, 84)
        lvStruk.Name = "lvStruk"
        lvStruk.Size = New Size(502, 146)
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
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(153, 0)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(114, 25)
        lblSubtotal.TabIndex = 1
        lblSubtotal.Text = "hasilSubtotal"
        lblSubtotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTax
        ' 
        lblTax.AutoSize = True
        lblTax.Location = New Point(153, 25)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(124, 25)
        lblTax.TabIndex = 2
        lblTax.Text = "hasilFanumTax"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(153, 50)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(84, 25)
        lblTotal.TabIndex = 3
        lblTotal.Text = "hasilTotal"
        ' 
        ' tblStruk
        ' 
        tblStruk.BackColor = Color.Transparent
        tblStruk.ColumnCount = 2
        tblStruk.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tblStruk.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tblStruk.Controls.Add(Label3, 0, 2)
        tblStruk.Controls.Add(Label2, 0, 1)
        tblStruk.Controls.Add(lblTax, 1, 1)
        tblStruk.Controls.Add(Label1, 0, 0)
        tblStruk.Controls.Add(lblTotal, 1, 2)
        tblStruk.Controls.Add(lblSubtotal, 1, 0)
        tblStruk.Location = New Point(12, 249)
        tblStruk.Name = "tblStruk"
        tblStruk.RowCount = 3
        tblStruk.RowStyles.Add(New RowStyle())
        tblStruk.RowStyles.Add(New RowStyle())
        tblStruk.RowStyles.Add(New RowStyle())
        tblStruk.Size = New Size(300, 76)
        tblStruk.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 25)
        Label3.TabIndex = 7
        Label3.Text = "Total :"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 25)
        Label2.TabIndex = 6
        Label2.Text = "Tax :"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 25)
        Label1.TabIndex = 5
        Label1.Text = "SubTotal :"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' formStruk
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(526, 450)
        Controls.Add(tblStruk)
        Controls.Add(lvStruk)
        Name = "formStruk"
        Text = "formStruk"
        tblStruk.ResumeLayout(False)
        tblStruk.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lvStruk As ListView
    Friend WithEvents Item As ColumnHeader
    Friend WithEvents Qty As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Total As ColumnHeader
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents tblStruk As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
