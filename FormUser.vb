Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FormUser

    Private _currentUser As User

    Public Property CurrentUser As User
        Get
            Return _currentUser
        End Get
        Set(value As User)
            _currentUser = value
        End Set
    End Property

    Dim conn As New MySqlConnection("server=localhost; port=3306; username=root; password=; database=sales_db")
    Dim i As Integer = 0
    Dim dr As MySqlDataReader

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function HashPassword(password As String) As String
        Using sha256 As New SHA256Managed()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower()
        End Using
    End Function

    Public Sub InitializeFormUser()
        conn.Close()
        DGVRead()
        btnHapus.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Public Sub DGVRead()
        DataGridView1.Rows.Clear()
        Try
            Dim index As Integer = 1
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_users", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(index, dr.Item("username"), dr.Item("nama"), dr.Item("role"))
                index += 1
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub clear()
        txtUsername.Clear()
        txtNama.Clear()
        txtPassword.Clear()

        DGVRead()
        txtUsername.ReadOnly = False
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnEye_Click(sender As Object, e As EventArgs) Handles btnEye.Click
        If txtPassword.PasswordChar = ControlChars.NullChar Then
            txtPassword.PasswordChar = "*"
        Else
            txtPassword.PasswordChar = ControlChars.NullChar
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            conn.Open()

            'Cek Username
            Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_users WHERE username = @username", conn)
                checkCmd.Parameters.AddWithValue("@username", txtUsername.Text)
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count > 0 Then
                    MsgBox("Username sudah ada. Masukkan username yang lain")
                    Return
                End If
            End Using

            ' Enkripsi password sebelum disimpan
            Dim hashedPassword As String = HashPassword(txtPassword.Text)

            Dim cmd As New MySqlCommand("INSERT INTO `tbl_users`(`username`, `password`, `role`, `nama`) VALUES (@username, @password, @role, @nama)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", hashedPassword)
            cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("User Berhasil di Buat!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("User Gagal di Buat!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            clear()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim username As String = DataGridView1.CurrentRow.Cells(1).Value
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_users WHERE username = @username", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", username)
            dr = cmd.ExecuteReader
            If dr.Read Then
                txtUsername.Text = dr.Item("username")
                txtNama.Text = dr.Item("nama")
                cmbRole.SelectedItem = dr.Item("role")
            End If
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        txtPassword.PasswordChar = "*"
        txtUsername.ReadOnly = True
        btnTambah.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("delete FROM `tbl_users` WHERE `username` = @username", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("User berhasil di Hapus!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("User gagal di Hapus!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            clear()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            conn.Open()

            Dim hashedPassword As String = HashPassword(txtPassword.Text)
            Dim cmd As New MySqlCommand("UPDATE `tbl_users` SET `username`= @username, `password`= @password, `role` = @role, `nama`= @nama WHERE `username` = @username", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", hashedPassword)
            cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("User Berhasil di Edit!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("User Gagal di Edit!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            clear()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim index As Integer = 0
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_users WHERE `username` LIKE '%" & txtSearch.Text & "%' OR `nama` LIKE '%" & txtSearch.Text & "%' OR `role` LIKE '%" & txtSearch.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                index += 1
                DataGridView1.Rows.Add(index, dr.Item("username"), dr.Item("nama"), dr.Item("role"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class