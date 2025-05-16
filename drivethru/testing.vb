Public Class testing
    Private Sub testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPage1.Text = "Burgers"
        TabPage2.Text = "Sides"
        TabPage3.Text = "Drinks"
        TabPage4.Text = "Combos"


        ' panel as container
        Panel1.AutoScroll = True
        Panel1.Dock = DockStyle.Fill
        Panel1.Padding = New Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0) ' agar scrollbar tidak menutupi isi

        ' TableLayoutPanel di dalam Panel
        TableLayoutPanel1.AutoSize = False
        TableLayoutPanel1.Dock = DockStyle.Top ' atau Fill jika ingin memenuhi panel
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddRows

        ListView1.View = View.Details
        ListView1.Columns.Add("Item", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Qty", 50, HorizontalAlignment.Center)
        ListView1.Columns.Add("Price", 70, HorizontalAlignment.Right)
        ListView1.Columns.Add("Total", 70, HorizontalAlignment.Right)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class