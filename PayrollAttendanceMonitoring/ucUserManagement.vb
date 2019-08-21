Public Class ucUserManagement

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim new_user As New frmRegisterUser
        new_user.ShowDialog(Me)
    End Sub
End Class
