<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailTransaksi
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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        lblNomorTransaksi = New Label()
        btnCetakInvoice = New Button()
        Label2 = New Label()
        lblNamaKasir = New Label()
        Label3 = New Label()
        lblWaktu = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column3, Column4, Column5, Column6, Column7})
        DataGridView1.Location = New Point(15, 67)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1006, 442)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "No."
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 50
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Produk ID"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Nama Produk"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight
        Column5.DefaultCellStyle = DataGridViewCellStyle7
        Column5.HeaderText = "Harga Produk"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight
        Column6.DefaultCellStyle = DataGridViewCellStyle8
        Column6.HeaderText = "Kuantitas"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 80
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight
        Column7.DefaultCellStyle = DataGridViewCellStyle9
        Column7.HeaderText = "Total Harga"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(30, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 28)
        Label1.TabIndex = 1
        Label1.Text = "No Transaksi :"
        ' 
        ' lblNomorTransaksi
        ' 
        lblNomorTransaksi.Anchor = AnchorStyles.Top
        lblNomorTransaksi.AutoSize = True
        lblNomorTransaksi.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNomorTransaksi.Location = New Point(166, 17)
        lblNomorTransaksi.Name = "lblNomorTransaksi"
        lblNomorTransaksi.Size = New Size(78, 28)
        lblNomorTransaksi.TabIndex = 2
        lblNomorTransaksi.Text = "Nomor"
        ' 
        ' btnCetakInvoice
        ' 
        btnCetakInvoice.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCetakInvoice.BackColor = Color.LightSeaGreen
        btnCetakInvoice.FlatAppearance.BorderSize = 0
        btnCetakInvoice.FlatAppearance.MouseDownBackColor = Color.Lime
        btnCetakInvoice.FlatStyle = FlatStyle.Flat
        btnCetakInvoice.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCetakInvoice.ForeColor = Color.White
        btnCetakInvoice.Location = New Point(882, 528)
        btnCetakInvoice.Margin = New Padding(0)
        btnCetakInvoice.Name = "btnCetakInvoice"
        btnCetakInvoice.Size = New Size(139, 43)
        btnCetakInvoice.TabIndex = 4
        btnCetakInvoice.Text = "Cetak Invoice"
        btnCetakInvoice.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(380, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 28)
        Label2.TabIndex = 5
        Label2.Text = "Kasir:"
        ' 
        ' lblNamaKasir
        ' 
        lblNamaKasir.Anchor = AnchorStyles.Top
        lblNamaKasir.AutoSize = True
        lblNamaKasir.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNamaKasir.Location = New Point(444, 17)
        lblNamaKasir.Name = "lblNamaKasir"
        lblNamaKasir.Size = New Size(68, 28)
        lblNamaKasir.TabIndex = 6
        lblNamaKasir.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(686, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 28)
        Label3.TabIndex = 7
        Label3.Text = "Waktu :"
        ' 
        ' lblWaktu
        ' 
        lblWaktu.Anchor = AnchorStyles.Top
        lblWaktu.AutoSize = True
        lblWaktu.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWaktu.Location = New Point(769, 17)
        lblWaktu.Name = "lblWaktu"
        lblWaktu.Size = New Size(73, 28)
        lblWaktu.TabIndex = 8
        lblWaktu.Text = "Waktu"
        ' 
        ' FormDetailTransaksi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1037, 580)
        Controls.Add(lblWaktu)
        Controls.Add(Label3)
        Controls.Add(lblNamaKasir)
        Controls.Add(Label2)
        Controls.Add(btnCetakInvoice)
        Controls.Add(lblNomorTransaksi)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FormDetailTransaksi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Detail Transaksi"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNomorTransaksi As Label
    Friend WithEvents btnCetakInvoice As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNamaKasir As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblWaktu As Label
End Class
