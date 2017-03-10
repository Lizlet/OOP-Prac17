Imports MySql.Data.MySqlClient
Namespace DBConn
    Public Class DBSearch
        Private Shared connString As String = $"Server={My.Resources.server}; Database={My.Resources.dbn}; Uid={My.Resources.uid}; Pwd={My.Resources.pwd};"
        Private Shared connection As New MySqlConnection(connString)

        Public Shared Function Search(locationName As String) As DataTable
            Dim table As New DataTable

            Try
                Dim dataAdapter As New MySqlDataAdapter
                Dim sql As String = "select postNumber as ""post number"", locationName as ""location name"" from post_numbers pn, post_locations pl where pn.locationID = pl.locationID and pl.locationName like @locationName"
                Dim cmd As New MySqlCommand(sql, connection)
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