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
    Dim defaultLblLocation As Point
    Dim defaultDateLocation As Point

    Private Sub FormMember_Loaded(sender As Object, e As EventArgs) Handles MyBase.Load
        defaultLblLocation = lblMasaAktif.Location
        defaultDateLocation = DateTimePicker1.Location
        InitializeFormMember()
    End Sub

    Public Sub InitializeFormMember()
        conn.Close()
        DGVRead("SELECT * FROM tbl_member")
        btnHapus.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Public Sub DGVRead(query)
        DataGridView1.Rows.Clear()
        Try
            Dim index As Integer = 1
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim poin As Integer = dr.Item("poin")
                Dim grade As String
                Dim status As String = "Aktif"
                If poin >= 1000 And poin < 3000 Then
                    grade = "Regular"
                ElseIf poin >= 3000 And poin < 6000 Then
                    grade = "Gold"
                ElseIf poin >= 6000 And poin < 10000 Then
                    grade = "Platinum"
                ElseIf poin >= 10000 Then
                    grade = "Diamond"
                Else
                    grade = "New"
                End If

                If dr.Item("masa_aktif") < DateTime.Now Then
                    status = "Tidak Aktif"
                End If

                DataGridView1.Rows.Add(index, dr.Item("kode_member"), dr.Item("nama"), Format(poin, "##,##0"), grade, DirectCast(dr.Item("created_at"), DateTime).ToString("dd-MM-yyyy"), DirectCast(dr.Item("masa_aktif"), DateTime).ToString("dd-MM-yyyy"), status)
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
        clear()
        btnTambah.Visible = False
        btnHapus.Visible = False
        btnClear.Visible = False
        btnEdit.Visible = False
        lblPoin.Visible = False
        txtPoin.Visible = False

        btnGenerate.Visible = True
        btnBatal.Visible = True
        btnSimpanTambah.Visible = True
        DateTimePicker1.Enabled = True

        btnSimpanTambah.Location = btnTambah.Location
        btnBatal.Location = btnEdit.Location

        lblMasaAktif.Location = lblPoin.Location
        DateTimePicker1.Location = txtPoin.Location
        DateTimePicker1.Value = DateTime.Now

        txtNama.ReadOnly = False
        txtPoin.ReadOnly = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnTambah.Visible = False
        btnHapus.Visible = False
        btnClear.Visible = False
        btnEdit.Visible = False

        btnBatal.Visible = True
        btnSimpanEdit.Visible = True
        DateTimePicker1.Enabled = True

        btnSimpanEdit.Location = btnTambah.Location
        btnBatal.Location = btnEdit.Location

        DataGridView1.Enabled = False

        txtNama.ReadOnly = False
        txtPoin.ReadOnly = False
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        btnGenerate.Visible = False
        btnBatal.Visible = False
        btnSimpanTambah.Visible = False
        btnSimpanEdit.Visible = False
        DateTimePicker1.Enabled = False

        lblPoin.Visible = True
        txtPoin.Visible = True
        btnTambah.Visible = True
        btnClear.Visible = True
        btnHapus.Visible = True
        btnEdit.Visible = True

        DataGridView1.Enabled = True

        lblMasaAktif.Location = defaultLblLocation
        DateTimePicker1.Location = defaultDateLocation

        txtKodeMember.ReadOnly = True
        txtNama.ReadOnly = True
        txtPoin.ReadOnly = True
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        clear()
        DGVRead("SELECT * FROM tbl_member WHERE `kode_member` like '%" & txtSearch.Text & "%' OR `nama` like '%" & txtSearch.Text & "%' ")
    End Sub

    Public Sub clear()
        txtKodeMember.Clear()
        txtNama.Clear()
        txtPoin.Clear()

        btnBatal_Click(Nothing, Nothing)
        DGVRead("SELECT * FROM tbl_member")
        btnEdit.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah kamu ingin menghapus data member " & DataGridView1.CurrentRow.Cells(2).Value & "?", MsgBoxStyle.YesNo, "HAPUS DATA") = MsgBoxResult.No Then
            Return
        End If

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

    Private Sub btnSimpanTambah_Click(sender As Object, e As EventArgs) Handles btnSimpanTambah.Click
        generateMember()
        Try
            If txtNama.Text Is "" Then
                MsgBox("Silahkan masukkan Nama")
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
            cmd.Parameters.AddWithValue("@poin", txtPoin.Text)
            cmd.Parameters.AddWithValue("@masa_aktif", DateTimePicker1.Value)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Data Berhasil di Tambahkan!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data Gagal di Tambahkan!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            conn.Close()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSimpanEdit_Click(sender As Object, e As EventArgs) Handles btnSimpanEdit.Click
        Try
            If txtNama.Text Is "" Then
                MsgBox("Silahkan Masukkan Nama")
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
            conn.Close()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        generateMember()

    End Sub

    Private Sub generateMember()
        Dim uniqueCode As String = String.Empty
        Dim random As New Random()
        Try
            conn.Open()
            Dim allowedChars As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            ' Loop sampai kode yang dihasilkan benar-benar unik
            Do
                ' Generate kode unik dengan panjang 8, dengan karakter yang diizinkan
                uniqueCode = New String(Enumerable.Repeat(allowedChars, 8).Select(Function(s) s(random.Next(s.Length))).ToArray())

                ' Cek apakah kode tersebut sudah ada di tabel
                Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_member WHERE kode_member = @kode_member", conn)
                    checkCmd.Parameters.AddWithValue("@kode_member", uniqueCode)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If count = 0 Then
                        ' Kode unik ditemukan, keluar dari loop
                        Exit Do
                    End If
                End Using
            Loop While True

            txtKodeMember.Text = uniqueCode
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            DGVRead("SELECT * FROM tbl_member")
        End Try
    End Sub
End Class