<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ButtonFetchSchema = New Button()
        ButtonSubmit = New Button()
        FormIDTextBox = New TextBox()
        CreateFormButton = New Button()
        FormPanel = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' ButtonFetchSchema
        ' 
        ButtonFetchSchema.Location = New Point(274, 13)
        ButtonFetchSchema.Name = "ButtonFetchSchema"
        ButtonFetchSchema.Size = New Size(75, 23)
        ButtonFetchSchema.TabIndex = 1
        ButtonFetchSchema.Text = "Fetch Schema"
        ButtonFetchSchema.UseVisualStyleBackColor = True
        ' 
        ' ButtonSubmit
        ' 
        ButtonSubmit.Location = New Point(215, 515)
        ButtonSubmit.Name = "ButtonSubmit"
        ButtonSubmit.Size = New Size(75, 23)
        ButtonSubmit.TabIndex = 2
        ButtonSubmit.Text = "Submit"
        ButtonSubmit.UseVisualStyleBackColor = True
        ' 
        ' FormIDTextBox
        ' 
        FormIDTextBox.Location = New Point(24, 13)
        FormIDTextBox.Name = "FormIDTextBox"
        FormIDTextBox.PlaceholderText = "Form ID"
        FormIDTextBox.Size = New Size(244, 23)
        FormIDTextBox.TabIndex = 4
        ' 
        ' CreateFormButton
        ' 
        CreateFormButton.Location = New Point(355, 12)
        CreateFormButton.Name = "CreateFormButton"
        CreateFormButton.Size = New Size(111, 23)
        CreateFormButton.TabIndex = 5
        CreateFormButton.Text = "Create New"
        CreateFormButton.UseVisualStyleBackColor = True
        ' 
        ' FormPanel
        ' 
        FormPanel.Location = New Point(24, 42)
        FormPanel.Name = "FormPanel"
        FormPanel.Size = New Size(442, 467)
        FormPanel.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(502, 550)
        Controls.Add(FormPanel)
        Controls.Add(CreateFormButton)
        Controls.Add(FormIDTextBox)
        Controls.Add(ButtonSubmit)
        Controls.Add(ButtonFetchSchema)
        Name = "Form1"
        Text = "Formely"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ButtonFetchSchema As Button
    Friend WithEvents ButtonSubmit As Button
    Friend WithEvents FormIDTextBox As TextBox
    Friend WithEvents CreateFormButton As Button
    Friend WithEvents FormPanel As FlowLayoutPanel

End Class
