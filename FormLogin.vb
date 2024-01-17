Imports MySql.Data.MySqlClient

Public Class FormLogin
    Dim conn As New MySqlConnection("server=localhost; port=3306; username=root; password=; database=sales_db")
    Dim dr As MySqlDataReader

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            conn.Open()
            Dim user As User = GetUser(txtUser.Text, txtPass.Text)

            If user IsNot Nothing Then
                txtPass.Clear()
                txtUser.Clear()
                Me.Hide()

                If UCase(user.Role) = "ADMIN" Then
                    FormMain.CurrentUser = user
                    'FormPenjualan.CurrentUser = user
                    FormMain.Show()
                ElseIf UCase(user.Role) = "KASIR" Then
                    FormMain.CurrentUser = user
                    FormPOS.CurrentUser = user
                    FormMain.Show()
                End If
            Else
                MsgBox("username atau password salah!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function GetUser(username As String, password As String) As User
        Dim user As User = Nothing
        Try
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_users WHERE username = @username AND password = @password", conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                user = New User() With {
                        .Username = dr.Item("username").ToString(),
                        .Password = dr.Item("password").ToString(),
                        .Role = dr.Item("role").ToString(),
                        .Nama = dr.Item("nama").ToString()
                    }
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        Return user
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Apakah kamu ingin keluar dari Aplikasi?", MsgBoxStyle.Question + vbYesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the Enter key to prevent it from being processed by other controls
            btnLogin_Click(sender, e) ' Call the btnLogin_Click method
        End If
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the Enter key to prevent it from being processed by other controls
            btnLogin_Click(sender, e) ' Call the btnLogin_Click method
        End If
    End Sub
End Class

Public Class User
    Public Property Username As String
    Public Property Password As String
    Public Property Role As String
    Public Property Nama As String
End Class