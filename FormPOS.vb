Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class FormPOS

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

    Dim conn As New MySqlConnection("server=localhost; port=3306; username=root; password=; database=sales_db")
    Dim i As Integer
    Dim dr, dr2 As MySqlDataReader
    Dim uang As Integer = 0

    Private WithEvents pan As Panel
    Private WithEvents namaproduk, harga, diskon, hargaDiskon, stok, poin As Label
    Private WithEvents img As PictureBox

    'Invoice Print ------------------------------------------------------------------------------
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper, invoiceID As Integer

    Private Sub FormPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kategoriRead()
        InitializeFormPOS()
    End Sub

    Public Sub InitializeFormPOS()
        conn.Close()
        lblUser.Text = CurrentUser.Nama
        btnBayar.Enabled = False
        ClearData()
        loadProduct()
    End Sub
    Private Sub ClearData()
        DataGridView1.Rows.Clear()
        txtMember.Text = ""
        txtTotal.Text = 0
        rtxtUang.Text = 0
        txtKembali.Text = 0
        lblDiskon.Text = ""
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
            .Width = 220
            .Height = 200
            .Cursor = Cursors.Hand
            .Margin = New Padding(14, 14, 14, 14)
            .BackColor = Color.FromArgb(255, 255, 255)
            .Tag = dr.Item("produk_id").ToString
        End With

        img = New PictureBox
        With img
            .Height = 30
            .Cursor = Cursors.Hand
            .BackgroundImageLayout = ImageLayout.Stretch
            .Dock = DockStyle.Top
            .Tag = dr.Item("produk_id").ToString
        End With

        namaproduk = New Label
        With namaproduk
            .ForeColor = Color.FromArgb(44, 44, 45)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Cursor = Cursors.Hand
            .Dock = DockStyle.Top
            .Tag = dr.Item("produk_id").ToString
        End With

        harga = New Label
        With harga
            .ForeColor = Color.FromArgb(44, 44, 45)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Cursor = Cursors.Hand
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("produk_id").ToString
        End With

        diskon = New Label
        With diskon
            .ForeColor = Color.FromArgb(44, 44, 45)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Cursor = Cursors.Hand
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("produk_id").ToString
        End With

        hargaDiskon = New Label
        With hargaDiskon
            .ForeColor = Color.FromArgb(44, 44, 45)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Cursor = Cursors.Hand
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("produk_id").ToString
        End With

        poin = New Label
        With poin
            .ForeColor = Color.FromArgb(44, 44, 45)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Cursor = Cursors.Hand
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("produk_id").ToString
        End With

        stok = New Label
        With stok
            .ForeColor = Color.FromArgb(44, 44, 45)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Cursor = Cursors.Hand
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("produk_id").ToString
        End With

        'Dim ms As New System.IO.MemoryStream(array)
        'Dim bitmap As New System.Drawing.Bitmap(ms)
        'img.BackgroundImage = bitmap

        namaproduk.Text = "Nama : " & dr.Item("nama_produk").ToString
        harga.Text = "Harga : Rp. " & dr.Item("harga").ToString
        diskon.Text = "Diskon : " & dr.Item("diskon").ToString & "%"
        hargaDiskon.Text = "Harga Diskon : Rp. " & (dr.Item("harga") * (1 - (CDec(dr.Item("diskon")) / 100))).ToString
        poin.Text = "Poin : " & dr.Item("poin").ToString
        stok.Text = "Stok : " & dr.Item("jumlah").ToString

        pan.Controls.Add(img)
        pan.Controls.Add(stok)
        pan.Controls.Add(poin)
        pan.Controls.Add(hargaDiskon)
        pan.Controls.Add(diskon)
        pan.Controls.Add(harga)
        pan.Controls.Add(namaproduk)

        FlowLayoutPanel1.Controls.Add(pan)

        AddHandler namaproduk.Click, AddressOf productClicked
        AddHandler harga.Click, AddressOf productClicked
        AddHandler diskon.Click, AddressOf productClicked
        AddHandler hargaDiskon.Click, AddressOf productClicked
        AddHandler poin.Click, AddressOf productClicked
        AddHandler stok.Click, AddressOf productClicked
        AddHandler img.Click, AddressOf productClicked
        AddHandler pan.Click, AddressOf productClicked
    End Sub

    Public Sub productClicked(sender As Object, e As EventArgs)
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk WHERE produk_id like '" & sender.tag.ToString & "%'", conn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim exist As Boolean = False, numrow As Integer = 0, quantity As Integer

                For Each item As DataGridViewRow In DataGridView1.Rows
                    If item.Cells(0).Value IsNot Nothing Then
                        If item.Cells(0).Value.ToString = dr.Item("nama_produk") Then
                            exist = True
                            numrow = item.Index
                            quantity = CInt(item.Cells(2).Value)
                            Exit For
                        End If
                    End If
                Next

                If exist = False Then
                    DataGridView1.Rows.Add(dr.Item("nama_produk"), Format(dr.Item("harga") * (1 - (CDec(dr.Item("diskon")) / 100)), "#,##0.00"), 1, dr.Item("produk_id"), dr.Item("diskon"), dr.Item("harga"), dr.Item("poin"))
                Else
                    conn.Close()
                    DataGridView1.Rows(numrow).Cells(2).Value = 1 + quantity
                End If
            End If
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            getTotalHarga()
        End Try
    End Sub

    Private Sub txtMember_Leave(sender As Object, e As EventArgs) Handles txtMember.Leave
        getTotalHarga()
    End Sub

    Private Sub txtMember_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMember.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            getTotalHarga()
            rtxtUang.Focus()
        End If
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        For row As Integer = 0 To DataGridView1.RowCount - 1
            If Not IsNumeric(DataGridView1.Rows(row).Cells(2).Value) Then
                DataGridView1.Rows(row).Cells(2).Value = 1
            End If
        Next
        getTotalHarga()
    End Sub

    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        getTotalHarga()
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
            lblDiskon.Text = ""

            If Format(grandtotal, "#,##0.00") = txtTotal.Text And Not String.IsNullOrWhiteSpace(txtMember.Text) Then
                getDiskon()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getDiskon()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `tbl_member` WHERE `kode_member` = @kode_member", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@kode_member", txtMember.Text)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                If dr.Item("poin") >= 1000 And dr.Item("poin") < 3000 Then
                    lblDiskon.Text = "-2%"
                    txtTotal.Text = (CInt(txtTotal.Text) - (CInt(txtTotal.Text) * 0.02)).ToString("N0")
                ElseIf dr.Item("poin") >= 3000 And dr.Item("poin") < 6000 Then
                    lblDiskon.Text = "-4%"
                    txtTotal.Text = (CInt(txtTotal.Text) - (CInt(txtTotal.Text) * 0.04)).ToString("N0")
                ElseIf dr.Item("poin") >= 6000 And dr.Item("poin") < 10000 Then
                    lblDiskon.Text = "-7%"
                    txtTotal.Text = (CInt(txtTotal.Text) - (CInt(txtTotal.Text) * 0.07)).ToString("N0")
                ElseIf dr.Item("poin") >= 10000 Then
                    lblDiskon.Text = "-10%"
                    txtTotal.Text = (CInt(txtTotal.Text) - (CInt(txtTotal.Text) * 0.1)).ToString("N0")
                Else
                    lblDiskon.Text = ""
                End If
                Format(txtTotal.Text, "#,##0.00")
                dr.Dispose()
            Else
                lblDiskon.Text = ""
                conn.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        DataGridView1.Rows.Clear()
        txtTotal.Text = 0
        rtxtUang.Text = 0
        txtKembali.Text = 0
        lblDiskon.Text = ""
        txtMember.Text = ""
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
            rtxtUang.Text = 0
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
            Dim cmd As New MySqlCommand("SELECT * FROM `tbl_produk` WHERE produk_id like '%" & txtSearch.Text & "%' OR `nama_produk` like '%" & txtSearch.Text & "%' ", conn)
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

    Private Sub kategoriRead()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_kategori", conn)
            dr = cmd.ExecuteReader

            cmbKategori.Items.Clear()
            cmbKategori.DisplayMember = "nama_kategori"
            cmbKategori.ValueMember = "id_kategori"

            While dr.Read
                cmbKategori.Items.Add(dr("nama_kategori"))
            End While

            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cmbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKategori.SelectedIndexChanged
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `tbl_produk` INNER JOIN tbl_kategori ON tbl_produk.id_kategori=tbl_kategori.id_kategori WHERE nama_kategori like '%" & cmbKategori.SelectedItem & "%'", conn)
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
            If txtMember.Text IsNot "" Then
                Try
                    Dim totalPoin As Integer
                    conn.Open()
                    Dim cmd As New MySqlCommand("SELECT * FROM `tbl_member` WHERE `kode_member` = @kode_member", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@kode_member", txtMember.Text)

                    dr = cmd.ExecuteReader()
                    If dr.Read() Then
                        For row As Integer = 0 To DataGridView1.RowCount - 1
                            totalPoin += DataGridView1.Rows(row).Cells(2).Value * DataGridView1.Rows(row).Cells(6).Value
                        Next
                        Try
                            Dim cmd2 As New MySqlCommand("UPDATE `tbl_member` SET `poin`= `poin` + @totalPoin WHERE `kode_member`= @kode_member", conn)
                            cmd2.Parameters.Clear()
                            cmd2.Parameters.AddWithValue("@totalPoin", totalPoin)
                            cmd2.Parameters.AddWithValue("@kode_member", txtMember.Text)
                            dr.Dispose()
                            i = cmd2.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            conn.Close()
                        End Try
                    Else
                        MsgBox("Kode Member salah, Silahkan masukkan kode yang benar")
                        conn.Close()
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                End Try
            End If

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

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings With {
            .PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
            }
        'pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim height, totalKuantitas As Integer
        Dim i As Long
        Dim total, kembalian As Decimal
        Dim diskon As Boolean = False

        If lblDiskon.Text IsNot "" Then
            diskon = True
        End If

        DataGridView1.AllowUserToAddRows = False

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
        Dim today As String = currentDateAndTime.ToString("yyyy-MM-dd")
        Dim formattedDate As String = currentDateAndTime.ToString("dd-MM-yyyy")
        Dim formattedTime As String = currentDateAndTime.ToString("HH:mm:ss")
        Dim invoiceDate As String = currentDateAndTime.ToString("ddMMM")
        Dim yearDate As String = currentDateAndTime.ToString("yy")

        e.Graphics.DrawString("POS", f10, Brushes.Black, centermargin, 40, center)

        Try
            conn.Open()
            Dim maxInvoiceID As Integer
            Dim cmdMaxID As New MySqlCommand($"SELECT MAX(CAST(SUBSTRING(`no_transaksi`, 11) AS UNSIGNED)) FROM `tbl_penjualan` WHERE `created_at` >= '{today}'", conn)
            Dim result As Object = cmdMaxID.ExecuteScalar()
            If result IsNot DBNull.Value Then
                maxInvoiceID = Convert.ToInt32(result)
            Else
                maxInvoiceID = 0
            End If
            invoiceID = maxInvoiceID + 1
            invoice = "POS" & invoiceDate.ToUpper & yearDate & invoiceID.ToString("D4")
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
        e.Graphics.DrawString(CurrentUser.Nama.ToString(), f8, Brushes.Black, 70, 85)

        e.Graphics.DrawString("Waktu", f8, Brushes.Black, 0, 95)
        e.Graphics.DrawString(":", f8, Brushes.Black, 65, 95)
        e.Graphics.DrawString(formattedDate & " | " & formattedTime, f8, Brushes.Black, 70, 95)
        'DetailHeader
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 0, 120)
        e.Graphics.DrawString("Item", f8, Brushes.Black, 25, 120)
        e.Graphics.DrawString("Harga", f8, Brushes.Black, 180, 120, right)
        e.Graphics.DrawString("Subtotal", f8, Brushes.Black, rightmargin, 120, right)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 130)

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

            totalKuantitas += DataGridView1.Rows(row).Cells(2).Value

            Try
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE `tbl_produk` SET `jumlah`= `jumlah` - @quantity WHERE `produk_id` = @produk_id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@produk_id", DataGridView1.Rows(row).Cells(3).Value)
                cmd.Parameters.AddWithValue("@quantity", CInt(DataGridView1.Rows(row).Cells(2).Value))
                i = cmd.ExecuteNonQuery

                Dim cmd2 As New MySqlCommand("INSERT INTO `tbl_detail_penjualan` (`no_transaksi`, `produk_id`, `nama_produk`, `harga_produk`, `kuantitas_produk`, `total_harga`) VALUES (@no_transaksi, @produk_id, @nama_produk, @harga_produk, @kuantitas_produk, @total_harga)", conn)
                cmd2.Parameters.Clear()
                cmd2.Parameters.AddWithValue("@operator", CurrentUser.Nama.ToString())
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

        total = CDec(txtTotal.Text)

        kembalian = uang - total

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tbl_penjualan` (`operator`, `no_transaksi`, `diskon`, `total_kuantitas`, `grandtotal`, `tunai`, `kembalian`) VALUES (@operator, @no_transaksi, @diskon, @total_kuantitas, @grandtotal, @tunai, @kembalian)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@operator", CurrentUser.Nama.ToString())
            cmd.Parameters.AddWithValue("@no_transaksi", invoice)
            cmd.Parameters.AddWithValue("@total_kuantitas", totalKuantitas)
            cmd.Parameters.AddWithValue("@grandtotal", total)
            cmd.Parameters.AddWithValue("@tunai", uang)
            cmd.Parameters.AddWithValue("@kembalian", kembalian)

            If lblDiskon.Text Is "" Then
                cmd.Parameters.AddWithValue("@diskon", 0)
            Else
                cmd.Parameters.AddWithValue("@diskon", CInt(lblDiskon.Text.Replace("-", "").Replace("%", "")))
            End If

            i = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height + 135)

        If diskon Then
            e.Graphics.DrawString("Diskon Member", f8, Brushes.Black, 0, height + 150)
            e.Graphics.DrawString(lblDiskon.Text.Replace("-", ""), f8, Brushes.Black, rightmargin, height + 150, right)
            height += 15
        End If

        e.Graphics.DrawString("Total", f8, Brushes.Black, 0, height + 150)
        e.Graphics.DrawString(total.ToString("##,##0"), f8, Brushes.Black, rightmargin, height + 150, right)

        e.Graphics.DrawString("Tunai", f8, Brushes.Black, 0, height + 165)
        e.Graphics.DrawString(uang.ToString("##,##0"), f8, Brushes.Black, rightmargin, height + 165, right)

        e.Graphics.DrawString("Kembalian", f8, Brushes.Black, 0, height + 180)
        e.Graphics.DrawString(kembalian.ToString("##,##0"), f8, Brushes.Black, rightmargin, height + 180, right)

        e.Graphics.DrawString("------------------ TERIMA KASIH ------------------", f8, Brushes.Black, centermargin, height + 200, center)

        InitializeFormPOS()
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If String.IsNullOrWhiteSpace(rtxtUang.Text) Then
            rtxtUang.Text = 0
        End If

        Dim kembalian As Decimal = (uang - CDec(txtTotal.Text)).ToString("N2")
        txtKembali.Text = String.Format("{0:N}", kembalian)
        If kembalian >= 0 And CInt(rtxtUang.Text) > 0 Then
            btnBayar.Enabled = True
        Else
            btnBayar.Enabled = False
        End If
    End Sub

    'Proteksi Angka---------------------------------------------------------------------------------------
    Private Sub rtxtUang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtxtUang.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If DataGridView1.CurrentCell.ColumnIndex = 2 AndAlso TypeOf e.Control Is TextBox Then
            ' Menghapus handler sebelumnya (jika ada)
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf NumericOnly_KeyPress
            ' Menambahkan handler KeyPress baru
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf NumericOnly_KeyPress
        End If
    End Sub

    Private Sub NumericOnly_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


End Class