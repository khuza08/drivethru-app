Public Class testing
    Private Sub testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPage1.Text = "Burgers"
        TabPage2.Text = "Sides"
        TabPage3.Text = "Drinks"
        TabPage4.Text = "Combos"
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        ' Panel sebagai container
        Panel1.AutoScroll = True
        Panel1.Dock = DockStyle.Fill
        Panel1.Padding = New Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0) ' agar scrollbar tidak menutupi isi

        ' TableLayoutPanel di dalam Panel
        TableLayoutPanel1.AutoSize = False
        TableLayoutPanel1.Dock = DockStyle.Top ' atau Fill jika ingin memenuhi panel
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddRows



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class