﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPOS
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
        Panel1 = New Panel()
        txtTotal = New TextBox()
        Label1 = New Label()
        btnClearList = New Button()
        Panel3 = New Panel()
        btn100000 = New Button()
        lblCash = New Label()
        btn50000 = New Button()
        lblRp = New Label()
        btn20000 = New Button()
        rtxtUang = New RichTextBox()
        btn10000 = New Button()
        btn5000 = New Button()
        btn1000 = New Button()
        LabelT = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        btnBayar = New Button()
        Panel2 = New Panel()
        txtKembali = New TextBox()
        LabelK = New Label()
        pnlSideBar = New Panel()
        btnTrans = New Button()
        Button3 = New Button()
        btnPOS = New Button()
        btnCRUD = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label2 = New Label()
        txtSearch = New TextBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        pnlSideBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Controls.Add(txtTotal)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnClearList)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(LabelT)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(btnBayar)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Right
        Panel1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Panel1.Location = New Point(939, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(362, 752)
        Panel1.TabIndex = 6
        ' 
        ' txtTotal
        ' 
        txtTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtTotal.BackColor = Color.White
        txtTotal.BorderStyle = BorderStyle.None
        txtTotal.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotal.Location = New Point(209, 393)
        txtTotal.MaxLength = 17
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.RightToLeft = RightToLeft.Yes
        txtTotal.Size = New Size(134, 24)
        txtTotal.TabIndex = 29
        txtTotal.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(167, 391)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 28)
        Label1.TabIndex = 26
        Label1.Text = "Rp."
        ' 
        ' btnClearList
        ' 
        btnClearList.BackColor = Color.Tomato
        btnClearList.FlatStyle = FlatStyle.Flat
        btnClearList.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClearList.ForeColor = Color.White
        btnClearList.Location = New Point(256, 13)
        btnClearList.Name = "btnClearList"
        btnClearList.Size = New Size(85, 35)
        btnClearList.TabIndex = 28
        btnClearList.Text = "Clear"
        btnClearList.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.MintCream
        Panel3.Controls.Add(btn100000)
        Panel3.Controls.Add(lblCash)
        Panel3.Controls.Add(btn50000)
        Panel3.Controls.Add(lblRp)
        Panel3.Controls.Add(btn20000)
        Panel3.Controls.Add(rtxtUang)
        Panel3.Controls.Add(btn10000)
        Panel3.Controls.Add(btn5000)
        Panel3.Controls.Add(btn1000)
        Panel3.Location = New Point(16, 432)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(325, 179)
        Panel3.TabIndex = 26
        ' 
        ' btn100000
        ' 
        btn100000.BackColor = Color.Teal
        btn100000.FlatAppearance.BorderSize = 0
        btn100000.FlatAppearance.MouseDownBackColor = Color.Lime
        btn100000.FlatStyle = FlatStyle.Flat
        btn100000.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn100000.ForeColor = Color.White
        btn100000.Location = New Point(223, 119)
        btn100000.Margin = New Padding(0)
        btn100000.Name = "btn100000"
        btn100000.Size = New Size(96, 45)
        btn100000.TabIndex = 18
        btn100000.Text = "+ 100.000"
        btn100000.UseVisualStyleBackColor = False
        ' 
        ' lblCash
        ' 
        lblCash.AutoSize = True
        lblCash.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCash.ForeColor = Color.DarkSlateGray
        lblCash.Location = New Point(8, 17)
        lblCash.Name = "lblCash"
        lblCash.Size = New Size(63, 28)
        lblCash.TabIndex = 25
        lblCash.Text = "CASH"
        ' 
        ' btn50000
        ' 
        btn50000.BackColor = Color.Teal
        btn50000.FlatAppearance.BorderSize = 0
        btn50000.FlatAppearance.MouseDownBackColor = Color.Lime
        btn50000.FlatStyle = FlatStyle.Flat
        btn50000.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn50000.ForeColor = Color.White
        btn50000.Location = New Point(116, 119)
        btn50000.Margin = New Padding(0)
        btn50000.Name = "btn50000"
        btn50000.Size = New Size(96, 45)
        btn50000.TabIndex = 17
        btn50000.Text = "+ 50.000"
        btn50000.UseVisualStyleBackColor = False
        ' 
        ' lblRp
        ' 
        lblRp.AutoSize = True
        lblRp.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRp.ForeColor = Color.DarkSlateGray
        lblRp.Location = New Point(116, 17)
        lblRp.Name = "lblRp"
        lblRp.Size = New Size(41, 28)
        lblRp.TabIndex = 24
        lblRp.Text = "Rp."
        ' 
        ' btn20000
        ' 
        btn20000.BackColor = Color.Teal
        btn20000.FlatAppearance.BorderSize = 0
        btn20000.FlatAppearance.MouseDownBackColor = Color.Lime
        btn20000.FlatStyle = FlatStyle.Flat
        btn20000.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn20000.ForeColor = Color.White
        btn20000.Location = New Point(7, 119)
        btn20000.Margin = New Padding(0)
        btn20000.Name = "btn20000"
        btn20000.Size = New Size(96, 45)
        btn20000.TabIndex = 16
        btn20000.Text = "+ 20.000"
        btn20000.UseVisualStyleBackColor = False
        ' 
        ' rtxtUang
        ' 
        rtxtUang.Anchor = AnchorStyles.Right
        rtxtUang.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rtxtUang.Location = New Point(164, 14)
        rtxtUang.MaxLength = 14
        rtxtUang.Multiline = False
        rtxtUang.Name = "rtxtUang"
        rtxtUang.RightToLeft = RightToLeft.Yes
        rtxtUang.Size = New Size(151, 36)
        rtxtUang.TabIndex = 1
        rtxtUang.Text = ""
        ' 
        ' btn10000
        ' 
        btn10000.BackColor = Color.Teal
        btn10000.FlatAppearance.BorderSize = 0
        btn10000.FlatAppearance.MouseDownBackColor = Color.Lime
        btn10000.FlatStyle = FlatStyle.Flat
        btn10000.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn10000.ForeColor = Color.White
        btn10000.Location = New Point(223, 65)
        btn10000.Margin = New Padding(0)
        btn10000.Name = "btn10000"
        btn10000.Size = New Size(96, 45)
        btn10000.TabIndex = 15
        btn10000.Text = "+ 10.000"
        btn10000.UseVisualStyleBackColor = False
        ' 
        ' btn5000
        ' 
        btn5000.BackColor = Color.Teal
        btn5000.FlatAppearance.BorderSize = 0
        btn5000.FlatAppearance.MouseDownBackColor = Color.Lime
        btn5000.FlatStyle = FlatStyle.Flat
        btn5000.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn5000.ForeColor = Color.White
        btn5000.Location = New Point(116, 65)
        btn5000.Margin = New Padding(0)
        btn5000.Name = "btn5000"
        btn5000.Size = New Size(96, 45)
        btn5000.TabIndex = 14
        btn5000.Text = "+ 5.000"
        btn5000.UseVisualStyleBackColor = False
        ' 
        ' btn1000
        ' 
        btn1000.BackColor = Color.Teal
        btn1000.FlatAppearance.BorderSize = 0
        btn1000.FlatAppearance.MouseDownBackColor = Color.Lime
        btn1000.FlatStyle = FlatStyle.Flat
        btn1000.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn1000.ForeColor = Color.White
        btn1000.Location = New Point(7, 65)
        btn1000.Margin = New Padding(0)
        btn1000.Name = "btn1000"
        btn1000.Size = New Size(96, 45)
        btn1000.TabIndex = 8
        btn1000.Text = "+ 1.000"
        btn1000.UseVisualStyleBackColor = False
        ' 
        ' LabelT
        ' 
        LabelT.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelT.AutoSize = True
        LabelT.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelT.Location = New Point(19, 391)
        LabelT.Name = "LabelT"
        LabelT.Size = New Size(69, 28)
        LabelT.TabIndex = 23
        LabelT.Text = "TOTAL"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(16, 57)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(325, 328)
        DataGridView1.TabIndex = 22
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Nama"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Harga"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Qty"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Produk_id"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Visible = False
        Column4.Width = 125
        ' 
        ' btnBayar
        ' 
        btnBayar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnBayar.BackColor = Color.DarkTurquoise
        btnBayar.FlatAppearance.BorderSize = 0
        btnBayar.FlatAppearance.MouseDownBackColor = Color.Lime
        btnBayar.FlatStyle = FlatStyle.Flat
        btnBayar.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBayar.ForeColor = Color.DarkSlateGray
        btnBayar.Location = New Point(89, 671)
        btnBayar.Margin = New Padding(0)
        btnBayar.Name = "btnBayar"
        btnBayar.Size = New Size(175, 60)
        btnBayar.TabIndex = 3
        btnBayar.Text = "BAYAR"
        btnBayar.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(txtKembali)
        Panel2.Controls.Add(LabelK)
        Panel2.Location = New Point(21, 617)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(318, 48)
        Panel2.TabIndex = 20
        ' 
        ' txtKembali
        ' 
        txtKembali.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtKembali.BackColor = Color.LightCyan
        txtKembali.BorderStyle = BorderStyle.None
        txtKembali.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtKembali.Location = New Point(176, 12)
        txtKembali.MaxLength = 17
        txtKembali.Name = "txtKembali"
        txtKembali.ReadOnly = True
        txtKembali.RightToLeft = RightToLeft.Yes
        txtKembali.Size = New Size(134, 24)
        txtKembali.TabIndex = 30
        txtKembali.Text = "0"
        ' 
        ' LabelK
        ' 
        LabelK.AutoSize = True
        LabelK.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelK.ForeColor = Color.Teal
        LabelK.Location = New Point(10, 11)
        LabelK.Name = "LabelK"
        LabelK.Size = New Size(86, 25)
        LabelK.TabIndex = 0
        LabelK.Text = "KEMBALI"
        ' 
        ' pnlSideBar
        ' 
        pnlSideBar.BackColor = Color.DeepSkyBlue
        pnlSideBar.Controls.Add(btnTrans)
        pnlSideBar.Controls.Add(Button3)
        pnlSideBar.Controls.Add(btnPOS)
        pnlSideBar.Controls.Add(btnCRUD)
        pnlSideBar.Dock = DockStyle.Left
        pnlSideBar.Location = New Point(0, 0)
        pnlSideBar.Name = "pnlSideBar"
        pnlSideBar.Size = New Size(99, 752)
        pnlSideBar.TabIndex = 5
        ' 
        ' btnTrans
        ' 
        btnTrans.BackColor = SystemColors.Control
        btnTrans.Location = New Point(18, 157)
        btnTrans.Name = "btnTrans"
        btnTrans.Size = New Size(60, 53)
        btnTrans.TabIndex = 4
        btnTrans.TabStop = False
        btnTrans.Text = "Trans"
        btnTrans.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button3.BackColor = Color.OrangeRed
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.White
        Button3.Location = New Point(18, 679)
        Button3.Name = "Button3"
        Button3.Size = New Size(60, 53)
        Button3.TabIndex = 2
        Button3.TabStop = False
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
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel1.BackColor = SystemColors.Control
        FlowLayoutPanel1.Location = New Point(104, 88)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(10)
        FlowLayoutPanel1.Size = New Size(829, 652)
        FlowLayoutPanel1.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(123, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 15
        Label2.Text = "Search :"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(123, 37)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(385, 27)
        txtSearch.TabIndex = 0
        ' 
        ' FormPOS
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1301, 752)
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel1)
        Controls.Add(pnlSideBar)
        Name = "FormPOS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Point of Sales"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        pnlSideBar.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents btnPOS As Button
    Friend WithEvents btnCRUD As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btn100000 As Button
    Friend WithEvents btn50000 As Button
    Friend WithEvents btn20000 As Button
    Friend WithEvents btn10000 As Button
    Friend WithEvents btn5000 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelK As Label
    Friend WithEvents rtxtUang As RichTextBox
    Friend WithEvents btnBayar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCash As Label
    Friend WithEvents lblRp As Label
    Friend WithEvents LabelT As Label
    Friend WithEvents btnClearList As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnTrans As Button
End Class