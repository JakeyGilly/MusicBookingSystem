Imports MusicBookingSystem.DataStructures
Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If username <> "Anonymous" Then
            lblWelcome.Text = lblWelcome.Text + username
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        amendLesson.Show()
    End Sub
End Class