<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dt1 = New System.Windows.Forms.DataGridView()
        Me.cl1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.bt3 = New System.Windows.Forms.Button()
        Me.bt4 = New System.Windows.Forms.Button()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dt1
        '
        Me.dt1.AllowUserToAddRows = False
        Me.dt1.AllowUserToDeleteRows = False
        Me.dt1.AllowUserToResizeColumns = False
        Me.dt1.AllowUserToResizeRows = False
        Me.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cl1, Me.cl2, Me.cl3, Me.cl4, Me.cl5})
        Me.dt1.Location = New System.Drawing.Point(292, 12)
        Me.dt1.MultiSelect = False
        Me.dt1.Name = "dt1"
        Me.dt1.ReadOnly = True
        Me.dt1.RowHeadersVisible = False
        Me.dt1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt1.Size = New System.Drawing.Size(503, 242)
        Me.dt1.TabIndex = 17
        '
        'cl1
        '
        Me.cl1.DataPropertyName = "MaSP"
        Me.cl1.HeaderText = "MaSP"
        Me.cl1.Name = "cl1"
        Me.cl1.ReadOnly = True
        '
        'cl2
        '
        Me.cl2.DataPropertyName = "TenSP"
        Me.cl2.HeaderText = "TenSP"
        Me.cl2.Name = "cl2"
        Me.cl2.ReadOnly = True
        '
        'cl3
        '
        Me.cl3.DataPropertyName = "TenLoai"
        Me.cl3.HeaderText = "LoaiSP"
        Me.cl3.Name = "cl3"
        Me.cl3.ReadOnly = True
        '
        'cl4
        '
        Me.cl4.DataPropertyName = "Giaban"
        Me.cl4.HeaderText = "Giaban"
        Me.cl4.Name = "cl4"
        Me.cl4.ReadOnly = True
        '
        'cl5
        '
        Me.cl5.DataPropertyName = "Soluong"
        Me.cl5.HeaderText = "Soluong"
        Me.cl5.Name = "cl5"
        Me.cl5.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "MaSP"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "TenSP"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(151, 20)
        Me.TextBox2.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "LoaiSP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "GiaSP"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(6, 172)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(151, 20)
        Me.TextBox4.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Soluong"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(6, 216)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(151, 20)
        Me.TextBox5.TabIndex = 28
        '
        'bt2
        '
        Me.bt2.Location = New System.Drawing.Point(173, 75)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(75, 23)
        Me.bt2.TabIndex = 29
        Me.bt2.Text = "Them"
        Me.bt2.UseVisualStyleBackColor = True
        '
        'bt3
        '
        Me.bt3.Location = New System.Drawing.Point(173, 109)
        Me.bt3.Name = "bt3"
        Me.bt3.Size = New System.Drawing.Size(75, 23)
        Me.bt3.TabIndex = 30
        Me.bt3.Text = "Xoa"
        Me.bt3.UseVisualStyleBackColor = True
        '
        'bt4
        '
        Me.bt4.Location = New System.Drawing.Point(173, 145)
        Me.bt4.Name = "bt4"
        Me.bt4.Size = New System.Drawing.Size(75, 23)
        Me.bt4.TabIndex = 31
        Me.bt4.Text = "Sua"
        Me.bt4.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.DisplayMember = "Maloai"
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(6, 125)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(151, 21)
        Me.cb1.TabIndex = 32
        Me.cb1.ValueMember = "Maloai"
        '
        'bt1
        '
        Me.bt1.Location = New System.Drawing.Point(173, 180)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(75, 23)
        Me.bt1.TabIndex = 33
        Me.bt1.Text = "Thoat"
        Me.bt1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.bt1)
        Me.GroupBox1.Controls.Add(Me.cb1)
        Me.GroupBox1.Controls.Add(Me.bt4)
        Me.GroupBox1.Controls.Add(Me.bt3)
        Me.GroupBox1.Controls.Add(Me.bt2)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 248)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thong tin san pham"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(173, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Tim kiem"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dt1)
        Me.Name = "Form1"
        Me.Text = "QuanlySP"
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dt1 As System.Windows.Forms.DataGridView
    Friend WithEvents cl1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cl2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cl3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cl4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cl5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents bt2 As System.Windows.Forms.Button
    Friend WithEvents bt3 As System.Windows.Forms.Button
    Friend WithEvents bt4 As System.Windows.Forms.Button
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents bt1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
