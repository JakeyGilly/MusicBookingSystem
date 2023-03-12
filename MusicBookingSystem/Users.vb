Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.UserFileHandler
Imports MusicBookingSystem.Validation
Imports MusicBookingSystem.Algorithms

Public Class Users
    Public index As Integer = 0
    Public IdFile As String = "userId.txt"
    Public newUser As Boolean = False
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Read all data from files
        ReadUsers()
        ' Set up the input boxes
        comboUserType.DropDownStyle = ComboBoxStyle.DropDownList
        comboUserType.Items.AddRange({"Admin", "User"})
        ' Populate the list box with the users
        For i = 0 To userMaxIndex - 1
            lstUsers.Items.Add(userDataArray(i).Id)
        Next
        ' Disable the input boxes
        chkUpdate.Checked = False
        txtId.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        comboUserType.Enabled = False
    End Sub

    Private Sub lstUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged
        ' If the user has selected a user, update the input boxes
        If lstUsers.SelectedIndex = -1 Then
            Return
        End If
        Dim tempIndex As Integer = -1
        For i = 0 To userMaxIndex - 1
            If userDataArray(i).Id = lstUsers.SelectedItem Then
                tempIndex = i
            End If
        Next
        If tempIndex <> -1 Then
            index = tempIndex
        Else
            MsgBox("Error selecting item.")
            Return
        End If
        UpdateUserBoxes()
    End Sub

    Private Sub chkUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles chkUpdate.CheckedChanged
        ' Enable or disable the input boxes
        txtUsername.Enabled = chkUpdate.Checked
        txtPassword.Enabled = chkUpdate.Checked
        comboUserType.Enabled = chkUpdate.Checked
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Check if all fields are filled in
        If Not MassPresenceCheck({txtUsername.Text, txtPassword.Text}) And comboUserType.SelectedIndex <> -1 Then
            MsgBox("Please fill in all fields")
            Return
        End If
        ' Check if the password field is over or equal to 7 characters
        If Not MinimumLengthCheck(txtPassword.Text, 7) And Not MaximumLengthCheck(txtPassword.Text, 16) Then
            MsgBox("Password does not meet password requirements")
            Return
        End If
        ' Update the user data
        UpdateUserArray()
        ' if the user is new, add it to the list box and increment the id
        If newUser Then
            IncrementId(IdFile, userDataArray, index)
            userMaxIndex += 1
            newUser = False
            lstUsers.Items.Add(userDataArray(index).Id)
        End If
        ' Disable the input boxes
        chkUpdate.Checked = False
        ' Save the data to the files
        WriteUsers()
    End Sub

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        ' Generate a new id
        Dim newId As Integer = GetNewId(IdFile)
        ' Update the input boxes
        txtId.Text = newId
        txtUsername.Text = ""
        txtPassword.Text = ""
        comboUserType.SelectedIndex = -1
        ' Set the index to the end of the array
        index = userMaxIndex
        newUser = True
        ' Enable the input boxes
        chkUpdate.Checked = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' If the user is new, just remove it from the list box
        If newUser Then
            index -= 1
            newUser = False
            UpdateUserBoxes()
            Return
        End If
        ' If the user is not new, ask the user if they are sure they want to delete it
        Dim result = MsgBox("Are you sure you want to delete this user?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            ' Remove the user from the list box
            Dim item = lstUsers.SelectedItem
            Dim itemindex = lstUsers.SelectedIndex
            lstUsers.SelectedIndex -= 1
            lstUsers.Items.Remove(item)
            ' Shift the array down
            For i = itemindex To userMaxIndex - 1
                userDataArray(i) = userDataArray(i + 1)
            Next
            userMaxIndex -= 1
            WriteUsers()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Return to the main menu
        Me.Hide()
        AdminMenu.Show()
    End Sub

    Sub UpdateUserBoxes()
        ' Update the input boxes with the user data
        txtId.Text = userDataArray(index).Id
        txtUsername.Text = userDataArray(index).Username
        txtPassword.Text = userDataArray(index).Password
        comboUserType.SelectedIndex = comboUserType.Items.IndexOf(userDataArray(index).UserType)
    End Sub

    Sub UpdateUserArray()
        ' Update the user data array
        userDataArray(index).Id = txtId.Text
        userDataArray(index).Username = txtUsername.Text
        userDataArray(index).Password = txtPassword.Text
        userDataArray(index).UserType = comboUserType.SelectedItem
    End Sub
End Class