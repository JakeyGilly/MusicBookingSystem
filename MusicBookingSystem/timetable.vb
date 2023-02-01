Imports MusicBookingSystem.BookingFileHandler
Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.LessonFileHandler
Public Class timetable
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim f1 = New MainMenu
        f1.Show()
    End Sub

    Private Sub timetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadBookings()
        ReadLessons()
        DataGridView1.ColumnCount = 5
        DataGridView1.RowCount = 5
        comboRoom.Items.AddRange({"Practice Room 1", "Practice Room 2", "Practice Room 3", "Studio", "Drum Room", "Back Room"})
        comboRoom.SelectedIndex = 0
    End Sub

    Private Sub timetable_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ReadBookings()
        ReadLessons()
    End Sub

    Private Sub comboRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboRoom.SelectedIndexChanged
        Dim days() = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"}
        Dim times() = {"8:50-10:20", "10:40-12:10", "Lunch", "13:00-14:30", "14:40-16:10"}
        For i = 0 To 4
            DataGridView1.Columns(i).HeaderCell.Value = days(i)
            DataGridView1.Rows(i).HeaderCell.Value = times(i)
        Next
        For i = 0 To 4
            For j = 0 To 4
                DataGridView1.Rows(i).Cells(j).Value = ""
            Next
        Next
        Dim DayOfWeek = Date.Today.DayOfWeek
        For i = 0 To 4
            For j = 0 To 4
                Dim day = Today.AddDays(((DayOfWeek - DayOfWeek.Monday) * -1) + i)
                Dim Booking = bookingDataArray.FirstOrDefault(Function(x) x.Day = day And x.Period - 1 = j And x.Roomname = comboRoom.SelectedItem)
                Dim lesson = lessonDataArray.FirstOrDefault(Function(x) x.Day = day And x.Period - 1 = j)
                If Booking.Username <> "" Then
                    DataGridView1.Rows(j).Cells(i).Value = $"{Booking.Username} in {Booking.Roomname}"
                End If
                If lesson.Subject <> "" Then
                    DataGridView1.Rows(j).Cells(i).Value = $"{lesson.Subject} -  {lesson.Teacher}"
                End If
            Next
        Next
    End Sub
End Class