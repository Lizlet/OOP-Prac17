Public Class FileReader
    Public Shared Function ReadFile() As Tuple(Of DataTable, DataTable)
        Dim postLocations As New DataTable
        Dim postNumbers As New DataTable

        postLocations.Columns.Add("locationID")
        postLocations.Columns.Add("locationName")
        postNumbers.Columns.Add("postNumber")
        postNumbers.Columns.Add("locationID")

        Dim x As String = My.Resources.Postnummerregister_ansi
        Dim index As Integer = 0
        For Each line In x.Split(Environment.NewLine)
            Dim lineSplit = line.Split(vbTab)
            Dim plRow As DataRow = postLocations.NewRow
            Dim pnRow As DataRow = postNumbers.NewRow

            plRow("locationID") = index
            plRow("locationName") = lineSplit(0)
            pnRow("postNumber") = lineSplit(1)
            pnRow("locationID") = index

            postLocations.Rows.Add(plRow)
            postNumbers.Rows.Add(pnRow)

            index += 1
        Next

        Return New Tuple(Of DataTable, DataTable)(postLocations, postNumbers)
    End Function
End Class
