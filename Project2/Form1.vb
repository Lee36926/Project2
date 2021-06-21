Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String
        Dim password As String
        username = TextBox1.Text
        password = TextBox2.Text
        If username = "customer" And password = "abcde" Then
            FrmCus.Show()
            Me.Hide()
        ElseIf username = "manager" And password = "abcde" Then
            FrmAdmin.Show()
            Me.Hide()
        Else
            Dim dialog As DialogResult = MessageBox.Show("Invalid username/password", "Manufacturing System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure to Exit?", "Travel Package Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = vbYes) Then
            Me.Close()
        End If
    End Sub
End Class
