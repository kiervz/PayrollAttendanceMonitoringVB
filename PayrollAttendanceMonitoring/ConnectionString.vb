Imports System.Data.SqlClient

Module ConnectionString

    Public sqlconn As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public str As String

    Public UserID As String
    Public UserPass As String
    Public Firstname As String
    Public Middlename As String
    Public Lastname As String
    Public UserType As String

    Public Sub Connect()
        Try
            If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
            sqlconn.ConnectionString = "Database=PayrollAttendanceDB; Server=KIERVEY-PC\SQLEXPRESS; Trusted_Connection=true; MultipleActiveResultSets=true"
            sqlconn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Module
