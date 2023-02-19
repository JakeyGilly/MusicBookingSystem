Imports MusicBookingSystem.UserFileHandler
Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.Validation
Public Class ForgottenPassword
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim user = userDataArray.FirstOrDefault(Function(u) u.Username = txtUsername.Text)
        If user.Username = "" Then
            MsgBox("Username not found")
        Else
            If EqualsCheck(txtPassword.Text, txtConfirm.Text) Then
                userDataArray(Array.FindIndex(userDataArray, Function(x) x.Id = user.Id)).Password = txtPassword.Text
                WriteUsers()
                MsgBox("Password changed")
                Me.Hide()
                LoginMenu.Show()
            Else
                MsgBox("Passwords do not match")
            End If
        End If
    End Sub

    Private Sub ForgottenPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadUsers()
    End Sub
End Class