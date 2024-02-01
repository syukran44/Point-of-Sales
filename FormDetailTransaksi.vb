Imports System.CodeDom
Imports System.ComponentModel
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FormDetailTransaksi
    Dim conn As New MySqlConnection("server=localhost; port=3306; username=root; password=; database=sales_db")
    Dim i As Integer = 0
    Dim dr As MySqlDataReader

    'Invoice Print ------------------------------------------------------------------------------
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper, invoiceID As Integer
    Dim nomorTransaksi As String
    Dim tipeTransaksi As Boolean

    Public Sub New(noTransaksi As String, tipe As Boolean)
        InitializeComponent()

        nomorTransaksi = noTransaksi
        tipeTransaksi = tipe

        If tipe = True Then
            loadDGV(noTransaksi)
        Else
            loadDGVPembelian(noTransaksi)
            'MsgBox("bukan Pembelian")
        End If
    End Sub

    Private Sub FormDetailTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loadDGV(noTransaksi)
        i = 0
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_detail_penjualan JOIN tbl_penjualan ON tbl_detail_penjualan.no_transaksi=tbl_penjualan.no_transaksi WHERE tbl_detail_penjualan.no_transaksi = @no_transaksi", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@no_transaksi", noTransaksi)

            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("produk_id"), dr.Item("nama_produk"), "Rp. " & Format(dr.Item("harga_produk"), "##,##0"), dr.Item("kuantitas_produk"), "Rp. " & Format(dr.Item("total_harga"), "##,##0"))
            End While
            lblNamaKasir.Text = dr.Item("operator")
            lblWaktu.Text = dr.Item("created_at")
            lblNomorTransaksi.Text = noTransaksi
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub loadDGVPembelian(noTransaksi)
        i = 0
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_detail_pembelian JOIN tbl_pembelian ON tbl_detail_pembelian.no_transaksi=tbl_pembelian.no_transaksi WHERE tbl_detail_pembelian.no_transaksi = @no_transaksi", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@no_transaksi", noTransaksi)

            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("produk_id"), dr.Item("nama_produk"), "Rp. " & Format(dr.Item("harga_produk"), "##,##0"), dr.Item("kuantitas_produk"), "Rp. " & Format(dr.Item("total_harga"), "##,##0"))
            End While
            lblNamaKasir.Text = dr.Item("operator")
            lblWaktu.Text = dr.Item("created_at")
            lblNomorTransaksi.Text = noTransaksi
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnCetakInvoice_Click(sender As Object, e As EventArgs) Handles btnCetakInvoice.Click
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper += 240
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings With {
            .PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
            }
        'pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim height As Integer
        Dim i As Long
        Dim total, hargaDiskon As Decimal
        Dim diskon As Boolean = False
        Dim namaKasir As String = ""
        Dim waktu As DateTime
        Dim kembalian, tunai, jumlahDiskon, totalHarga As Integer

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_detail_penjualan JOIN tbl_penjualan ON tbl_detail_penjualan.no_transaksi=tbl_penjualan.no_transaksi WHERE tbl_detail_penjualan.no_transaksi = @no_transaksi", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@no_transaksi", nomorTransaksi)

            dr = cmd.ExecuteReader
            While dr.Read
                If dr.Item("diskon") <> 0 Then
                    diskon = True
                    jumlahDiskon = dr.Item("diskon")
                End If
            End While
            namaKasir = dr.Item("operator")
            waktu = dr.Item("created_at")
            total = dr.Item("grandtotal")
            kembalian = dr.Item("kembalian")
            tunai = dr.Item("tunai")

            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "-------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("POS", f10, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("No Invoice", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 65, 75)
        e.Graphics.DrawString(nomorTransaksi, f8, Brushes.Black, 70, 75)

        e.Graphics.DrawString("Kasir", f8, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f8, Brushes.Black, 65, 85)
        e.Graphics.DrawString(namaKasir, f8, Brushes.Black, 70, 85)

        e.Graphics.DrawString("Waktu", f8, Brushes.Black, 0, 95)
        e.Graphics.DrawString(":", f8, Brushes.Black, 65, 95)
        e.Graphics.DrawString(waktu.ToString("dd-MM-yyyy") & " | " & waktu.ToString("HH:mm:ss"), f8, Brushes.Black, 70, 95)
        'DetailHeader
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 0, 120)
        e.Graphics.DrawString("Item", f8, Brushes.Black, 25, 120)
        e.Graphics.DrawString("Harga", f8, Brushes.Black, 180, 120, right)
        e.Graphics.DrawString("Subtotal", f8, Brushes.Black, rightmargin, 120, right)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 130)

        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(4).Value.ToString, f8, Brushes.Black, 0, 125 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f8, Brushes.Black, 25, 125 + height)

            'harga
            i = DataGridView1.Rows(row).Cells(3).Value.ToString().Replace("Rp. ", "")
            e.Graphics.DrawString(i.ToString("##,##0"), f8, Brushes.Black, 180, 125 + height, right)

            'subtotal
            i = DataGridView1.Rows(row).Cells(5).Value.ToString().Replace("Rp. ", "")
            e.Graphics.DrawString(i.ToString("##,##0"), f8, Brushes.Black, rightmargin, 125 + height, right)
            totalHarga += i
        Next

        hargaDiskon = Math.Floor(totalHarga * (jumlahDiskon / 100) / 100) * 100

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height + 135)

        If diskon Then
            e.Graphics.DrawString("Diskon Member", f8, Brushes.Black, 0, height + 150)
            e.Graphics.DrawString(jumlahDiskon & "%" & " (-" & hargaDiskon.ToString("##,##0") & ")", f8, Brushes.Black, rightmargin, height + 150, right)
            height += 15
        End If

        e.Graphics.DrawString("Total", f8, Brushes.Black, 0, height + 150)
        e.Graphics.DrawString(total.ToString("##,##0"), f8, Brushes.Black, rightmargin, height + 150, right)

        e.Graphics.DrawString("Tunai", f8, Brushes.Black, 0, height + 165)
        e.Graphics.DrawString(tunai.ToString("##,##0"), f8, Brushes.Black, rightmargin, height + 165, right)

        e.Graphics.DrawString("Kembalian", f8, Brushes.Black, 0, height + 180)
        e.Graphics.DrawString(kembalian.ToString("##,##0"), f8, Brushes.Black, rightmargin, height + 180, right)

        e.Graphics.DrawString("------------------ TERIMA KASIH ------------------", f8, Brushes.Black, centermargin, height + 200, center)
    End Sub
End Class