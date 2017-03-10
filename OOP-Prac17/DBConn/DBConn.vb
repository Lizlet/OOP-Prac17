Imports MySql.Data.MySqlClient
Public Class DBConn
    Private Shared server As String = "mysql.stud.iie.ntnu.no"
    Private Shared dbn As String = "sondg"
    Private Shared uid As String = "sondg"
    Private Shared pwd As String = "7ppasexr"
    Private Shared connString As String = $"Server={server}; Database={dbn}; Uid={uid}; Pwd={pwd};"
    Private Shared connection As New MySqlConnection(connString)

    Public Shared Sub Upload(postLocations As DataTable, postNumbers As DataTable)
        Try
            connection.Open()
            Dim cmd As New MySqlCommand()
            cmd.Connection = connection
            uploadTable(cmd, postLocations, "post_locations", False)
            uploadTable(cmd, postNumbers, "post_numbers", True)
        Catch ex As MySqlException
            Debug.WriteLine($"something went wrong: {ex.Message}")
        End Try
    End Sub

    Private Shared Sub uploadTable(cmd As MySqlCommand, table As DataTable, tName As String, firstFieldIsAString As Boolean)
        Dim sql As String = $"INSERT INTO `{tName}`(`{table.Columns(0).ColumnName}`, `{table.Columns(1).ColumnName}`) VALUES "
        For Each row In table.Rows
            sql += $"({row(table.Columns(0).ColumnName)}, '{row(table.Columns(1).ColumnName)}'),"
        Next
        cmd.CommandText = sql.Substring(0, sql.Length - 1)
        cmd.ExecuteNonQuery()
    End Sub

End Class
