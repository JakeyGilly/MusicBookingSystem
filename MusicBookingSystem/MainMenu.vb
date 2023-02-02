Imports MusicBookingSystem.DataStructures
Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        If currentlyLoggedInUser.Username <> anonUser.Username Then
            lblWelcome.Text = lblWelcome.Text + currentlyLoggedInUser.Username
            btnLogin.Hide()
        Else
            lblWelcome.Hide()
        End If
    End Sub
    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        Me.Hide()
        FileDebugger.Show()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        LoginMenu.Show()
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        Me.Hide()
        amendBooking.Show()
    End Sub

    Private Sub btnTimetable_Click(sender As Object, e As EventArgs) Handles btnTimetable.Click
        Me.Hide()
        timetable.Show()
    End Sub

    Private Sub btnLesson_Click(sender As Object, e As EventArgs) Handles btnLesson.Click
        Me.Hide()
        amendLesson.Show()
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        Me.Hide()
        amendRoom.Show()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Me.Hide()
        amendUser.Show()
    End Sub
End Class