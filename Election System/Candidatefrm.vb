Public Class Candidatefrm

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtCourse.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        connect()
        rs.Open("Select * from CandidateTable where CandidateID ='" & txtCandidateID.Text & "'", con, 3, 3)
        If rs.RecordCount = 0 Then
            rs.AddNew()
            rs.Fields("CandidateID").Value = txtCandidateID.Text
            rs.Fields("CandidateName").Value = txtName.Text
            rs.Fields("CandidateCourse").Value = txtCourse.Text
            rs.Fields("CandidatePosition").Value = cbposition.Text
            rs.Fields("CandidateGender").Value = txtGender.Text
            rs.Fields("CandidateParty").Value = txtParty.Text
            rs.Update()
            MsgBox("Candidate Added!")
        Else
            MsgBox("already exist!")
        End If
        rs.Close()
        con.Close()

    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        Mainfrm.Show()
    End Sub

End Class