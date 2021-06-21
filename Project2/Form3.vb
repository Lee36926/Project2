Public Class FrmAdmin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FrmAdd.show()
        Me.Hide()
    End Sub

    Public Sub Read()
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMySQL
        retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM cus_order")
        Dim row As DataRow
        DgvTable.Rows.Clear()
        For Each row In retrieveTable.Rows
            DgvTable.Rows.Add(row("Id"), row("Name"), row("Price"))
        Next
        retrieveTable = Nothing
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Read()
    End Sub

    Private Sub DgvTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTable.CellClick
        Dim Result As New ArrayList
        Dim retrieveRow As New VBMySQL
        Dim strName As String
        If e.RowIndex < 0 Then Exit Sub
        strName = DgvTable.Item(1, e.RowIndex).Value.ToString()
        Dim strSql As String = "SELECT * FROM cus_order WHERE Name = '" + strName + "'"
        Try
            Result = retrieveRow.Retrieve_Row(strSql)

        Catch ex As Exception
            MessageBox.Show("The data reading process failed." & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        For Each row As Dictionary(Of String, Object) In Result
            With FrmDetails
                .txtName.Text = row("Name").ToString
                .txtPrice.Text = row("Price").ToString
            End With

            With FrmEdit
                .txtName.Text = row("Name").ToString
                .txtPrice.Text = row("Price").ToString
            End With
        Next
        Me.Hide()
        FrmDetails.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLog.Click
        FrmMain.Show()
        Me.Hide()
    End Sub
End Class