Imports MusicBookingSystem.BookingFileHandler
Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.RoomFileHandler
Imports MusicBookingSystem.LessonFileHandler
Public Class Timetable
    ' Get the next five days from today
    Public StartOfWeek As Date = Date.Today.AddDays(-(Date.Today.DayOfWeek - DayOfWeek.Monday))
    Private Sub timetable_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Read all data from files
        ReadRooms()
        ReadBookings()
        ReadLessons()
        ' Populate the combo box with the room names
        For Each Room In roomDataArray
            If (Room.Name <> Nothing) Then
                comboRoom.Items.Add(Room.Name)
            End If
        Next
        ' Set up the timetable
        DataGridView1.ColumnCount = 5
        DataGridView1.RowCount = 5
        comboRoom.SelectedIndex = 0
        comboRoom.DropDownStyle = ComboBoxStyle.DropDownList
        DataGridView1.ReadOnly = True
        Dim times() = {"8:50-10:20", "10:40-12:10", "Lunch", "13:00-14:30", "14:40-16:10"}
        Dim days() = getNextFiveDays()
        ' Set the column and row headers
        For i = 0 To 4
            DataGridView1.Columns(i).HeaderCell.Value = days(i)
            DataGridView1.Rows(i).HeaderCell.Value = times(i)
        Next
        ' Populate the timetable
        UpdateTimetable(roomDataArray(comboRoom.Items.IndexOf(comboRoom.SelectedItem)))
    End Sub

    Private Sub comboRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboRoom.SelectedIndexChanged
        ' Populate the timetable
        UpdateTimetable(roomDataArray(comboRoom.Items.IndexOf(comboRoom.SelectedItem)))
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Move the timetable forward a week
        StartOfWeek = StartOfWeek.AddDays(7)
        Dim days() = getNextFiveDays()
        For i = 0 To 4
            DataGridView1.Columns(i).HeaderCell.Value = days(i)
        Next
        ' Populate the timetable
        UpdateTimetable(roomDataArray(comboRoom.Items.IndexOf(comboRoom.SelectedItem)))
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        ' Move the timetable back a week
        StartOfWeek = StartOfWeek.AddDays(-7)
        Dim days() = getNextFiveDays()
        For i = 0 To 4
            DataGridView1.Columns(i).HeaderCell.Value = days(i)
        Next
        ' Populate the timetable
        UpdateTimetable(roomDataArray(comboRoom.Items.IndexOf(comboRoom.SelectedItem)))
    End Sub

    Sub UpdateTimetable(Room As Room)
        ' Clear the timetable
        For i = 0 To 4
            For j = 0 To 4
                DataGridView1.Rows(i).Cells(j).Value = ""
            Next
        Next
        ' Populate the timetable  with bookings
        For Each Booking In bookingDataArray
            ' Check if the booking is in the current room and week
            If (Booking.Room.Id = Room.Id And Booking.Day >= StartOfWeek And Booking.Day <= StartOfWeek.AddDays(4)) Then
                ' Get the day and time of the booking
                Dim day As Integer = Booking.Day.DayOfWeek - DayOfWeek.Monday
                Dim time As Integer = Booking.Period
                ' Set the cell value
                DataGridView1.Rows(time).Cells(day).Value = $"Booked by {Booking.User.Username}"
            End If
        Next
        ' Populate the timetable with lessons
        For Each Lesson In lessonDataArray
            ' Check if the lesson exists
            If Lesson.Subject = Nothing Then Continue For
            ' Get the day and time of the lesson
            Dim day As Integer = Lesson.Day
            Dim time As Integer = Lesson.Period
            ' Set the cell value
            DataGridView1.Rows(time).Cells(day).Value = $"Lesson: {Lesson.Subject} {Lesson.Teacher}"
        Next
    End Sub

    Function getNextFiveDays() As String()
        ' Get the next five days
        Dim days(4) As String
        For i = 0 To 4
            days(i) = StartOfWeek.AddDays(i)
        Next
        Return days
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Go back to the user menu
        Me.Hide()
        UserMenu.Show()
    End Sub
End Class