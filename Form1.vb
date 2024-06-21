
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

Public Class Form1
    Private Sub ViewSubmissionsButton_Click(sender As Object, e As EventArgs) Handles ViewSubmissionsButton.Click
        ViewSubmissionsForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

