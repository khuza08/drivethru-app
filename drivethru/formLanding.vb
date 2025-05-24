Imports System.Drawing.Drawing2D

Public Class Form1

    Private dragging As Boolean = False
    Private offset As Point

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  form tanpa border & fixed size
        Me.FormBorderStyle = FormBorderStyle.None
        Me.ControlBox = False
        Me.MaximizeBox = False

        ' rounded corner
        Dim radius As Integer = 30
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        Me.Region = New Region(path)
    End Sub

    ' drag / move logic
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            dragging = True
            offset = e.Location
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If dragging Then
            Me.Location = New Point(Me.Location.X + e.X - offset.X, Me.Location.Y + e.Y - offset.Y)
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        dragging = False
    End Sub

    ' button action
    Private Sub btnPreorder_Click(sender As Object, e As EventArgs) Handles btnPreorder.Click
        testing.Show()
        btnPreorder.BringToFront()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Guna2PictureBox1.SendToBack()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
        ' note: Process.Kill () ga ku rekomendasiin kecuali kalo bener" perlu
        ' itu force close tappi masih ada cachenya, kalo aplikasi hang bisa pake
        ' Process.GetCurrentProcess ().Kill()
    End Sub

End Class
