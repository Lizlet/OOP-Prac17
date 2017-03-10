Imports MySql.Data.MySqlClient
Namespace DBConn
    Public Class DBUpload
        Private Shared server As String = "mysql.stud.iie.ntnu.no"
        Private Shared dbn As String = "sondg"
        Private Shared uid As String = "sondg"
        Private Shared pwd As String = "7ppasexr"
        Private Shared connString As String = $"Server={server}; Database={dbn}; Uid={uid}; Pwd={pwd};"
        Private Shared connection As New MySqlConnection(connString)

        Public Shared Sub Upload(postLocations As DataTable, postNumbers As DataTable)
            Try
                connection.Open()
                PrepDatabase()
                uploadTable(postLocations, "post_locations", False)
                uploadTable(postNumbers, "post_numbers", True)
            Catch ex As MySqlException
                Debug.WriteLine($"something went wrong: {ex.Message}")
            Finally
                connection.Close()
                connection.Dispose()
            End Try
        End Sub

        Private Shared Sub uploadTable(table As DataTable, tName As String, firstFieldIsAString As Boolean)
            Dim cmd As New MySqlCommand()
            Dim sql As String = $"INSERT INTO `{tName}`(`{table.Columns(0).ColumnName}`, `{table.Columns(1).ColumnName}`) VALUES "

            For i = 0 To table.Rows.Count - 1
                sql += $"(@col1{i}, @col2{i}),"
                cmd.Parameters.AddWithValue($"@col1{i}", table.Rows(i)(table.Columns(0).ColumnName))
                cmd.Parameters.AddWithValue($"@col2{i}", table.Rows(i)(table.Columns(1).ColumnName))
            Next

            cmd.CommandText = sql.Substring(0, sql.Length - 1)
            cmd.Connection = connection
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End Sub

        Private Shared Sub PrepDatabase()
            Dim cmd As New MySqlCommand(My.Resources.createTables, connection)
            cmd.ExecuteNonQuery()
        End Sub
    End Class
End Namespace
