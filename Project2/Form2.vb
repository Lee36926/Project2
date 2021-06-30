Public Class FrmCus
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMySQL
        retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM cus_order")
        Dim row As DataRow
        DvgTable1.Rows.Clear()
        For Each row In retrieveTable.Rows
            DvgTable1.Rows.Add(row("Id"), row("Name"), row("Price"))
        Next
        retrieveTable = Nothing
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnLog.Click
        FrmMain.Show()
        Me.Hide()

    End Sub

    Private Sub DvgTable1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DvgTable1.CellContentClick

    End Sub
End Class