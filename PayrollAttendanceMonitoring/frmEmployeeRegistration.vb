Public Class frmEmployeeRegistration

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub frmEmployeeRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
    End Sub
End Class