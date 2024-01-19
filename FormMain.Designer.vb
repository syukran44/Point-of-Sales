<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlSideBar = New Panel()
        btnUser = New Button()
        btnMember = New Button()
        btnLogout = New Button()
        btnPembelian = New Button()
        btnPenjualan = New Button()
        btnPOS = New Button()
        btnProduk = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        pnlSideBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSideBar
        ' 
        pnlSideBar.BackColor = Color.DeepSkyBlue
        pnlSideBar.Controls.Add(btnUser)
        pnlSideBar.Controls.Add(btnMember)
        pnlSideBar.Controls.Add(btnLogout)
        pnlSideBar.Controls.Add(btnPembelian)
        pnlSideBar.Controls.Add(btnPenjualan)
        pnlSideBar.Controls.Add(btnPOS)
        pnlSideBar.Controls.Add(btnProduk)
        pnlSideBar.Controls.Add(Button3)
        pnlSideBar.Dock = DockStyle.Left
        pnlSideBar.Location = New Point(0, 0)
        pnlSideBar.Name = "pnlSideBar"
        pnlSideBar.Size = New Size(181, 752)
        pnlSideBar.TabIndex = 7
        ' 
        ' btnUser
        ' 
        btnUser.BackColor = Color.DeepSkyBlue
        btnUser.Dock = DockStyle.Top
        btnUser.FlatAppearance.MouseOverBackColor = Color.DodgerBlue
        btnUser.FlatStyle = FlatStyle.Popup
        btnUser.Location = New Point(0, 265)
        btnUser.Name = "btnUser"
        btnUser.Size = New Size(181, 53)
        btnUser.TabIndex = 8
        btnUser.TabStop = False
        btnUser.Text = "User"
        btnUser.UseVisualStyleBackColor = False
        ' 
        ' btnMember
        ' 
        btnMember.BackColor = Color.DeepSkyBlue
        btnMember.Dock = DockStyle.Top
        btnMember.FlatAppearance.MouseOverBackColor = Color.DodgerBlue
        btnMember.FlatStyle = FlatStyle.Popup
        btnMember.Location = New Point(0, 212)
        btnMember.Name = "btnMember"
        btnMember.Size = New Size(181, 53)
        btnMember.TabIndex = 7
        btnMember.TabStop = False
        btnMember.Text = "Member"
        btnMember.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLogout.BackColor = Color.OrangeRed
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(20, 679)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(141, 55)
        btnLogout.TabIndex = 6
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnPembelian
        ' 
        btnPembelian.BackColor = Color.DeepSkyBlue
        btnPembelian.Dock = DockStyle.Top
        btnPembelian.FlatAppearance.MouseOverBackColor = Color.DodgerBlue
        btnPembelian.FlatStyle = FlatStyle.Popup
        btnPembelian.Location = New Point(0, 159)
        btnPembelian.Name = "btnPembelian"
        btnPembelian.Size = New Size(181, 53)
        btnPembelian.TabIndex = 5
        btnPembelian.TabStop = False
        btnPembelian.Text = "Pembelian"
        btnPembelian.UseVisualStyleBackColor = False
        ' 
        ' btnPenjualan
        ' 
        btnPenjualan.BackColor = Color.DeepSkyBlue
        btnPenjualan.Dock = DockStyle.Top
        btnPenjualan.FlatAppearance.MouseOverBackColor = Color.DodgerBlue
        btnPenjualan.FlatStyle = FlatStyle.Popup
        btnPenjualan.Location = New Point(0, 106)
        btnPenjualan.Name = "btnPenjualan"
        btnPenjualan.Size = New Size(181, 53)
        btnPenjualan.TabIndex = 3
        btnPenjualan.TabStop = False
        btnPenjualan.Text = "Penjualan"
        btnPenjualan.UseVisualStyleBackColor = False
        ' 
        ' btnPOS
        ' 
        btnPOS.BackColor = Color.DeepSkyBlue
        btnPOS.Dock = DockStyle.Top
        btnPOS.FlatAppearance.MouseOverBackColor = Color.DodgerBlue
        btnPOS.FlatStyle = FlatStyle.Popup
        btnPOS.Location = New Point(0, 53)
        btnPOS.Name = "btnPOS"
        btnPOS.Size = New Size(181, 53)
        btnPOS.TabIndex = 1
        btnPOS.TabStop = False
        btnPOS.Text = "POS"
        btnPOS.UseVisualStyleBackColor = False
        ' 
        ' btnProduk
        ' 
        btnProduk.BackColor = Color.DeepSkyBlue
        btnProduk.Dock = DockStyle.Top
        btnProduk.FlatAppearance.BorderSize = 0
        btnProduk.FlatAppearance.MouseOverBackColor = Color.DodgerBlue
        btnProduk.FlatStyle = FlatStyle.Popup
        btnProduk.Location = New Point(0, 0)
        btnProduk.Name = "btnProduk"
        btnProduk.Size = New Size(181, 53)
        btnProduk.TabIndex = 0
        btnProduk.TabStop = False
        btnProduk.Text = "Produk"
        btnProduk.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button3.BackColor = Color.OrangeRed
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.White
        Button3.Location = New Point(18, 1983)
        Button3.Name = "Button3"
        Button3.Size = New Size(60, 53)
        Button3.TabIndex = 2
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.AutoSize = True
        Panel1.Location = New Point(181, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1120, 752)
        Panel1.TabIndex = 8
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1301, 752)
        Controls.Add(Panel1)
        Controls.Add(pnlSideBar)
        Name = "FormMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormMain"
        pnlSideBar.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents btnPembelian As Button
    Friend WithEvents btnPenjualan As Button
    Friend WithEvents btnPOS As Button
    Friend WithEvents btnProduk As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMember As Button
    Friend WithEvents btnUser As Button
End Class
