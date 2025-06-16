<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bridge
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
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        btnLaporan = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 15
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Gold
        Guna2Button1.Font = New Font("Arial", 11F, FontStyle.Bold)
        Guna2Button1.ForeColor = Color.Black
        Guna2Button1.Location = New Point(12, 12)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(284, 68)
        Guna2Button1.TabIndex = 0
        Guna2Button1.Text = "ID Transaksi"
        ' 
        ' btnLaporan
        ' 
        btnLaporan.BorderRadius = 15
        btnLaporan.CustomizableEdges = CustomizableEdges3
        btnLaporan.DisabledState.BorderColor = Color.DarkGray
        btnLaporan.DisabledState.CustomBorderColor = Color.DarkGray
        btnLaporan.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLaporan.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLaporan.FillColor = Color.Gold
        btnLaporan.Font = New Font("Arial", 11F, FontStyle.Bold)
        btnLaporan.ForeColor = Color.Black
        btnLaporan.Location = New Point(12, 95)
        btnLaporan.Name = "btnLaporan"
        btnLaporan.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnLaporan.Size = New Size(284, 68)
        btnLaporan.TabIndex = 1
        btnLaporan.Text = "Laporan"
        ' 
        ' bridge
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        ClientSize = New Size(308, 177)
        Controls.Add(btnLaporan)
        Controls.Add(Guna2Button1)
        Name = "bridge"
        Text = "bridge"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLaporan As Guna.UI2.WinForms.Guna2Button
End Class
