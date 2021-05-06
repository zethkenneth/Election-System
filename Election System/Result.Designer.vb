<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lvwMayor = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwVicePresident = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwSenator = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwCouncilor = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwPresident = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwViceMayor = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "President"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Vice-President"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(385, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Mayor"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 347)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Senator"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(385, 347)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Coucilor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(385, 178)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Vice Mayor"
        '
        'lvwMayor
        '
        Me.lvwMayor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvwMayor.Location = New System.Drawing.Point(388, 25)
        Me.lvwMayor.Name = "lvwMayor"
        Me.lvwMayor.Size = New System.Drawing.Size(310, 150)
        Me.lvwMayor.TabIndex = 20
        Me.lvwMayor.UseCompatibleStateImageBehavior = False
        Me.lvwMayor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Candidate Name"
        Me.ColumnHeader1.Width = 199
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Votes"
        Me.ColumnHeader2.Width = 100
        '
        'lvwVicePresident
        '
        Me.lvwVicePresident.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwVicePresident.Location = New System.Drawing.Point(10, 194)
        Me.lvwVicePresident.Name = "lvwVicePresident"
        Me.lvwVicePresident.Size = New System.Drawing.Size(310, 150)
        Me.lvwVicePresident.TabIndex = 21
        Me.lvwVicePresident.UseCompatibleStateImageBehavior = False
        Me.lvwVicePresident.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Candidate Name"
        Me.ColumnHeader3.Width = 199
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Votes"
        Me.ColumnHeader4.Width = 100
        '
        'lvwSenator
        '
        Me.lvwSenator.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvwSenator.Location = New System.Drawing.Point(10, 363)
        Me.lvwSenator.Name = "lvwSenator"
        Me.lvwSenator.Size = New System.Drawing.Size(310, 150)
        Me.lvwSenator.TabIndex = 22
        Me.lvwSenator.UseCompatibleStateImageBehavior = False
        Me.lvwSenator.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Candidate Name"
        Me.ColumnHeader5.Width = 199
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Votes"
        Me.ColumnHeader6.Width = 100
        '
        'lvwCouncilor
        '
        Me.lvwCouncilor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvwCouncilor.Location = New System.Drawing.Point(388, 363)
        Me.lvwCouncilor.Name = "lvwCouncilor"
        Me.lvwCouncilor.Size = New System.Drawing.Size(310, 150)
        Me.lvwCouncilor.TabIndex = 23
        Me.lvwCouncilor.UseCompatibleStateImageBehavior = False
        Me.lvwCouncilor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Candidate Name"
        Me.ColumnHeader7.Width = 199
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Votes"
        Me.ColumnHeader8.Width = 100
        '
        'lvwPresident
        '
        Me.lvwPresident.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvwPresident.Location = New System.Drawing.Point(10, 25)
        Me.lvwPresident.Name = "lvwPresident"
        Me.lvwPresident.Size = New System.Drawing.Size(310, 150)
        Me.lvwPresident.TabIndex = 24
        Me.lvwPresident.UseCompatibleStateImageBehavior = False
        Me.lvwPresident.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Candidate Name"
        Me.ColumnHeader9.Width = 199
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Votes"
        Me.ColumnHeader10.Width = 100
        '
        'lvwViceMayor
        '
        Me.lvwViceMayor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvwViceMayor.Location = New System.Drawing.Point(388, 194)
        Me.lvwViceMayor.Name = "lvwViceMayor"
        Me.lvwViceMayor.Size = New System.Drawing.Size(310, 150)
        Me.lvwViceMayor.TabIndex = 25
        Me.lvwViceMayor.UseCompatibleStateImageBehavior = False
        Me.lvwViceMayor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Candidate Name"
        Me.ColumnHeader11.Width = 199
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Votes"
        Me.ColumnHeader12.Width = 100
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(566, 520)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(132, 23)
        Me.btnLogout.TabIndex = 26
        Me.btnLogout.Text = "LogOut"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 555)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lvwViceMayor)
        Me.Controls.Add(Me.lvwPresident)
        Me.Controls.Add(Me.lvwCouncilor)
        Me.Controls.Add(Me.lvwSenator)
        Me.Controls.Add(Me.lvwVicePresident)
        Me.Controls.Add(Me.lvwMayor)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Result"
        Me.Text = "Result"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lvwMayor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwVicePresident As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwSenator As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwCouncilor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwPresident As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwViceMayor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
