Imports System.Data.Odbc

Module Mod_publicvariables

    Public con As New OdbcConnection("Driver={MySQL ODBC 5.3 ANSI Driver};Server=localhost;Port=3308;Uid=root;Pwd=;Database=vet_db;")
    Public constring As String = "Driver={MySQL ODBC 5.3 ANSI Driver};Server=localhost;Port=3308;Uid=root;Pwd=;Database=vet_db;"
    Public mycmd As New OdbcCommand
    Public username As String
    Public username1 As String
End Module
