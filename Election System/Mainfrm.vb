Public Class Mainfrm

    Private Sub VotingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Votingfrm.Show()
    End Sub

    Private Sub CandiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CandiToolStripMenuItem.Click
        Me.Hide()
        Candidatefrm.Show()
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click
        Me.Hide()
        Student.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Loginfrm.Show()
    End Sub
End Class