Imports System.Data
Imports System.Data.SqlClient
Module ModConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public conn As SqlConnection

    Public Function OpenConnection() As Boolean
        Dim myConnStr As String
        If My.Settings.WinAuth = False Then
            myConnStr = "Server='" & My.Settings.Server & "';Database='" & My.Settings.Database & "';User Id='" & My.Settings.UserName & "';password='" & My.Settings.Password & "'"
        Else
            myConnStr = "Server='" & My.Settings.Server & "';Database='" & My.Settings.Database & "';Trusted_Connection=True"
        End If
        Try
            conn = New SqlConnection(myConnStr)
            conn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function
End Module
