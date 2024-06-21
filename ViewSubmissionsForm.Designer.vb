<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSubmissionsForm))
        StopwatchTimeTextBox = New TextBox()
        GithubLinkTextBox = New TextBox()
        GithubLinkLabel = New Label()
        PhoneTextBox = New TextBox()
        PhoneLabel = New Label()
        EmailTextBox = New TextBox()
        EmailLabel = New Label()
        NameTextBox = New TextBox()
        NameLabel = New Label()
        StopwatchTimeLabel = New Label()
        PreviousButton = New Button()
        NextButton = New Button()
        SuspendLayout()
        ' 
        ' StopwatchTimeTextBox
        ' 
        StopwatchTimeTextBox.Enabled = False
        StopwatchTimeTextBox.Location = New Point(123, 138)
        StopwatchTimeTextBox.Name = "StopwatchTimeTextBox"
        StopwatchTimeTextBox.Size = New Size(135, 23)
        StopwatchTimeTextBox.TabIndex = 20
        ' 
        ' GithubLinkTextBox
        ' 
        GithubLinkTextBox.Enabled = False
        GithubLinkTextBox.Location = New Point(102, 109)
        GithubLinkTextBox.Name = "GithubLinkTextBox"
        GithubLinkTextBox.Size = New Size(156, 23)
        GithubLinkTextBox.TabIndex = 19
        ' 
        ' GithubLinkLabel
        ' 
        GithubLinkLabel.AutoSize = True
        GithubLinkLabel.Location = New Point(27, 112)
        GithubLinkLabel.Name = "GithubLinkLabel"
        GithubLinkLabel.Size = New Size(68, 15)
        GithubLinkLabel.TabIndex = 18
        GithubLinkLabel.Text = "Github Link"
        ' 
        ' PhoneTextBox
        ' 
        PhoneTextBox.Enabled = False
        PhoneTextBox.Location = New Point(102, 80)
        PhoneTextBox.Name = "PhoneTextBox"
        PhoneTextBox.Size = New Size(156, 23)
        PhoneTextBox.TabIndex = 17
        ' 
        ' PhoneLabel
        ' 
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New Point(27, 83)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New Size(41, 15)
        PhoneLabel.TabIndex = 16
        PhoneLabel.Text = "Phone"
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Enabled = False
        EmailTextBox.Location = New Point(102, 51)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(156, 23)
        EmailTextBox.TabIndex = 15
        ' 
        ' EmailLabel
        ' 
        EmailLabel.AutoSize = True
        EmailLabel.Location = New Point(27, 54)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(36, 15)
        EmailLabel.TabIndex = 14
        EmailLabel.Text = "Email"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Enabled = False
        NameTextBox.Location = New Point(102, 22)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(156, 23)
        NameTextBox.TabIndex = 13
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(27, 25)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(39, 15)
        NameLabel.TabIndex = 12
        NameLabel.Text = "Name"
        ' 
        ' StopwatchTimeLabel
        ' 
        StopwatchTimeLabel.AutoSize = True
        StopwatchTimeLabel.Location = New Point(27, 141)
        StopwatchTimeLabel.Name = "StopwatchTimeLabel"
        StopwatchTimeLabel.Size = New Size(90, 15)
        StopwatchTimeLabel.TabIndex = 22
        StopwatchTimeLabel.Text = "Stopwatch time"
        ' 
        ' PreviousButton
        ' 
        PreviousButton.Location = New Point(27, 175)
        PreviousButton.Name = "PreviousButton"
        PreviousButton.Size = New Size(113, 23)
        PreviousButton.TabIndex = 23
        PreviousButton.Text = "Previous (Ctrl+P)"
        PreviousButton.UseVisualStyleBackColor = True
        ' 
        ' NextButton
        ' 
        NextButton.Location = New Point(146, 175)
        NextButton.Name = "NextButton"
        NextButton.Size = New Size(112, 23)
        NextButton.TabIndex = 24
        NextButton.Text = "Next (Ctrl+N)"
        NextButton.UseVisualStyleBackColor = True
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(296, 222)
        Controls.Add(NextButton)
        Controls.Add(PreviousButton)
        Controls.Add(StopwatchTimeLabel)
        Controls.Add(StopwatchTimeTextBox)
        Controls.Add(GithubLinkTextBox)
        Controls.Add(GithubLinkLabel)
        Controls.Add(PhoneTextBox)
        Controls.Add(PhoneLabel)
        Controls.Add(EmailTextBox)
        Controls.Add(EmailLabel)
        Controls.Add(NameTextBox)
        Controls.Add(NameLabel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents StopwatchTimeTextBox As TextBox
    Friend WithEvents GithubLinkTextBox As TextBox
    Friend WithEvents GithubLinkLabel As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents StopwatchTimeLabel As Label
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
End Class
