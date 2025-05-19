<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label2 = New Label()
        btnPreorder = New Guna.UI2.WinForms.Guna2Button()
        btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        btnClose = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Montserrat Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(40, 304)
        Label2.Name = "Label2"
        Label2.Size = New Size(229, 28)
        Label2.TabIndex = 4
        Label2.Text = "Ambafood Restaurant"
        ' 
        ' btnPreorder
        ' 
        btnPreorder.AutoRoundedCorners = True
        btnPreorder.BackColor = Color.Transparent
        btnPreorder.CustomizableEdges = CustomizableEdges1
        btnPreorder.DisabledState.BorderColor = Color.DarkGray
        btnPreorder.DisabledState.CustomBorderColor = Color.DarkGray
        btnPreorder.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnPreorder.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnPreorder.FillColor = Color.Gold
        btnPreorder.Font = New Font("Montserrat SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPreorder.ForeColor = Color.Black
        btnPreorder.Location = New Point(24, 224)
        btnPreorder.Name = "btnPreorder"
        btnPreorder.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnPreorder.Size = New Size(270, 68)
        btnPreorder.TabIndex = 5
        btnPreorder.Text = "Order Here"
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnLogin.BackColor = Color.Transparent
        btnLogin.BorderRadius = 10
        btnLogin.CustomizableEdges = CustomizableEdges3
        btnLogin.DisabledState.BorderColor = Color.DarkGray
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogin.FillColor = Color.Gold
        btnLogin.Font = New Font("Montserrat SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.Black
        btnLogin.Location = New Point(216, 408)
        btnLogin.Name = "btnLogin"
        btnLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnLogin.Size = New Size(108, 38)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Login"
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.BackColor = Color.Transparent
        Guna2PictureBox1.BackgroundImage = CType(resources.GetObject("Guna2PictureBox1.BackgroundImage"), Image)
        Guna2PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges5
        Guna2PictureBox1.FillColor = Color.Transparent
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(48, 32)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2PictureBox1.Size = New Size(256, 256)
        Guna2PictureBox1.TabIndex = 7
        Guna2PictureBox1.TabStop = False
        Guna2PictureBox1.UseTransparentBackground = True
        ' 
        ' btnClose
        ' 
        btnClose.DisabledState.BorderColor = Color.DarkGray
        btnClose.DisabledState.CustomBorderColor = Color.DarkGray
        btnClose.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnClose.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnClose.FillColor = Color.Gold
        btnClose.Font = New Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Black
        btnClose.Location = New Point(291, 3)
        btnClose.Name = "btnClose"
        btnClose.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btnClose.Size = New Size(32, 32)
        btnClose.TabIndex = 8
        btnClose.Text = "X"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        ClientSize = New Size(326, 450)
        ControlBox = False
        Controls.Add(btnClose)
        Controls.Add(Guna2PictureBox1)
        Controls.Add(btnLogin)
        Controls.Add(btnPreorder)
        Controls.Add(Label2)
        ForeColor = SystemColors.ControlText
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPreorder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2CircleButton
End Class
