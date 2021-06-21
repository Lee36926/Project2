Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username As String
        Dim password As String
        username = TextBox1.Text
        password = TextBox2.Text
        If username = "customer" And password = "abcde" Then
            Form2.Show()
            Me.Hide()
        ElseIf username = "manager" And password = "abcde" Then
            Form3.Show()
            Me.Hide()
        Else
            Dim dialog As DialogResult = MessageBox.Show("Invalid username/password", "Manufacturing System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
