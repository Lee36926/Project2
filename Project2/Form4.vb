Public Class FrmAdd
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Dim strName As String = TextBox2.Text
        Dim decPrice As Decimal
        decPrice = CDbl(txtPrice.Text)
        Dim strSql = "INSERT INTO cus_order VALUES (null, '" & strName & "', '" & decPrice & "')"
        Dim CreateMySQL As New VBMySQL
        Try
            CreateMySQL.Insert_Row(strSql)
            MessageBox.Show("Data successfully saved.", "Congratulations", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("The data failed to stored." & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        FrmAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class