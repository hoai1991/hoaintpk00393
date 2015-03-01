Public Class Form4
    Private ketnoi As DataBaseAccess
    Private kn = "Data Source=SQL5004.myASP.NET;Initial Catalog=DB_9BB477_hoai;Persist Security Info=True;User ID=DB_9BB477_hoai_admin;Password=77621176"

    Private Sub aa()
        ketnoi = New DataBaseAccess(kn)
        Dim dt As DataTable
        dt = ketnoi.GetDataTable("select * from Hoadon")
        dt5.DataSource = dt
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        aa()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu")
        Else
            Dim lenh As String
            lenh = "insert Hoadon values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + date2.Value + "')"
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
            lenh = "delete Hoadon where MaHD='" + TextBox1.Text + "'"
            If (ketnoi.ExecuteNoneQuery(lenh, True) = True) Then
                aa()
            End If
        End If
    End Sub

    Private Sub dt5_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dt5.CellClick
        Try
            Dim dt As DataTable
            dt = ketnoi.GetDataTable("select * from Hoadon")
            Dim strCurrentID As String
            strCurrentID = "MaHD = '" & dt5("cl1", e.RowIndex).Value.ToString().Trim() & "'"
            Dim rowProduct = dt.Select(strCurrentID)
            TextBox1.Text = rowProduct(0).Item("MaHD").ToString.Trim
            TextBox2.Text = rowProduct(0).Item("MaKH").ToString
            date2.Value = rowProduct(0).Item("Ngaylap").ToString
        Catch
            MessageBox.Show("Vui long chon dung khung du lieu")
        End Try
    End Sub
End Class