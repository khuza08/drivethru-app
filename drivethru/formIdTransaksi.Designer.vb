<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formIdTransaksi
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        btnEnter = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.Location = New Point(12, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(247, 33)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "Masukkan ID Transaksi"
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Guna2TextBox1.CustomizableEdges = CustomizableEdges1
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2TextBox1.ForeColor = Color.Black
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(14, 53)
        Guna2TextBox1.Margin = New Padding(4, 5, 4, 5)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2TextBox1.Size = New Size(243, 38)
        Guna2TextBox1.TabIndex = 1
        ' 
        ' btnEnter
        ' 
        btnEnter.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnEnter.AutoRoundedCorners = True
        btnEnter.CustomizableEdges = CustomizableEdges3
        btnEnter.DisabledState.BorderColor = Color.DarkGray
        btnEnter.DisabledState.CustomBorderColor = Color.DarkGray
        btnEnter.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEnter.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEnter.FillColor = Color.DarkGray
        btnEnter.Font = New Font("Segoe UI", 9F)
        btnEnter.ForeColor = Color.White
        btnEnter.Location = New Point(13, 113)
        btnEnter.Name = "btnEnter"
        btnEnter.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnEnter.Size = New Size(245, 48)
        btnEnter.TabIndex = 2
        btnEnter.Text = "ENTER"
        ' 
        ' formIdTransaksi
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(271, 178)
        Controls.Add(btnEnter)
        Controls.Add(Guna2TextBox1)
        Controls.Add(Guna2HtmlLabel1)
        Name = "formIdTransaksi"
        Text = "formIdTransaksi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnEnter As Guna.UI2.WinForms.Guna2Button
End Class
