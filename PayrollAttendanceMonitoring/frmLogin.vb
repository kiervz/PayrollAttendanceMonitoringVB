Imports System.Data.SqlClient

Public Class frmLogin

    Dim totalAttempt As Integer = 0
    Public IDNoLogInOut As Integer
    Public IDNoAttendance As Integer
    Public Data As AppData

    Sub New(ByVal data As AppData)
        InitializeComponent()
        Me.Data = data
    End Sub

    Private Sub Login()
        If txtUsername.Text = "" And txtPassword.Text <> "" Then
            Msg(Me, "Please enter your username.", "Fields Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtPassword.Text = "" And txtUsername.Text <> "" Then
            Msg(Me, "Please enter your password.", "Fields Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtUsername.Text = "" And txtPassword.Text = "" Then
            Msg(Me, "Please enter your username and password.", "Fields Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                str = "Select * from tblUserInformation where Username=@Username AND Password=@Password"
                cmd = New SqlCommand(str, sqlconn)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                dr = cmd.ExecuteReader()

                If dr.Read() Then
                    UserID = dr("UserID")
                    UserPass = dr("Password")
                    UserType = dr("UserType")
                    Firstname = dr("FirstName")
                    Middlename = dr("MiddleName")
                    Lastname = dr("LastName")


                    txtUsername.Clear()
                    txtPassword.Clear()
                    frmMain.Show()
                    Me.Hide()
                Else
                    Msg(Me, "Incorrect Username or Password", "Authentication Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Attempt()
                    txtUsername.Clear()
                    txtPassword.Clear()
                    txtUsername.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Attempt()
        totalAttempt = totalAttempt + 1

        If totalAttempt = 3 Then
            Msg(Me, "You have reached the maximum attempts. System will be closed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Login()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Login()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
    End Sub
End Class