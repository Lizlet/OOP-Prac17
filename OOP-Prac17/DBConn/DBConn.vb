Imports MySql.Data.MySqlClient
Public Class DBConn
    Private Shared server As String = "mysql.stud.iie.ntnu.no"
    Private Shared dbn As String = "sondg"
    Private Shared uid As String = "sondg"
    Private Shared pwd As String = "7ppasexr"
    Private Shared connString As String = String.Format("Server={0}; Database={1}; Uid={2}; Pwd={3};", server, dbn, uid, pwd)
    Private Shared connection As New MySqlConnection(connString)

    Public Shared Sub Upload(postLocations As DataTable)
        Try
            connection.Open()
            Debug.WriteLine("it worked")

            Dim cmd As New MySqlCommand()
            Dim sql As String = "INSERT INTO `post_locations`(`locationID`, `locationName`) VALUES "

            For Each row In postLocations.Rows
                sql += String.Format("({0}, ""{1}""),", row("locationID"), row("locationName"))
            Next
            cmd.Connection = connection
            cmd.CommandText = sql.Substring(0, sql.Length - 1)
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            Debug.WriteLine("It did not work: " & ex.Message)
        End Try
    End Sub


End Class
