﻿Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection("server=localhost; port=3306; username=root; password=; database=sales_db")
    Dim i As Integer
    Dim dr As MySqlDataReader


    Private _currentUser As User

    Public Property CurrentUser As User
        Get
            Return _currentUser
        End Get
        Set(value As User)
            _currentUser = value
            ' Optionally, update UI elements based on the current user.
        End Set
    End Property

    Public Sub InitializeForm1()
        conn.Close()
        Me.WindowState = FormWindowState.Maximized
        DGVRead()
        kategoriRead()
        btnHapus.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Private Sub Form1_Loaded(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeForm1()
    End Sub

    Public Sub create()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tbl_produk`(`produk_id`, `nama`, `kategori`, `harga`, `diskon`, `poin`, `jumlah`) VALUES (@produk_id, @nama, @kategori, @harga, @diskon, @poin, @jumlah)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@produk_id", txtProdukID.Text)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@kategori", txtKategori.Text)
            cmd.Parameters.AddWithValue("@harga", CInt(txtHarga.Text))
            cmd.Parameters.AddWithValue("@diskon", CInt(txtDiskon.Text))
            cmd.Parameters.AddWithValue("@poin", CInt(txtPoin.Text))
            cmd.Parameters.AddWithValue("@jumlah", CInt(txtJumlah.Text))
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
        End Try
    End Sub

    Public Sub DGVRead()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim hargaDiskon As Decimal = dr.Item("harga") * (1 - (CDec(dr.Item("diskon")) / 100))
                DataGridView1.Rows.Add(dr.Item("produk_id"), dr.Item("nama"), dr.Item("kategori"), dr.Item("harga"), dr.Item("diskon") & "%", hargaDiskon, dr.Item("poin"), dr.Item("jumlah"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub kategoriRead()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT `kategori` FROM tbl_produk", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                If cmbKategori.Items.Contains(dr("kategori").ToString()) Then
                    Continue While
                Else
                    cmbKategori.Items.Add(dr("kategori").ToString())
                End If
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cmbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKategori.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk WHERE `kategori` like '%" & cmbKategori.SelectedItem.ToString() & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim hargaDiskon As Decimal = dr.Item("harga") * (1 - (CDec(dr.Item("diskon")) / 100))
                DataGridView1.Rows.Add(dr.Item("produk_id"), dr.Item("nama"), dr.Item("kategori"), dr.Item("harga"), dr.Item("diskon") & "%", hargaDiskon, dr.Item("poin"), dr.Item("jumlah"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub update()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `tbl_produk` SET `produk_id`= @produk_id, `nama`= @nama, `kategori`= @kategori, `harga`= @harga, `diskon`= @diskon, `poin`= @poin, `jumlah`= @jumlah WHERE `produk_id` = @produk_id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@produk_id", txtProdukID.Text)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@kategori", txtKategori.Text)
            cmd.Parameters.AddWithValue("@harga", CInt(txtHarga.Text))
            cmd.Parameters.AddWithValue("@diskon", CInt(txtDiskon.Text))
            cmd.Parameters.AddWithValue("@poin", CInt(txtPoin.Text))
            cmd.Parameters.AddWithValue("@jumlah", CInt(txtJumlah.Text))
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
        End Try
    End Sub

    Public Sub delete()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("delete FROM `tbl_produk` WHERE `produk_id` = @produk_id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@produk_id", txtProdukID.Text)
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
        End Try
    End Sub

    Public Sub clear()
        txtProdukID.Clear()
        txtNama.Clear()
        txtKategori.Clear()
        txtHarga.Clear()
        txtDiskon.Clear()
        txtPoin.Clear()
        txtJumlah.Clear()

        DGVRead()
        txtProdukID.ReadOnly = False
        btnTambah.Enabled = True
        btnEdit.Enabled = False
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        create()
        clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtProdukID.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtNama.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtKategori.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtHarga.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtDiskon.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString().Replace("%", "")
        txtPoin.Text = DataGridView1.CurrentRow.Cells(6).Value
        txtJumlah.Text = DataGridView1.CurrentRow.Cells(7).Value

        txtProdukID.ReadOnly = True
        btnTambah.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        update()
        clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah kamu ingin menghapus data " & DataGridView1.CurrentRow.Cells(1).Value & "?", MsgBoxStyle.YesNo, "HAPUS DATA") = MsgBoxResult.Yes Then
            delete()
            clear()
            DGVRead()
        Else
            Return
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        clear()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk WHERE `produk_id` like '%" & txtSearch.Text & "%' OR `nama` like '%" & txtSearch.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim hargaDiskon As Decimal = dr.Item("harga") * (1 - (CDec(dr.Item("diskon")) / 100))
                DataGridView1.Rows.Add(dr.Item("produk_id"), dr.Item("nama"), dr.Item("kategori"), dr.Item("harga"), dr.Item("diskon") & "%", hargaDiskon, dr.Item("poin"), dr.Item("jumlah"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PopupFormBeli.Show()
    End Sub

    'Proteksi Angka---------------------------------------------------------------------------------------
    Private Sub txtHarga_TextChanged(sender As Object, e As EventArgs) Handles txtHarga.TextChanged
        If Not IsNumeric(txtHarga.Text) And Not txtHarga.Text = "" Then
            MsgBox("Masukkan Jumlah yang benar")
            txtHarga.Text = 0
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtDiskon_TextChanged(sender As Object, e As EventArgs) Handles txtDiskon.TextChanged
        If Not IsNumeric(txtDiskon.Text) And Not txtDiskon.Text = "" Then
            MsgBox("Masukkan Jumlah yang benar")
            txtDiskon.Text = 0
        End If
    End Sub

    Private Sub txtDiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiskon.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

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

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        If Not IsNumeric(txtJumlah.Text) And Not txtJumlah.Text = "" Then
            MsgBox("Masukkan Jumlah yang benar")
            txtJumlah.Text = 0
        End If
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class
