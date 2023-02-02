Imports MusicBookingSystem.UserFileHandler
Imports MusicBookingSystem.DataStructures
Public Class amendUser
    Public index As Integer = 0
    Public IdFile As String = "userId.txt"
    Private Sub amendBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadUsers()
        comboUserType.Items.AddRange({"User", "Admin"})
        UpdateUserBoxes()
    End Sub
    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        Dim newId As Integer = getNewId()
        index = userMaxIndex
        txtId.Text = newId
        txtUsername.Text = ""
        txtPassword.Text = ""
        comboUserType.SelectedIndex = -1
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If index > 0 Then
            index -= 1
            UpdateUserBoxes()
        Else
            MsgBox("cannot go to previous record")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If index < userMaxIndex - 1 Then
            index += 1
            UpdateUserBoxes()
        Else
            MsgBox("cannot go to next record")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UpdateUserArray()
        WriteUsers()
        If (index = userMaxIndex) Then
            IncrementId()
            userMaxIndex += 1
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim f1 = New MainMenu
        f1.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For i = index To userMaxIndex
            userDataArray(i) = userDataArray(i + 1)
        Next
        WriteUsers()
        If (index = userMaxIndex) Then
            DecrementId()
            userMaxIndex -= 1
        End If
        index -= 1
        UpdateUserBoxes()
    End Sub

    Function getNewId()
        FileOpen(1, IdFile, OpenMode.Input)
        Dim Id As Integer
        Input(1, Id)
        FileClose(1)
        Return Id + 1
    End Function

    Sub IncrementId()
        FileOpen(1, IdFile, OpenMode.Output)
        Write(1, userDataArray(index).Id + 1)
        FileClose(1)
    End Sub

    Sub DecrementId()
        FileOpen(1, IdFile, OpenMode.Output)
        Write(1, userDataArray(index).Id - 1)
        FileClose(1)
    End Sub

    Sub UpdateUserBoxes()
        txtId.Text = userDataArray(index).Id
        txtUsername.Text = userDataArray(index).Username
        txtPassword.Text = userDataArray(index).Password
        comboUserType.SelectedIndex = comboUserType.Items.IndexOf(userDataArray(index).UserType)
    End Sub

    Sub UpdateUserArray()
        userDataArray(index).Id = txtId.Text
        userDataArray(index).Username = txtUsername.Text
        userDataArray(index).Password = txtPassword.Text
        userDataArray(index).UserType = comboUserType.SelectedItem
    End Sub
End Class