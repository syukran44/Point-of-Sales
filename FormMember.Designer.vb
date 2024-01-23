<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMember
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnSimpanEdit = New Button()
        btnGenerate = New Button()
        btnBatal = New Button()
        btnSimpanTambah = New Button()
        lblKodeMember = New Label()
        txtKodeMember = New TextBox()
        btnClear = New Button()
        btnHapus = New Button()
        btnEdit = New Button()
        btnTambah = New Button()
        DateTimePicker1 = New DateTimePicker()
        lblPoin = New Label()
        txtPoin = New TextBox()
        lblMasaAktif = New Label()
        lblNama = New Label()
        txtNama = New TextBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        txtSearch = New TextBox()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(318, 752)
        Panel1.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Left
        Panel2.Controls.Add(btnSimpanEdit)
        Panel2.Controls.Add(btnGenerate)
        Panel2.Controls.Add(btnBatal)
        Panel2.Controls.Add(btnSimpanTambah)
        Panel2.Controls.Add(lblKodeMember)
        Panel2.Controls.Add(txtKodeMember)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnHapus)
        Panel2.Controls.Add(btnEdit)
        Panel2.Controls.Add(btnTambah)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(lblPoin)
        Panel2.Controls.Add(txtPoin)
        Panel2.Controls.Add(lblMasaAktif)
        Panel2.Controls.Add(lblNama)
        Panel2.Controls.Add(txtNama)
        Panel2.Location = New Point(33, 96)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(251, 577)
        Panel2.TabIndex = 30
        ' 
        ' btnSimpanEdit
        ' 
        btnSimpanEdit.BackColor = Color.LimeGreen
        btnSimpanEdit.FlatAppearance.BorderSize = 0
        btnSimpanEdit.FlatAppearance.MouseDownBackColor = Color.Lime
        btnSimpanEdit.FlatStyle = FlatStyle.Flat
        btnSimpanEdit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpanEdit.ForeColor = Color.White
        btnSimpanEdit.Location = New Point(12, 525)
        btnSimpanEdit.Margin = New Padding(0)
        btnSimpanEdit.Name = "btnSimpanEdit"
        btnSimpanEdit.Size = New Size(106, 43)
        btnSimpanEdit.TabIndex = 30
        btnSimpanEdit.Text = "Simpan"
        btnSimpanEdit.UseVisualStyleBackColor = False
        btnSimpanEdit.Visible = False
        ' 
        ' btnGenerate
        ' 
        btnGenerate.Anchor = AnchorStyles.Left
        btnGenerate.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGenerate.Location = New Point(12, 15)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(100, 36)
        btnGenerate.TabIndex = 29
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = True
        btnGenerate.Visible = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.OrangeRed
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatAppearance.MouseDownBackColor = Color.Lime
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(130, 470)
        btnBatal.Margin = New Padding(0)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(106, 43)
        btnBatal.TabIndex = 28
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        btnBatal.Visible = False
        ' 
        ' btnSimpanTambah
        ' 
        btnSimpanTambah.BackColor = Color.LimeGreen
        btnSimpanTambah.FlatAppearance.BorderSize = 0
        btnSimpanTambah.FlatAppearance.MouseDownBackColor = Color.Lime
        btnSimpanTambah.FlatStyle = FlatStyle.Flat
        btnSimpanTambah.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpanTambah.ForeColor = Color.White
        btnSimpanTambah.Location = New Point(12, 470)
        btnSimpanTambah.Margin = New Padding(0)
        btnSimpanTambah.Name = "btnSimpanTambah"
        btnSimpanTambah.Size = New Size(106, 43)
        btnSimpanTambah.TabIndex = 27
        btnSimpanTambah.Text = "Simpan"
        btnSimpanTambah.UseVisualStyleBackColor = False
        btnSimpanTambah.Visible = False
        ' 
        ' lblKodeMember
        ' 
        lblKodeMember.AutoSize = True
        lblKodeMember.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKodeMember.Location = New Point(12, 58)
        lblKodeMember.Name = "lblKodeMember"
        lblKodeMember.Size = New Size(111, 20)
        lblKodeMember.TabIndex = 26
        lblKodeMember.Text = "Kode Member :"
        ' 
        ' txtKodeMember
        ' 
        txtKodeMember.CharacterCasing = CharacterCasing.Upper
        txtKodeMember.Location = New Point(14, 84)
        txtKodeMember.MaxLength = 8
        txtKodeMember.Name = "txtKodeMember"
        txtKodeMember.ReadOnly = True
        txtKodeMember.Size = New Size(224, 38)
        txtKodeMember.TabIndex = 1
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.AppWorkspace
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatAppearance.MouseDownBackColor = Color.Yellow
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.Black
        btnClear.Location = New Point(130, 414)
        btnClear.Margin = New Padding(0)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 43)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.OrangeRed
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatAppearance.MouseDownBackColor = Color.Lime
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(12, 414)
        btnHapus.Margin = New Padding(0)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(106, 43)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Gold
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatAppearance.MouseDownBackColor = Color.Yellow
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(130, 358)
        btnEdit.Margin = New Padding(0)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(106, 43)
        btnEdit.TabIndex = 6
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.LimeGreen
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatAppearance.MouseDownBackColor = Color.Lime
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(12, 358)
        btnTambah.Margin = New Padding(0)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(106, 43)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Enabled = False
        DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(14, 313)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(169, 27)
        DateTimePicker1.TabIndex = 4
        ' 
        ' lblPoin
        ' 
        lblPoin.AutoSize = True
        lblPoin.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPoin.Location = New Point(13, 208)
        lblPoin.Name = "lblPoin"
        lblPoin.Size = New Size(44, 20)
        lblPoin.TabIndex = 15
        lblPoin.Text = "Poin :"
        ' 
        ' txtPoin
        ' 
        txtPoin.Location = New Point(14, 236)
        txtPoin.Name = "txtPoin"
        txtPoin.ReadOnly = True
        txtPoin.Size = New Size(224, 38)
        txtPoin.TabIndex = 3
        ' 
        ' lblMasaAktif
        ' 
        lblMasaAktif.AutoSize = True
        lblMasaAktif.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMasaAktif.Location = New Point(14, 286)
        lblMasaAktif.Name = "lblMasaAktif"
        lblMasaAktif.Size = New Size(86, 20)
        lblMasaAktif.TabIndex = 5
        lblMasaAktif.Text = "Masa Aktif :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(13, 133)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 20)
        lblNama.TabIndex = 4
        lblNama.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(14, 160)
        txtNama.Name = "txtNama"
        txtNama.ReadOnly = True
        txtNama.Size = New Size(224, 38)
        txtNama.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label1.Location = New Point(17, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 31)
        Label1.TabIndex = 3
        Label1.Text = "MEMBER"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column5, Column6, Column1, Column2, Column7, Column3, Column4, Column8})
        DataGridView1.Location = New Point(342, 98)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(938, 631)
        DataGridView1.TabIndex = 6
        DataGridView1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(342, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 19
        Label2.Text = "Search :"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(342, 45)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(366, 27)
        txtSearch.TabIndex = 0
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "No."
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 50
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column6.HeaderText = "Kode Member"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Nama"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight
        Column2.DefaultCellStyle = DataGridViewCellStyle1
        Column2.HeaderText = "Poin"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Tingkat"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 125
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Registrasi Awal"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Masa Aktif S/D"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Status"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 125
        ' 
        ' FormMember
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1301, 752)
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormMember"
        Text = "Form Member"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblPoin As Label
    Friend WithEvents txtPoin As TextBox
    Friend WithEvents lblMasaAktif As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblKodeMember As Label
    Friend WithEvents txtKodeMember As TextBox
    Friend WithEvents btnSimpanTambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSimpanEdit As Button
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
