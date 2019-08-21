Public Class frmLogin

    Dim totalAttempt As Integer = 0
    Public IDNoLogInOut As Integer
    Public IDNoAttendance As Integer
    Public Data As AppData

    Sub New(ByVal data As AppData)
        InitializeComponent()
        Me.Data = data
    End Sub


End Class