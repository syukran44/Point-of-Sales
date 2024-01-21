Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FormMember

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

    Private Sub FormMember_Loaded(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeFormMember()
    End Sub

    Public Sub InitializeFormMember()
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
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_member", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim poin As Integer = dr.Item("poin")
                Dim status As String
                If poin >= 1000 And poin < 3000 Then
                    status = "Regular"
                ElseIf poin >= 3000 And poin < 6000 Then
                    status = "Gold"
                ElseIf poin >= 6000 And poin < 10000 Then
                    status = "Platinum"
                ElseIf poin >= 10000 Then
                    status = "Diamond"
                Else
                    status = "New"
                End If
                DataGridView1.Rows.Add(index, dr.Item("kode_member"), dr.Item("nama"), poin, status, dr.Item("created_at"), dr.Item("masa_aktif"))
                index += 1
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            If DateTimePicker1.Value < DateTime.Now Then
                MsgBox("Tanggal tidak boleh lebih awal dari hari ini")
                Return
            End If
            conn.Open()

            'Cek kode member
            Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_member WHERE kode_member = @kode_member", conn)
                checkCmd.Parameters.AddWithValue("@kode_member", txtKodeMember.Text)
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count > 0 Then
                    MsgBox("Kode Member sudah ada. Masukkan kode yang lain")
                    Return
                End If
            End Using

            Dim cmd As New MySqlCommand("INSERT INTO `tbl_member`(`kode_member`, `nama`, `poin`, `masa_aktif`) VALUES (@kode_member, @nama, @poin, @masa_aktif)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@kode_member", txtKodeMember.Text)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@poin", CInt(txtPoin.Text))
            cmd.Parameters.AddWithValue("@masa_aktif", DateTimePicker1.Value)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Data Berhasil di Tambahkan!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data Gagal di Tambahkan!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            DGVRead()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        clear()
        DataGridView1.Rows.Clear()
        Try
            Dim index As Integer = 1
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_member WHERE `kode_member` like '%" & txtSearch.Text & "%' OR `nama` like '%" & txtSearch.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim poin As Integer = dr.Item("poin")
                Dim status As String
                If poin >= 1000 Then
                    status = "Regular"
                ElseIf poin >= 3000 Then
                    status = "Gold"
                ElseIf poin >= 6000 Then
                    status = "Platinum"
                ElseIf poin >= 10000 Then
                    status = "Diamond"
                Else
                    status = "New"
                End If
                DataGridView1.Rows.Add(index, dr.Item("kode_member"), dr.Item("nama"), poin, status, dr.Item("created_at"), dr.Item("masa_aktif"))
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
        txtKodeMember.Clear()
        txtNama.Clear()
        txtPoin.Clear()

        DGVRead()
        txtKodeMember.ReadOnly = False
        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If DateTimePicker1.Value < DateTime.Now Then
                MsgBox("Tanggal tidak boleh lebih awal dari hari ini")
                Return
            End If

            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `tbl_member` SET `kode_member`= @kode_member, `nama`= @nama, `poin`= @poin, `masa_aktif`= @masa_aktif WHERE `kode_member` = @kode_member", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@kode_member", txtKodeMember.Text)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@poin", CInt(txtPoin.Text))
            cmd.Parameters.AddWithValue("@masa_aktif", DateTimePicker1.Value)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Data Berhasil di Edit!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data Gagal di Edit!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            clear()
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("delete FROM `tbl_member` WHERE `kode_member` = @kode_member", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@kode_member", txtKodeMember.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Data berhasil di Hapus!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data gagal di Hapus!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            clear()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtKodeMember.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtNama.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtPoin.Text = DataGridView1.CurrentRow.Cells(3).Value
        DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(6).Value

        txtKodeMember.ReadOnly = True
        btnTambah.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub


    'Proteksi Angka---------------------------------------------------------------------------------------
    Private Sub txtPoin_TextChanged(sender As Object, e As EventArgs) Handles txtPoin.TextChanged
        If Not IsNumeric(txtPoin.Text) And Not txtPoin.Text = "" Then
            MsgBox("Masukkan Jumlah yang benar")
            txtPoin.Text = 0
        End If
    End Sub

    Private Sub txtPoin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPoin.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class