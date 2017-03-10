Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tables = FileReader.ReadFile
        DBConn.DBUpload.Upload(tables.Item1, tables.Item2)
        DataGridView1.DataSource = tables.Item1
        DataGridView2.DataSource = tables.Item2
        TextBox1.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        handleClick()
    End Sub

    Private Sub handleClick()
        TextBox2.Text = TextBox1.Text
        TextBox1.SelectAll()
        DataGridView3.DataSource = DBConn.DBSearch.Search(TextBox1.Text)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            handleClick()
        End If
    End Sub
End Class
