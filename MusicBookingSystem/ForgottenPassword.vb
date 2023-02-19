Imports MusicBookingSystem.UserFileHandler
Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.Validation
Public Class ForgottenPassword
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Check if the username exists
        Dim user = userDataArray.FirstOrDefault(Function(u) u.Username = txtUsername.Text)
        If user.Username = "" Then
            ' If the username does not exist, display an error message
            MsgBox("Username not found")
        Else
            ' If the username exists, check if the passwords match
            If EqualsCheck(txtPassword.Text, txtConfirm.Text) Then
                ' If the passwords match, change the password
                userDataArray(Array.FindIndex(userDataArray, Function(x) x.Id = user.Id)).Password = txtPassword.Text
                ' Save the data to the files
                WriteUsers()
                MsgBox("Password changed")
                ' Send the user back to the login menu
                Me.Hide()
                LoginMenu.Show()
            Else
                ' If the passwords do not match, display an error message
                MsgBox("Passwords do not match")
            End If
        End If
    End Sub

    Private Sub ForgottenPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Read all data from files
        ReadUsers()
    End Sub
End Class