Imports MusicBookingSystem.UserFileHandler
Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.Validation
Imports MusicBookingSystem.SearchAlgorithms
Public Class ForgottenPassword
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Check if the username exists
        Dim user = SearchUserUsername(txtUsername.Text)
        If user.Username = "" Then
            ' If the username does not exist, display an error message
            MsgBox("Username not found")
        Else
            ' If the username exists, check if the passwords match
            If EqualsCheck(txtPassword.Text, txtConfirm.Text) Then
                ' If the passwords match, change the password
                Dim tempIndex As Integer = -1
                For i = 0 To userMaxIndex - 1
                    If userDataArray(i).Id = user.Id Then
                        tempIndex = i
                    End If
                Next
                If tempIndex <> -1 Then
                    userDataArray(tempIndex).Password = txtPassword.Text
                Else
                    MsgBox("Error when resetting password")
                    Return
                End If
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Return to the login menu
        Me.Hide()
        LoginMenu.Show()
    End Sub
End Class