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
    End Sub

    Public Sub DGVRead()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_produk", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("produk_id"), dr.Item("nama"), dr.Item("harga"), dr.Item("jumlah"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class