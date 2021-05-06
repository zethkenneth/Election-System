Module Module1
    Public con As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public rx As New ADODB.Recordset

    Public Sub connect()
        con.Open("Provider=Microsoft.jet.Oledb.4.0; data source = " & Application.StartupPath & "\ElectionSystemDatabase.mdb")
    End Sub
End Module
