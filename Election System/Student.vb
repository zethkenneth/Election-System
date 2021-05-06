Public Class Student

    Dim flag As Integer

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        unlock()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnAdd.Enabled = False
        flag = 1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If flag = 1 Then
            connect()
            rs.Open("select * From StudentTable where StudentID = '" & txtStudentID.Text & "'", con, 3, 3)
            rx.Open("Select * from LoginTable where Username = '" & txtStudentID.Text & "'", con, 3, 3)
            If rs.RecordCount = 0 And rx.RecordCount = 0 Then
                rs.AddNew()
                rx.AddNew()
                rs.Fields("StudentID").Value = txtStudentID.Text
                rx.Fields("Username").Value = txtStudentID.Text
                rx.Fields("Password").Value = txtPassword.Text
                rx.Fields("usertype").Value = "Voter"
                rs.Fields("StudentName").Value = txtName.Text
                rs.Fields("Course").Value = txtCourse.Text
                rs.Fields("VotingStatus").Value = "Unvoted"
                rx.Update()
                rs.Update()
            Else
                MsgBox("Records Already Exist", vbCritical, "EXISTING")
            End If
        ElseIf flag = 2 Then
            connect()
            rs.Open("select * From StudentTable where StudentID = '" & txtStudentID.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Update()
                rs.Fields("StudentID").Value = txtStudentID.Text
                rs.Fields("StudentName").Value = txtName.Text
                rs.Fields("Course").Value = txtCourse.Text
                rs.Update()
            Else
                MsgBox("Records Already Exist", vbCritical, "EXISTING")
            End If
        End If
        rs.Close()
        con.Close()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        unlock()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnAdd.Enabled = False
        flag = 2
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connect()
        rs.Open("select * From StudentTable where StudentID = '" & txtStudentID.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            rs.Delete()
        End If
        rs.Close()
        con.Close()

    End Sub
    Public Sub lock()
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = False
            ElseIf TypeOf c Is ComboBox Then
                c.Enabled = False
            End If
        Next
    End Sub
    Public Sub unlock()
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = True
            ElseIf TypeOf c Is ComboBox Then
                c.Enabled = True
            End If
        Next
    End Sub

    Public Sub clr()
        For Each c In Me.Controls

            If TypeOf c Is TextBox Then
                c.Text = ""
            ElseIf TypeOf c Is ComboBox Then
                c.Text = "Select"
            End If
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Mainfrm.Show()

    End Sub

    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEdit.Enabled = True
        btnSave.Enabled = False
        btnAdd.Enabled = True
    End Sub
End Class