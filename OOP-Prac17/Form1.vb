Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tables = FileReader.ReadFile
        DataGridView1.DataSource = tables.Item1
        DataGridView2.DataSource = tables.Item2
        DBConn.DBUpload.Upload(tables.Item1, tables.Item2)


    End Sub
End Class
