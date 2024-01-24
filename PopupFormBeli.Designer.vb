<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopupFormBeli
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        txtSearch = New TextBox()
        btnTambah = New Button()
        cmbKategori = New ComboBox()
        txtQty = New TextBox()
        Label1 = New Label()
        txtDiskon = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtTotal = New TextBox()
        DataGridView2 = New DataGridView()
        Label5 = New Label()
        Label6 = New Label()
        btnBeli = New Button()
        Label7 = New Label()
        txtPajak = New TextBox()
        Label8 = New Label()
        txtProdukID = New TextBox()
        Label9 = New Label()
        btnTutup = New Button()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 26
        Label2.Text = "Search :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column5, Column3})
        DataGridView1.Location = New Point(21, 103)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(494, 428)
        DataGridView1.TabIndex = 25
        DataGridView1.TabStop = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(21, 38)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(206, 27)
        txtSearch.TabIndex = 0
        ' 
        ' btnTambah
        ' 
        btnTambah.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTambah.BackColor = Color.LightSeaGreen
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatAppearance.MouseDownBackColor = Color.Lime
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(920, 22)
        btnTambah.Margin = New Padding(0)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(106, 43)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambahkan"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' cmbKategori
        ' 
        cmbKategori.FormattingEnabled = True
        cmbKategori.Location = New Point(233, 37)
        cmbKategori.Name = "cmbKategori"
        cmbKategori.Size = New Size(153, 28)
        cmbKategori.TabIndex = 1
        ' 
        ' txtQty
        ' 
        txtQty.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtQty.Location = New Point(829, 38)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(63, 27)
        txtQty.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(825, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 30
        Label1.Text = "Qty (PCS) :"
        ' 
        ' txtDiskon
        ' 
        txtDiskon.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtDiskon.Location = New Point(541, 578)
        txtDiskon.MaxLength = 2
        txtDiskon.Name = "txtDiskon"
        txtDiskon.Size = New Size(84, 27)
        txtDiskon.TabIndex = 4
        txtDiskon.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(538, 549)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 32
        Label3.Text = "Diskon (%) :"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(744, 549)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 33
        Label4.Text = "Total (Rp.) :"
        ' 
        ' txtTotal
        ' 
        txtTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtTotal.Location = New Point(744, 578)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.RightToLeft = RightToLeft.Yes
        txtTotal.Size = New Size(148, 27)
        txtTotal.TabIndex = 34
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToResizeColumns = False
        DataGridView2.AllowUserToResizeRows = False
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, Column4, Column6, Column7})
        DataGridView2.Location = New Point(532, 103)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(494, 428)
        DataGridView2.TabIndex = 35
        DataGridView2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(233, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 20)
        Label5.TabIndex = 36
        Label5.Text = "Kategori :"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Location = New Point(21, 77)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 20)
        Label6.TabIndex = 37
        Label6.Text = "Daftar Produk :"
        ' 
        ' btnBeli
        ' 
        btnBeli.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnBeli.BackColor = Color.LimeGreen
        btnBeli.FlatAppearance.BorderSize = 0
        btnBeli.FlatAppearance.MouseDownBackColor = Color.Lime
        btnBeli.FlatStyle = FlatStyle.Flat
        btnBeli.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBeli.ForeColor = Color.White
        btnBeli.Location = New Point(914, 562)
        btnBeli.Margin = New Padding(0)
        btnBeli.Name = "btnBeli"
        btnBeli.Size = New Size(106, 43)
        btnBeli.TabIndex = 6
        btnBeli.Text = "Beli"
        btnBeli.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Location = New Point(638, 549)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 20)
        Label7.TabIndex = 42
        Label7.Text = "Pajak (%) :"
        ' 
        ' txtPajak
        ' 
        txtPajak.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtPajak.Location = New Point(643, 578)
        txtPajak.MaxLength = 2
        txtPajak.Name = "txtPajak"
        txtPajak.Size = New Size(84, 27)
        txtPajak.TabIndex = 5
        txtPajak.Text = "0"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Location = New Point(717, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(81, 20)
        Label8.TabIndex = 40
        Label8.Text = "Produk ID :"
        ' 
        ' txtProdukID
        ' 
        txtProdukID.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtProdukID.Location = New Point(721, 38)
        txtProdukID.Name = "txtProdukID"
        txtProdukID.Size = New Size(91, 27)
        txtProdukID.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(532, 77)
        Label9.Name = "Label9"
        Label9.Size = New Size(93, 20)
        Label9.TabIndex = 43
        Label9.Text = "Akan Dibeli :"
        ' 
        ' btnTutup
        ' 
        btnTutup.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnTutup.BackColor = Color.OrangeRed
        btnTutup.FlatAppearance.BorderSize = 0
        btnTutup.FlatAppearance.MouseDownBackColor = Color.Lime
        btnTutup.FlatStyle = FlatStyle.Flat
        btnTutup.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(21, 562)
        btnTutup.Margin = New Padding(0)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(106, 43)
        btnTutup.TabIndex = 7
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column1.HeaderText = "Produk ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 70
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Nama"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Kategori"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight
        Column3.DefaultCellStyle = DataGridViewCellStyle1
        Column3.HeaderText = "Harga"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 90
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Produk ID"
        DataGridViewTextBoxColumn2.MinimumWidth = 6
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Width = 70
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn3.FillWeight = 85.71429F
        DataGridViewTextBoxColumn3.HeaderText = "Nama"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewTextBoxColumn4.FillWeight = 114.285713F
        DataGridViewTextBoxColumn4.HeaderText = "Harga"
        DataGridViewTextBoxColumn4.MinimumWidth = 6
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        DataGridViewTextBoxColumn4.Width = 125
        ' 
        ' Column4
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight
        Column4.DefaultCellStyle = DataGridViewCellStyle3
        Column4.HeaderText = "Qty (PCS)"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 70
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Kategori"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Visible = False
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Total"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Visible = False
        Column7.Width = 125
        ' 
        ' PopupFormBeli
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1055, 627)
        Controls.Add(btnTutup)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(txtPajak)
        Controls.Add(Label8)
        Controls.Add(txtProdukID)
        Controls.Add(btnBeli)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(DataGridView2)
        Controls.Add(txtTotal)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtDiskon)
        Controls.Add(Label1)
        Controls.Add(txtQty)
        Controls.Add(cmbKategori)
        Controls.Add(btnTambah)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(txtSearch)
        FormBorderStyle = FormBorderStyle.None
        Name = "PopupFormBeli"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Pembelian"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDiskon As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBeli As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPajak As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProdukID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnTutup As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
