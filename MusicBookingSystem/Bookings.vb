Imports MusicBookingSystem.BookingFileHandler
Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.RoomFileHandler
Imports MusicBookingSystem.UserFileHandler
Imports MusicBookingSystem.Validation
Imports MusicBookingSystem.Algorithms
Imports MusicBookingSystem.SearchAlgorithms

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
        For i = 0 To roomMaxIndex - 1
            comboRoom.Items.Add(roomDataArray(i).Name)
        Next
        ' Populate the list box with the bookings
        If currentlyLoggedInUser.UserType = "Admin" Then
            For i = 0 To bookingMaxIndex - 1
                lstBookings.Items.Add(bookingDataArray(i).Id)
            Next
        Else
            For i = 0 To bookingMaxIndex - 1
                If bookingDataArray(i).User.Id = currentlyLoggedInUser.Id Then
                    lstBookings.Items.Add(bookingDataArray(i).Id)
                End If
            Next
        End If
        ' Disable the input boxes
        chkUpdate.Checked = False
        txtId.Enabled = False
        txtUser.Enabled = False
        comboRoom.Enabled = False
        numPeriod.Enabled = False
        datePick.Enabled = False
    End Sub

    Private Sub lstBookings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBookings.SelectedIndexChanged
        ' If the user has selected a booking, update the input boxes
        If lstBookings.SelectedIndex = -1 Then
            Return
        End If
        Dim tempIndex As Integer = -1
        For i = 0 To bookingMaxIndex - 1
            If bookingDataArray(i).Id = lstBookings.SelectedItem Then
                tempIndex = i
            End If
        Next
        If tempIndex <> -1 Then
            index = tempIndex
        Else
            MsgBox("Error selecting item.")
            Return
        End If
        UpdateBookingBoxes()
    End Sub

    Private Sub chkUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles chkUpdate.CheckedChanged
        ' Enable or disable the input boxes
        comboRoom.Enabled = chkUpdate.Checked
        numPeriod.Enabled = chkUpdate.Checked
        datePick.Enabled = chkUpdate.Checked
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Check if all fields are filled in
        If Not MassPresenceCheck({txtId.Text, txtUser.Text, comboRoom.Text, numPeriod.Text, datePick.Text}) And RangeCheck(numPeriod.Value, 0, 4) Then
            MsgBox("Please fill in all fields")
            Return
        End If
        ' Check if the room is available
        For i = 0 To bookingMaxIndex - 1
            If datePick.Value.ToLongDateString() = bookingDataArray(i).Day.ToLongDateString() And numPeriod.Value = bookingDataArray(i).Period Then
                MsgBox("Booking already at that time")
                Return
            End If
        Next
        For i = 0 To lessonMaxIndex - 1
            If (datePick.Value.DayOfWeek - DayOfWeek.Monday) = lessonDataArray(i).Day And numPeriod.Value = lessonDataArray(i).Period Then
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
        datePick.Text = Date.Now
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
            Return
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
        datePick.Text = bookingDataArray(index).Day
    End Sub

    Sub UpdateBookingArray()
        ' Update the booking data array
        bookingDataArray(index).Id = txtId.Text
        bookingDataArray(index).User = SearchUserUsername(txtUser.Text)
        bookingDataArray(index).Room = roomDataArray(comboRoom.SelectedIndex)
        bookingDataArray(index).Period = numPeriod.Value
        bookingDataArray(index).Day = datePick.Text
    End Sub
End Class