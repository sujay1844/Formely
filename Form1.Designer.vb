﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        ViewSubmissionsButton = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(38, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 30)
        Label1.TabIndex = 0
        Label1.Text = "Formely: Slidely Task"
        ' 
        ' ViewSubmissionsButton
        ' 
        ViewSubmissionsButton.Location = New Point(38, 60)
        ViewSubmissionsButton.Name = "ViewSubmissionsButton"
        ViewSubmissionsButton.Size = New Size(213, 23)
        ViewSubmissionsButton.TabIndex = 1
        ViewSubmissionsButton.Text = "View Submissions"
        ViewSubmissionsButton.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(38, 103)
        Button2.Name = "Button2"
        Button2.Size = New Size(213, 23)
        Button2.TabIndex = 2
        Button2.Text = "Create New Submission"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(295, 160)
        Controls.Add(Button2)
        Controls.Add(ViewSubmissionsButton)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Formely"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ViewSubmissionsButton As Button
    Friend WithEvents Button2 As Button

End Class
