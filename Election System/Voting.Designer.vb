<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Voting
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
        Me.cbPresident = New System.Windows.Forms.ComboBox()
        Me.cbVP = New System.Windows.Forms.ComboBox()
        Me.cbMayor = New System.Windows.Forms.ComboBox()
        Me.cbSenator = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbViceMayor = New System.Windows.Forms.ComboBox()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.clbCouncilor = New System.Windows.Forms.CheckedListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbPresident
        '
        Me.cbPresident.FormattingEnabled = True
        Me.cbPresident.Location = New System.Drawing.Point(92, 66)
        Me.cbPresident.Name = "cbPresident"
        Me.cbPresident.Size = New System.Drawing.Size(185, 21)
        Me.cbPresident.TabIndex = 0
        '
        'cbVP
        '
        Me.cbVP.FormattingEnabled = True
        Me.cbVP.Location = New System.Drawing.Point(92, 93)
        Me.cbVP.Name = "cbVP"
        Me.cbVP.Size = New System.Drawing.Size(185, 21)
        Me.cbVP.TabIndex = 1
        '
        'cbMayor
        '
        Me.cbMayor.FormattingEnabled = True
        Me.cbMayor.Location = New System.Drawing.Point(92, 147)
        Me.cbMayor.Name = "cbMayor"
        Me.cbMayor.Size = New System.Drawing.Size(185, 21)
        Me.cbMayor.TabIndex = 3
        '
        'cbSenator
        '
        Me.cbSenator.FormattingEnabled = True
        Me.cbSenator.Location = New System.Drawing.Point(92, 120)
        Me.cbSenator.Name = "cbSenator"
        Me.cbSenator.Size = New System.Drawing.Size(185, 21)
        Me.cbSenator.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "President"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Vice president"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Senator"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Councilor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Vice Mayor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Mayor"
        '
        'cbViceMayor
        '
        Me.cbViceMayor.FormattingEnabled = True
        Me.cbViceMayor.Location = New System.Drawing.Point(92, 174)
        Me.cbViceMayor.Name = "cbViceMayor"
        Me.cbViceMayor.Size = New System.Drawing.Size(185, 21)
        Me.cbViceMayor.TabIndex = 4
        '
        'btnVote
        '
        Me.btnVote.Location = New System.Drawing.Point(55, 271)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(75, 23)
        Me.btnVote.TabIndex = 9
        Me.btnVote.Text = "Vote"
        Me.btnVote.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(136, 271)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'clbCouncilor
        '
        Me.clbCouncilor.FormattingEnabled = True
        Me.clbCouncilor.Location = New System.Drawing.Point(92, 201)
        Me.clbCouncilor.Name = "clbCouncilor"
        Me.clbCouncilor.Size = New System.Drawing.Size(185, 64)
        Me.clbCouncilor.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "StudentID"
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(92, 39)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(185, 20)
        Me.txtStudentID.TabIndex = 17
        '
        'Voting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 309)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.clbCouncilor)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbViceMayor)
        Me.Controls.Add(Me.cbMayor)
        Me.Controls.Add(Me.cbSenator)
        Me.Controls.Add(Me.cbVP)
        Me.Controls.Add(Me.cbPresident)
        Me.Name = "Voting"
        Me.Text = "Voting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbPresident As System.Windows.Forms.ComboBox
    Friend WithEvents cbVP As System.Windows.Forms.ComboBox
    Friend WithEvents cbMayor As System.Windows.Forms.ComboBox
    Friend WithEvents cbSenator As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbViceMayor As System.Windows.Forms.ComboBox
    Friend WithEvents btnVote As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents clbCouncilor As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
End Class
