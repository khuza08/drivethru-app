<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnOrder = New Button()
        btnLogin = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' btnOrder
        ' 
        btnOrder.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnOrder.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnOrder.Location = New Point(84, 186)
        btnOrder.Name = "btnOrder"
        btnOrder.Size = New Size(128, 76)
        btnOrder.TabIndex = 0
        btnOrder.Text = "Order Here"
        btnOrder.UseCompatibleTextRendering = True
        btnOrder.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnLogin.Location = New Point(216, 403)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(71, 35)
        btnLogin.TabIndex = 1
        btnLogin.Text = "login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.Location = New Point(12, 404)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 2
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(299, 450)
        Controls.Add(Button1)
        Controls.Add(btnLogin)
        Controls.Add(btnOrder)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnOrder As Button
    Friend WithEvents btnLogin As Button

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        formOrder.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Friend WithEvents Button1 As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        testing.Show()
    End Sub
End Class
