Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

Public Class ViewSubmissionsForm
    Private Property SubmissionIDs As List(Of String)
    Private Property CurrentIndex As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SubmissionIDs = New List(Of String)
        ' Add handler for the Shown event
        AddHandler Me.Shown, AddressOf ViewSubmissionsForm_Shown
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            PreviousButton_Click(PreviousButton, EventArgs.Empty)
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            NextButton_Click(NextButton, EventArgs.Empty)
            Return True
        ElseIf keyData = (Keys.Control Or Keys.E) Then
            EditButton_Click(EditButton, EventArgs.Empty)
            Return True
        ElseIf keyData = (Keys.Control Or Keys.D) Then
            DeleteButton_Click(DeleteButton, EventArgs.Empty)
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Async Sub ViewSubmissionsForm_Shown(sender As Object, e As EventArgs)
        ' Await the async method and initialize SubmissionIDs
        SubmissionIDs = Await GetSubmissionIDs()
        CurrentIndex = 0
        ' Show the first form entry
        Await ShowFormEntry(CurrentIndex)
    End Sub

    Private Async Function GetSubmissionIDs() As Task(Of List(Of String))
        Dim url As String = "https://formely-backend-krgbirukmq-el.a.run.app/read"
        Dim submissions As List(Of String)
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(url)

            Dim content As String = Await response.Content.ReadAsStringAsync()

            Dim json As Object = JsonConvert.DeserializeObject(content)
            submissions = json("ids").ToObject(Of List(Of String))
        End Using
        Return submissions
    End Function

    Private Async Function ShowFormEntry(index As Integer) As Task
        Dim entry As FormEntry = Await GetFormEntry(index)
        NameTextBox.Text = entry.Name
        EmailTextBox.Text = entry.Email
        PhoneTextBox.Text = entry.Phone
        GithubLinkTextBox.Text = entry.GithubLink
        StopwatchTimeTextBox.Text = entry.StopwatchTime
    End Function

    Private Async Function GetFormEntry(index As Integer) As Task(Of FormEntry)
        Dim url As String = "https://formely-backend-krgbirukmq-el.a.run.app/read/" & SubmissionIDs(index)
        Dim entry As FormEntry
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(url)

            Dim content As String = Await response.Content.ReadAsStringAsync()
            Dim settings As New JsonSerializerSettings()
            settings.ContractResolver = New DefaultContractResolver() With {
                .NamingStrategy = New SnakeCaseNamingStrategy()
            }
            entry = JsonConvert.DeserializeObject(Of FormEntry)(content, settings)
        End Using
        Return entry
    End Function

    Private Async Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        CurrentIndex += 1
        If CurrentIndex >= SubmissionIDs.Count Then
            MessageBox.Show("No more submissions!")
            CurrentIndex -= 1
            Return
        End If
        Await ShowFormEntry(CurrentIndex)
    End Sub

    Private Async Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        CurrentIndex -= 1
        If CurrentIndex < 0 Then
            MessageBox.Show("No more submissions!")
            CurrentIndex += 1
            Return
        End If
        Await ShowFormEntry(CurrentIndex)
    End Sub

    Private Async Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim entry As FormEntry = New FormEntry With {
            .Name = NameTextBox.Text,
            .Email = EmailTextBox.Text,
            .Phone = PhoneTextBox.Text,
            .GithubLink = GithubLinkTextBox.Text,
            .StopwatchTime = StopwatchTimeTextBox.Text
        }
        Dim editForm As EditResponseForm = New EditResponseForm(entry, SubmissionIDs(CurrentIndex))
        editForm.Show()
        ' Re-render the current form entry after editing
        Await ShowFormEntry(CurrentIndex)
    End Sub

    Private Async Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim url As String = "https://formely-backend-krgbirukmq-el.a.run.app/delete/" & SubmissionIDs(CurrentIndex)
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.DeleteAsync(url)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Deletion successful!")
                SubmissionIDs.RemoveAt(CurrentIndex)
                If CurrentIndex >= SubmissionIDs.Count Then
                    CurrentIndex = 0
                End If
                Await ShowFormEntry(CurrentIndex)
            Else
                MessageBox.Show("Deletion failed!")
            End If
        End Using
    End Sub
End Class