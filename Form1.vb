
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

Public Class Form1
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.V) Then
            ViewSubmissionsButton_Click(ViewSubmissionsButton, EventArgs.Empty)
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            CreateNewResponseButton_Click(CreateNewResponseButton, EventArgs.Empty)
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub ViewSubmissionsButton_Click(sender As Object, e As EventArgs) Handles ViewSubmissionsButton.Click
        ViewSubmissionsForm.Show()
    End Sub

    Private Sub CreateNewResponseButton_Click(sender As Object, e As EventArgs) Handles CreateNewResponseButton.Click
        CreateNewResponseForm.Show()
    End Sub
End Class

Public Class FormEntry
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String

    Public Function JsonEncoded() As String
        Dim settings As New JsonSerializerSettings()
        settings.ContractResolver = New DefaultContractResolver() With {
            .NamingStrategy = New SnakeCaseNamingStrategy()
        }
        Return JsonConvert.SerializeObject(Me, settings)
    End Function
End Class

