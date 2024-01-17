Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class PopupFormBeli
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

    Private Sub PopupFormBeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Close()
        DGVRead()
        kategoriRead()
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

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        txtProdukID.Text = DataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim exist As Boolean = False, numrow As Integer = 0, quantity As Integer

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
                    DataGridView2.Rows.Add(dr.Item("produk_id"), dr.Item("nama"), dr.Item("harga"), 1)
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
            DataGridView2.Rows.Add(DataGridView1.CurrentRow.Cells(0).Value, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(3).Value, 1)
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
    End Sub
End Class