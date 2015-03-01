Imports System.Data.SqlClient

Public Class Form3

    Private ketnoi As DataBaseAccess
    Private kn = "Data Source=SQL5004.myASP.NET;Initial Catalog=DB_9BB477_hoai;Persist Security Info=True;User ID=DB_9BB477_hoai_admin;Password=77621176"

    Private Sub aa()
        ketnoi = New DataBaseAccess(kn)
        Dim dt As DataTable
        dt = ketnoi.GetDataTable("select * from Khachhang")
        dt3.DataSource = dt
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        aa()
    End Sub

    Private Sub dt3_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dt3.CellClick
        Try
            Dim dt As DataTable
            dt = ketnoi.GetDataTable("select * from Khachhang")
            Dim strCurrentID As String
            strCurrentID = "MaKH = '" & dt3("cl1", e.RowIndex).Value.ToString() & "'"
            Dim rowProduct = dt.Select(strCurrentID)
            TextBox1.Text = rowProduct(0).Item("MaKH").ToString
            TextBox2.Text = rowProduct(0).Item("TenKH").ToString
            TextBox4.Text = rowProduct(0).Item("SDT").ToString
            TextBox3.Text = rowProduct(0).Item("Diachi").ToString
        Catch
            MessageBox.Show("Vui long chon dung khung du lieu")
        End Try
    End Sub

    Private Sub bt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1.Click
        If TextBox1.Text.Trim = "" Or TextBox1.Text.Trim = "" Or TextBox4.Text.Trim = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu")
        Else
            Dim lenh As String
            lenh = "insert Khachhang values ('" + TextBox1.Text + "',N'" + TextBox2.Text + "','" + TextBox4.Text + "','" + TextBox3.Text + "')"
            If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
                aa()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text.Trim = "" Or TextBox1.Text.Trim = "" Or TextBox4.Text.Trim = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu")
        Else
            Dim lenh As String
            lenh = "update Khachhang set MaKH='" + TextBox1.Text + "',TenKH=N'" + TextBox2.Text + "',SDT='" + TextBox4.Text + "',Diachi='" + TextBox3.Text + "' where MaKH='" + TextBox1.Text + "'"
            If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
                aa()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text.Trim = "" Then
            MessageBox.Show("Vui lòng chọn đối tượng muốn xóa")
        Else
            Dim lenh As String
            lenh = "delete Khachhang where MaKH='" + TextBox1.Text + "'"
            If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
                aa()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text.Trim = "" And TextBox2.Text.Trim = "" Then
            MessageBox.Show("Vui long nhap du lieu tim kiem")
        ElseIf TextBox1.Text.Trim <> "" And TextBox2.Text.Trim <> "" Then
            MessageBox.Show("Vui long nhap MaKH hoac TenKH")
        ElseIf TextBox1.Text.Trim <> "" And TextBox2.Text.Trim = "" Then
            Dim a As DataTable
            a = ketnoi.GetDataTable("select * from Khachhang where MaKH='" + TextBox1.Text + "'")
            dt3.DataSource = a
            TextBox1.Text = ""
        ElseIf TextBox1.Text.Trim = "" And TextBox2.Text.Trim <> "" Then
            Dim a As DataTable
            a = ketnoi.GetDataTable("select * from Khachhang where TenKH=N'" + TextBox2.Text + "'")
            dt3.DataSource = a
            TextBox2.Text = ""
        End If
    End Sub
End Class