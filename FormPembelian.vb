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
    Dim longpaper, invoiceID As Integer

    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTransaksi()
        loadDGV2()
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
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_pembelian WHERE created_at BETWEEN @waktu1 AND @waktu2", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@waktu1", formattedWaktu1)
            cmd.Parameters.AddWithValue("@waktu2", formattedWaktu2)

            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add("", dr.Item("operator"), dr.Item("no_transaksi"), dr.Item("produk_id"), dr.Item("nama_produk"), dr.Item("harga_produk"), dr.Item("kuantitas_produk"), dr.Item("total_harga"))
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
            Dim cmd As New MySqlCommand("SELECT SUM(`kuantitas_produk`) as total_produk_terjual, SUM(`total_harga`) as total_keuntungan FROM tbl_pembelian WHERE created_at BETWEEN @waktu1 AND @waktu2", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@waktu1", formattedWaktu1)
            cmd.Parameters.AddWithValue("@waktu2", formattedWaktu2)

            dr = cmd.ExecuteReader
            dr.Read()
            DataGridView2.Rows.Add(formattedWaktu1 & " - " & formattedWaktu2, dr.Item("total_produk_terjual"), dr.Item("total_keuntungan"))
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
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_pembelian WHERE `no_transaksi` like '%" & txtSearch.Text & "%' OR `nama_produk` like '%" & txtSearch.Text & "%' OR `produk_id` like '%" & txtSearch.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("no_transaksi"), dr.Item("produk_id"), dr.Item("nama_produk"), dr.Item("harga_produk"), dr.Item("kuantitas_produk"), dr.Item("total_harga"))
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
End Class