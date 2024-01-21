Imports System.ComponentModel
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FormPenjualan
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

    'Cetak Penjualan ------------------------------------------------------------------------------
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Public Sub InitializeFormPenjualan()
        conn.Close()
        loadTransaksi()
        loadDGV2()
    End Sub

    Private Sub FormPenjualan_Loaded(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeFormPenjualan()
    End Sub

    Public Sub loadTransaksi()
        i = 0
        DataGridView1.Rows.Clear()

        Dim rentangWaktu1 As Date = DateTimePicker1.Value
        Dim rentangWaktu2 As Date = DateTimePicker2.Value

        Dim formattedWaktu1 As String = rentangWaktu1.ToString("yyyy-MM-dd")
        Dim formattedWaktu2 As String = rentangWaktu2.ToString("yyyy-MM-dd")

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_penjualan WHERE created_at BETWEEN @waktu1 AND @waktu2", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@waktu1", formattedWaktu1)
            cmd.Parameters.AddWithValue("@waktu2", formattedWaktu2)

            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add("", dr.Item("operator"), dr.Item("no_transaksi"), dr.Item("produk_id"), dr.Item("nama_produk"), Format(dr.Item("harga_produk"), "##,##0"), dr.Item("kuantitas_produk"), dr.Item("diskon") & "%", Format(dr.Item("grandtotal"), "##,##0"))
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

        Dim rentangWaktu1 As Date = DateTimePicker1.Value
        Dim rentangWaktu2 As Date = DateTimePicker2.Value

        Dim formattedWaktu1 As String = rentangWaktu1.ToString("yyyy-MM-dd")
        Dim formattedWaktu2 As String = rentangWaktu2.ToString("yyyy-MM-dd")
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT SUM(`kuantitas_produk`) as total_produk_terjual, grandtotal as total_keuntungan FROM tbl_penjualan WHERE created_at BETWEEN @waktu1 AND @waktu2 GROUP BY no_transaksi, operator", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@waktu1", formattedWaktu1)
            cmd.Parameters.AddWithValue("@waktu2", formattedWaktu2)

            dr = cmd.ExecuteReader
            Dim totalProdukTerjual As Integer = 0
            Dim totalKeuntungan As Decimal = 0
            While dr.Read()
                totalProdukTerjual += dr.Item("total_produk_terjual")
                totalKeuntungan += dr.Item("total_keuntungan")
            End While
            DataGridView2.Rows.Add(formattedWaktu1 & " S/d " & formattedWaktu2, totalProdukTerjual, Format(totalKeuntungan, "##,##0"))
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DataGridView1.Sort(DataGridView1.Columns("Column1"), ListSortDirection.Descending)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        i = 0
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_penjualan WHERE `operator` like '%" & txtSearch.Text & "%' OR `no_transaksi` like '%" & txtSearch.Text & "%' OR `nama_produk` like '%" & txtSearch.Text & "%' OR `produk_id` like '%" & txtSearch.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("operator"), dr.Item("no_transaksi"), dr.Item("produk_id"), dr.Item("nama_produk"), Format(dr.Item("harga_produk"), "##,##0"), dr.Item("kuantitas_produk"), dr.Item("diskon") & "%", Format(dr.Item("grandtotal"), "##,##0"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
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

        e.Graphics.DrawString("Point of Sales", f12b, Brushes.Black, leftmargin, 40, center)
        e.Graphics.DrawString("Mulai Tgl.   :   " & tglMulai, f12, Brushes.Black, rightmargin, 40, right)
        e.Graphics.DrawString("S/d Tgl.     :   " & tglAkhir, f12, Brushes.Black, rightmargin, 60, right)

        e.Graphics.DrawString("Laporan Penjualan", f10b, Brushes.Black, leftmargin, 100)

        e.Graphics.DrawString(line, lineFont, Brushes.Black, leftmargin, 116)

        e.Graphics.DrawString("No", f10, Brushes.Black, leftmargin, 128)
        e.Graphics.DrawString("Operator", f10, Brushes.Black, 30 + leftmargin, 128)
        e.Graphics.DrawString("Nomor Transaksi", f10, Brushes.Black, 200 + leftmargin, 128)
        e.Graphics.DrawString("Produk ID", f10, Brushes.Black, 350 + leftmargin, 128)
        e.Graphics.DrawString("Nama Produk", f10, Brushes.Black, 450 + leftmargin, 128)
        e.Graphics.DrawString("Harga Produk", f10, Brushes.Black, 600 + leftmargin, 128)
        e.Graphics.DrawString("Kuantitas", f10, Brushes.Black, 720 + leftmargin, 128)
        e.Graphics.DrawString("Diskon", f10, Brushes.Black, 810 + leftmargin, 128)
        e.Graphics.DrawString("Total", f10, Brushes.Black, 900 + leftmargin, 128)

        e.Graphics.DrawString(line, lineFont, Brushes.Black, leftmargin, 140)

        Dim startIndex As Integer = (currentPage - 1) * rowsPerPage
        Dim endIndex As Integer = Math.Min(currentPage * rowsPerPage, DataGridView1.Rows.Count)

        For row As Integer = startIndex To endIndex - 1
            height += 25
            'no
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, leftmargin, 125 + height)
            'Operator
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 30 + leftmargin, 125 + height)
            'Nomor Transaksi
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, 200 + leftmargin, 125 + height)
            'Produk ID
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(3).Value.ToString, f10, Brushes.Black, 350 + leftmargin, 125 + height)
            'Nama Produk
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(4).Value.ToString, f10, Brushes.Black, 450 + leftmargin, 125 + height)
            'Harga Produk            
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(5).Value.ToString, f10, Brushes.Black, 685 + leftmargin, 125 + height, right)
            'Kuantitas
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(6).Value.ToString, f10, Brushes.Black, 735 + leftmargin, 125 + height)
            'Diskon
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(7).Value.ToString, f10, Brushes.Black, 820 + leftmargin, 125 + height)
            'grandtotal
            i = DataGridView1.Rows(row).Cells(8).Value
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(8).Value.ToString, f10, Brushes.Black, 950 + leftmargin, 125 + height, right)

            e.Graphics.DrawString(line, lineFont, Brushes.Black, leftmargin, 138 + height)

            total += i
        Next

        currentPage += 1

        e.HasMorePages = currentPage <= Math.Ceiling(DataGridView1.Rows.Count / rowsPerPage)

        If Not e.HasMorePages Then
            e.Graphics.DrawString("Total Penjualan  : " & DataGridView2.Rows(0).Cells(2).Value.ToString(), f10, Brushes.Black, rightmargin, 170 + height, right)
            e.Graphics.DrawString("Produk Terjual   : " & DataGridView2.Rows(0).Cells(1).Value.ToString(), f10, Brushes.Black, rightmargin, 190 + height, right)
        End If
    End Sub

End Class