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
        DataGridView1 = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        txtNama = New TextBox()
        txtHarga = New TextBox()
        pnlSideBar = New Panel()
        btnTrans = New Button()
        btnExit = New Button()
        btnPOS = New Button()
        btnCRUD = New Button()
        Panel1 = New Panel()
        lblProdukID = New Label()
        txtProdukID = New TextBox()
        btnClear = New Button()
        btnHapus = New Button()
        btnEdit = New Button()
        btnTambah = New Button()
        lblStok = New Label()
        txtJumlah = New TextBox()
        lblHarga = New Label()
        lblNama = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtSearch = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        pnlSideBar.SuspendLayout()
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {id, Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(466, 101)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(764, 602)
        DataGridView1.TabIndex = 5
        DataGridView1.TabStop = False
        ' 
        ' id
        ' 
        id.HeaderText = "ID"
        id.MinimumWidth = 6
        id.Name = "id"
        id.ReadOnly = True
        id.Visible = False
        id.Width = 125
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
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Harga"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Stok"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 67
        ' 
        ' txtNama
        ' 
        txtNama.Anchor = AnchorStyles.Left
        txtNama.Location = New Point(42, 268)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(224, 38)
        txtNama.TabIndex = 2
        ' 
        ' txtHarga
        ' 
        txtHarga.Anchor = AnchorStyles.Left
        txtHarga.Location = New Point(42, 349)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(224, 38)
        txtHarga.TabIndex = 3
        ' 
        ' pnlSideBar
        ' 
        pnlSideBar.BackColor = Color.DeepSkyBlue
        pnlSideBar.Controls.Add(btnTrans)
        pnlSideBar.Controls.Add(btnExit)
        pnlSideBar.Controls.Add(btnPOS)
        pnlSideBar.Controls.Add(btnCRUD)
        pnlSideBar.Dock = DockStyle.Left
        pnlSideBar.Location = New Point(0, 0)
        pnlSideBar.Name = "pnlSideBar"
        pnlSideBar.Size = New Size(99, 752)
        pnlSideBar.TabIndex = 3
        ' 
        ' btnTrans
        ' 
        btnTrans.BackColor = SystemColors.Control
        btnTrans.Location = New Point(18, 157)
        btnTrans.Name = "btnTrans"
        btnTrans.Size = New Size(60, 53)
        btnTrans.TabIndex = 22
        btnTrans.TabStop = False
        btnTrans.Text = "Trans"
        btnTrans.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnExit.BackColor = Color.OrangeRed
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(18, 674)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(60, 53)
        btnExit.TabIndex = 23
        btnExit.TabStop = False
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnPOS
        ' 
        btnPOS.BackColor = SystemColors.Control
        btnPOS.Location = New Point(18, 88)
        btnPOS.Name = "btnPOS"
        btnPOS.Size = New Size(60, 53)
        btnPOS.TabIndex = 21
        btnPOS.TabStop = False
        btnPOS.Text = "POS"
        btnPOS.UseVisualStyleBackColor = False
        ' 
        ' btnCRUD
        ' 
        btnCRUD.BackColor = SystemColors.Control
        btnCRUD.Location = New Point(18, 19)
        btnCRUD.Name = "btnCRUD"
        btnCRUD.Size = New Size(60, 53)
        btnCRUD.TabIndex = 20
        btnCRUD.TabStop = False
        btnCRUD.Text = "CRUD"
        btnCRUD.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Controls.Add(lblProdukID)
        Panel1.Controls.Add(txtProdukID)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(lblStok)
        Panel1.Controls.Add(txtJumlah)
        Panel1.Controls.Add(lblHarga)
        Panel1.Controls.Add(lblNama)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtHarga)
        Panel1.Controls.Add(txtNama)
        Panel1.Dock = DockStyle.Left
        Panel1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Panel1.Location = New Point(99, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(318, 752)
        Panel1.TabIndex = 4
        ' 
        ' lblProdukID
        ' 
        lblProdukID.Anchor = AnchorStyles.Left
        lblProdukID.AutoSize = True
        lblProdukID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProdukID.Location = New Point(42, 162)
        lblProdukID.Name = "lblProdukID"
        lblProdukID.Size = New Size(81, 20)
        lblProdukID.TabIndex = 13
        lblProdukID.Text = "Produk ID :"
        ' 
        ' txtProdukID
        ' 
        txtProdukID.Anchor = AnchorStyles.Left
        txtProdukID.Location = New Point(42, 190)
        txtProdukID.Name = "txtProdukID"
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
        btnClear.Location = New Point(160, 556)
        btnClear.Margin = New Padding(0)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 43)
        btnClear.TabIndex = 11
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
        btnHapus.Location = New Point(42, 556)
        btnHapus.Margin = New Padding(0)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(106, 43)
        btnHapus.TabIndex = 10
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
        btnEdit.Location = New Point(160, 498)
        btnEdit.Margin = New Padding(0)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(106, 43)
        btnEdit.TabIndex = 9
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
        btnTambah.Location = New Point(42, 498)
        btnTambah.Margin = New Padding(0)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(106, 43)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' lblStok
        ' 
        lblStok.Anchor = AnchorStyles.Left
        lblStok.AutoSize = True
        lblStok.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStok.Location = New Point(42, 404)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(45, 20)
        lblStok.TabIndex = 7
        lblStok.Text = "Stok :"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Anchor = AnchorStyles.Left
        txtJumlah.Location = New Point(42, 429)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(224, 38)
        txtJumlah.TabIndex = 4
        ' 
        ' lblHarga
        ' 
        lblHarga.Anchor = AnchorStyles.Left
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHarga.Location = New Point(42, 324)
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
        lblNama.Location = New Point(42, 240)
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
        Label2.Location = New Point(466, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 13
        Label2.Text = "Search :"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(466, 48)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(366, 27)
        txtSearch.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1301, 752)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(txtSearch)
        Controls.Add(Panel1)
        Controls.Add(pnlSideBar)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CRUD Operation"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        pnlSideBar.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblStok As Label
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
    Friend WithEvents btnCRUD As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPOS As Button
    Friend WithEvents btnTrans As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn

End Class
