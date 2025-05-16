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
        loginBack = New Button()
        login = New Button()
        Label1 = New Label()
        Label2 = New Label()
        tbuser = New TextBox()
        tbpw = New TextBox()
        SuspendLayout()
        ' 
        ' loginBack
        ' 
        loginBack.Location = New Point(209, 286)
        loginBack.Name = "loginBack"
        loginBack.Size = New Size(112, 34)
        loginBack.TabIndex = 0
        loginBack.Text = "Back"
        loginBack.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        login.Location = New Point(24, 286)
        login.Name = "login"
        login.Size = New Size(112, 34)
        login.TabIndex = 1
        login.Text = "Login"
        login.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 25)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 166)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' tbuser
        ' 
        tbuser.Location = New Point(24, 94)
        tbuser.Name = "tbuser"
        tbuser.Size = New Size(297, 31)
        tbuser.TabIndex = 4
        ' 
        ' tbpw
        ' 
        tbpw.Location = New Point(24, 194)
        tbpw.Name = "tbpw"
        tbpw.Size = New Size(297, 31)
        tbpw.TabIndex = 5
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(357, 330)
        Controls.Add(tbpw)
        Controls.Add(tbuser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(login)
        Controls.Add(loginBack)
        Name = "FormLogin"
        Text = "Login Portal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents loginBack As Button
    Friend WithEvents login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbuser As TextBox
    Friend WithEvents tbpw As TextBox
End Class
