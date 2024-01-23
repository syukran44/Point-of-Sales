<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        Column9 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        ColumnHarga = New DataGridViewTextBoxColumn()
        ColumnDiskon = New DataGridViewTextBoxColumn()
        ColumnHargaDiskon = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        txtNama = New TextBox()
        txtHarga = New TextBox()
        Panel1 = New Panel()
        cmbKategoriInput = New ComboBox()
        btnBatal = New Button()
        btnSimpanTambah = New Button()
        Label6 = New Label()
        txtPoin = New TextBox()
        Label4 = New Label()
        txtDiskon = New TextBox()
        Label3 = New Label()
        lblProdukID = New Label()
        txtProdukID = New TextBox()
        btnClear = New Button()
        btnHapus = New Button()
        btnEdit = New Button()
        btnTambah = New Button()
        lblJumlah = New Label()
        txtJumlah = New TextBox()
        lblHarga = New Label()
        lblNama = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtSearch = New TextBox()
        btnCetak = New Button()
        Button1 = New Button()
        Label5 = New Label()
        cmbKategori = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column9, Column1, Column2, Column5, ColumnHarga, ColumnDiskon, ColumnHargaDiskon, Column7, Column4})
        DataGridView1.Location = New Point(342, 98)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(937, 629)
        DataGridView1.TabIndex = 5
        DataGridView1.TabStop = False
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "No."
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 50
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Produk ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 103
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
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column5.HeaderText = "Kategori"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' ColumnHarga
        ' 
        ColumnHarga.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight
        ColumnHarga.DefaultCellStyle = DataGridViewCellStyle1
        ColumnHarga.HeaderText = "Harga"
        ColumnHarga.MinimumWidth = 6
        ColumnHarga.Name = "ColumnHarga"
        ColumnHarga.ReadOnly = True
        ' 
        ' ColumnDiskon
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight
        ColumnDiskon.DefaultCellStyle = DataGridViewCellStyle2
        ColumnDiskon.HeaderText = "Diskon"
        ColumnDiskon.MinimumWidth = 6
        ColumnDiskon.Name = "ColumnDiskon"
        ColumnDiskon.ReadOnly = True
        ColumnDiskon.Width = 80
        ' 
        ' ColumnHargaDiskon
        ' 
        ColumnHargaDiskon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight
        ColumnHargaDiskon.DefaultCellStyle = DataGridViewCellStyle3
        ColumnHargaDiskon.HeaderText = "Harga Diskon"
        ColumnHargaDiskon.MinimumWidth = 6
        ColumnHargaDiskon.Name = "ColumnHargaDiskon"
        ColumnHargaDiskon.ReadOnly = True
        ' 
        ' Column7
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight
        Column7.DefaultCellStyle = DataGridViewCellStyle4
        Column7.HeaderText = "Poin"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 125
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight
        Column4.DefaultCellStyle = DataGridViewCellStyle5
        Column4.HeaderText = "Stok (PCS)"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 98
        ' 
        ' txtNama
        ' 
        txtNama.Anchor = AnchorStyles.Left
        txtNama.Location = New Point(39, 168)
        txtNama.Name = "txtNama"
        txtNama.ReadOnly = True
        txtNama.Size = New Size(224, 38)
        txtNama.TabIndex = 2
        ' 
        ' txtHarga
        ' 
        txtHarga.Anchor = AnchorStyles.Left
        txtHarga.Location = New Point(39, 316)
        txtHarga.Name = "txtHarga"
        txtHarga.ReadOnly = True
        txtHarga.Size = New Size(224, 38)
        txtHarga.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Controls.Add(cmbKategoriInput)
        Panel1.Controls.Add(btnBatal)
        Panel1.Controls.Add(btnSimpanTambah)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtPoin)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtDiskon)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(lblProdukID)
        Panel1.Controls.Add(txtProdukID)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(lblJumlah)
        Panel1.Controls.Add(txtJumlah)
        Panel1.Controls.Add(lblHarga)
        Panel1.Controls.Add(lblNama)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtHarga)
        Panel1.Controls.Add(txtNama)
        Panel1.Dock = DockStyle.Left
        Panel1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(318, 752)
        Panel1.TabIndex = 4
        ' 
        ' cmbKategoriInput
        ' 
        cmbKategoriInput.Anchor = AnchorStyles.Left
        cmbKategoriInput.Enabled = False
        cmbKategoriInput.FormattingEnabled = True
        cmbKategoriInput.Location = New Point(39, 244)
        cmbKategoriInput.Name = "cmbKategoriInput"
        cmbKategoriInput.Size = New Size(218, 39)
        cmbKategoriInput.TabIndex = 22
        ' 
        ' btnBatal
        ' 
        btnBatal.Anchor = AnchorStyles.Left
        btnBatal.BackColor = Color.OrangeRed
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatAppearance.MouseDownBackColor = Color.Lime
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(157, 702)
        btnBatal.Margin = New Padding(0)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(106, 43)
        btnBatal.TabIndex = 21
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        btnBatal.Visible = False
        ' 
        ' btnSimpanTambah
        ' 
        btnSimpanTambah.Anchor = AnchorStyles.Left
        btnSimpanTambah.BackColor = Color.LimeGreen
        btnSimpanTambah.FlatAppearance.BorderSize = 0
        btnSimpanTambah.FlatAppearance.MouseDownBackColor = Color.Lime
        btnSimpanTambah.FlatStyle = FlatStyle.Flat
        btnSimpanTambah.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpanTambah.ForeColor = Color.White
        btnSimpanTambah.Location = New Point(39, 702)
        btnSimpanTambah.Margin = New Padding(0)
        btnSimpanTambah.Name = "btnSimpanTambah"
        btnSimpanTambah.Size = New Size(106, 43)
        btnSimpanTambah.TabIndex = 20
        btnSimpanTambah.Text = "Simpan"
        btnSimpanTambah.UseVisualStyleBackColor = False
        btnSimpanTambah.Visible = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(39, 441)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 20)
        Label6.TabIndex = 19
        Label6.Text = "Poin :"
        ' 
        ' txtPoin
        ' 
        txtPoin.Anchor = AnchorStyles.Left
        txtPoin.Location = New Point(39, 464)
        txtPoin.Name = "txtPoin"
        txtPoin.ReadOnly = True
        txtPoin.Size = New Size(224, 38)
        txtPoin.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(39, 366)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 17
        Label4.Text = "Diskon (%) :"
        ' 
        ' txtDiskon
        ' 
        txtDiskon.Anchor = AnchorStyles.Left
        txtDiskon.Location = New Point(39, 390)
        txtDiskon.MaxLength = 2
        txtDiskon.Name = "txtDiskon"
        txtDiskon.ReadOnly = True
        txtDiskon.Size = New Size(224, 38)
        txtDiskon.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(39, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 15
        Label3.Text = "Kategori :"
        ' 
        ' lblProdukID
        ' 
        lblProdukID.Anchor = AnchorStyles.Left
        lblProdukID.AutoSize = True
        lblProdukID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProdukID.Location = New Point(39, 66)
        lblProdukID.Name = "lblProdukID"
        lblProdukID.Size = New Size(81, 20)
        lblProdukID.TabIndex = 13
        lblProdukID.Text = "Produk ID :"
        ' 
        ' txtProdukID
        ' 
        txtProdukID.Anchor = AnchorStyles.Left
        txtProdukID.CharacterCasing = CharacterCasing.Upper
        txtProdukID.Location = New Point(39, 94)
        txtProdukID.Name = "txtProdukID"
        txtProdukID.ReadOnly = True
        txtProdukID.Size = New Size(224, 38)
        txtProdukID.TabIndex = 1
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Left
        btnClear.BackColor = SystemColors.AppWorkspace
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatAppearance.MouseDownBackColor = Color.Yellow
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.Black
        btnClear.Location = New Point(157, 656)
        btnClear.Margin = New Padding(0)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 43)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.Anchor = AnchorStyles.Left
        btnHapus.BackColor = Color.OrangeRed
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatAppearance.MouseDownBackColor = Color.Lime
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(39, 656)
        btnHapus.Margin = New Padding(0)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(106, 43)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Left
        btnEdit.BackColor = Color.Gold
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatAppearance.MouseDownBackColor = Color.Yellow
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(157, 598)
        btnEdit.Margin = New Padding(0)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(106, 43)
        btnEdit.TabIndex = 10
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnTambah
        ' 
        btnTambah.Anchor = AnchorStyles.Left
        btnTambah.BackColor = Color.LimeGreen
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatAppearance.MouseDownBackColor = Color.Lime
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(39, 598)
        btnTambah.Margin = New Padding(0)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(106, 43)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' lblJumlah
        ' 
        lblJumlah.Anchor = AnchorStyles.Left
        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJumlah.Location = New Point(39, 516)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(45, 20)
        lblJumlah.TabIndex = 7
        lblJumlah.Text = "Stok :"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Anchor = AnchorStyles.Left
        txtJumlah.Location = New Point(39, 538)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.ReadOnly = True
        txtJumlah.Size = New Size(224, 38)
        txtJumlah.TabIndex = 7
        ' 
        ' lblHarga
        ' 
        lblHarga.Anchor = AnchorStyles.Left
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHarga.Location = New Point(39, 291)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(57, 20)
        lblHarga.TabIndex = 5
        lblHarga.Text = "Harga :"
        ' 
        ' lblNama
        ' 
        lblNama.Anchor = AnchorStyles.Left
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(39, 141)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 20)
        lblNama.TabIndex = 4
        lblNama.Text = "Nama :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label1.Location = New Point(17, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 31)
        Label1.TabIndex = 3
        Label1.Text = "PRODUK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(342, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 13
        Label2.Text = "Search :"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(342, 45)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(366, 27)
        txtSearch.TabIndex = 0
        ' 
        ' btnCetak
        ' 
        btnCetak.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCetak.BackColor = Color.MediumAquamarine
        btnCetak.FlatAppearance.BorderSize = 0
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(1173, 35)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(106, 47)
        btnCetak.TabIndex = 13
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.LimeGreen
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Lime
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1053, 35)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 47)
        Button1.TabIndex = 12
        Button1.Text = "Beli"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(714, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 20)
        Label5.TabIndex = 38
        Label5.Text = "Kategori :"
        ' 
        ' cmbKategori
        ' 
        cmbKategori.FormattingEnabled = True
        cmbKategori.Location = New Point(714, 44)
        cmbKategori.Name = "cmbKategori"
        cmbKategori.Size = New Size(153, 28)
        cmbKategori.TabIndex = 37
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1301, 752)
        Controls.Add(Label5)
        Controls.Add(cmbKategori)
        Controls.Add(Button1)
        Controls.Add(btnCetak)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(txtSearch)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CRUD Operation"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblProdukID As Label
    Friend WithEvents txtProdukID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCetak As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPoin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDiskon As TextBox
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDiskon As DataGridViewTextBoxColumn
    Friend WithEvents ColumnHargaDiskon As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnSimpanTambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents cmbKategoriInput As ComboBox

End Class
