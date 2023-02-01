Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.BookingFileHandler
Imports MusicBookingSystem.LessonFileHandler
Public Class FileDebugger
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        lstOutput.Items.Clear()
        For i = 0 To bookingMaxIndex - 1
            lstOutput.Items.Add($"{bookingDataArray(i).Id} {bookingDataArray(i).Username} {bookingDataArray(i).Roomname} {bookingDataArray(i).Period} {bookingDataArray(i).Day.ToShortDateString()}")
        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLesson.Click
        lstOutput.Items.Clear()
        For i = 0 To lessonMaxIndex - 1
            lstOutput.Items.Add($"{lessonDataArray(i).Id} {lessonDataArray(i).Subject} {lessonDataArray(i).Teacher} {lessonDataArray(i).Period} {lessonDataArray(i).Day.ToShortDateString()}")
        Next
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim f1 = New MainMenu
        f1.Show()
    End Sub

    Function searchBooking(value As String)
        Return bookingDataArray.FirstOrDefault(Function(x) x.Id = value)
    End Function

    Function searchLesson(value As String)
        Return lessonDataArray.FirstOrDefault(Function(x) x.Id = value)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearchBookings.Click
        Dim value As Integer = InputBox("Enter Booking Id")
        Dim booking As Booking = searchBooking(value)
        lstOutput.Items.Clear()
        lstOutput.Items.Add($"{booking.Id} {booking.Username} {booking.Roomname} {booking.Period} {booking.Day.ToShortDateString()}")
    End Sub

    Private Sub FileDebugger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadBookings()
        ReadLessons()
    End Sub

    Private Sub btnSearchLessons_Click(sender As Object, e As EventArgs) Handles btnSearchLessons.Click
        Dim value As Integer = InputBox("Enter Lessons Id")
        Dim booking As Lesson = searchLesson(value)
        lstOutput.Items.Clear()
        lstOutput.Items.Add($"{booking.Id} {booking.Subject} {booking.Teacher} {booking.Period} {booking.Day.ToShortDateString()}")
    End Sub
End Class
