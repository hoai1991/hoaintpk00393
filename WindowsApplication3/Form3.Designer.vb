<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.dt3 = New System.Windows.Forms.DataGridView()
        Me.cl1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cl4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.bt1 = New System.Windows.Forms.Button()
        CType(Me.dt3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dt3
        '
        Me.dt3.AllowUserToAddRows = False
        Me.dt3.AllowUserToDeleteRows = False
        Me.dt3.AllowUserToResizeColumns = False
        Me.dt3.AllowUserToResizeRows = False
        Me.dt3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cl1, Me.cl2, Me.cl3, Me.cl4})
        Me.dt3.Location = New System.Drawing.Point(347, 12)
        Me.dt3.MultiSelect = False
        Me.dt3.Name = "dt3"
        Me.dt3.ReadOnly = True
        Me.dt3.RowHeadersVisible = False
        Me.dt3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt3.ShowEditingIcon = False
        Me.dt3.Size = New System.Drawing.Size(403, 188)
        Me.dt3.TabIndex = 33
        '
        'cl1
        '
        Me.cl1.DataPropertyName = "MaKH"
        Me.cl1.HeaderText = "MaKH"
        Me.cl1.Name = "cl1"
        Me.cl1.ReadOnly = True
        '
        'cl2
        '
        Me.cl2.DataPropertyName = "TenKH"
        Me.cl2.HeaderText = "TenKH"
        Me.cl2.Name = "cl2"
        Me.cl2.ReadOnly = True
        '
        'cl3
        '
        Me.cl3.DataPropertyName = "SDT"
        Me.cl3.HeaderText = "SDT"
        Me.cl3.Name = "cl3"
        Me.cl3.ReadOnly = True
        '
        'cl4
        '
        Me.cl4.DataPropertyName = "Diachi"
        Me.cl4.HeaderText = "Diachi"
        Me.cl4.Name = "cl4"
        Me.cl4.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.bt1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 188)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thong tin khach hang"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(213, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 23)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Tim kiem"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(75, 110)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(120, 20)
        Me.TextBox3.TabIndex = 44
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(75, 80)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(120, 20)
        Me.TextBox4.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Diachi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "SDT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "TenKH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "MaKH"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Thoat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(75, 51)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 20)
        Me.TextBox2.TabIndex = 37
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(75, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 36
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(160, 150)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 23)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "Sua"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(80, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 23)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Xoa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'bt1
        '
        Me.bt1.Location = New System.Drawing.Point(6, 150)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(68, 23)
        Me.bt1.TabIndex = 33
        Me.bt1.Text = "Them"
        Me.bt1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 216)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dt3)
        Me.Name = "Form3"
        Me.Text = "QLKH"
        CType(Me.dt3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dt3 As System.Windows.Forms.DataGridView
    Friend WithEvents cl1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cl2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cl3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cl4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents bt1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
