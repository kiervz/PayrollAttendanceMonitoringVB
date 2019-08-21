Public Class ucEmployeeManagement

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim emp_reg As New frmEmployeeRegistration
        emp_reg.ShowDialog(Me)
    End Sub
End Class
