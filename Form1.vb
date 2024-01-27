Imports System.Drawing.Printing
Imports System.Globalization
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection("server=localhost; port=3306; username=root; password=; database=sales_db")
    Dim i, currentRow As Integer
    Dim dr As MySqlDataReader
    Dim simpanTambah As Boolean = False

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
        DGVRead("SELECT * FROM tbl_produk INNER JOIN tbl_kategori ON tbl_produk.id_kategori=tbl_kategori.id_kategori")
        btnHapus.Enabled = False
        btnEdit.Enabled = False
        kategoriInputRead()
        cmbKategori.SelectedIndex = 0
    End Sub

    Private Sub DGVRead(query)
        Dim index As Integer = 0
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                index += 1
                Dim hargaDiskon As Decimal = dr.Item("harga") * (1 - (CDec(dr.Item("diskon")) / 100))
                DataGridView1.Rows.Add(index, dr.Item("produk_id"), dr.Item("nama_produk"), dr.Item("nama_kategori"), "Rp. " & Format(dr.Item("harga"), "##,##0"), dr.Item("diskon") & "%", "Rp. " & Format(hargaDiskon, "##,##0"), dr.Item("poin"), dr.Item("jumlah"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Form1_Loaded(sender As Object, e As EventArgs) Handles MyBase.Load
        kategoriRead()
        InitializeForm1()
    End Sub

    Private Sub btnSimpanTambah_Click(sender As Object, e As EventArgs) Handles btnSimpanTambah.Click
        If simpanTambah = True Then
            create()
        Else
            update()
        End If
    End Sub

    Private Sub create()
        If txtNama.Text Is "" Then
            MsgBox("Silahkan masukkan nama")
            txtNama.Focus()
            Return
        ElseIf txtHarga.Text Is "" Then
            MsgBox("Silahkan masukkan harga")
            txtHarga.Focus()
            Return
        End If
        Try
            conn.Open()

            Dim cmdSelectId As New MySqlCommand("SELECT id_kategori FROM tbl_kategori WHERE nama_kategori = @nama_kategori", conn)
            cmdSelectId.Parameters.AddWithValue("@nama_kategori", cmbKategoriInput.SelectedItem.ToString())
            Dim categoryId As Integer = Convert.ToInt32(cmdSelectId.ExecuteScalar())

            Dim cmd As New MySqlCommand("INSERT INTO `tbl_produk`(`produk_id`, `nama_produk`, `id_kategori`, `harga`, `diskon`, `poin`, `jumlah`) VALUES (@produk_id, @nama_produk, @id_kategori, @harga, @diskon, @poin, @jumlah)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@produk_id", txtProdukID.Text)
            cmd.Parameters.AddWithValue("@nama_produk", txtNama.Text)
            cmd.Parameters.AddWithValue("@id_kategori", categoryId)
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
            cmd.Parameters.AddWithValue("@diskon", txtDiskon.Text)
            cmd.Parameters.AddWithValue("@poin", txtPoin.Text)
            cmd.Parameters.AddWithValue("@jumlah", txtJumlah.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Data Berhasil di Tambahkan!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data Gagal di Tambahkan!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            conn.Close()
            btnBatal_Click(Nothing, Nothing)
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub kategoriRead()
        cmbKategori.Items.Add("Semua")
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT `nama_kategori` FROM tbl_kategori", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                If cmbKategori.Items.Contains(dr("nama_kategori").ToString()) Then
                    Continue While
                Else
                    cmbKategori.Items.Add(dr("nama_kategori").ToString())
                End If
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub kategoriInputRead()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_kategori", conn)
            dr = cmd.ExecuteReader

            cmbKategoriInput.Items.Clear()
            cmbKategoriInput.DisplayMember = "nama_kategori"
            cmbKategoriInput.ValueMember = "id_kategori"

            While dr.Read
                cmbKategoriInput.Items.Add(dr("nama_kategori"))
            End While

            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cmbKategoriInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKategoriInput.SelectedIndexChanged
        If simpanTambah = True Then
            generateProdukID()
        End If
    End Sub

    Private Sub generateProdukID()
        Try
            Dim id, lastID As Integer
            Dim key As String
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT MAX(CAST(SUBSTRING(`produk_id`, 2) AS UNSIGNED)) AS 'lastID', SUBSTRING(`produk_id`, 1, 1) AS 'key' FROM `tbl_produk` JOIN tbl_kategori ON tbl_produk.id_kategori=tbl_kategori.id_kategori WHERE nama_kategori LIKE '%" & cmbKategoriInput.SelectedItem & "%'", conn)
            cmd.Parameters.Clear()
            dr = cmd.ExecuteReader
            If dr.Read Then
                If Not IsDBNull(dr.Item("lastID")) Then
                    lastID = Convert.ToInt32(dr.Item("lastID"))
                Else
                    lastID = 0
                End If
                id += 1
                key = dr.Item("key") & (id + lastID).ToString("D4")
            Else
                key = dr.Item("key")
            End If
            txtProdukID.Text = key
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cmbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKategori.SelectedIndexChanged
        Dim index As Integer = 0
        DataGridView1.Rows.Clear()
        If cmbKategori.SelectedItem.ToString().Equals("SEMUA", StringComparison.CurrentCultureIgnoreCase) Then
            DGVRead("SELECT * FROM tbl_produk INNER JOIN tbl_kategori ON tbl_produk.id_kategori=tbl_kategori.id_kategori")
        Else
            DGVRead("SELECT * FROM tbl_produk INNER JOIN tbl_kategori ON tbl_produk.id_kategori=tbl_kategori.id_kategori WHERE `nama_kategori` LIKE '%" & cmbKategori.SelectedItem.ToString() & "%'")
        End If
    End Sub

    Private Sub update()
        Try
            If txtNama.Text Is "" Then
                MsgBox("Silahkan masukkan nama")
                txtNama.Focus()
                Return
            ElseIf txtHarga.Text Is "" Then
                MsgBox("Silahkan masukkan harga")
                txtHarga.Focus()
                Return
            End If

            conn.Open()

            Dim cmdSelectId As New MySqlCommand("SELECT id_kategori FROM tbl_kategori WHERE nama_kategori = @nama_kategori", conn)
            cmdSelectId.Parameters.AddWithValue("@nama_kategori", cmbKategoriInput.SelectedItem.ToString())
            Dim categoryId As Integer = Convert.ToInt32(cmdSelectId.ExecuteScalar())

            Dim cmd As New MySqlCommand("UPDATE `tbl_produk` SET `produk_id`= @produk_id, `nama_produk`= @nama_produk, `id_kategori`= @id_kategori, `harga`= @harga, `diskon`= @diskon, `poin`= @poin, `jumlah`= @jumlah WHERE `produk_id` = @produk_id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@produk_id", txtProdukID.Text)
            cmd.Parameters.AddWithValue("@nama_produk", txtNama.Text)
            cmd.Parameters.AddWithValue("@id_kategori", categoryId)
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
            cmd.Parameters.AddWithValue("@diskon", txtDiskon.Text)
            cmd.Parameters.AddWithValue("@poin", txtPoin.Text)
            cmd.Parameters.AddWithValue("@jumlah", txtJumlah.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Data Berhasil di Edit!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data Gagal di Edit!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            conn.Close()
            btnBatal_Click(Nothing, Nothing)
            DGVRead("SELECT * FROM tbl_produk INNER JOIN tbl_kategori ON tbl_produk.id_kategori=tbl_kategori.id_kategori")
            DataGridView1.ClearSelection()
            DataGridView1.Rows(currentRow).Selected = True
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub delete()
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
            btnBatal_Click(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub clear()
        txtProdukID.Clear()
        txtNama.Clear()
        txtHarga.Clear()
        txtDiskon.Clear()
        txtPoin.Clear()
        txtJumlah.Clear()

        cmbKategori.SelectedIndex = 0
        DGVRead("SELECT * FROM tbl_produk INNER JOIN tbl_kategori ON tbl_produk.id_kategori=tbl_kategori.id_kategori")
        btnEdit.Enabled = False
    End Sub

    Private Sub editMode()
        DataGridView1.Enabled = False

        cmbKategori.SelectedIndex = 0
        btnTambah.Visible = False
        btnHapus.Visible = False
        btnClear.Visible = False
        btnEdit.Visible = False

        btnBatal.Visible = True
        btnSimpanTambah.Visible = True

        btnSimpanTambah.Location = btnTambah.Location
        btnBatal.Location = btnEdit.Location

        lblJumlah.Visible = False
        txtJumlah.Visible = False

        txtNama.ReadOnly = False
        txtHarga.ReadOnly = False
        cmbKategoriInput.Enabled = True
        txtDiskon.ReadOnly = False
        txtPoin.ReadOnly = False
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        simpanTambah = True
        clear()
        editMode()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        simpanTambah = False
        editMode()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If simpanTambah = True Then
            clear()
        End If

        simpanTambah = False

        DataGridView1.Enabled = True

        btnBatal.Visible = False
        btnSimpanTambah.Visible = False

        btnTambah.Visible = True
        btnHapus.Visible = True
        btnClear.Visible = True
        btnEdit.Visible = True

        lblJumlah.Visible = True
        txtJumlah.Visible = True

        txtNama.ReadOnly = True
        txtHarga.ReadOnly = True
        cmbKategoriInput.Enabled = False
        txtDiskon.ReadOnly = True
        txtPoin.ReadOnly = True
        txtJumlah.ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        currentRow = DataGridView1.CurrentCell.RowIndex

        txtProdukID.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtNama.Text = DataGridView1.CurrentRow.Cells(2).Value
        'txtKategori.Text = DataGridView1.CurrentRow.Cells(3).Value
        cmbKategoriInput.SelectedItem = DataGridView1.CurrentRow.Cells(3).Value
        txtHarga.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString().Replace("Rp. ", "")
        txtDiskon.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString().Replace("%", "")
        txtPoin.Text = DataGridView1.CurrentRow.Cells(7).Value
        txtJumlah.Text = DataGridView1.CurrentRow.Cells(8).Value

        'txtProdukID.ReadOnly = True
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah kamu ingin menghapus data " & DataGridView1.CurrentRow.Cells(2).Value & "?", MsgBoxStyle.YesNo, "HAPUS DATA") = MsgBoxResult.Yes Then
            delete()
            clear()
            DGVRead("SELECT * FROM tbl_produk INNER JOIN tbl_kategori ON tbl_produk.id_kategori=tbl_kategori.id_kategori")
        Else
            Return
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim index As Integer = 0
        clear()
        DGVRead("SELECT * FROM tbl_produk INNER JOIN tbl_kategori ON tbl_produk.id_kategori=tbl_kategori.id_kategori WHERE `produk_id` like '%" & txtSearch.Text & "%' OR `nama_produk` like '%" & txtSearch.Text & "%'")
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
