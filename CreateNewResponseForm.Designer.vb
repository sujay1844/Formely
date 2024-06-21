<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewResponseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateNewResponseForm))
        NameLabel = New Label()
        NameTextBox = New TextBox()
        EmailTextBox = New TextBox()
        EmailLabel = New Label()
        PhoneTextBox = New TextBox()
        PhoneLabel = New Label()
        GithubLinkTextBox = New TextBox()
        GithubLinkLabel = New Label()
        StopwatchTimeTextBox = New TextBox()
        StopwatchLabel = New Label()
        SubmitButton = New Button()
        SuspendLayout()
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(36, 37)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(39, 15)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Name"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(111, 34)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(156, 23)
        NameTextBox.TabIndex = 1
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(111, 63)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(156, 23)
        EmailTextBox.TabIndex = 3
        ' 
        ' EmailLabel
        ' 
        EmailLabel.AutoSize = True
        EmailLabel.Location = New Point(36, 66)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(36, 15)
        EmailLabel.TabIndex = 2
        EmailLabel.Text = "Email"
        ' 
        ' PhoneTextBox
        ' 
        PhoneTextBox.Location = New Point(111, 92)
        PhoneTextBox.Name = "PhoneTextBox"
        PhoneTextBox.Size = New Size(156, 23)
        PhoneTextBox.TabIndex = 5
        ' 
        ' PhoneLabel
        ' 
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New Point(36, 95)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New Size(41, 15)
        PhoneLabel.TabIndex = 4
        PhoneLabel.Text = "Phone"
        ' 
        ' GithubLinkTextBox
        ' 
        GithubLinkTextBox.Location = New Point(111, 121)
        GithubLinkTextBox.Name = "GithubLinkTextBox"
        GithubLinkTextBox.Size = New Size(156, 23)
        GithubLinkTextBox.TabIndex = 7
        ' 
        ' GithubLinkLabel
        ' 
        GithubLinkLabel.AutoSize = True
        GithubLinkLabel.Location = New Point(36, 124)
        GithubLinkLabel.Name = "GithubLinkLabel"
        GithubLinkLabel.Size = New Size(68, 15)
        GithubLinkLabel.TabIndex = 6
        GithubLinkLabel.Text = "Github Link"
        ' 
        ' StopwatchTimeTextBox
        ' 
        StopwatchTimeTextBox.Enabled = False
        StopwatchTimeTextBox.Location = New Point(111, 150)
        StopwatchTimeTextBox.Name = "StopwatchTimeTextBox"
        StopwatchTimeTextBox.Size = New Size(156, 23)
        StopwatchTimeTextBox.TabIndex = 9
        ' 
        ' StopwatchLabel
        ' 
        StopwatchLabel.AutoSize = True
        StopwatchLabel.Location = New Point(39, 153)
        StopwatchLabel.Name = "StopwatchLabel"
        StopwatchLabel.Size = New Size(63, 15)
        StopwatchLabel.TabIndex = 8
        StopwatchLabel.Text = "Stopwatch"
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(122, 195)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(75, 23)
        SubmitButton.TabIndex = 10
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' CreateNewResponseForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(317, 252)
        Controls.Add(SubmitButton)
        Controls.Add(StopwatchTimeTextBox)
        Controls.Add(StopwatchLabel)
        Controls.Add(GithubLinkTextBox)
        Controls.Add(GithubLinkLabel)
        Controls.Add(PhoneTextBox)
        Controls.Add(PhoneLabel)
        Controls.Add(EmailTextBox)
        Controls.Add(EmailLabel)
        Controls.Add(NameTextBox)
        Controls.Add(NameLabel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "CreateNewResponseForm"
        Text = "Create New Response"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents GithubLinkTextBox As TextBox
    Friend WithEvents GithubLinkLabel As Label
    Friend WithEvents StopwatchTimeTextBox As TextBox
    Friend WithEvents StopwatchLabel As Label
    Friend WithEvents SubmitButton As Button
End Class
