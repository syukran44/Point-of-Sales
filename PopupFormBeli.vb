Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class PopupFormBeli
    Dim conn As New MySqlConnection("server=localhost; port=3306; username=root; password=; database=sales_db")
    Dim i As Integer
    Dim dr As MySqlDataReader

    'Cetak Pembelian ------------------------------------------------------------------------------
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper, invoiceID As Integer

    Private _currentUser As User
    Public Property CurrentUser As User
        Get
            Return _currentUser
        End Get
        Set(value As User)
            _currentUser = value
        End Set
    End Property

    Private Sub PopupFormBeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Close()
        DGVRead()
        getKategori()
        cmbKategori.SelectedIndex = 0
    End Sub

    Public Sub DGVRead()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("produk_id"), dr.Item("nama"), dr.Item("kategori"), dr.Item("harga"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub getKategori()
        cmbKategori.Items.Add("Semua")
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

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        txtProdukID.Text = DataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim exist As Boolean = False, numrow As Integer = 0, quantity As Integer

        If txtQty.Text = "" Then
            txtQty.Text = 1
        End If

        For Each item As DataGridViewRow In DataGridView2.Rows
            If item.Cells(0).Value IsNot Nothing Then
                If item.Cells(0).Value.ToString = txtProdukID.Text.ToUpper() Then
                    exist = True
                    numrow = item.Index
                    quantity = CInt(item.Cells(3).Value)
                    Exit For
                End If
            End If
        Next

        If exist = False Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk WHERE `produk_id` like '%" & txtProdukID.Text & "%'", conn)
                dr = cmd.ExecuteReader
                While dr.Read
                    DataGridView2.Rows.Add(dr.Item("produk_id"), dr.Item("nama"), dr.Item("harga"), txtQty.Text, dr.Item("kategori"))
                End While
                dr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            DataGridView2.Rows(numrow).Cells(3).Value = quantity + txtQty.Text
        End If
        getTotalHarga()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim exist As Boolean = False, numrow As Integer = 0, quantity As Integer

        For Each item As DataGridViewRow In DataGridView2.Rows
            If item.Cells(0).Value IsNot Nothing Then
                If item.Cells(0).Value.ToString = DataGridView1.CurrentRow.Cells(0).Value Then
                    exist = True
                    numrow = item.Index
                    quantity = CInt(item.Cells(3).Value)
                    Exit For
                End If
            End If
        Next

        If exist = False Then
            DataGridView2.Rows.Add(DataGridView1.CurrentRow.Cells(0).Value, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(3).Value, 1, DataGridView1.CurrentRow.Cells(2).Value)
        Else
            DataGridView2.Rows(numrow).Cells(3).Value = 1 + quantity
        End If

        getTotalHarga()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk WHERE `produk_id` like '%" & txtSearch.Text & "%' OR `nama` like '%" & txtSearch.Text & "%' OR `kategori` like '%" & txtSearch.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("produk_id"), dr.Item("nama"), dr.Item("kategori"), dr.Item("harga"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txtProdukID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProdukID.KeyDown
        If e.KeyCode = Keys.Enter Then
            DataGridView1.Rows.Clear()
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk WHERE `produk_id` like '%" & txtProdukID.Text & "%'", conn)
                dr = cmd.ExecuteReader
                While dr.Read
                    DataGridView1.Rows.Add(dr.Item("produk_id"), dr.Item("nama"), dr.Item("kategori"), dr.Item("harga"))
                End While
                dr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
                txtQty.Focus()
            End Try
        End If
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        If Not IsNumeric(txtQty.Text) And Not txtQty.Text = "" Then
            MsgBox("Masukkan Jumlah yang benar")
            txtQty.Text = 0
        End If
    End Sub

    Public Sub getTotalHarga()
        Dim grandtotal As Decimal
        grandtotal = 0 ' Reset grandtotal to zero before calculating the total

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value IsNot Nothing Then
                Dim harga As Decimal = CDec(row.Cells(2).Value)
                Dim quantity As Integer = CInt(row.Cells(3).Value)
                grandtotal += (quantity * harga) * (1 - (CDec(txtDiskon.Text) / 100))
            End If
        Next
        grandtotal += (grandtotal * (CDec(txtPajak.Text) / 100))

        txtTotal.Text = Format(grandtotal, "#,##0.00")
    End Sub

    Private Sub txtDiskon_TextChanged(sender As Object, e As EventArgs) Handles txtDiskon.TextChanged
        If Not IsNumeric(txtDiskon.Text) And Not txtDiskon.Text = "" Then
            MsgBox("Masukkan Jumlah yang benar")
            txtDiskon.Text = 0
        ElseIf txtDiskon.Text = "" Then
            txtDiskon.Text = 0
        End If

        txtPajak.Text = 0

        getTotalHarga()
    End Sub

    Private Sub txtPajak_TextChanged(sender As Object, e As EventArgs) Handles txtPajak.TextChanged
        If Not IsNumeric(txtPajak.Text) And Not txtPajak.Text = "" Then
            MsgBox("Masukkan Jumlah yang benar")
            txtPajak.Text = 0
        ElseIf txtPajak.Text = "" Then
            txtPajak.Text = 0
        End If

        getTotalHarga()
    End Sub

    Private Sub cmbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKategori.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        If cmbKategori.SelectedItem.ToString().ToUpper() = "SEMUA" Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk", conn)
                dr = cmd.ExecuteReader
                While dr.Read
                    DataGridView1.Rows.Add(dr.Item("produk_id"), dr.Item("nama"), dr.Item("kategori"), dr.Item("harga"))
                End While
                dr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk WHERE `kategori` like '%" & cmbKategori.SelectedItem.ToString() & "%'", conn)
                dr = cmd.ExecuteReader
                While dr.Read
                    DataGridView1.Rows.Add(dr.Item("produk_id"), dr.Item("nama"), dr.Item("kategori"), dr.Item("harga"))
                End While
                dr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnBeli_Click(sender As Object, e As EventArgs) Handles btnBeli.Click
        If DataGridView2.Rows.Count = 0 Then
            MsgBox("Item tidak ada", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            changelongpaper()
            PPD.Document = PD
            PPD.ShowDialog()
            DataGridView2.Rows.Clear()
            txtDiskon.Clear()
            txtPajak.Clear()
            txtTotal.Clear()
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
        pagesetup.PaperSize = New PaperSize("A4", 1169, 827) ' A4 Landscape
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
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width - 50

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line, invoice As String
        Dim index As Integer = 1

        line = New String("—", PD.DefaultPageSettings.PaperSize.Width - leftmargin - 999)
        Dim height As Integer
        Dim total As Decimal

        Dim currentDateAndTime As DateTime = DateTime.Now
        Dim today As String = currentDateAndTime.ToString("yyyy-MM-dd")
        Dim tanggal As String = currentDateAndTime.ToString("dd-MM-yyyy")
        Dim invoiceDate As String = currentDateAndTime.ToString("ddMMM")

        Try
            conn.Open()
            Dim maxInvoiceID As Integer
            Dim cmdMaxID As New MySqlCommand($"SELECT MAX(CAST(SUBSTRING(`no_transaksi`, 9) AS UNSIGNED)) FROM `tbl_pembelian` WHERE `created_at` = '{today}'", conn)
            Dim result As Object = cmdMaxID.ExecuteScalar()
            If result IsNot DBNull.Value Then
                maxInvoiceID = Convert.ToInt32(result)
            Else
                maxInvoiceID = 0
            End If
            invoiceID = maxInvoiceID + 1
            invoice = "PBL" & invoiceDate.ToUpper & invoiceID.ToString("D4")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        e.Graphics.DrawString("Point of Sales", f12b, Brushes.Black, leftmargin, 40, center)
        e.Graphics.DrawString("Tgl.             :               " & tanggal, f12, Brushes.Black, rightmargin, 40, right)
        e.Graphics.DrawString("No. Transaksi    :               " & invoice, f12, Brushes.Black, rightmargin, 60, right)
        e.Graphics.DrawString("Operator         :               " & CurrentUser.Nama, f12, Brushes.Black, rightmargin, 80, right)

        e.Graphics.DrawString("Pembelian Produk", f10b, Brushes.Black, leftmargin, 100)

        e.Graphics.DrawString(line, lineFont, Brushes.Black, leftmargin, 116)

        e.Graphics.DrawString("No", f10, Brushes.Black, leftmargin, 128)
        e.Graphics.DrawString("Produk ID", f10, Brushes.Black, 30 + leftmargin, 128)
        e.Graphics.DrawString("Nama Produk", f10, Brushes.Black, 150 + leftmargin, 128)
        e.Graphics.DrawString("Kategori Produk", f10, Brushes.Black, 400 + leftmargin, 128)
        e.Graphics.DrawString("Harga Produk", f10, Brushes.Black, 600 + leftmargin, 128)
        e.Graphics.DrawString("Kuantitas", f10, Brushes.Black, 750 + leftmargin, 128)
        e.Graphics.DrawString("Total", f10, Brushes.Black, 900 + leftmargin, 128)

        e.Graphics.DrawString(line, lineFont, Brushes.Black, leftmargin, 140)
        For row As Integer = 0 To DataGridView2.RowCount - 1
            height += 25

            e.Graphics.DrawString(index, f10, Brushes.Black, leftmargin, 125 + height)
            e.Graphics.DrawString(DataGridView2.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, 30 + leftmargin, 125 + height)
            e.Graphics.DrawString(DataGridView2.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 150 + leftmargin, 125 + height)
            e.Graphics.DrawString(DataGridView2.Rows(row).Cells(4).Value.ToString, f10, Brushes.Black, 400 + leftmargin, 125 + height)
            i = DataGridView2.Rows(row).Cells(2).Value
            DataGridView2.Rows(row).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView2.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, 600 + leftmargin, 125 + height)
            e.Graphics.DrawString(DataGridView2.Rows(row).Cells(3).Value.ToString, f10, Brushes.Black, 750 + leftmargin, 125 + height)
            i = DataGridView2.Rows(row).Cells(2).Value * DataGridView2.Rows(row).Cells(3).Value
            DataGridView2.Rows(row).Cells(5).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView2.Rows(row).Cells(5).Value.ToString, f10, Brushes.Black, 900 + leftmargin, 125 + height)

            e.Graphics.DrawString(line, lineFont, Brushes.Black, leftmargin, 138 + height)

            total += i

            Try
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE `tbl_produk` SET `jumlah`= `jumlah` + @quantity WHERE `produk_id` = @produk_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@produk_id", DataGridView2.Rows(row).Cells(0).Value)
                cmd.Parameters.AddWithValue("@quantity", CInt(DataGridView2.Rows(row).Cells(3).Value))
                i = cmd.ExecuteNonQuery

                Dim cmd2 As New MySqlCommand("INSERT INTO `tbl_pembelian` (`operator` ,`no_transaksi`, `produk_id`, `nama_produk`, `harga_produk`, `kuantitas_produk`, `total_harga`, `diskon`, `pajak`, `grandtotal`) VALUES (@operator, @no_transaksi, @produk_id, @nama_produk, @harga_produk, @kuantitas_produk, @total_harga, @diskon, @pajak, @grandtotal)", conn)
                cmd2.Parameters.Clear()
                cmd2.Parameters.AddWithValue("@operator", CurrentUser.Nama.ToString())
                cmd2.Parameters.AddWithValue("@no_transaksi", invoice)
                cmd2.Parameters.AddWithValue("@produk_id", DataGridView2.Rows(row).Cells(0).Value)
                cmd2.Parameters.AddWithValue("@nama_produk", DataGridView2.Rows(row).Cells(1).Value)
                cmd2.Parameters.AddWithValue("@harga_produk", CInt(DataGridView2.Rows(row).Cells(2).Value))
                cmd2.Parameters.AddWithValue("@kuantitas_produk", CInt(DataGridView2.Rows(row).Cells(3).Value))
                cmd2.Parameters.AddWithValue("@total_harga", CInt(DataGridView2.Rows(row).Cells(5).Value))
                cmd2.Parameters.AddWithValue("@diskon", CInt(txtDiskon.Text))
                cmd2.Parameters.AddWithValue("@pajak", CInt(txtPajak.Text))
                cmd2.Parameters.AddWithValue("@grandtotal", CInt(txtTotal.Text))

                i = cmd2.ExecuteNonQuery
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
                Form1.InitializeForm1()
            End Try

            index += 1
        Next
        e.Graphics.DrawString("Total Pembelian  :               " & Format(total, "##,##0"), f10, Brushes.Black, rightmargin, 170 + height, right)
        e.Graphics.DrawString("Diskon           :               " & txtDiskon.Text & "%", f10, Brushes.Black, rightmargin, 190 + height, right)
        e.Graphics.DrawString("Pajak            :               " & txtPajak.Text & "%", f10, Brushes.Black, rightmargin, 210 + height, right)
        e.Graphics.DrawString("Grand Total      :               " & txtTotal.Text, f10, Brushes.Black, rightmargin, 230 + height, right)

    End Sub

    Private Sub DataGridView2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellValueChanged
        getTotalHarga()
    End Sub

    Private Sub DataGridView2_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView2.RowsRemoved
        getTotalHarga()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Hide()
    End Sub
End Class