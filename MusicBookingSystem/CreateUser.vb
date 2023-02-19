Imports MusicBookingSystem.UserFileHandler
Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.Validation
Imports MusicBookingSystem.Algorithms
Public Class CreateUser
    Public IdFile As String = "userId.txt"
    Public index As Integer = 0
    Private Sub CreateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Read all data from files
        ReadUsers()
        ' Set up the input boxes
        comboUserType.DropDownStyle = ComboBoxStyle.DropDownList
        comboUserType.Items.AddRange({"Admin", "User"})
        ' Disable the input boxes
        txtId.Enabled = False
        ' Set the id
        index = userMaxIndex
        txtId.Text = GetNewId(IdFile)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Check if all fields are filled in
        If Not MassPresenceCheck({txtUsername.Text, txtPassword.Text}) And comboUserType.SelectedIndex <> -1 Then
            MsgBox("Please fill in all fields")
            Exit Sub
        End If
        ' Update the user data
        userDataArray(index).Id = txtId.Text
        userDataArray(index).Username = txtUsername.Text
        userDataArray(index).Password = txtPassword.Text
        userDataArray(index).UserType = comboUserType.SelectedItem
        ' increment the id
        IncrementId(IdFile, userDataArray, index)
        userMaxIndex += 1
        ' Save the data to the files
        WriteUsers()
        MsgBox("User created")
        ' Send the user back to the login menu
        Me.Hide()
        LoginMenu.Show()
    End Sub
End Class