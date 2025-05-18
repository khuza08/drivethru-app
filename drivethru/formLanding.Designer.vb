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
        btnLogin = New Button()
        btnPreorder = New Button()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(293, 404)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 0
        btnLogin.Text = "login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnPreorder
        ' 
        btnPreorder.Location = New Point(134, 208)
        btnPreorder.Name = "btnPreorder"
        btnPreorder.Size = New Size(112, 34)
        btnPreorder.TabIndex = 1
        btnPreorder.Text = "Order Here"
        btnPreorder.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(417, 450)
        Controls.Add(btnPreorder)
        Controls.Add(btnLogin)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnPreorder As Button
End Class
