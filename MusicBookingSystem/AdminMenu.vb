Imports MusicBookingSystem.DataStructures
Public Class AdminMenu
    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Set the welcome message
        lblWelcome.Text = lblWelcome.Text + currentlyLoggedInUser.Username
    End Sub
    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        ' Send the user to the booking menu
        Me.Hide()
        Bookings.Show()
    End Sub

    Private Sub btnTimetable_Click(sender As Object, e As EventArgs) Handles btnTimetable.Click
        ' Send the user to the timetable menu
        Me.Hide()
        Timetable.Show()
    End Sub

    Private Sub btnLesson_Click(sender As Object, e As EventArgs) Handles btnLesson.Click
        ' Send the user to the lesson menu
        Me.Hide()
        Lessons.Show()
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        ' Send the user to the room menu
        Me.Hide()
        Rooms.Show()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        ' Send the user to the user menu
        Me.Hide()
        Users.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Log the user out
        currentlyLoggedInUser = Nothing
        ' Send the user back to the login menu
        Me.Hide()
        LoginMenu.Show()
    End Sub
End Class