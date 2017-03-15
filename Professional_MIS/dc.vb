Imports System.Data
Imports System.Data.OleDb

Public Class DBConnector
    ' Set up instance variables such as the connection string for the DB
    Private Const username As String = "PROJECTS1749"
    Private Const password As String = "ZV09wa$"
    Private Const DBName As String = "PROJECTS1749"

    Shared _dc As String = "Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=" & DBName & ";UID=" & username & ";PWD=" & password & ";"

    Public Function GetDataSet(ByVal query As String) As DataSet
        Dim con As OledbConnection = Nothing
        Dim command As OleDbCommand = Nothing
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet

        Try
            ' Make the database connection
            con = New OleDbConnection(_dc)
            con.Open()
            command = New OleDbCommand(query, con)

            ' Run the query to fill the dataset
            da = New OleDbDataAdapter()
            da.SelectCommand = command
            da.Fill(ds)
        Finally
            ' Close the connection and Return the dataset
            If Not con Is Nothing Then con.Close()
            If Not command Is Nothing Then command.Dispose()
        End Try

        Return ds

    End Function
    Public Function ExecuteNonQuery(ByVal query As String) As Integer
        Dim con As OleDbConnection = Nothing
        Dim command As OleDbCommand = Nothing
        Dim result As Integer = 0

        Try
            ' Make the database connection
            con = New OleDbConnection(_dc)
            command = New OleDbCommand(query, con)
            con.Open()
            ' Execute a "non-query" (doesn't return any result sets)
            result = command.ExecuteNonQuery()
        Finally
            If Not con Is Nothing Then con.Close()
            If Not command Is Nothing Then command.Dispose()
        End Try

        Return result

    End Function

    Public Function GetDataReader(ByVal query As String) As OleDbDataReader
        Dim con As OleDbConnection = Nothing
        Dim command As OleDbCommand = Nothing

        Try
            ' Make the database connection
            con = New OleDbConnection(_dc)
            con.Open()
            command = New OleDbCommand(query, con)
            ' Run the query to fill the reader
            Return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
        Finally
            ' Close the connection and Return the dataset
            If Not command Is Nothing Then command.Dispose()
        End Try

    End Function
End Class