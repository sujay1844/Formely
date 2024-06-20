Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

Public Class FormCreateForm
    Private Elements As New List(Of FormElementGUI)

    Private Sub AddFieldButton_Click(sender As Object, e As EventArgs) Handles AddFieldButton.Click
        Dim formElement As New FormElementGUI()
        Elements.Add(formElement)
        FieldsPanel.Controls.Add(formElement.FlowPanel())
    End Sub

    Private Async Sub CreateFormButton_Click(sender As Object, e As EventArgs) Handles CreateFormButton.Click
        Dim fields As New List(Of FormElement)
        For Each element In Elements
            fields.Add(element.GetValues())
        Next

        Dim postData As New Dictionary(Of String, Object) From {
            {"elements", fields}
        }

        ' Convert to JSON in snake_case
        Dim settings As New JsonSerializerSettings()
        settings.ContractResolver = New DefaultContractResolver() With {
            .NamingStrategy = New SnakeCaseNamingStrategy()
        }
        Dim json As String = JsonConvert.SerializeObject(postData, settings)
        Await Submit(json)
    End Sub

    Private Async Function Submit(data As String) As Task
        Dim url As String = "https://formely-backend-krgbirukmq-el.a.run.app/form"
        MessageBox.Show(data)
        Using client As New HttpClient()
            ' Set the content type to application/json
            Dim content As New StringContent(data, Encoding.UTF8, "application/json")

            ' Post the data to the API
            Dim response As HttpResponseMessage = Await client.PostAsync(url, content)
            Dim responseContent As String = Await response.Content.ReadAsStringAsync()

            If Not response.IsSuccessStatusCode Then
                MessageBox.Show("Error: " & response.StatusCode.ToString() & responseContent)
            End If

            ' Extract id from json response
            Dim id As String = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(responseContent)("id")
            ' Display the id in a MessageBox
            MessageBox.Show("Success. ID: " & id)
            ' Copy the id to the clipboard
            Clipboard.SetText(id)
            MessageBox.Show("ID copied to clipboard")
            ' Close the form
            Me.Close()
        End Using
    End Function
End Class

Public Class FormElementGUI
    Private textBox As TextBox
    Private comboBox As ComboBox

    Public Sub New()
        Me.textBox = New TextBox()
        Me.textBox.PlaceholderText = "Label"

        Me.comboBox = New ComboBox()
        Me.comboBox.DropDownStyle = ComboBoxStyle.DropDownList
        Me.comboBox.Items.Add("text")
        Me.comboBox.Items.Add("number")
        ' default value
        Me.comboBox.SelectedIndex = 0
    End Sub

    Public Function FlowPanel()
        Dim panel As New FlowLayoutPanel()
        panel.FlowDirection = FlowDirection.LeftToRight

        panel.Controls.Add(Me.textBox)
        panel.Controls.Add(Me.comboBox)

        Return panel

    End Function

    Public Function GetValues()
        Return New FormElement() With {.Label = Me.textBox.Text, .Type = Me.comboBox.SelectedItem.ToString()}
    End Function
End Class

Public Class FormElement
    Public Property Label As String
    Public Property Type As String
End Class