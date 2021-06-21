Public Class FrmDetails
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        FrmAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim strName As String = txtName.Text
        Dim strPrice As String = txtPrice.Text
        Dim strSql = "DELETE FROM cus_order WHERE Name=('" & strName & "')"
        Dim DeleteMySQL As New VBMySQL
        Try
            DeleteMySQL.Delete_Row(strSql)
            MessageBox.Show("Successfully deleted.", "Congratulations", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Failed to delete data" & vbCrLf & ex.Message,
           "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        FrmAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub FrmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class