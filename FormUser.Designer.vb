<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        Panel1 = New Panel()
        btnEye = New Button()
        cmbRole = New ComboBox()
        lblKodeMember = New Label()
        txtUsername = New TextBox()
        btnClear = New Button()
        btnHapus = New Button()
        btnEdit = New Button()
        btnTambah = New Button()
        lblPoin = New Label()
        txtNama = New TextBox()
        lblMasaAktif = New Label()
        lblNama = New Label()
        Label1 = New Label()
        txtPassword = New TextBox()
        Label2 = New Label()
        txtSearch = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Controls.Add(btnEye)
        Panel1.Controls.Add(cmbRole)
        Panel1.Controls.Add(lblKodeMember)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(lblPoin)
        Panel1.Controls.Add(txtNama)
        Panel1.Controls.Add(lblMasaAktif)
        Panel1.Controls.Add(lblNama)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtPassword)
        Panel1.Dock = DockStyle.Left
        Panel1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(318, 752)
        Panel1.TabIndex = 6
        ' 
        ' btnEye
        ' 
        btnEye.Anchor = AnchorStyles.Left
        btnEye.BackgroundImage = CType(resources.GetObject("btnEye.BackgroundImage"), Image)
        btnEye.BackgroundImageLayout = ImageLayout.Zoom
        btnEye.Cursor = Cursors.Hand
        btnEye.FlatAppearance.BorderSize = 0
        btnEye.FlatAppearance.MouseDownBackColor = Color.White
        btnEye.FlatAppearance.MouseOverBackColor = Color.White
        btnEye.FlatStyle = FlatStyle.Flat
        btnEye.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEye.Location = New Point(265, 258)
        btnEye.Name = "btnEye"
        btnEye.Size = New Size(31, 31)
        btnEye.TabIndex = 28
        btnEye.UseVisualStyleBackColor = True
        ' 
        ' cmbRole
        ' 
        cmbRole.Anchor = AnchorStyles.Left
        cmbRole.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"admin", "kasir"})
        cmbRole.Location = New Point(47, 405)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(224, 33)
        cmbRole.TabIndex = 27
        ' 
        ' lblKodeMember
        ' 
        lblKodeMember.Anchor = AnchorStyles.Left
        lblKodeMember.AutoSize = True
        lblKodeMember.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKodeMember.Location = New Point(47, 153)
        lblKodeMember.Name = "lblKodeMember"
        lblKodeMember.Size = New Size(82, 20)
        lblKodeMember.TabIndex = 26
        lblKodeMember.Text = "Username :"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Left
        txtUsername.Location = New Point(47, 180)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(224, 38)
        txtUsername.TabIndex = 1
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
        btnClear.Location = New Point(163, 534)
        btnClear.Margin = New Padding(0)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 43)
        btnClear.TabIndex = 7
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
        btnHapus.Location = New Point(45, 534)
        btnHapus.Margin = New Padding(0)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(106, 43)
        btnHapus.TabIndex = 8
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
        btnEdit.Location = New Point(163, 476)
        btnEdit.Margin = New Padding(0)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(106, 43)
        btnEdit.TabIndex = 6
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
        btnTambah.Location = New Point(45, 476)
        btnTambah.Margin = New Padding(0)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(106, 43)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' lblPoin
        ' 
        lblPoin.Anchor = AnchorStyles.Left
        lblPoin.AutoSize = True
        lblPoin.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPoin.Location = New Point(47, 305)
        lblPoin.Name = "lblPoin"
        lblPoin.Size = New Size(56, 20)
        lblPoin.TabIndex = 15
        lblPoin.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Anchor = AnchorStyles.Left
        txtNama.Location = New Point(47, 330)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(224, 38)
        txtNama.TabIndex = 3
        ' 
        ' lblMasaAktif
        ' 
        lblMasaAktif.Anchor = AnchorStyles.Left
        lblMasaAktif.AutoSize = True
        lblMasaAktif.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMasaAktif.Location = New Point(47, 381)
        lblMasaAktif.Name = "lblMasaAktif"
        lblMasaAktif.Size = New Size(46, 20)
        lblMasaAktif.TabIndex = 5
        lblMasaAktif.Text = "Role :"
        ' 
        ' lblNama
        ' 
        lblNama.Anchor = AnchorStyles.Left
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(47, 229)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(77, 20)
        lblNama.TabIndex = 4
        lblNama.Text = "Password :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label1.Location = New Point(17, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 31)
        Label1.TabIndex = 3
        Label1.Text = "USER"
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Left
        txtPassword.Location = New Point(47, 255)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(207, 38)
        txtPassword.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(342, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 21
        Label2.Text = "Search :"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(342, 45)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(366, 27)
        txtSearch.TabIndex = 20
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(342, 98)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(938, 631)
        DataGridView1.TabIndex = 22
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "No."
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 50
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Username"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Nama"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Role"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1301, 752)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormUser"
        Text = "FormUser"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblKodeMember As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblPoin As Label
    Friend WithEvents lblMasaAktif As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnEye As Button
End Class
