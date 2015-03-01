Imports System.Data.SqlClient
Imports System.Data.DataTableReader
Public Class Form2
    Private ketnoi As DataBaseAccess
    Private kn = "Data Source=SQL5004.myASP.NET;Initial Catalog=DB_9BB477_hoai;Persist Security Info=True;User ID=DB_9BB477_hoai_admin;Password=77621176"
    Public ma As String
    Private Sub aa()
        ketnoi = New DataBaseAccess(kn)
        Dim dt As DataTable
        dt = ketnoi.GetDataTable("select ChitietHD.MaSP,ChitietHD.Soluong,Thanhtien,Sanpham.TenSP,Sanpham.Giaban from ChitietHD inner join Sanpham on Sanpham.MaSP=ChitietHD.MaSP where MaHD='" + TextBox1.Text + "'")
        dt2.DataSource = dt
        Dim a As DataTable
        a = ketnoi.GetDataTable("select Hoadon.Ngaylap,TenKH,SDT,Diachi from Khachhang inner join Hoadon on Hoadon.MaKH=Khachhang.MaKH inner join ChitietHD on ChitietHD.MaHD=Hoadon.MaHD where ChitietHD.MaHD='" + TextBox1.Text + "'")
        For Each hang As DataRow In a.Rows
            TextBox2.Text = hang("TenKH").ToString()
            TextBox4.Text = hang("SDT").ToString()
            TextBox5.Text = hang("Diachi").ToString()
            date1.Value = hang("Ngaylap").ToString()
        Next
        Dim b As DataTable
        b = ketnoi.GetDataTable("select (SUM(Thanhtien))as Tong from ChitietHD where MaHD='" + TextBox1.Text + "' group by MaHD")
        For Each hang1 As DataRow In b.Rows
            TextBox3.Text = hang1("Tong").ToString()
        Next
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        dt2.DataSource = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button6.Enabled = False
        Button8.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        aa()
        Button8.Enabled = True
        Button6.Enabled = True
    End Sub

    Private Sub QLSPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QLSPToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub QLKHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QLKHToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox6.Text.Trim = "" Or TextBox7.Text.Trim = "" Or TextBox8.Text.Trim = "" Or TextBox9.Text.Trim = "" Or TextBox10.Text.Trim = "" Then
            MessageBox.Show("Vui long chon doi tuong muon xoa trong bang du lieu")
        Else
            Dim lenh As String
            lenh = "delete ChitietHD where MaCTHD='" + ma + "'"
            If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
                aa()
            End If
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            Button3.Enabled = False
            Button4.Enabled = False
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox6.Text.Trim = "" Or TextBox7.Text.Trim = "" Or TextBox8.Text.Trim = "" Or TextBox9.Text.Trim = "" Or TextBox10.Text.Trim = "" Then
            MessageBox.Show("Vui long nhap day du du lieu")
        Else
            Dim lenh As String
            lenh = "insert ChitietHD values('" + TextBox1.Text + "','" + TextBox6.Text + "','" + TextBox8.Text + "','" + TextBox10.Text + "')"
            If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
                aa()
            End If
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            Button3.Enabled = False
            Button4.Enabled = False
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim lenh As String
        lenh = "update ChitietHD set  Soluong='" + TextBox8.Text + "',Thanhtien='" + TextBox10.Text + "' where MaCTHD='" + ma + "'"
        If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
            aa()
        End If
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        Button3.Enabled = False
        Button4.Enabled = False
        Button2.Enabled = False
    End Sub

    Private Sub dt2_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dt2.CellClick
        Try
            Dim dt As DataTable
            dt = ketnoi.GetDataTable("select ChitietHD.MaCTHD as Ma,ChitietHD.MaSP,ChitietHD.Soluong,Thanhtien,Sanpham.TenSP,Sanpham.Giaban from ChitietHD inner join Sanpham on Sanpham.MaSP=ChitietHD.MaSP where MaHD='" + TextBox1.Text + "'")
            For Each hang As DataRow In dt.Rows
                ma = hang("Ma").ToString()
            Next
            Dim strCurrentID As String
            strCurrentID = "MaSP= '" & dt2("cl4", e.RowIndex).Value.ToString().Trim() & "'"
            Dim rowProduct = dt.Select(strCurrentID)
            TextBox6.Text = rowProduct(0).Item("MaSP").ToString.Trim
            TextBox7.Text = rowProduct(0).Item("TenSP").ToString
            TextBox9.Text = rowProduct(0).Item("Giaban").ToString
            TextBox8.Text = rowProduct(0).Item("Soluong").ToString
            TextBox10.Text = rowProduct(0).Item("Thanhtien").ToString
            Button3.Enabled = True
            Button4.Enabled = True
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
        Catch
            MessageBox.Show("Vui long chon dung khung du lieu")
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If TextBox6.Text.Trim = "" And TextBox7.Text.Trim = "" Then
            MessageBox.Show("Vui long nhap du lieu tim kiem")
        ElseIf TextBox6.Text.Trim <> "" And TextBox7.Text.Trim <> "" Then
            MessageBox.Show("Vui long nhap MaKH hoac TenKH")
        ElseIf TextBox6.Text.Trim <> "" And TextBox7.Text.Trim = "" Then
            Dim a As DataTable
            a = ketnoi.GetDataTable("select ChitietHD.MaSP,ChitietHD.Soluong,Thanhtien,Sanpham.TenSP,Sanpham.Giaban from ChitietHD inner join Sanpham on Sanpham.MaSP=ChitietHD.MaSP where Sanpham.MaSP='" + TextBox6.Text + "'")
            For Each hang As DataRow In a.Rows
                TextBox6.Text = hang("MaSP").ToString()
                TextBox7.Text = hang("TenSP").ToString()
                TextBox8.Text = hang("Soluong").ToString()
                TextBox9.Text = hang("Giaban").ToString()
                TextBox10.Text = hang("Thanhtien").ToString()
            Next
            Button2.Enabled = True
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
        ElseIf TextBox6.Text.Trim = "" And TextBox7.Text.Trim <> "" Then
            Dim a As DataTable
            a = ketnoi.GetDataTable("select ChitietHD.MaSP,ChitietHD.Soluong,Thanhtien,Sanpham.TenSP,Sanpham.Giaban from ChitietHD inner join Sanpham on Sanpham.MaSP=ChitietHD.MaSP where Sanpham.TenSP='" + TextBox7.Text + "'")
            For Each hang As DataRow In a.Rows
                TextBox6.Text = hang("MaSP").ToString()
                TextBox7.Text = hang("TenSP").ToString()
                TextBox8.Text = hang("Soluong").ToString()
                TextBox9.Text = hang("Giaban").ToString()
                TextBox10.Text = hang("Thanhtien").ToString()
            Next
            Button2.Enabled = True
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox6.Enabled = True
        TextBox7.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If dt2.RowCount = 0 Then
            Dim lenh As String
            lenh = "delete Hoadon where MaHD='" + TextBox1.Text + "'"
            If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
                aa()
            End If
        Else
            MessageBox.Show("Van con san pham trong hoa don cua khach hang", "Canh bao", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub QLHDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QLHDToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class