<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Label2 = New Label()
        login = New Guna.UI2.WinForms.Guna2Button()
        loginBack = New Guna.UI2.WinForms.Guna2Button()
        tbuser = New Guna.UI2.WinForms.Guna2TextBox()
        tbpw = New Guna.UI2.WinForms.Guna2TextBox()
        animation = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(24, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(24, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 25)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' login
        ' 
        login.BorderRadius = 10
        login.CustomizableEdges = CustomizableEdges1
        login.DisabledState.BorderColor = Color.DarkGray
        login.DisabledState.CustomBorderColor = Color.DarkGray
        login.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        login.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        login.FillColor = Color.Gold
        login.Font = New Font("Montserrat SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        login.ForeColor = Color.Black
        login.Location = New Point(8, 246)
        login.Name = "login"
        login.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        login.Size = New Size(110, 32)
        login.TabIndex = 6
        login.Text = "Login"
        ' 
        ' loginBack
        ' 
        loginBack.BorderRadius = 10
        loginBack.CustomizableEdges = CustomizableEdges3
        loginBack.DisabledState.BorderColor = Color.DarkGray
        loginBack.DisabledState.CustomBorderColor = Color.DarkGray
        loginBack.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        loginBack.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        loginBack.FillColor = Color.Gold
        loginBack.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loginBack.ForeColor = Color.Black
        loginBack.Location = New Point(240, 246)
        loginBack.Name = "loginBack"
        loginBack.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        loginBack.Size = New Size(110, 32)
        loginBack.TabIndex = 7
        loginBack.Text = "Back"
        ' 
        ' tbuser
        ' 
        tbuser.BorderRadius = 10
        tbuser.CustomizableEdges = CustomizableEdges5
        tbuser.DefaultText = ""
        tbuser.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbuser.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbuser.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbuser.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbuser.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbuser.Font = New Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbuser.ForeColor = Color.Black
        tbuser.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbuser.Location = New Point(29, 55)
        tbuser.Margin = New Padding(5, 6, 5, 6)
        tbuser.Name = "tbuser"
        tbuser.PlaceholderForeColor = Color.Black
        tbuser.PlaceholderText = ""
        tbuser.SelectedText = ""
        tbuser.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        tbuser.Size = New Size(296, 32)
        tbuser.TabIndex = 8
        ' 
        ' tbpw
        ' 
        tbpw.Animated = True
        tbpw.BorderRadius = 10
        tbpw.CustomizableEdges = CustomizableEdges7
        tbpw.DefaultText = ""
        tbpw.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbpw.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbpw.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbpw.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbpw.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbpw.Font = New Font("Segoe UI", 9F)
        tbpw.ForeColor = Color.Black
        tbpw.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbpw.Location = New Point(29, 154)
        tbpw.Margin = New Padding(4, 5, 4, 5)
        tbpw.Name = "tbpw"
        tbpw.PasswordChar = "⭐"c
        tbpw.PlaceholderForeColor = Color.Black
        tbpw.PlaceholderText = ""
        tbpw.SelectedText = ""
        tbpw.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        tbpw.Size = New Size(296, 32)
        tbpw.TabIndex = 9
        ' 
        ' animation
        ' 
        animation.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE
        animation.Interval = 5000
        animation.TargetForm = Me
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        ClientSize = New Size(357, 288)
        Controls.Add(tbpw)
        Controls.Add(tbuser)
        Controls.Add(loginBack)
        Controls.Add(login)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Portal"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents loginBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbuser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbpw As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents animation As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
