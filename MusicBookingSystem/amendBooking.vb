Imports MusicBookingSystem.BookingFileHandler
Imports MusicBookingSystem.UserFileHandler
Imports MusicBookingSystem.RoomFileHandler
Imports MusicBookingSystem.DataStructures
Public Class amendBooking
    Public index As Integer = 0
    Public IdFile As String = "bookingId.txt"
    Private Sub amendBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        ReadBookings()
        ReadUsers()
        ReadRooms()
        For Each Room In roomDataArray
            If (Room.Name <> Nothing) Then
                comboRoom.Items.Add(Room.Name)
            End If
        Next
        If (currentlyLoggedInUser.UserType = "Admin") Then
            For Each User In userDataArray
                If (User.Username <> Nothing) Then
                    comboUser.Items.Add(User.Username)
                End If
            Next
        ElseIf (currentlyLoggedInUser.Username = anonUser.Username) Then
            comboUser.Items.Add("Not Logged In")
        Else
            comboUser.Items.Add(currentlyLoggedInUser.Username)
        End If
        UpdateBookingBoxes()
    End Sub

    Private Sub btnNewBooking_Click(sender As Object, e As EventArgs) Handles btnNewBooking.Click
        Dim newId As Integer = getNewID()
        index = bookingMaxIndex
        txtId.Text = newId
        comboUser.SelectedIndex = -1
        comboRoom.SelectedIndex = -1
        txtPeriod.Text = ""
        datepick.Text = ""
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If index > 0 Then
            index -= 1
            UpdateBookingBoxes()
        Else
            MsgBox("cannot go to previous record")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If index < bookingMaxIndex - 1 Then
            index += 1
            UpdateBookingBoxes()
        Else
            MsgBox("cannot go to next record")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UpdateBookingArray()
        WriteBookings()
        If (index = bookingMaxIndex) Then
            IncrementId()
            bookingMaxIndex += 1
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim f1 = New MainMenu
        f1.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        For i = index To lessonMaxIndex
            bookingDataArray(i) = bookingDataArray(i + 1)
        Next
        WriteBookings()
        If (index = lessonMaxIndex) Then
            DecrementId()
            bookingMaxIndex -= 1
        End If
        index -= 1
        UpdateBookingBoxes()
    End Sub

    Function getNewId()
        FileOpen(1, IdFile, OpenMode.Input)
        Dim Id As Integer
        Input(1, Id)
        FileClose(1)
        Return Id + 1
    End Function

    Sub IncrementId()
        FileOpen(1, IdFile, OpenMode.Output)
        Write(1, bookingDataArray(index).Id + 1)
        FileClose(1)
    End Sub

    Sub DecrementId()
        FileOpen(1, IdFile, OpenMode.Output)
        Write(1, bookingDataArray(index).Id - 1)
        FileClose(1)
    End Sub

    Sub UpdateBookingBoxes()
        txtId.Text = bookingDataArray(index).Id
        comboUser.SelectedIndex = comboUser.Items.IndexOf(bookingDataArray(index).User.Username)
        comboRoom.SelectedIndex = comboRoom.Items.IndexOf(bookingDataArray(index).Room.Name)
        txtPeriod.Text = bookingDataArray(index).Period
        datepick.Text = bookingDataArray(index).Day
    End Sub

    Sub UpdateBookingArray()
        bookingDataArray(index).Id = txtId.Text
        bookingDataArray(index).User = userDataArray(comboUser.SelectedIndex)
        bookingDataArray(index).Room = roomDataArray(comboRoom.SelectedIndex)
        bookingDataArray(index).Period = txtPeriod.Text
        bookingDataArray(index).Day = datepick.Text
    End Sub
End Class