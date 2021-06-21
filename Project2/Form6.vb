Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strName As String = txtName.Text
        Dim strPrice As String = txtPrice.Text
        Dim strSql = "UPDATE cus_order SET Name='" & strName & "',Price='" & strPrice & "' WHERE Name= '" & strName & "'"
        Dim CreateMySQL As New VBMySQL
        Try
            CreateMySQL.Insert_Row(strSql)
        Catch ex As Exception
            MessageBox.Show("Proses update data gagal." & vbCrLf & ex.Message,
           "Maaf", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()
    End Sub
End Class