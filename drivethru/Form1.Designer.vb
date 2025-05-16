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
        SuspendLayout()
        ' 
        ' btnOrder
        ' 
        btnOrder.Location = New Point(66, 182)
        btnOrder.Name = "btnOrder"
        btnOrder.Size = New Size(151, 68)
        btnOrder.TabIndex = 0
        btnOrder.Text = "Order Here"
        btnOrder.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(216, 403)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(71, 35)
        btnLogin.TabIndex = 1
        btnLogin.Text = "login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(299, 450)
        Controls.Add(btnLogin)
        Controls.Add(btnOrder)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form1"
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
        formLogin.Show()
        Me.Hide()
    End Sub
End Class
