<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Candidatefrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Candidatefrm))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtParty = New System.Windows.Forms.TextBox()
        Me.txtCandidateID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbposition = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(164, 125)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(472, 26)
        Me.txtName.TabIndex = 1
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCourse
        '
        Me.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCourse.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(164, 209)
        Me.txtCourse.Multiline = True
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(269, 36)
        Me.txtCourse.TabIndex = 2
        Me.txtCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGender
        '
        Me.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGender.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(489, 209)
        Me.txtGender.Multiline = True
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(155, 30)
        Me.txtGender.TabIndex = 3
        Me.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtParty
        '
        Me.txtParty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtParty.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParty.Location = New System.Drawing.Point(489, 299)
        Me.txtParty.Multiline = True
        Me.txtParty.Name = "txtParty"
        Me.txtParty.Size = New System.Drawing.Size(155, 29)
        Me.txtParty.TabIndex = 5
        Me.txtParty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCandidateID
        '
        Me.txtCandidateID.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCandidateID.Location = New System.Drawing.Point(233, 80)
        Me.txtCandidateID.Multiline = True
        Me.txtCandidateID.Name = "txtCandidateID"
        Me.txtCandidateID.Size = New System.Drawing.Size(130, 23)
        Me.txtCandidateID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CandidateID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "         "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(534, 422)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "                           "
        '
        'cbposition
        '
        Me.cbposition.FormattingEnabled = True
        Me.cbposition.Items.AddRange(New Object() {"President", "Vice-President", "Senator", "Mayor", "Vice-Mayor", "Councilor"})
        Me.cbposition.Location = New System.Drawing.Point(164, 307)
        Me.cbposition.Name = "cbposition"
        Me.cbposition.Size = New System.Drawing.Size(269, 21)
        Me.cbposition.TabIndex = 8
        '
        'Candidatefrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(790, 495)
        Me.Controls.Add(Me.cbposition)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCandidateID)
        Me.Controls.Add(Me.txtParty)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Candidatefrm"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtParty As System.Windows.Forms.TextBox
    Friend WithEvents txtCandidateID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbposition As System.Windows.Forms.ComboBox
End Class
