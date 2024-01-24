Imports System.ComponentModel
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FormPembelian
    Dim conn As New MySqlConnection("server=localhost; port=3306; username=root; password=; database=sales_db")
    Dim i As Integer = 0
    Dim dr As MySqlDataReader

    'Cetak Pembelian ------------------------------------------------------------------------------
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Public Sub InitializeFormPembelian()
        conn.Close()
        loadTransaksi()
        loadDGV2()
    End Sub

    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeFormPembelian()
    End Sub

    Public Sub loadTransaksi()
        i = 0
        DataGridView1.Rows.Clear()

        Dim rentangWaktu1 As Date = DateTimePicker1.Value
        Dim rentangWaktu2 As Date = DateTimePicker2.Value.AddDays(1)

        Dim formattedWaktu1 As String = rentangWaktu1.ToString("yyyy-MM-dd")
        Dim formattedWaktu2 As String = rentangWaktu2.ToString("yyyy-MM-dd")

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_pembelian WHERE created_at BETWEEN @waktu1 AND @waktu2", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@waktu1", formattedWaktu1)
            cmd.Parameters.AddWithValue("@waktu2", formattedWaktu2)

            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("operator"), dr.Item("no_transaksi"), dr.Item("total_kuantitas"), dr.Item("diskon") & "%", dr.Item("pajak") & "%", Format(dr.Item("grandtotal"), "##,##0"), dr.Item("created_at"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DataGridView1.Sort(DataGridView1.Columns("Column1"), ListSortDirection.Descending)
            For Each item As DataGridViewRow In DataGridView1.Rows
                If item.Cells(0).Value Is Nothing Then
                    Exit For
                Else
                    item.Cells(0).Value = item.Index + 1
                End If
            Next
            conn.Close()
        End Try
    End Sub

    Public Sub loadDGV2()
        DataGridView2.Rows.Clear()

        If txtSearch.Text <> "" Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT SUM(`total_kuantitas`) as total_produk_terbeli, grandtotal as total_pembelian FROM tbl_pembelian WHERE `operator` like '%" & txtSearch.Text & "%' OR `no_transaksi` like '%" & txtSearch.Text & "%' GROUP BY operator", conn)
                cmd.Parameters.Clear()

                dr = cmd.ExecuteReader
                Dim totalProdukTerbeli As Integer = 0
                Dim totalPembelian As Decimal = 0
                While dr.Read()
                    totalProdukTerbeli += dr.Item("total_produk_terbeli")
                    totalPembelian += dr.Item("total_pembelian")
                End While
                DataGridView2.Rows.Add(DateTimePicker1.Value & " S/d " & DateTimePicker2.Value, totalProdukTerbeli, Format(totalPembelian, "##,##0"))
                dr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                DataGridView1.Sort(DataGridView1.Columns("Column1"), ListSortDirection.Descending)
                conn.Close()
            End Try
        End If

        Dim rentangWaktu1 As Date = DateTimePicker1.Value
        Dim rentangWaktu2 As Date = DateTimePicker2.Value.AddDays(1)

        Dim formattedWaktu1 As String = rentangWaktu1.ToString("yyyy-MM-dd")
        Dim formattedWaktu2 As String = rentangWaktu2.ToString("yyyy-MM-dd")
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT SUM(`total_kuantitas`) as total_produk_terbeli, grandtotal as total_pembelian FROM tbl_pembelian WHERE created_at BETWEEN @waktu1 AND @waktu2 GROUP BY no_transaksi, operator", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@waktu1", formattedWaktu1)
            cmd.Parameters.AddWithValue("@waktu2", formattedWaktu2)

            dr = cmd.ExecuteReader
            Dim totalProdukTerbeli As Integer = 0
            Dim totalPembelian As Decimal = 0
            While dr.Read()
                totalProdukTerbeli += dr.Item("total_produk_terbeli")
                totalPembelian += dr.Item("total_pembelian")
            End While
            DataGridView2.Rows.Add(formattedWaktu1 & " S/d " & formattedWaktu2, totalProdukTerbeli, Format(totalPembelian, "##,##0"))
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        i = 0
        DataGridView1.Rows.Clear()
        DateTimePicker1.Value = DateTime.Now.ToString("yyyy-MM-dd")
        DateTimePicker2.Value = DateTime.Now.ToString("yyyy-MM-dd")
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_pembelian WHERE `no_transaksi` like '%" & txtSearch.Text & "%' OR `nama_produk` like '%" & txtSearch.Text & "%' OR `produk_id` like '%" & txtSearch.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("operator"), dr.Item("no_transaksi"), dr.Item("total_kuantitas"), dr.Item("diskon") & "%", dr.Item("pajak") & "%", Format(dr.Item("grandtotal"), "##,##0"), dr.Item("created_at"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DataGridView1.Sort(DataGridView1.Columns("Column1"), ListSortDirection.Descending)
            For Each item As DataGridViewRow In DataGridView1.Rows
                If item.Cells(0).Value Is Nothing Then
                    Exit For
                Else
                    item.Cells(0).Value = item.Index + 1
                End If
            Next
            conn.Close()
            loadDGV2()
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        loadTransaksi()
        loadDGV2()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        loadTransaksi()
        loadDGV2()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        total = 0
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("Pembelian tidak ada", MsgBoxStyle.OkOnly)
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
    Dim total As Decimal

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

        Dim tglMulai As String = DateTimePicker1.Value.ToString("dd-MM-yyyy")
        Dim tglAkhir As String = DateTimePicker2.Value.ToString("dd-MM-yyyy")

        If txtSearch.Text <> "" Then
            tglMulai = "-"
            tglAkhir = "-"
        End If

        e.Graphics.DrawString("Point of Sales", f12b, Brushes.Black, leftmargin, 40, center)
        e.Graphics.DrawString("Mulai Tgl.   :   " & tglMulai, f12, Brushes.Black, rightmargin, 40, right)
        e.Graphics.DrawString("S/d Tgl.     :   " & tglAkhir, f12, Brushes.Black, rightmargin, 60, right)

        e.Graphics.DrawString("Laporan Pembelian", f10b, Brushes.Black, leftmargin, 100)

        e.Graphics.DrawString(line, lineFont, Brushes.Black, leftmargin, 116)

        e.Graphics.DrawString("No", f10, Brushes.Black, leftmargin, 128)
        e.Graphics.DrawString("Operator", f10, Brushes.Black, 30 + leftmargin, 128)
        e.Graphics.DrawString("Nomor Transaksi", f10, Brushes.Black, 150 + leftmargin, 128)
        e.Graphics.DrawString("Produk ID", f10, Brushes.Black, 300 + leftmargin, 128)
        e.Graphics.DrawString("Nama Produk", f10, Brushes.Black, 400 + leftmargin, 128)
        e.Graphics.DrawString("Harga Produk", f10, Brushes.Black, 530 + leftmargin, 128)
        e.Graphics.DrawString("Kuantitas", f10, Brushes.Black, 645 + leftmargin, 128)
        e.Graphics.DrawString("Diskon", f10, Brushes.Black, 740 + leftmargin, 128)
        e.Graphics.DrawString("Pajak", f10, Brushes.Black, 820 + leftmargin, 128)
        e.Graphics.DrawString("Total", f10, Brushes.Black, 890 + leftmargin, 128)

        e.Graphics.DrawString(line, lineFont, Brushes.Black, leftmargin, 140)

        Dim startIndex As Integer = (currentPage - 1) * rowsPerPage
        Dim endIndex As Integer = Math.Min(currentPage * rowsPerPage, DataGridView1.Rows.Count)

        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 25
            'no
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, leftmargin, 125 + height)
            'Operator
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 30 + leftmargin, 125 + height)
            'Nomor Transaksi
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, 150 + leftmargin, 125 + height)
            'Produk ID
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(3).Value.ToString, f10, Brushes.Black, 300 + leftmargin, 125 + height)
            'Nama Produk
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(4).Value.ToString, f10, Brushes.Black, 400 + leftmargin, 125 + height)
            'Harga Produk            
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(5).Value.ToString, f10, Brushes.Black, 615 + leftmargin, 125 + height, right)
            'Kuantitas
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(6).Value.ToString, f10, Brushes.Black, 665 + leftmargin, 125 + height)
            'Diskon
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(7).Value.ToString, f10, Brushes.Black, 750 + leftmargin, 125 + height)
            'pajak
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(8).Value.ToString, f10, Brushes.Black, 825 + leftmargin, 125 + height)
            'grandtotal
            i = DataGridView1.Rows(row).Cells(9).Value
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(9).Value.ToString, f10, Brushes.Black, 950 + leftmargin, 125 + height, right)

            e.Graphics.DrawString(line, lineFont, Brushes.Black, leftmargin, 138 + height)

            total += i
        Next

        currentPage += 1

        e.HasMorePages = currentPage <= Math.Ceiling(DataGridView1.Rows.Count / rowsPerPage)

        If Not e.HasMorePages Then
            e.Graphics.DrawString("Total Pembelian  : " & DataGridView2.Rows(0).Cells(2).Value.ToString(), f10, Brushes.Black, rightmargin, 170 + height, right)
            e.Graphics.DrawString("Produk Terbeli   : " & DataGridView2.Rows(0).Cells(1).Value.ToString(), f10, Brushes.Black, rightmargin, 190 + height, right)
        End If
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        ' Value no transaksi
        Dim noTransaksi As String = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Dim penjualan As Boolean = False

        ' Create an instance of FormDetailTransaksi and pass the data through the constructor
        Dim detailForm As New FormDetailTransaksi(noTransaksi, penjualan)
        detailForm.Show()
    End Sub
End Class