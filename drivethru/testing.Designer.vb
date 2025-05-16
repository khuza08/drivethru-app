<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testing
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        TabPage4 = New TabPage()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Location = New Point(12, 11)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(400, 435)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.AutoScroll = True
        TabPage1.CausesValidation = False
        TabPage1.Controls.Add(Panel1)
        TabPage1.Cursor = Cursors.IBeam
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(392, 397)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(392, 397)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 34)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(392, 397)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 34)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(392, 397)
        TabPage4.TabIndex = 3
        TabPage4.Text = "TabPage4"
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Location = New Point(6, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(380, 385)
        Panel1.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.Size = New Size(347, 807)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' testing
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(927, 450)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "testing"
        StartPosition = FormStartPosition.CenterScreen
        Text = "testing"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
