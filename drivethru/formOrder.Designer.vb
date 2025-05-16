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
        btnBurgers = New Button()
        btnSides = New Button()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
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
        ' btnBurgers
        ' 
        btnBurgers.Location = New Point(12, 12)
        btnBurgers.Name = "btnBurgers"
        btnBurgers.Size = New Size(112, 34)
        btnBurgers.TabIndex = 1
        btnBurgers.Text = "Burgers"
        btnBurgers.UseVisualStyleBackColor = True
        ' 
        ' btnSides
        ' 
        btnSides.Location = New Point(130, 12)
        btnSides.Name = "btnSides"
        btnSides.Size = New Size(112, 34)
        btnSides.TabIndex = 2
        btnSides.Text = "Sides"
        btnSides.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.doublebeef
        PictureBox2.Location = New Point(141, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(128, 128)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cheeseburger
        PictureBox1.Location = New Point(5, 5)
        PictureBox1.Margin = New Padding(5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(128, 128)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(PictureBox2)
        FlowLayoutPanel1.Location = New Point(12, 52)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(503, 439)
        FlowLayoutPanel1.TabIndex = 3
        ' 
        ' formOrder
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(971, 503)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(btnSides)
        Controls.Add(btnBurgers)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "formOrder"
        Text = "formOrder"
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnBurgers As Button
    Friend WithEvents btnSides As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
