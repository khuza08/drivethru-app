Imports MySql.Data.MySqlClient
Public Class FormLogin

    Private Sub loginBack_Click_1(sender As Object, e As EventArgs) Handles loginBack.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub tbpw_TextChanged(sender As Object, e As EventArgs)
        tbpw.UseSystemPasswordChar = True

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim db As New database()
        If db.Login(tbuser.Text, tbpw.Text) Then
            If db.Userlevel = "admin" Then
                adminpanel.Show()
            ElseIf db.Userlevel = "kasir" Then
                formIdTransaksi.Show()
            Else
                MessageBox.Show("Level user tidak dikenali.")
                Exit Sub
            End If
            Me.Hide()
        Else
            MessageBox.Show("Username atau password salah.")
        End If
    End Sub

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.AcceptButton = login

    End Sub

    Private dragging As Boolean = False
    Private offset As Point

    Private Sub formLoad_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            dragging = True
            offset = e.Location
        End If
    End Sub

    Private Sub formLoad_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If dragging Then
            Me.Location = New Point(Me.Location.X + e.X - offset.X, Me.Location.Y + e.Y - offset.Y)
        End If
    End Sub

    Private Sub formLoad_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        dragging = False
    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        ' Hilangkan border dan control box
        Me.FormBorderStyle = FormBorderStyle.None
        Me.ControlBox = False

        ' Atur ukuran form
        ' Me.Size = New Size(400, 600) ' lebar > panjang

        ' Buat rounded corners (radius 30)
        Dim radius As Integer = 30
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        Me.Region = New Region(path)
    End Sub

End Class