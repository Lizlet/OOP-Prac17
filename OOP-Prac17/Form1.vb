Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tables = FileReader.ReadFile
        DBConn.Upload(tables.Item1)
    End Sub
End Class
