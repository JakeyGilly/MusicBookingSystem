Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.UserFileHandler
Public Class LoginMenu
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim user = userDataArray.FirstOrDefault(Function(u) u.Username = txtUsername.Text)
        If (user.Password = txtPassword.Text) Then
            currentlyLoggedInUser = user
        Else
            MsgBox("Incorrect username or password")
            Exit Sub
        End If
        Me.Hide()
        Dim f1 = New MainMenu()
        f1.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim f1 = New MainMenu()
        f1.Show()
    End Sub

    Private Sub LoginMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadUsers()
    End Sub
End Class