Imports System.Net.Http
Imports System.Text

Public Class EditResponseForm
    Private Property Entry As FormEntry
    Private Property Id As String
    Private stopwatch As Stopwatch
    Private timer As Timer
    Private stopwatchIsRunning As Boolean
    Public Sub New(entry As FormEntry, id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Entry = entry
        Me.Id = id
        ShowFormEntry()
        stopwatch = New Stopwatch()
        timer = New Timer()
        timer.Interval = 100
        AddHandler timer.Tick, AddressOf Timer_Tick
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        StopwatchTimeTextBox.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss\.ff")
    End Sub
    Private Sub ShowFormEntry()
        Dim entry As FormEntry = Me.Entry
        NameTextBox.Text = entry.Name
        EmailTextBox.Text = entry.Email
        PhoneTextBox.Text = entry.Phone
        GithubLinkTextBox.Text = entry.GithubLink
        StopwatchTimeTextBox.Text = entry.StopwatchTime
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.T) Then
            StopwatchToggleButton_Click(StopwatchToggleButton, EventArgs.Empty)
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            SubmitButton_Click(SubmitButton, EventArgs.Empty)
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub StopwatchToggleButton_Click(sender As Object, e As EventArgs) Handles StopwatchToggleButton.Click
        If Not stopwatchIsRunning Then
            stopwatch.Start()
            timer.Start()
            stopwatchIsRunning = True
        Else
            stopwatch.Stop()
            timer.Stop()
            stopwatchIsRunning = False
        End If
    End Sub
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
        Dim url As String = "https://formely-backend-krgbirukmq-el.a.run.app/edit/" & Me.Id
        Using client As New HttpClient()
            Dim content As New StringContent(data, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PutAsync(url, content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Edit successful!")
            Else
                MessageBox.Show("Edit failed!")
            End If
        End Using
    End Function
End Class