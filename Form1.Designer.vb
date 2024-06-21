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
        PanelDynamicControls = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' ButtonFetchSchema
        ' 
        ButtonFetchSchema.Location = New Point(107, 18)
        ButtonFetchSchema.Name = "ButtonFetchSchema"
        ButtonFetchSchema.Size = New Size(75, 23)
        ButtonFetchSchema.TabIndex = 1
        ButtonFetchSchema.Text = "Fetch Schema"
        ButtonFetchSchema.UseVisualStyleBackColor = True
        ' 
        ' ButtonSubmit
        ' 
        ButtonSubmit.Location = New Point(425, 18)
        ButtonSubmit.Name = "ButtonSubmit"
        ButtonSubmit.Size = New Size(75, 23)
        ButtonSubmit.TabIndex = 2
        ButtonSubmit.Text = "Submit"
        ButtonSubmit.UseVisualStyleBackColor = True
        ' 
        ' PanelDynamicControls
        ' 
        PanelDynamicControls.Location = New Point(61, 77)
        PanelDynamicControls.Name = "PanelDynamicControls"
        PanelDynamicControls.Size = New Size(677, 332)
        PanelDynamicControls.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PanelDynamicControls)
        Controls.Add(ButtonSubmit)
        Controls.Add(ButtonFetchSchema)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub
    Friend WithEvents ButtonFetchSchema As Button
    Friend WithEvents ButtonSubmit As Button
    Friend WithEvents PanelDynamicControls As FlowLayoutPanel

End Class
