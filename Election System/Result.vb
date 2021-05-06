Public Class Result

    Private Sub Result_Click(sender As Object, e As EventArgs) Handles Me.Click
        lvwPresident.Items.Clear()
        lvwVicePresident.Items.Clear()
        lvwSenator.Items.Clear()
        lvwMayor.Items.Clear()
        lvwViceMayor.Items.Clear()
        lvwCouncilor.Items.Clear()
        Dim countP, countVP, countS, countM, countVM, countC As Integer
        countP = 0
        countVP = 0
        countS = 0
        countM = 0
        countVM = 0
        countC = 0
        connect()
        rs.Open("Select * from CandidateTable", con, 3, 3)
        'puting name in listview and counting the candidate accourding to position
        Do Until rs.EOF
            If rs.Fields("CandidatePosition").Value = "President" Then

                With Me.lvwPresident
                    .Items.Add(rs.Fields("CandidateName").Value)
                    '.Items(countP).SubItems.Add(0)
                End With

                countP = countP + 1
            End If
            If rs.Fields("CandidatePosition").Value = "Vice-President" Then

                With Me.lvwVicePresident
                    .Items.Add(rs.Fields("CandidateName").Value)
                    '.Items(countVP).SubItems.Add(0)
                End With
                countVP = countVP + 1
            End If
            If rs.Fields("CandidatePosition").Value = "Senator" Then

                With Me.lvwSenator
                    .Items.Add(rs.Fields("CandidateName").Value)
                    '.Items(countS).SubItems.Add(0)
                End With
                countS = countS + 1
            End If
            If rs.Fields("CandidatePosition").Value = "Mayor" Then

                With Me.lvwMayor
                    .Items.Add(rs.Fields("CandidateName").Value)
                    '.Items(countM).SubItems.Add(0)
                End With
                countM = countM + 1

            End If
            If rs.Fields("CandidatePosition").Value = "Vice-Mayor" Then

                With Me.lvwViceMayor
                    .Items.Add(rs.Fields("CandidateName").Value)
                    '.Items(countVM).SubItems.Add(0)
                End With
                countVM = countVM + 1
            End If
            If rs.Fields("CandidatePosition").Value = "Councilor" Then

                With Me.lvwCouncilor
                    .Items.Add(rs.Fields("CandidateName").Value)
                    '.Items(countC).SubItems.Add(0)
                End With
                countC = countC + 1
            End If
            rs.MoveNext()
        Loop
        Dim P(countP - 1), VP(countVP - 1), S(countS - 1), M(countM - 1), VM(countVM - 1), C(countC - 1) As String
        rs.Close()
        'Passing the values to array
        rs.Open("Select * from CandidateTable", con, 3, 3)
        Dim a, b, g, d, h, f As Integer
        a = 0
        b = 0
        g = 0
        d = 0
        h = 0
        f = 0

        Do Until rs.EOF
            If rs.Fields("CandidatePosition").Value = "President" Then
                P(a) = rs.Fields("CandidateName").Value
                a += 1
            End If
            If rs.Fields("CandidatePosition").Value = "Vice-President" Then
                VP(b) = rs.Fields("CandidateName").Value
                b += 1
            End If
            If rs.Fields("CandidatePosition").Value = "Senator" Then
                S(g) = rs.Fields("CandidateName").Value
                g += 1
            End If
            If rs.Fields("CandidatePosition").Value = "Mayor" Then
                M(d) = rs.Fields("CandidateName").Value
                d += 1
            End If
            If rs.Fields("CandidatePosition").Value = "Vice-Mayor" Then
                VM(h) = rs.Fields("CandidateName").Value
                h += 1
            End If
            If rs.Fields("CandidatePosition").Value = "Councilor" Then
                C(f) = rs.Fields("CandidateName").Value
                f += 1
            End If
            rs.MoveNext()
        Loop
        rs.Close()
        'Counting the votes per candidate
        rs.Open("Select * from VoteTable", con, 3, 3)
        Dim Pr(countP - 1), VPr(countVP - 1), Se(countS - 1), Ma(countM - 1), VMa(countVM - 1), Co(countC - 1) As Integer
        Do Until rs.EOF
            If rs.Fields("CandidatePosition").Value = "President" Then
                For i = 0 To P.Length - 1
                    If P(i) = rs.Fields("CandidateName").Value Then
                        Pr(i) = Pr(i) + 1
                    End If
                    i += 1
                Next
            End If
            If rs.Fields("CandidatePosition").Value = "Vice-President" Then
                For i = 0 To VP.Length - 1
                    If VP(i) = rs.Fields("CandidateName").Value Then
                        VPr(i) = VPr(i) + 1
                    End If
                    i += 1
                Next
            End If
            If rs.Fields("CandidatePosition").Value = "Senator" Then
                For i = 0 To S.Length - 1
                    If S(i) = rs.Fields("CandidateName").Value Then
                        Se(i) = Se(i) + 1
                    End If
                    i += 1
                Next
            End If
            If rs.Fields("CandidatePosition").Value = "Mayor" Then
                For i = 0 To M.Length - 1
                    If M(i) = rs.Fields("CandidateName").Value Then
                        Ma(i) = Ma(i) + 1
                    End If
                    i += 1
                Next

            End If
            If rs.Fields("CandidatePosition").Value = "Vice-Mayor" Then
                For i = 0 To VM.Length - 1
                    If VM(i) = rs.Fields("CandidateName").Value Then
                        VMa(i) = VMa(i) + 1
                    End If
                    i += 1
                Next
            End If
            If rs.Fields("CandidatePosition").Value = "Councilor" Then
                For i = 0 To C.Length - 1
                    If C(i) = rs.Fields("CandidateName").Value Then
                        Co(i) = Co(i) + 1
                    End If
                    i += 1
                Next
            End If
            rs.MoveNext()
        Loop
        rs.Close()
        countP = 0
        countVP = 0
        countS = 0
        countM = 0
        countVM = 0
        countC = 0

        'displaying the votes
        rs.Open("Select * from CandidateTable ", con, 3, 3)
        Do Until rs.EOF
            If rs.Fields("CandidatePosition").Value = "President" Then

                With Me.lvwPresident
                    .Items(countP).SubItems.Add(Pr(countP))
                End With
                countP = countP + 1

            End If
            If rs.Fields("CandidatePosition").Value = "Vice-President" Then

                With Me.lvwVicePresident
                    .Items(countVP).SubItems.Add(VPr(countVP))
                End With
                countVP = countVP + 1
            End If
            If rs.Fields("CandidatePosition").Value = "Senator" Then

                With Me.lvwSenator

                    .Items(countS).SubItems.Add(Se(countS))
                End With
                countS = countS + 1
            End If
            If rs.Fields("CandidatePosition").Value = "Mayor" Then

                With Me.lvwMayor

                    .Items(countM).SubItems.Add(Ma(countM))
                End With
                countM = countM + 1

            End If
            If rs.Fields("CandidatePosition").Value = "Vice-Mayor" Then

                With Me.lvwViceMayor

                    .Items(countVM).SubItems.Add(VMa(countVM))
                End With
                countVM = countVM + 1
            End If
            If rs.Fields("CandidatePosition").Value = "Councilor" Then
                With Me.lvwCouncilor
                    .Items(countC).SubItems.Add(Co(countC))
                End With
                countC = countC + 1
            End If
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Loginfrm.Show()
    End Sub

End Class