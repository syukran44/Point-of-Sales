<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(53, 51)
        PictureBox1.MaximumSize = New Size(500, 500)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(296, 332)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(402, 450)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(552, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 41)
        Label1.TabIndex = 20
        Label1.Text = "LOGIN"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(500, 173)
        txtUser.Name = "txtUser"
        txtUser.PlaceholderText = "username"
        txtUser.Size = New Size(218, 27)
        txtUser.TabIndex = 0
        txtUser.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(500, 212)
        txtPass.Name = "txtPass"
        txtPass.PlaceholderText = "password"
        txtPass.Size = New Size(218, 27)
        txtPass.TabIndex = 1
        txtPass.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DodgerBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(541, 275)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 45)
        Button1.TabIndex = 2
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.OrangeRed
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(541, 381)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 45)
        Button2.TabIndex = 21
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormLogin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
