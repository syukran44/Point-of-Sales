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
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        txtSearch = New TextBox()
        btnTambah = New Button()
        ComboBox1 = New ComboBox()
        txtQty = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        DataGridView2 = New DataGridView()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Label7 = New Label()
        TextBox3 = New TextBox()
        Label8 = New Label()
        TextBox4 = New TextBox()
        Label9 = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
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
        txtSearch.TabIndex = 24
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
        btnTambah.TabIndex = 27
        btnTambah.Text = "Tambahkan"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(233, 37)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(153, 28)
        ComboBox1.TabIndex = 28
        ' 
        ' txtQty
        ' 
        txtQty.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtQty.Location = New Point(829, 38)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(63, 27)
        txtQty.TabIndex = 29
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(825, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 20)
        Label1.TabIndex = 30
        Label1.Text = "Qty :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TextBox1.Location = New Point(541, 578)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(84, 27)
        TextBox1.TabIndex = 31
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
        Label4.Size = New Size(49, 20)
        Label4.TabIndex = 33
        Label4.Text = "Total :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TextBox2.Location = New Point(744, 578)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(148, 27)
        TextBox2.TabIndex = 34
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, Column4})
        DataGridView2.Location = New Point(532, 103)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
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
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.BackColor = Color.LimeGreen
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Lime
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(914, 562)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 43)
        Button1.TabIndex = 38
        Button1.Text = "Beli"
        Button1.UseVisualStyleBackColor = False
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
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TextBox3.Location = New Point(643, 578)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(84, 27)
        TextBox3.TabIndex = 41
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
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TextBox4.Location = New Point(721, 38)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(91, 27)
        TextBox4.TabIndex = 39
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
        Column5.HeaderText = "Kategori"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Harga"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn2.HeaderText = "Produk ID"
        DataGridViewTextBoxColumn2.MinimumWidth = 6
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Width = 103
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn3.HeaderText = "Nama"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn4.HeaderText = "Harga"
        DataGridViewTextBoxColumn4.MinimumWidth = 6
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Qty"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 70
        ' 
        ' PopupFormBeli
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1055, 627)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(TextBox3)
        Controls.Add(Label8)
        Controls.Add(TextBox4)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(DataGridView2)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(txtQty)
        Controls.Add(ComboBox1)
        Controls.Add(btnTambah)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(txtSearch)
        Name = "PopupFormBeli"
        Text = "PopupFormBeli"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
