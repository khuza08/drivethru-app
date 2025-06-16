Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private dragging As Boolean = False
    Private offset As Point

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.ControlBox = False
        Me.MaximizeBox = False
        Me.AcceptButton = login

        ' buat rounded corner ui
        Dim radius As Integer = 30
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Me.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Me.Width - radius, Me.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Me.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        Me.Region = New Region(path)

        tbpw.UseSystemPasswordChar = True
    End Sub

    Private Sub loginBack_Click(sender As Object, e As EventArgs) Handles loginBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        If tbuser.Text = "" OrElse tbpw.Text = "" Then
            MessageBox.Show("Isi semua field login!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim db As New database()
        If db.Login(tbuser.Text, tbpw.Text) Then
            session.KasirUsername = tbuser.Text
            session.KasirNama = db.Nama

            Select Case db.Userlevel
                Case "admin"
                    MessageBox.Show("Login Berhasil.")
                    adminpanel.Show()
                    tbuser.Text = ""
                    tbpw.Text = ""
                Case "kasir"
                    MessageBox.Show("Login Sukses.")
                    bridge.Show()
                    tbuser.Text = ""
                    tbpw.Text = ""
                Case Else
                    MessageBox.Show("Level user tidak dikenali.")
                    Exit Sub
            End Select
            Me.Hide()
        Else
            MessageBox.Show("Username atau password salah.")
        End If
    End Sub

    ' drag logic
    Private Sub FormLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            dragging = True
            offset = e.Location
        End If
    End Sub

    Private Sub FormLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If dragging Then
            Me.Location = New Point(Me.Location.X + e.X - offset.X, Me.Location.Y + e.Y - offset.Y)
        End If
    End Sub

    Private Sub FormLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        dragging = False
    End Sub

End Class
