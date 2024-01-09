﻿Imports MySql.Data.MySqlClient
Imports Windows.Win32.UI.Input
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports Mysqlx.XDevAPI.Relational

Public Class FormPOS
    Dim conn As New MySqlConnection("server=localhost; port=3306; username=root; password=; database=sales_db")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim uang As Integer = 0

    Private WithEvents pan As Panel
    Private WithEvents namaproduk As Label
    Private WithEvents harga As Label
    Private WithEvents stok As Label
    Private WithEvents img As PictureBox

    'Invoice Print ------------------------------------------------------------------------------
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper, invoiceID As Integer

    Private Sub btnCRUD_Click(sender As Object, e As EventArgs) Handles btnCRUD.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTrans.Click
        Me.Hide()
        FormTransaksi.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Apakah kamu ingin keluar dari Aplikasi?", MsgBoxStyle.Question + vbYesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub FormPOS_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        WindowState = FormWindowState.Maximized
        btnBayar.Enabled = False
        loadProduct()
    End Sub

    Public Sub loadProduct()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `tbl_produk` WHERE `jumlah` > 0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                loadControls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Public Sub loadControls()
        'Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        'Dim array(CInt(len)) As Byte
        'dr.GetBytes(0, 0, array, 0, CInt(len))

        pan = New Panel
        With pan
            .Width = 246
            .Height = 200
            .Margin = New Padding(14, 14, 14, 14)
            .BackColor = Color.FromArgb(255, 255, 255)
            .Tag = dr.Item("id").ToString
        End With

        img = New PictureBox
        With img
            .Height = 30
            .BackgroundImageLayout = ImageLayout.Stretch
            .Dock = DockStyle.Top
            .Tag = dr.Item("id").ToString
        End With

        namaproduk = New Label
        With namaproduk
            .ForeColor = Color.FromArgb(44, 44, 45)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("id").ToString
        End With

        harga = New Label
        With harga
            .ForeColor = Color.FromArgb(44, 44, 45)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("id").ToString
        End With

        stok = New Label
        With stok
            .ForeColor = Color.FromArgb(44, 44, 45)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("id").ToString
        End With

        'Dim ms As New System.IO.MemoryStream(array)
        'Dim bitmap As New System.Drawing.Bitmap(ms)
        'img.BackgroundImage = bitmap

        namaproduk.Text = "Nama : " & dr.Item("nama").ToString
        harga.Text = "Harga : Rp. " & dr.Item("harga").ToString
        stok.Text = "Stok : " & dr.Item("jumlah").ToString

        pan.Controls.Add(img)
        pan.Controls.Add(stok)
        pan.Controls.Add(harga)
        pan.Controls.Add(namaproduk)

        FlowLayoutPanel1.Controls.Add(pan)

        AddHandler namaproduk.Click, AddressOf productClicked
        AddHandler harga.Click, AddressOf productClicked
        AddHandler stok.Click, AddressOf productClicked
        AddHandler img.Click, AddressOf productClicked
        AddHandler pan.Click, AddressOf productClicked
    End Sub

    Public Sub productClicked(sender As Object, e As EventArgs)
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk WHERE id like '" & sender.tag.ToString & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim exist As Boolean = False, numrow As Integer = 0, quantity As Integer

                For Each item As DataGridViewRow In DataGridView1.Rows
                    If item.Cells(0).Value IsNot Nothing Then
                        If item.Cells(0).Value.ToString = dr.Item("nama") Then
                            exist = True
                            numrow = item.Index
                            quantity = CInt(item.Cells(2).Value)
                            Exit For
                        End If
                    End If
                Next

                If exist = False Then
                    'Dim price As Decimal = dr("harga")
                    DataGridView1.Rows.Add(dr.Item("nama"), dr.Item("harga"), 1, dr.Item("produk_id"))
                Else
                    DataGridView1.Rows(numrow).Cells(2).Value = 1 + quantity
                End If
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            getTotalHarga()
            conn.Close()
        End Try
    End Sub

    Sub getTotalHarga()
        Try
            Dim grandtotal As Decimal = 0

            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(0).Value IsNot Nothing Then
                    Dim quantity As Integer = CInt(row.Cells(2).Value)
                    Dim harga As Decimal = CDec(row.Cells(1).Value)
                    grandtotal += quantity * harga
                End If
            Next
            txtTotal.Text = Format(grandtotal, "#,##0.00")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        DataGridView1.Rows.Clear()
        txtTotal.Text = 0
        rtxtUang.Text = 0
        txtKembali.Text = 0
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        AddAmount(1000)
    End Sub

    Private Sub btn5000_Click(sender As Object, e As EventArgs) Handles btn5000.Click
        AddAmount(5000)
    End Sub

    Private Sub btn10000_Click(sender As Object, e As EventArgs) Handles btn10000.Click
        AddAmount(10000)
    End Sub

    Private Sub btn20000_Click(sender As Object, e As EventArgs) Handles btn20000.Click
        AddAmount(20000)
    End Sub

    Private Sub btn50000_Click(sender As Object, e As EventArgs) Handles btn50000.Click
        AddAmount(50000)
    End Sub

    Private Sub btn100000_Click(sender As Object, e As EventArgs) Handles btn100000.Click
        AddAmount(100000)
    End Sub

    Private Sub rtxtUang_TextChanged(sender As Object, e As EventArgs) Handles rtxtUang.TextChanged
        If String.IsNullOrWhiteSpace(rtxtUang.Text) Then
            uang = 0
        ElseIf IsNumeric(rtxtUang.Text) Then
            uang = rtxtUang.Text
        Else
            MsgBox("Inputkan hanya angka", MsgBoxStyle.Critical, "Nominal Error")
            rtxtUang.Text = uang
        End If

        Dim kembalian As Decimal = (uang - CDec(txtTotal.Text)).ToString("N2")
        txtKembali.Text = String.Format("{0:N}", kembalian)
        If kembalian >= 0 And CInt(rtxtUang.Text) > 0 Then
            btnBayar.Enabled = True
        Else
            btnBayar.Enabled = False
        End If

    End Sub

    Private Sub AddAmount(amount As Integer)
        uang += amount
        rtxtUang.Text = uang
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `tbl_produk` WHERE id like '%" & txtSearch.Text & "%' OR `nama` like '%" & txtSearch.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                loadControls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("Item tidak ada", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            changelongpaper()
            PPD.Document = PD
            PPD.ShowDialog()
            invoiceID += 1
        End If
    End Sub

    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        'pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
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

        Dim line, invoice As String
        line = "-------------------------------------------------------------------------------------------"

        Dim currentDateAndTime As DateTime = DateTime.Now
        Dim formattedDate As String = currentDateAndTime.ToString("dd-MM-yyyy")
        Dim formattedTime As String = currentDateAndTime.ToString("HH:mm:ss")
        Dim invoiceDate As String = currentDateAndTime.ToString("ddMMM")

        e.Graphics.DrawString("POS", f10, Brushes.Black, centermargin, 40, center)

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT `no_transaksi` FROM `tbl_transaksi`", conn)
            dr = cmd.ExecuteReader
            If dr.Read() Then
                While dr.Read
                    invoice = "POS" & invoiceDate.ToUpper & invoiceID.ToString("D4")
                    If invoice = dr.Item("no_transaksi") Then
                        invoiceID += 1
                    Else
                        invoice = "POS" & invoiceDate.ToUpper & invoiceID.ToString("D4")
                    End If
                End While
            Else
                invoice = "POS" & invoiceDate.ToUpper & invoiceID.ToString("D4")
            End If
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        e.Graphics.DrawString("No Invoice", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 65, 75)
        e.Graphics.DrawString(invoice, f8, Brushes.Black, 70, 75)

        e.Graphics.DrawString("Kasir", f8, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f8, Brushes.Black, 65, 85)
        e.Graphics.DrawString("Syukran", f8, Brushes.Black, 70, 85)

        e.Graphics.DrawString("Waktu", f8, Brushes.Black, 0, 95)
        e.Graphics.DrawString(":", f8, Brushes.Black, 65, 95)
        e.Graphics.DrawString(formattedDate & " | " & formattedTime, f8, Brushes.Black, 70, 95)
        'DetailHeader
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 0, 120)
        e.Graphics.DrawString("Item", f8, Brushes.Black, 25, 120)
        e.Graphics.DrawString("Harga", f8, Brushes.Black, 180, 120, right)
        e.Graphics.DrawString("Subtotal", f8, Brushes.Black, rightmargin, 120, right)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 130)

        Dim height As Integer
        Dim i As Long
        Dim total, kembalian As Decimal
        DataGridView1.AllowUserToAddRows = False

        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f8, Brushes.Black, 0, 125 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(0).Value.ToString, f8, Brushes.Black, 25, 125 + height)
            i = DataGridView1.Rows(row).Cells(1).Value
            DataGridView1.Rows(row).Cells(1).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, 180, 125 + height, right)

            'subtotal
            Dim subtotal As Decimal
            subtotal = DataGridView1.Rows(row).Cells(1).Value * DataGridView1.Rows(row).Cells(2).Value
            total += subtotal
            e.Graphics.DrawString(subtotal.ToString("##,##0"), f8, Brushes.Black, rightmargin, 125 + height, right)

            Try
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE `tbl_produk` SET `jumlah`= `jumlah` - @quantity WHERE `produk_id` = @produk_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@produk_id", DataGridView1.Rows(row).Cells(3).Value)
                cmd.Parameters.AddWithValue("@quantity", CInt(DataGridView1.Rows(row).Cells(2).Value))
                i = cmd.ExecuteNonQuery

                Dim cmd2 As New MySqlCommand("INSERT INTO `tbl_transaksi` (`no_transaksi`, `produk_id`, `nama_produk`, `harga_produk`, `kuantitas_produk`, `total_harga`) VALUES (@no_transaksi, @produk_id, @nama_produk, @harga_produk, @kuantitas_produk, @total_harga)", conn)
                cmd2.Parameters.Clear()
                cmd2.Parameters.AddWithValue("@no_transaksi", invoice)
                cmd2.Parameters.AddWithValue("@produk_id", DataGridView1.Rows(row).Cells(3).Value)
                cmd2.Parameters.AddWithValue("@nama_produk", DataGridView1.Rows(row).Cells(0).Value)
                cmd2.Parameters.AddWithValue("@harga_produk", CInt(DataGridView1.Rows(row).Cells(1).Value))
                cmd2.Parameters.AddWithValue("@kuantitas_produk", CInt(DataGridView1.Rows(row).Cells(2).Value))
                cmd2.Parameters.AddWithValue("@total_harga", subtotal)
                i = cmd2.ExecuteNonQuery
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        Next

        kembalian = uang - total

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height + 135)

        e.Graphics.DrawString("Total", f8, Brushes.Black, 0, height + 150)
        e.Graphics.DrawString(total.ToString("##,##0"), f8, Brushes.Black, rightmargin, height + 150, right)

        e.Graphics.DrawString("Tunai", f8, Brushes.Black, 0, height + 165)
        e.Graphics.DrawString(uang.ToString("##,##0"), f8, Brushes.Black, rightmargin, height + 165, right)

        e.Graphics.DrawString("Kembalian", f8, Brushes.Black, 0, height + 180)
        e.Graphics.DrawString(kembalian.ToString("##,##0"), f8, Brushes.Black, rightmargin, height + 180, right)

        e.Graphics.DrawString("------------------ TERIMA KASIH ------------------", f8, Brushes.Black, centermargin, height + 200, center)
    End Sub


End Class