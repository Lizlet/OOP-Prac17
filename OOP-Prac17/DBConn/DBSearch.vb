Imports MySql.Data.MySqlClient
Namespace DBConn
    Public Class DBSearch
        Private Shared connString As String = $"Server={My.Resources.server}; Database={My.Resources.dbn}; Uid={My.Resources.uid}; Pwd={My.Resources.pwd};"
    End Class
End Namespace