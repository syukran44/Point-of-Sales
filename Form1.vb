Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection("server=localhost; port=3306; username=root; password=; database=sales_db")
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub btnPOS_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        Me.Hide()
        FormPOS.Show()
    End Sub

    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTrans.Click
        Me.Hide()
        FormTransaksi.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Apakah kamu ingin keluar dari Aplikasi?", MsgBoxStyle.Question + vbYesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        conn.Close()
        Me.WindowState = FormWindowState.Maximized
        DGVRead()
        btnHapus.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Public Sub create()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tbl_produk`(`produk_id`, `nama`, `harga`, `jumlah`) VALUES (@produk_id, @nama, @harga, @jumlah)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@produk_id", txtProdukID.Text)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
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
                DataGridView1.Rows.Add(dr.Item("id"), dr.Item("produk_id"), dr.Item("nama"), dr.Item("harga"), dr.Item("jumlah"))
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
            Dim cmd As New MySqlCommand("UPDATE `tbl_produk` SET `produk_id`= @produk_id, `nama`= @nama, `harga`= @harga, `jumlah`= @jumlah WHERE `id` = @id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
            cmd.Parameters.AddWithValue("@produk_id", txtProdukID.Text)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
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
            Dim cmd As New MySqlCommand("delete FROM `tbl_produk` WHERE `id` = @id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
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
        txtHarga.Clear()
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
        txtProdukID.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtNama.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtHarga.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtJumlah.Text = DataGridView1.CurrentRow.Cells(4).Value

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
        If MsgBox("Apakah kamu ingin menghapus data " & DataGridView1.CurrentRow.Cells(2).Value & "?", MsgBoxStyle.YesNo, "HAPUS DATA") = MsgBoxResult.Yes Then
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
                DataGridView1.Rows.Add(dr.Item("id"), dr.Item("produk_id"), dr.Item("nama"), dr.Item("harga"), dr.Item("jumlah"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class
