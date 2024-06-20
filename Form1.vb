Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization



Public Class Form1
    Private Async Sub ButtonFetchSchema_Click(sender As Object, e As EventArgs) Handles ButtonFetchSchema.Click
        Dim FormID As String = FormIDTextBox.Text
        ' Define the schema API endpoint
        Dim schemaApiUrl As String = "https://formely-backend-krgbirukmq-el.a.run.app/form/" & FormID ' Replace with your schema API endpoint

        ' Fetch the schema
        Dim schema As Schema = Await FetchSchemaAsync(schemaApiUrl)

        ' Create controls dynamically based on the schema
        If schema IsNot Nothing Then
            CreateControls(schema)
        End If
    End Sub

    Private Async Function FetchSchemaAsync(url As String) As Task(Of Schema)
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(url)
            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Return JsonConvert.DeserializeObject(Of Schema)(jsonResponse)
            Else
                MessageBox.Show("Error fetching schema: " & response.StatusCode.ToString())
                Return Nothing
            End If
        End Using
    End Function

    Private Sub CreateControls(schema As Schema)
        ' Clear any existing controls
        FormPanel.Controls.Clear()

        ' Loop through schema elements and create corresponding controls
        For Each element As Element In schema.Elements
            Dim label As New Label() With {.Text = element.Label, .AutoSize = True}
            FormPanel.Controls.Add(label)

            If element.Type = "text" Then
                Dim textBox As New TextBox() With {.Name = "TextBox_" & element.Label}
                FormPanel.Controls.Add(textBox)
            ElseIf element.Type = "number" Then
                Dim numericUpDown As New NumericUpDown() With {.Name = "NumericUpDown_" & element.Label}
                FormPanel.Controls.Add(numericUpDown)
            End If
        Next
    End Sub

    Private Async Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        ' Create a new instance of PostData
        Dim data As New Dictionary(Of String, Object)

        ' Loop through controls and populate PostData
        For Each control As Control In FormPanel.Controls
            If TypeOf control Is TextBox AndAlso control.Name.StartsWith("TextBox_") Then
                Dim propertyName As String = control.Name.Replace("TextBox_", "")
                Dim propertyValue As String = DirectCast(control, TextBox).Text
                data(propertyName) = propertyValue
            ElseIf TypeOf control Is NumericUpDown AndAlso control.Name.StartsWith("NumericUpDown_") Then
                Dim propertyName As String = control.Name.Replace("NumericUpDown_", "")
                Dim propertyValue As Integer = CInt(DirectCast(control, NumericUpDown).Value)
                data(propertyName) = propertyValue
            End If
        Next

        ' Serialize the data to JSON
        Dim jsonPostData As String = JsonConvert.SerializeObject(data)
        Dim FormID As String = FormIDTextBox.Text

        ' Define the API endpoint
        Dim apiUrl As String = "https://formely-backend-krgbirukmq-el.a.run.app/response/" & FormID ' Replace with your API endpoint

        ' Send the data to the API
        Await SendDataToApiAsync(apiUrl, jsonPostData)
    End Sub

    Private Async Function SendDataToApiAsync(url As String, data As String) As Task
        MessageBox.Show(data)
        ' Create an instance of HttpClient
        Using client As New HttpClient()
            ' Set the content type to application/json
            Dim content As New StringContent(data, Encoding.UTF8, "application/json")

            ' Post the data to the API
            Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                ' Display the response in a MessageBox
                MessageBox.Show("Success: " & responseContent)
            Else
                ' Display the error in a MessageBox
                MessageBox.Show("Error: " & response.StatusCode.ToString())
            End If
        End Using
    End Function

    Private Sub CreateFormButton_Click(sender As Object, e As EventArgs) Handles CreateFormButton.Click
        Dim createForm As New FormCreateForm()
        createForm.Show()
    End Sub

    Private Async Sub GetResponsesButton_Click(sender As Object, e As EventArgs) Handles GetResponsesButton.Click
        Dim formID As String = FormIDTextBox.Text
        ' Get the responses API endpoint
        Dim responses As String = Await GetResponses(formID)
        If responses IsNot Nothing Then
            ' Show file dialog to save responses
            SaveToFile(responses)
        End If
    End Sub

    Private Shared Sub SaveToFile(responses As String)
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "JSON files (*.json)|*.json"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(saveFileDialog.FileName, responses)
        End If
    End Sub

    Private Shared Async Function GetResponses(formID As String) As Task(Of String)
        Dim url As String = "https://formely-backend-krgbirukmq-el.a.run.app/response/" & formID
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(url)
            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Return jsonResponse
            Else
                MessageBox.Show("Error fetching responses: " & response.StatusCode.ToString())
                Return Nothing
            End If
        End Using
    End Function
End Class
Public Class Element
    Public Property Label As String
    Public Property Type As String
    Public Property Value As Object ' to store the actual value inputted by the user
End Class

Public Class Schema
    Public Property Elements As List(Of Element)
End Class
