﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label2 = New Label()
        txtSearch = New TextBox()
        DataGridView1 = New DataGridView()
        Column7 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        lblWaktu = New Label()
        DataGridView2 = New DataGridView()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        btnCetak = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(29, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 17
        Label2.Text = "Search :"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(29, 46)
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column7, Column11, Column1, Column5, Column12, Column6, Column2, Column3, Column4})
        DataGridView1.Location = New Point(29, 98)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1237, 511)
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
        ' Column11
        ' 
        Column11.HeaderText = "Kasir"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 170
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Nomor Transaksi"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column5
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight
        Column5.DefaultCellStyle = DataGridViewCellStyle1
        Column5.HeaderText = "Total Kuantitas"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 80
        ' 
        ' Column12
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight
        Column12.DefaultCellStyle = DataGridViewCellStyle2
        Column12.HeaderText = "Diskon"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Width = 125
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight
        Column6.DefaultCellStyle = DataGridViewCellStyle3
        Column6.HeaderText = "Grandtotal"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight
        Column2.DefaultCellStyle = DataGridViewCellStyle4
        Column2.HeaderText = "Tunai"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight
        Column3.DefaultCellStyle = DataGridViewCellStyle5
        Column3.HeaderText = "Kembalian"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Waktu"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' lblWaktu
        ' 
        lblWaktu.AutoSize = True
        lblWaktu.Location = New Point(455, 18)
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
        DataGridView2.Location = New Point(232, 635)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.ScrollBars = ScrollBars.None
        DataGridView2.ShowEditingIcon = False
        DataGridView2.Size = New Size(908, 61)
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
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight
        Column9.DefaultCellStyle = DataGridViewCellStyle6
        Column9.HeaderText = "Produk Terjual"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight
        Column10.DefaultCellStyle = DataGridViewCellStyle7
        Column10.HeaderText = "Total Penjualan"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(455, 46)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(176, 27)
        DateTimePicker1.TabIndex = 2
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(643, 46)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(176, 27)
        DateTimePicker2.TabIndex = 3
        ' 
        ' btnCetak
        ' 
        btnCetak.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCetak.BackColor = Color.MediumAquamarine
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(1148, 36)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(118, 47)
        btnCetak.TabIndex = 22
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' FormPenjualan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1283, 734)
        ControlBox = False
        Controls.Add(btnCetak)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(DataGridView2)
        Controls.Add(lblWaktu)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        FormBorderStyle = FormBorderStyle.None
        MinimizeBox = False
        Name = "FormPenjualan"
        StartPosition = FormStartPosition.CenterParent
        Text = "Penjualan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblWaktu As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents btnCetak As Button
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
