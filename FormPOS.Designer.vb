<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label4 = New Label()
        lblUser = New Label()
        Label3 = New Label()
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label2 = New Label()
        txtSearch = New TextBox()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblUser)
        Panel1.Controls.Add(Label3)
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
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(19, 354)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 20)
        Label4.TabIndex = 32
        Label4.Text = "CODE MEMBER"
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUser.Location = New Point(77, 25)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(56, 23)
        lblUser.TabIndex = 31
        lblUser.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 23)
        Label3.TabIndex = 30
        Label3.Text = "Kasir : "
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
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.Location = New Point(16, 57)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(325, 285)
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
        txtKembali.ForeColor = Color.Teal
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
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel1.BackColor = SystemColors.Control
        FlowLayoutPanel1.Location = New Point(5, 84)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(10)
        FlowLayoutPanel1.Size = New Size(920, 657)
        FlowLayoutPanel1.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(29, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 15
        Label2.Text = "Search :"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(29, 46)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(385, 27)
        txtSearch.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(175, 350)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(164, 27)
        TextBox1.TabIndex = 33
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
        FormBorderStyle = FormBorderStyle.None
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btn1000 As Button
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
    Friend WithEvents lblUser As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
