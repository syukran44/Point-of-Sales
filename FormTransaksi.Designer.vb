<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        btnExit = New Button()
        Button1 = New Button()
        Button3 = New Button()
        btnPOS = New Button()
        btnCRUD = New Button()
        Label2 = New Label()
        txtSearch = New TextBox()
        DataGridView1 = New DataGridView()
        Column7 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        lblWaktu = New Label()
        DataGridView2 = New DataGridView()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        pnlSideBar.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlSideBar
        ' 
        pnlSideBar.BackColor = Color.DeepSkyBlue
        pnlSideBar.Controls.Add(btnExit)
        pnlSideBar.Controls.Add(Button1)
        pnlSideBar.Controls.Add(Button3)
        pnlSideBar.Controls.Add(btnPOS)
        pnlSideBar.Controls.Add(btnCRUD)
        pnlSideBar.Dock = DockStyle.Left
        pnlSideBar.Location = New Point(0, 0)
        pnlSideBar.Name = "pnlSideBar"
        pnlSideBar.Size = New Size(99, 752)
        pnlSideBar.TabIndex = 6
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnExit.BackColor = Color.OrangeRed
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(18, 677)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(60, 53)
        btnExit.TabIndex = 4
        btnExit.TabStop = False
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Control
        Button1.Location = New Point(18, 157)
        Button1.Name = "Button1"
        Button1.Size = New Size(60, 53)
        Button1.TabIndex = 3
        Button1.TabStop = False
        Button1.Text = "Trans"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button3.BackColor = Color.OrangeRed
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.White
        Button3.Location = New Point(18, 1331)
        Button3.Name = "Button3"
        Button3.Size = New Size(60, 53)
        Button3.TabIndex = 2
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnPOS
        ' 
        btnPOS.BackColor = SystemColors.Control
        btnPOS.Location = New Point(18, 88)
        btnPOS.Name = "btnPOS"
        btnPOS.Size = New Size(60, 53)
        btnPOS.TabIndex = 1
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
        btnCRUD.TabIndex = 0
        btnCRUD.TabStop = False
        btnCRUD.Text = "CRUD"
        btnCRUD.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(133, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 17
        Label2.Text = "Search :"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(133, 45)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(385, 27)
        txtSearch.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column7, Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(133, 97)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1133, 540)
        DataGridView1.TabIndex = 18
        DataGridView1.TabStop = False
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "No."
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 50
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Nomor Transaksi"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Produk ID"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Nama Produk"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Harga Produk"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Kuantitas"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Total"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' lblWaktu
        ' 
        lblWaktu.AutoSize = True
        lblWaktu.Location = New Point(559, 17)
        lblWaktu.Name = "lblWaktu"
        lblWaktu.Size = New Size(112, 20)
        lblWaktu.TabIndex = 20
        lblWaktu.Text = "Rentang Waktu:"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.Anchor = AnchorStyles.Bottom
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Column8, Column9, Column10})
        DataGridView2.Enabled = False
        DataGridView2.Location = New Point(133, 664)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.ScrollBars = ScrollBars.None
        DataGridView2.ShowEditingIcon = False
        DataGridView2.Size = New Size(1133, 61)
        DataGridView2.TabIndex = 21
        DataGridView2.TabStop = False
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column8.HeaderText = "Tanggal"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column9.HeaderText = "Produk Terjual"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column10.HeaderText = "Total Keuntungan"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(559, 45)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(176, 27)
        DateTimePicker1.TabIndex = 2
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(747, 45)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(176, 27)
        DateTimePicker2.TabIndex = 3
        ' 
        ' FormTransaksi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1301, 752)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(DataGridView2)
        Controls.Add(lblWaktu)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        Controls.Add(pnlSideBar)
        Name = "FormTransaksi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormTransaksi"
        pnlSideBar.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnPOS As Button
    Friend WithEvents btnCRUD As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblWaktu As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
