Imports MySql.Data.MySqlClient
Namespace DBConn
    Public Class DBSearch
        Private Shared connString As String = $"Server={My.Resources.server}; Database={My.Resources.dbn}; Uid={My.Resources.uid}; Pwd={My.Resources.pwd};"
        Private Shared connection As New MySqlConnection(connString)

        Public Shared Function Search(locationName As String) As DataTable
            Dim table As New DataTable

            Try
                Dim dataAdapter As New MySqlDataAdapter
                Dim cmd As New MySqlCommand(My.Resources.searchQuery, connection)
                cmd.Parameters.AddWithValue("@locationName", $"%{locationName}%")

                connection.Open()
                dataAdapter.SelectCommand = cmd

                dataAdapter.Fill(table)
            Catch ex As Exception
                Debug.WriteLine($"something went wrong: {ex.Message}")
            Finally
                connection.Close()
                connection.Dispose()
            End Try

            Return table
        End Function
    End Class
End Namespace