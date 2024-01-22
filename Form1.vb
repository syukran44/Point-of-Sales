Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

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

    'Cetak Produk ------------------------------------------------------------------------------
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

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
        Dim index As Integer = 0
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                index += 1
                Dim hargaDiskon As Decimal = dr.Item("harga") * (1 - (CDec(dr.Item("diskon")) / 100))
                DataGridView1.Rows.Add(index, dr.Item("produk_id"), dr.Item("nama"), dr.Item("kategori"), Format(dr.Item("harga"), "##,##0"), dr.Item("diskon") & "%", Format(hargaDiskon, "##,##0"), dr.Item("poin"), dr.Item("jumlah"))
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
        Dim index As Integer = 0
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk WHERE `kategori` like '%" & cmbKategori.SelectedItem.ToString() & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                index += 1
                Dim hargaDiskon As Decimal = dr.Item("harga") * (1 - (CDec(dr.Item("diskon")) / 100))
                DataGridView1.Rows.Add(index, dr.Item("produk_id"), dr.Item("nama"), dr.Item("kategori"), Format(dr.Item("harga"), "##,##0"), dr.Item("diskon") & "%", Format(hargaDiskon, "##,##0"), dr.Item("poin"), dr.Item("jumlah"))
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
        txtProdukID.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtNama.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtKategori.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtHarga.Text = DataGridView1.CurrentRow.Cells(4).Value
        txtDiskon.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString().Replace("%", "")
        txtPoin.Text = DataGridView1.CurrentRow.Cells(7).Value
        txtJumlah.Text = DataGridView1.CurrentRow.Cells(8).Value

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
        Dim index As Integer = 0
        clear()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk WHERE `produk_id` like '%" & txtSearch.Text & "%' OR `nama` like '%" & txtSearch.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                index += 1
                Dim hargaDiskon As Decimal = dr.Item("harga") * (1 - (CDec(dr.Item("diskon")) / 100))
                DataGridView1.Rows.Add(index, dr.Item("produk_id"), dr.Item("nama"), dr.Item("kategori"), Format(dr.Item("harga"), "##,##0"), dr.Item("diskon") & "%", Format(hargaDiskon, "##,##0"), dr.Item("poin"), dr.Item("jumlah"))
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

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        totalProduk = 0
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("Penjualan tidak ada", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            changelongpaper()
            PPD.Document = PD
            PPD.ShowDialog()
        End If
    End Sub

    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper += 240
    End Sub

    Dim currentPage As Integer = 1
    Dim rowsPerPage As Integer = 20 ' Ubah sesuai dengan jumlah baris yang dapat masuk ke satu halaman
    Dim totalProduk As Integer

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        currentPage = 1
        Dim pagesetup As New PageSettings With {
            .PaperSize = New PaperSize("A4", 827, 1169),
            .Landscape = True
            }
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 500)
        'pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        'Dim f10u As New Font("Calibri", 10, FontStyle.Underline)
        Dim f12 As New Font("Calibri", 12, FontStyle.Regular)
        Dim f12b As New Font("Calibri", 12, FontStyle.Bold)
        Dim lineFont As New Font("Arial", 10, FontStyle.Regular)


        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Height / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Height - 50

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = New String("—", PD.DefaultPageSettings.PaperSize.Height - leftmargin - 1003)
        Dim height As Integer

        e.Graphics.DrawString("Point of Sales", f12b, Brushes.Black, leftmargin, 40, center)

        e.Graphics.DrawString("Laporan Stok", f10b, Brushes.Black, leftmargin, 100)

        e.Graphics.DrawString(line, lineFont, Brushes.Black, leftmargin, 116)

        e.Graphics.DrawString("No", f10, Brushes.Black, leftmargin, 128)
        e.Graphics.DrawString("Produk ID", f10, Brushes.Black, 50 + leftmargin, 128)
        e.Graphics.DrawString("Nama", f10, Brushes.Black, 130 + leftmargin, 128)
        e.Graphics.DrawString("Kategori", f10, Brushes.Black, 320 + leftmargin, 128)
        e.Graphics.DrawString("Harga", f10, Brushes.Black, 470 + leftmargin, 128)
        e.Graphics.DrawString("Diskon", f10, Brushes.Black, 590 + leftmargin, 128)
        e.Graphics.DrawString("Harga Diskon", f10, Brushes.Black, 685 + leftmargin, 128)
        e.Graphics.DrawString("Poin", f10, Brushes.Black, 810 + leftmargin, 128)
        e.Graphics.DrawString("Stok", f10, Brushes.Black, 900 + leftmargin, 128)

        e.Graphics.DrawString(line, lineFont, Brushes.Black, leftmargin, 140)

        Dim startIndex As Integer = (currentPage - 1) * rowsPerPage
        Dim endIndex As Integer = Math.Min(currentPage * rowsPerPage, DataGridView1.Rows.Count)

        For row As Integer = startIndex To endIndex - 1
            height += 25
            'no
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, leftmargin, 125 + height)
            'Produk ID
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 50 + leftmargin, 125 + height)
            'Nama
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, 130 + leftmargin, 125 + height)
            'Kategori
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(3).Value.ToString, f10, Brushes.Black, 320 + leftmargin, 125 + height)
            'Harga
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(4).Value.ToString, f10, Brushes.Black, 470 + leftmargin, 125 + height)
            'Diskon        
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(5).Value.ToString, f10, Brushes.Black, 620 + leftmargin, 125 + height, right)
            'Harga Diskon
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(6).Value.ToString, f10, Brushes.Black, 715 + leftmargin, 125 + height)
            'Poin
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(7).Value.ToString, f10, Brushes.Black, 820 + leftmargin, 125 + height)
            'Stok
            i = DataGridView1.Rows(row).Cells(8).Value
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(8).Value.ToString, f10, Brushes.Black, 950 + leftmargin, 125 + height, right)

            e.Graphics.DrawString(line, lineFont, Brushes.Black, leftmargin, 138 + height)

            totalProduk += i
        Next

        currentPage += 1

        e.HasMorePages = currentPage <= Math.Ceiling(DataGridView1.Rows.Count / rowsPerPage)

        If Not e.HasMorePages Then
            e.Graphics.DrawString("Total Produk  : " & totalProduk, f10, Brushes.Black, rightmargin, 170 + height, right)
        End If
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
