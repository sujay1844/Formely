Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
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

