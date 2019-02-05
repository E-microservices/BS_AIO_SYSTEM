Imports System.IO
Imports MySql.Data.MySqlClient

Module FonctionModule1
    Dim connexion As New MySqlConnection
    Dim cmd As MySqlCommand
    Dim query As String
    Dim conStr As String
    Public Sub setUserInfos(text As List(Of String))
        For Each t As String In text
            File.AppendAllText("file.bs", t + Environment.NewLine)
        Next
    End Sub
    Public Function getUserInfos() As String()
        Return File.ReadAllLines("file.bs")
    End Function

    Public Function connected(user As String, password As String) As Boolean
        conStr = "server=server-pc; database=beeshop; user=" + user + "; Password=" + password
        Dim retou As Boolean
        If connexion IsNot Nothing Then
            connexion.Close()
            connexion.Dispose()
        End If
        connexion.ConnectionString = conStr

        Try
            connexion.Open()
            retou = True
        Catch ex As Exception
            retou = False
        Finally
            If connexion IsNot Nothing Then
                connexion.Close()
                connexion.Dispose()
            End If

        End Try
        Return retou
    End Function
End Module
