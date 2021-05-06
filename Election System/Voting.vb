Public Class Voting
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtStudentID.Text = Loginfrm.voter
        connect()
        rs.Open("Select * from studentTable where StudentId = '" & txtStudentID.Text & "'", con, 3, 3)

        If rs.Fields("VotingStatus").Value = "Voted" Then
            MsgBox("Already Voted!")

            Votingfrm.Show()
            Me.Hide()
        End If
        rs.Close()
        rs.Open("Select * from CandidateTable", con, 3, 3)
        Do Until rs.EOF
            If rs.Fields("CandidatePosition").Value = "President" Then
                cbPresident.Items.Add(rs.Fields("CandidateName").Value)
            ElseIf rs.Fields("CandidatePosition").Value = "Vice-President" Then
                cbVP.Items.Add(rs.Fields("CandidateName").Value)
            ElseIf rs.Fields("CandidatePosition").Value = "Senator" Then
                cbSenator.Items.Add(rs.Fields("CandidateName").Value)
            ElseIf rs.Fields("CandidatePosition").Value = "Mayor" Then
                cbMayor.Items.Add(rs.Fields("CandidateName").Value)
            ElseIf rs.Fields("CandidatePosition").Value = "Vice-Mayor" Then
                cbViceMayor.Items.Add(rs.Fields("CandidateName").Value)
            ElseIf rs.Fields("CandidatePosition").Value = "Councilor" Then
                clbCouncilor.Items.Add(rs.Fields("CandidateName").Value)
            End If
            rs.MoveNext()
        Loop

        rs.Close()
        con.Close()
    End Sub

    'Private Sub cbCouncilor1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCouncilor1.SelectedIndexChanged
    '    Dim selectedItem = CType(cbCouncilor1.SelectedItem, String)
    '    Dim resultIndex As Integer = cbCouncilor2.FindStringExact(cbCouncilor1.SelectedItem)
    '    Me.cbCouncilor2.Items.RemoveAt(resultIndex)
    'End Sub

    'Private Sub cbCouncilor2_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Dim selectedItem = CType(cbCouncilor2.SelectedItem, String)
    '    Dim resultIndex As Integer = cbCouncilor1.FindStringExact(cbCouncilor2.SelectedItem)
    '    Me.cbCouncilor1.Items.RemoveAt(resultIndex)
    'End Sub

    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click

        connect()
        rs.Open("Select * from VoteTable", con, 3, 3)
        rs.AddNew()
        rs.Fields("StudentID").Value = txtStudentID.Text
        rs.Fields("CandidateName").Value = cbPresident.Text
        rs.Fields("CandidatePosition").Value = "President"
        rs.Update()
        rs.Close()
        rs.Open("Select * from VoteTable")
        rs.AddNew()
        rs.Fields("StudentID").Value = txtStudentID.Text
        rs.Fields("CandidateName").Value = cbVP.Text
        rs.Fields("CandidatePosition").Value = "Vice-President"
        rs.Update()
        rs.Close()
        rs.Open("Select * from VoteTable")
        rs.AddNew()
        rs.Fields("StudentID").Value = txtStudentID.Text
        rs.Fields("CandidateName").Value = cbSenator.Text
        rs.Fields("CandidatePosition").Value = "Senator"
        rs.Update()
        rs.Close()
        rs.Open("Select * from VoteTable")
        rs.AddNew()
        rs.Fields("StudentID").Value = txtStudentID.Text
        rs.Fields("CandidateName").Value = cbMayor.Text
        rs.Fields("CandidatePosition").Value = "Mayor"
        rs.Update()
        rs.Close()
        rs.Open("Select * from VoteTable")
        rs.AddNew()
        rs.Fields("StudentID").Value = txtStudentID.Text
        rs.Fields("CandidateName").Value = cbViceMayor.Text
        rs.Fields("CandidatePosition").Value = "Vice-Mayor"
        rs.Update()
        For i = 0 To clbCouncilor.SelectedItems.Count - 1
            If clbCouncilor.SelectedItems(i).ToString = " " Then
            Else
                rs.AddNew()
                rs.Fields("StudentID").Value = txtStudentID.Text
                rs.Fields("CandidateName").Value = clbCouncilor.SelectedItems(i).ToString
                rs.Fields("CandidatePosition").Value = "Councilor"
                rs.Update()
            End If
        Next
        rs.Close()
        rs.Open("select * from StudentTable where StudentID = '" & txtStudentID.Text & "'", con, 3, 3)
        rs.Update()
        rs.Fields("VotingStatus").Value = "Voted"
        rs.Update()
        rs.Close()

        con.Close()
        MsgBox("Voted Successfully")
        Me.Hide()
        clear()
        Votingfrm.Show()

    End Sub

 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Votingfrm.Show()
    End Sub

    Public Sub clear()
        txtStudentID.Clear()
        cbPresident.Items.Clear()
        cbMayor.Items.Clear()
        cbSenator.Items.Clear()
        cbViceMayor.Items.Clear()
        cbVP.Items.Clear()
    End Sub
End Class