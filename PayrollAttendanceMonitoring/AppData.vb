Public Class AppData

    'Variables for Finger print

    ' constants 
    Public Const MaxFingers As Integer = 10
    ' members
    'Public EnrolledFingersMask As Integer = 0
    'Public MaxEnrollFingerCount As Integer = MaxFingers
    Public IsEventHandlerSucceeds As Boolean = True
    Public IsFeatureSetMatched As Boolean = False
    Public FalseAcceptRate As Integer = 0
    Public Templates(MaxFingers - 1) As DPFP.Template


End Class
