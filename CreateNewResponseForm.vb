Imports System.Net.Http
Imports System.Text

Public Class CreateNewResponseForm
    Public Async Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim entry As New FormEntry With {
                .Name = NameTextBox.Text,
                .Email = EmailTextBox.Text,
                .Phone = PhoneTextBox.Text,
                .GithubLink = GithubLinkTextBox.Text,
                .StopwatchTime = StopwatchTimeTextBox.Text
            }
        ' Send POST request to server
        Await SubmitEntry(entry.JsonEncoded())
        Me.Close()
    End Sub

    Private Async Function SubmitEntry(data As String) As Task
        MessageBox.Show(data)
        Dim url As String = "https://formely-backend-krgbirukmq-el.a.run.app/submit"
        Using client As New HttpClient()
            Dim content As New StringContent(data, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Submission failed!")
            End If
        End Using
    End Function
End Class