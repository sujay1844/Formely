Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization



Public Class Form1

    Private Async Sub ButtonFetchSchema_Click(sender As Object, e As EventArgs) Handles ButtonFetchSchema.Click
        ' Define the schema API endpoint
        Dim schemaApiUrl As String = "https://formely-backend-krgbirukmq-el.a.run.app/form/66730835a18b80c48990df49" ' Replace with your schema API endpoint

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
        PanelDynamicControls.Controls.Clear()

        ' Loop through schema elements and create corresponding controls
        For Each element As Element In schema.Elements
            Dim label As New Label() With {.Text = element.Label, .AutoSize = True}
            PanelDynamicControls.Controls.Add(label)

            If element.Type = "text" Then
                Dim textBox As New TextBox() With {.Name = "TextBox_" & element.Label}
                PanelDynamicControls.Controls.Add(textBox)
            ElseIf element.Type = "number" Then
                Dim numericUpDown As New NumericUpDown() With {.Name = "NumericUpDown_" & element.Label}
                PanelDynamicControls.Controls.Add(numericUpDown)
            End If
        Next
    End Sub

    Private Async Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        ' Collect data from dynamically created controls and create the PostData object
        Dim elements As New List(Of Element)

        For Each control As Control In PanelDynamicControls.Controls
            If TypeOf control Is TextBox Then
                elements.Add(New Element With {.Label = control.Name.Replace("TextBox_", ""), .Type = "text", .Value = DirectCast(control, TextBox).Text})
            ElseIf TypeOf control Is NumericUpDown Then
                elements.Add(New Element With {.Label = control.Name.Replace("NumericUpDown_", ""), .Type = "number", .Value = DirectCast(control, NumericUpDown).Value})
            End If
        Next

        Dim postData As New PostData With {
            .Elements = elements
        }

        Dim settings As New JsonSerializerSettings()
        settings.ContractResolver = New DefaultContractResolver() With {
            .NamingStrategy = New SnakeCaseNamingStrategy()
        }

        ' Serialize the data to JSON
        Dim jsonPostData As String = JsonConvert.SerializeObject(postData, settings)

        ' Define the API endpoint
        Dim apiUrl As String = "https://formely-backend-krgbirukmq-el.a.run.app/response/66730835a18b80c48990df49" ' Replace with your API endpoint

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

End Class
Public Class Element
    Public Property Label As String
    Public Property Type As String
    Public Property Value As Object ' to store the actual value inputted by the user
End Class

Public Class Schema
    Public Property Elements As List(Of Element)
End Class

Public Class PostData
    Public Property Elements As List(Of Element)
End Class