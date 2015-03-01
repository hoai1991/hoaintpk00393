Imports System.Data.SqlClient

Public Class Form1

    Private ketnoi As DataBaseAccess
    Private kn = "Data Source=SQL5004.myASP.NET;Initial Catalog=DB_9BB477_hoai;Persist Security Info=True;User ID=DB_9BB477_hoai_admin;Password=77621176"

    Private Sub aa()
        ketnoi = New DataBaseAccess(kn)
        Dim dt As DataTable
        dt = ketnoi.GetDataTable("select MaSP,TenSP,LoaiSP.TenLoai,Giaban,Soluong from Sanpham inner join LoaiSP on LoaiSP.Maloai=Sanpham.MaLoai")
        dt1.DataSource = dt
        Dim ds As DataTable
        ds = ketnoi.GetDataTable("select Maloai from LoaiSP")
        cb1.DataSource = ds
        cb1.DisplayMember = "Maloai"
        cb1.ValueMember = "Maloai"
        TextBox1.Text = ""
        TextBox4.Text = ""
        TextBox2.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub dt1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dt1.CellClick
        Try
            Dim dt As DataTable
            dt = ketnoi.GetDataTable("select * from Sanpham")
            Dim strCurrentID As String
            strCurrentID = "MaSP = '" & dt1("cl1", e.RowIndex).Value.ToString().Trim() & "'"
            Dim rowProduct = dt.Select(strCurrentID)
            TextBox1.Text = rowProduct(0).Item("MaSP").ToString.Trim
            TextBox2.Text = rowProduct(0).Item("TenSP").ToString
            cb1.SelectedValue = rowProduct(0).Item("MaLoai").ToString
            TextBox4.Text = rowProduct(0).Item("Giaban").ToString
            TextBox5.Text = rowProduct(0).Item("Soluong").ToString
        Catch
            MessageBox.Show("Vui long chon dung khung du lieu")
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        aa()
    End Sub

    Private Sub bt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub bt2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt2.Click
        If TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = "" Or cb1.Text.Trim = "" Or TextBox4.Text.Trim = "" Or TextBox5.Text.Trim = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu")
        Else
            Dim lenh As String
            lenh = "insert Sanpham values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + cb1.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')"
            If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
                aa()
            End If
        End If
    End Sub

    Private Sub bt3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt3.Click
        If TextBox1.Text.Trim = "" Then
            MessageBox.Show("Vui lòng chọn đối tượng muốn xóa")
        Else
            Dim lenh As String
            lenh = "delete Sanpham where MaSP='" + TextBox1.Text + "'"
            If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
                aa()
            End If
        End If
    End Sub

    Private Sub bt4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt4.Click
        If TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = "" Or cb1.Text.Trim = "" Or TextBox4.Text.Trim = "" Or TextBox5.Text.Trim = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu")
        Else
            Dim lenh As String
            lenh = "update Sanpham set MaSP='" + TextBox1.Text + "',TenSP='" + TextBox2.Text + "',MaLoai='" + cb1.Text + "',Giaban='" + TextBox4.Text + "',Soluong='" + TextBox5.Text + "' where MaSP='" + TextBox1.Text + "'"
            If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
                aa()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = "" And TextBox2.Text.Trim = "" Then
            MessageBox.Show("Vui long nhap du lieu tim kiem")
        ElseIf TextBox1.Text.Trim <> "" And TextBox2.Text.Trim <> "" Then
            MessageBox.Show("Vui long nhap MaSP hoac TenSP")
        ElseIf TextBox1.Text.Trim <> "" And TextBox2.Text.Trim = "" Then
            Dim a As DataTable
            a = ketnoi.GetDataTable("select * from Sanpham where MaSP='" + TextBox1.Text + "'")
            dt1.DataSource = a
            TextBox1.Text = ""
        ElseIf TextBox1.Text.Trim = "" And TextBox2.Text.Trim <> "" Then
            Dim a As DataTable
            a = ketnoi.GetDataTable("select * from Sanpham where TenSP=N'" + TextBox2.Text + "'")
            dt1.DataSource = a
            TextBox2.Text = ""
        End If
    End Sub
End Class
