Public Class Loginfrm
    Public voter As String

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        connect()
        rs.Open("Select * From LoginTable where Username = '" & txtUser.Text & "' and Password = '" & txtPass.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            If rs.Fields("usertype").Value = "Admin" Then
                Me.Hide()
                Mainfrm.Show()
            ElseIf rs.Fields("usertype").Value = "Voter" Then
                Me.Hide()
                voter = txtUser.Text
                Votingfrm.Show()
            ElseIf rs.Fields("usertype").Value = "Moderator" Then
                Result.Show()
                Me.Hide()

            End If
        End If
        rs.Close()
        con.Close()
    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        End
    End Sub
End Class
