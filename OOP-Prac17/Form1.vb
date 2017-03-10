Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tables = FileReader.ReadFile

        DBConn.DBUpload.Upload(tables.Item1, tables.Item2)
        DataGridView1.DataSource = tables.Item1
        DataGridView2.DataSource = tables.Item2
        DataGridView3.DataSource = DBConn.DBSearch.Search("trond")

    End Sub
End Class
