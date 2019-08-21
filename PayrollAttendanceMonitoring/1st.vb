Public Class _1st

    Private Data As AppData
    Private Verifier As frmLogin
    Public WithEvents AppData As AppData
    Private countAllRows As Integer

    Sub New()
        InitializeComponent()

        Data = New AppData()
        Verifier = New frmLogin(Data)
    End Sub




    Private Sub _1st_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Verifier.ShowDialog()
    End Sub
End Class