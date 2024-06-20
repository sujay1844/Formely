Public Class FormCreateForm
    Private Elements As New List(Of FormElementGUI)

    Private Sub AddFieldButton_Click(sender As Object, e As EventArgs) Handles AddFieldButton.Click
        Dim formElement As New FormElementGUI()
        Elements.Add(formElement)
        FieldsPanel.Controls.Add(formElement.FlowPanel())
    End Sub
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