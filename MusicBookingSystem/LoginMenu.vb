Imports MusicBookingSystem.DataStructures
Public Class LoginMenu
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        username = txtUsername.Text
        Me.Hide()
        Dim f1 = New MainMenu()
        f1.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim f1 = New MainMenu()
        f1.Show()
    End Sub
End Class