<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditResponseForm
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
        StopwatchToggleButton = New Button()
        SubmitButton = New Button()
        StopwatchTimeTextBox = New TextBox()
        GithubLinkTextBox = New TextBox()
        GithubLinkLabel = New Label()
        PhoneTextBox = New TextBox()
        PhoneLabel = New Label()
        EmailTextBox = New TextBox()
        EmailLabel = New Label()
        NameTextBox = New TextBox()
        NameLabel = New Label()
        SuspendLayout()
        ' 
        ' StopwatchToggleButton
        ' 
        StopwatchToggleButton.Location = New Point(28, 140)
        StopwatchToggleButton.Name = "StopwatchToggleButton"
        StopwatchToggleButton.Size = New Size(176, 23)
        StopwatchToggleButton.TabIndex = 22
        StopwatchToggleButton.Text = "Toggle Stopwatch (Ctrl+T)"
        StopwatchToggleButton.UseVisualStyleBackColor = True
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(142, 182)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(117, 23)
        SubmitButton.TabIndex = 21
        SubmitButton.Text = "Submit (Ctrl+S)"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' StopwatchTimeTextBox
        ' 
        StopwatchTimeTextBox.Enabled = False
        StopwatchTimeTextBox.Location = New Point(210, 140)
        StopwatchTimeTextBox.Name = "StopwatchTimeTextBox"
        StopwatchTimeTextBox.Size = New Size(156, 23)
        StopwatchTimeTextBox.TabIndex = 20
        ' 
        ' GithubLinkTextBox
        ' 
        GithubLinkTextBox.Location = New Point(210, 111)
        GithubLinkTextBox.Name = "GithubLinkTextBox"
        GithubLinkTextBox.Size = New Size(156, 23)
        GithubLinkTextBox.TabIndex = 19
        ' 
        ' GithubLinkLabel
        ' 
        GithubLinkLabel.AutoSize = True
        GithubLinkLabel.Location = New Point(28, 114)
        GithubLinkLabel.Name = "GithubLinkLabel"
        GithubLinkLabel.Size = New Size(68, 15)
        GithubLinkLabel.TabIndex = 18
        GithubLinkLabel.Text = "Github Link"
        ' 
        ' PhoneTextBox
        ' 
        PhoneTextBox.Location = New Point(210, 82)
        PhoneTextBox.Name = "PhoneTextBox"
        PhoneTextBox.Size = New Size(156, 23)
        PhoneTextBox.TabIndex = 17
        ' 
        ' PhoneLabel
        ' 
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New Point(28, 85)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New Size(41, 15)
        PhoneLabel.TabIndex = 16
        PhoneLabel.Text = "Phone"
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(210, 53)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(156, 23)
        EmailTextBox.TabIndex = 15
        ' 
        ' EmailLabel
        ' 
        EmailLabel.AutoSize = True
        EmailLabel.Location = New Point(28, 56)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(36, 15)
        EmailLabel.TabIndex = 14
        EmailLabel.Text = "Email"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(210, 24)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(156, 23)
        NameTextBox.TabIndex = 13
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(28, 27)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(39, 15)
        NameLabel.TabIndex = 12
        NameLabel.Text = "Name"
        ' 
        ' EditResponseForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(412, 232)
        Controls.Add(StopwatchToggleButton)
        Controls.Add(SubmitButton)
        Controls.Add(StopwatchTimeTextBox)
        Controls.Add(GithubLinkTextBox)
        Controls.Add(GithubLinkLabel)
        Controls.Add(PhoneTextBox)
        Controls.Add(PhoneLabel)
        Controls.Add(EmailTextBox)
        Controls.Add(EmailLabel)
        Controls.Add(NameTextBox)
        Controls.Add(NameLabel)
        Name = "EditResponseForm"
        Text = "Edit Response"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StopwatchToggleButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents StopwatchTimeTextBox As TextBox
    Friend WithEvents GithubLinkTextBox As TextBox
    Friend WithEvents GithubLinkLabel As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NameLabel As Label
End Class
