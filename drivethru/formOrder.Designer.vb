<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formOrder
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
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Controls.Add(GroupBox1)
        Panel1.Location = New Point(538, -9)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(438, 519)
        Panel1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Location = New Point(13, 396)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(408, 104)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(6, 61)
        Button2.Name = "Button2"
        Button2.Size = New Size(396, 34)
        Button2.TabIndex = 1
        Button2.Text = "Order Now"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(6, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(396, 34)
        Button1.TabIndex = 0
        Button1.Text = "Reset Order"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(12, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 1
        Button3.Text = "Burgers"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(130, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 2
        Button4.Text = "Sides"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(12, 52)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(505, 439)
        FlowLayoutPanel1.TabIndex = 3
        ' 
        ' formOrder
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(971, 503)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "formOrder"
        Text = "formOrder"
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
