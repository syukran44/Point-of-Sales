Public Class FormMain
    Private _currentUser As User

    Public Property CurrentUser As User
        Get
            Return _currentUser
        End Get
        Set(value As User)
            _currentUser = value
        End Set
    End Property

    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        'btnProduk.BackColor = Color.DodgerBlue
        If Not Panel1.Controls.Contains(Form1) Then
            With Form1
                .TopLevel = False
                .AutoSize = True
                .Size = Panel1.Size
                Panel1.Controls.Add(Form1)
            End With
        End If
        Form1.InitializeForm1()
        Form1.BringToFront()
        Form1.Show()
    End Sub

    Private Sub btnPOS_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        If Not Panel1.Controls.Contains(FormPOS) Then
            With FormPOS
                .TopLevel = False
                .AutoSize = True
                .Size = Panel1.Size
                Panel1.Controls.Add(FormPOS)
            End With
        End If
        FormPOS.BringToFront()
        FormPOS.Show()
    End Sub
    Private Sub btnPenjualan_Click(sender As Object, e As EventArgs) Handles btnPenjualan.Click
        If Not Panel1.Controls.Contains(FormPenjualan) Then
            With FormPenjualan
                .TopLevel = False
                .AutoSize = True
                .Size = Panel1.Size
                Panel1.Controls.Add(FormPenjualan)
            End With
        End If
        FormPenjualan.InitializeFormPenjualan()
        FormPenjualan.BringToFront()
        FormPenjualan.Show()
    End Sub

    Private Sub FormMain_Loaded(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        If UCase(CurrentUser.Role.ToString()) = "KASIR" Then
            Form1.Close()
            FormPembelian.Close()
            FormMember.Close()
            FormUser.Close()

            btnPOS.Visible = True
            btnProduk.Visible = False
            btnPembelian.Visible = False
            btnMember.Visible = False
            btnUser.Visible = False

            With FormPOS
                .TopLevel = False
                .AutoSize = True
                .Size = Panel1.Size
                Panel1.Controls.Add(FormPOS)
                .BringToFront()
                .Show()
            End With
        Else
            FormPOS.Close()

            btnProduk.Visible = True
            btnPOS.Visible = False
            btnMember.Visible = True
            btnUser.Visible = True

            With Form1
                .TopLevel = False
                .AutoSize = True
                .Size = Panel1.Size
                Panel1.Controls.Add(Form1)
                .BringToFront()
                .Show()
            End With
        End If
    End Sub

    Private Sub btnPembelian_Click(sender As Object, e As EventArgs) Handles btnPembelian.Click
        If Not Panel1.Controls.Contains(FormPembelian) Then
            With FormPembelian
                .TopLevel = False
                .AutoSize = True
                .Size = Panel1.Size
                Panel1.Controls.Add(FormPembelian)
            End With
        End If
        FormPembelian.InitializeFormPembelian()
        FormPembelian.BringToFront()
        FormPembelian.Show()
    End Sub

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        If Not Panel1.Controls.Contains(FormMember) Then
            With FormMember
                .TopLevel = False
                .AutoSize = True
                .Size = Panel1.Size
                Panel1.Controls.Add(FormMember)
            End With
        End If
        FormMember.InitializeFormMember()
        FormMember.BringToFront()
        FormMember.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Apakah kamu ingin Logout dari Aplikasi?", MsgBoxStyle.Question + vbYesNo) = MsgBoxResult.Yes Then
            Me.Close()
            FormLogin.Show()
        End If
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        If Not Panel1.Controls.Contains(FormUser) Then
            With FormUser
                .TopLevel = False
                .AutoSize = True
                .Size = Panel1.Size
                Panel1.Controls.Add(FormUser)
            End With
        End If
        FormUser.InitializeFormUser()
        FormUser.BringToFront()
        FormUser.Show()
    End Sub
End Class