Public Class formOrder

    Dim menuData As New Dictionary(Of String, List(Of MenuItem)) From {
    {"Burgers", New List(Of MenuItem) From {
        New MenuItem With {.Name = "Cheeseburger", .Price = 3.5D, .ImagePath = "images\cheeseburger.jpg"},
        New MenuItem With {.Name = "Double Beef", .Price = 5D, .ImagePath = "images\doublebeef.jpg"}
    }},
    {"Sides", New List(Of MenuItem) From {
        New MenuItem With {.Name = "French Fries", .Price = 2D, .ImagePath = "images\fries.jpg"},
        New MenuItem With {.Name = "Onion Rings", .Price = 2.5D, .ImagePath = "images\onionrings.jpg"}
    }}
}
    Private Sub ShowMenuItems(category As String)
        FlowLayoutPanel1.Controls.Clear()

        If menuData.ContainsKey(category) Then
            For Each item In menuData(category)
                Dim panel As New Panel With {.Width = 200, .Height = 150, .BorderStyle = BorderStyle.FixedSingle}

                Dim pic As New PictureBox With {
                .Image = Image.FromFile(item.ImagePath),
                .SizeMode = PictureBoxSizeMode.StretchImage,
                .Size = New Size(80, 80),
                .Location = New Point(10, 10)
            }

                Dim lblName As New Label With {
                .Text = item.Name,
                .Location = New Point(100, 10),
                .AutoSize = True
            }

                Dim lblPrice As New Label With {
                .Text = "Rp" & item.Price.ToString("N0"),
                .Location = New Point(100, 40),
                .AutoSize = True
            }

                panel.Controls.Add(pic)
                panel.Controls.Add(lblName)
                panel.Controls.Add(lblPrice)

                FlowLayoutPanel1.Controls.Add(panel)
            Next
        End If
    End Sub

    Private Sub formOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        receiptForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class

