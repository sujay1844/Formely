<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreateForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        AddFieldButton = New Button()
        FieldsPanel = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' AddFieldButton
        ' 
        AddFieldButton.Location = New Point(237, 12)
        AddFieldButton.Name = "AddFieldButton"
        AddFieldButton.Size = New Size(75, 23)
        AddFieldButton.TabIndex = 0
        AddFieldButton.Text = "Add field"
        AddFieldButton.UseVisualStyleBackColor = True
        ' 
        ' FieldsPanel
        ' 
        FieldsPanel.FlowDirection = FlowDirection.TopDown
        FieldsPanel.Location = New Point(12, 41)
        FieldsPanel.Name = "FieldsPanel"
        FieldsPanel.Size = New Size(699, 497)
        FieldsPanel.TabIndex = 1
        ' 
        ' FormCreateForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(723, 550)
        Controls.Add(FieldsPanel)
        Controls.Add(AddFieldButton)
        Name = "FormCreateForm"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents AddFieldButton As Button
    Friend WithEvents FieldsPanel As FlowLayoutPanel
End Class
