Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.BookingFileHandler
Imports MusicBookingSystem.LessonFileHandler
Imports MusicBookingSystem.UserFileHandler
Imports MusicBookingSystem.RoomFileHandler
Public Class FileDebugger
    Private Sub FileDebugger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadBookings()
        ReadLessons()
        ReadUsers()
        ReadRooms()
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        lstOutput.Items.Clear()
        For i = 0 To bookingMaxIndex - 1
            lstOutput.Items.Add($"{bookingDataArray(i).Id} {bookingDataArray(i).User} {bookingDataArray(i).Room} {bookingDataArray(i).Period} {bookingDataArray(i).Day.ToShortDateString()}")
        Next
    End Sub
    Private Sub btnLesson_Click(sender As Object, e As EventArgs) Handles btnLesson.Click
        lstOutput.Items.Clear()
        For i = 0 To lessonMaxIndex - 1
            lstOutput.Items.Add($"{lessonDataArray(i).Id} {lessonDataArray(i).Subject} {lessonDataArray(i).Teacher} {lessonDataArray(i).Period} {lessonDataArray(i).Day}")
        Next
    End Sub
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        lstOutput.Items.Clear()
        For i = 0 To userMaxIndex - 1
            lstOutput.Items.Add($"{userDataArray(i).Id} {userDataArray(i).Username} {userDataArray(i).Password} {userDataArray(i).UserType}")
        Next
    End Sub
    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        lstOutput.Items.Clear()
        For i = 0 To roomMaxIndex - 1
            lstOutput.Items.Add($"{roomDataArray(i).Id} {roomDataArray(i).Name}")
        Next
    End Sub

    Private Sub btnSearchBookings_Click(sender As Object, e As EventArgs) Handles btnSearchBookings.Click
        Dim value As Integer = InputBox("Enter Booking Id")
        Dim booking As Booking = bookingDataArray.FirstOrDefault(Function(x) x.Id = value)
        lstOutput.Items.Clear()
        lstOutput.Items.Add($"{booking.Id} {booking.User} {booking.Room} {booking.Period} {booking.Day.ToShortDateString()}")
    End Sub
    Private Sub btnSearchLessons_Click(sender As Object, e As EventArgs) Handles btnSearchLessons.Click
        Dim value As Integer = InputBox("Enter Lessons Id")
        Dim lesson As Lesson = lessonDataArray.FirstOrDefault(Function(x) x.Id = value)
        lstOutput.Items.Clear()
        lstOutput.Items.Add($"{lesson.Id} {lesson.Subject} {lesson.Teacher} {lesson.Period} {lesson.Day}")
    End Sub
    Private Sub btnSearchUser_Click(sender As Object, e As EventArgs) Handles btnSearchUser.Click
        Dim value As Integer = InputBox("Enter Users Id")
        Dim user As User = userDataArray.FirstOrDefault(Function(x) x.Id = value)
        lstOutput.Items.Clear()
        lstOutput.Items.Add($"{user.Id} {user.Username} {user.Password} {user.UserType}")
    End Sub
    Private Sub btnSearchRooms_Click(sender As Object, e As EventArgs) Handles btnSearchRooms.Click
        Dim value As Integer = InputBox("Enter Rooms Id")
        Dim room As Room = roomDataArray.FirstOrDefault(Function(x) x.Id = value)
        lstOutput.Items.Clear()
        lstOutput.Items.Add($"{room.Id} {room.Name}")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim f1 = New MainMenu
        f1.Show()
    End Sub
End Class
