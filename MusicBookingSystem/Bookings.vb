Imports MusicBookingSystem.BookingFileHandler
Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.RoomFileHandler
Imports MusicBookingSystem.UserFileHandler
Imports MusicBookingSystem.Validation
Imports MusicBookingSystem.Algorithms

Public Class Bookings
    Public index As Integer = 0
    Public IdFile As String = "bookingId.txt"
    Public newBooking As Boolean = False
    Private Sub Bookings_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Read all data from files
        ReadBookings()
        ReadUsers()
        ReadRooms()
        ' Set up the input boxes
        comboRoom.DropDownStyle = ComboBoxStyle.DropDownList
        For Each room In roomDataArray
            If room.Name <> Nothing Then
                comboRoom.Items.Add(room.Name)
            End If
        Next
        ' Populate the list box with the bookings
        Dim bookings As Booking()
        If currentlyLoggedInUser.UserType = "Admin" Then
            bookings = Array.FindAll(bookingDataArray, Function(x) x.User.Username <> Nothing)
        Else
            bookings = Array.FindAll(bookingDataArray, Function(x) x.User.Id = currentlyLoggedInUser.Id)
        End If
        For Each booking In bookings
            lstBookings.Items.Add(booking.Id)
        Next
        ' Disable the input boxes
        chkUpdate.Checked = False
        txtId.Enabled = False
        txtUser.Enabled = False
        comboRoom.Enabled = False
        numPeriod.Enabled = False
        datepick.Enabled = False
    End Sub

    Private Sub lstBookings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBookings.SelectedIndexChanged
        ' If the user has selected a booking, update the input boxes
        If lstBookings.SelectedIndex = -1 Then
            Exit Sub
        End If
        index = Array.FindIndex(bookingDataArray, Function(x) x.Id = lstBookings.SelectedItem)
        UpdateBookingBoxes()
    End Sub

    Private Sub chkUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles chkUpdate.CheckedChanged
        ' Enable or disable the input boxes
        comboRoom.Enabled = chkUpdate.Checked
        numPeriod.Enabled = chkUpdate.Checked
        datepick.Enabled = chkUpdate.Checked
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Check if all fields are filled in
        If Not MassPresenceCheck({txtId.Text, txtUser.Text, comboRoom.Text, numPeriod.Text, datepick.Text}) Then
            MsgBox("Please fill in all fields")
            Exit Sub
        End If
        ' Check if the room is available
        For i = 0 To bookingMaxIndex - 1
            If datepick.Value.ToLongDateString() = bookingDataArray(i).Day.ToLongDateString() And numPeriod.Value = bookingDataArray(i).Period Then
                MsgBox("Booking already at that time")
                Return
            End If
        Next
        For i = 0 To lessonMaxIndex - 1
            If (datepick.Value.DayOfWeek - DayOfWeek.Monday) = lessonDataArray(i).Day And numPeriod.Value = lessonDataArray(i).Period Then
                MsgBox("Lesson already at that time")
                Return
            End If
        Next
        ' Update the booking data
        UpdateBookingArray()
        ' if the booking is new, add it to the list box and increment the id
        If newBooking Then
            IncrementId(IdFile, bookingDataArray, index)
            bookingMaxIndex += 1
            newBooking = False
            lstBookings.Items.Add(bookingDataArray(index).Id)
        End If
        ' Disable the input boxes
        chkUpdate.Checked = False
        ' Save the data to the files
        WriteBookings()
    End Sub

    Private Sub btnNewBooking_Click(sender As Object, e As EventArgs) Handles btnNewBooking.Click
        ' Generate a new id
        Dim newId As Integer = GetNewId(IdFile)
        ' Update the input boxes
        txtId.Text = newId
        txtUser.Text = currentlyLoggedInUser.Username
        comboRoom.SelectedIndex = 0
        numPeriod.Value = 0
        datepick.Text = Date.Now
        ' Set the index to the end of the array
        index = bookingMaxIndex
        newBooking = True
        ' Enable the input boxes
        chkUpdate.Checked = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' If the booking is new, just remove it from the list box
        If newBooking Then
            index -= 1
            newBooking = False
            UpdateBookingBoxes()
            Exit Sub
        End If
        ' If the booking is not new, ask the user if they are sure they want to delete it
        Dim result = MsgBox("Are you sure you want to delete this booking?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            ' Remove the booking from the list box
            Dim item = lstBookings.SelectedItem
            Dim itemindex = lstBookings.SelectedIndex
            lstBookings.SelectedIndex -= 1
            lstBookings.Items.Remove(item)
            ' Shift the array down
            For i = itemindex To bookingMaxIndex - 1
                bookingDataArray(i) = bookingDataArray(i + 1)
            Next
            bookingMaxIndex -= 1
            WriteBookings()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Return to the main menu
        Me.Hide()
        If (currentlyLoggedInUser.UserType = "Admin") Then
            AdminMenu.Show()
        Else
            UserMenu.Show()
        End If
    End Sub

    Sub UpdateBookingBoxes()
        ' Update the input boxes with the booking data
        txtId.Text = bookingDataArray(index).Id
        txtUser.Text = bookingDataArray(index).User.Username
        comboRoom.SelectedIndex = comboRoom.Items.IndexOf(bookingDataArray(index).Room.Name)
        numPeriod.Value = bookingDataArray(index).Period
        datepick.Text = bookingDataArray(index).Day
    End Sub

    Sub UpdateBookingArray()
        ' Update the booking data array
        bookingDataArray(index).Id = txtId.Text
        bookingDataArray(index).User = userDataArray.First(Function(x) x.Username = txtUser.Text)
        bookingDataArray(index).Room = roomDataArray(comboRoom.SelectedIndex)
        bookingDataArray(index).Period = numPeriod.Value
        bookingDataArray(index).Day = datepick.Text
    End Sub
End Class