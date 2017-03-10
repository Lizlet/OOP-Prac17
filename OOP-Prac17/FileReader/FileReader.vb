''' <summary>
'''     the .txt file was added to the project as a resource, meaning I can do the reading bit a lot simpler
'''     
'''     I decided to use the hashcode of the location name as ID, saving me a lot of annoyance having to deal with finding the id
'''     of already stored records in a datatable, I am sure I could do it, butI certainly cant be bothered.
'''     Unless it turns out I have overlapping ids, but I doubt it. the probability with a samplesize this miniscule is abysmal
''' </summary>
Public Class FileReader
    Public Shared Function ReadFile() As Tuple(Of DataTable, DataTable)
        Dim postLocations As New DataTable
        Dim postNumbers As New DataTable

        postLocations.Columns.Add("locationID")
        postLocations.Columns.Add("locationName")
        postNumbers.Columns.Add("postNumber")
        postNumbers.Columns.Add("locationID")

        Dim x As String = My.Resources.Postnummerregister_ansi
        For Each line In x.Split(Environment.NewLine)
            Dim lineSplit = line.Split(vbTab) 'lineSplit(0) = post number and lineSplit(1) = post location
            Dim pnRow As DataRow = postNumbers.NewRow

            ' to ensure the same location is not added twice.
            Dim rows = postLocations.Select(String.Format("locationName = '{0}'", lineSplit(1)))
            If rows.Length = 0 Then
                Dim plRow As DataRow = postLocations.NewRow
                plRow("locationID") = lineSplit(1).GetHashCode
                plRow("locationName") = lineSplit(1)
                postLocations.Rows.Add(plRow)
            End If

            pnRow("postNumber") = lineSplit(0)
            pnRow("locationID") = lineSplit(1).GetHashCode
            postNumbers.Rows.Add(pnRow)
        Next

        Return New Tuple(Of DataTable, DataTable)(postLocations, postNumbers)
    End Function
End Class
