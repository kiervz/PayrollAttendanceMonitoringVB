Public Class frmMain

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim ask As String = MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130)

        If ask = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    Private Sub HideAllUserControl()
        UcDailyAttendance1.Visible = False
        UcEmployeeInfo1.Visible = False
        UcDashboard1.Visible = False
        UcEmployeePayroll1.Visible = False
        UcUserManagement1.Visible = False
    End Sub

    Private Sub btnMonitoring_Click(sender As Object, e As EventArgs) Handles btnMonitoring.Click
        HideAllUserControl()
        UcDailyAttendance1.Visible = True
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        HideAllUserControl()
        UcDashboard1.Visible = True
    End Sub

    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        HideAllUserControl()
        UcEmployeePayroll1.Visible = True
    End Sub

    Private Sub btnEmployeeManagement_Click(sender As Object, e As EventArgs) Handles btnEmployeeManagement.Click
        HideAllUserControl()
        UcEmployeeInfo1.Visible = True
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        HideAllUserControl()
        UcUserManagement1.Visible = True
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        HideAllUserControl()
        UcDashboard1.Visible = True

        txtUserType.Text = UserType
    End Sub
End Class