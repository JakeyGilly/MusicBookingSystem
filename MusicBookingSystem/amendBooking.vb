Imports MusicBookingSystem.BookingFileHandler
Imports MusicBookingSystem.DataStructures
Public Class amendBooking
    Public index As Integer = 0
    Public IdFile As String = "bookingId.txt"
    Private Sub amendBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadBookings()
        comboRoom.Items.AddRange({"Practice Room 1", "Practice Room 2", "Practice Room 3", "Studio", "Drum Room", "Back Room"})
        UpdateBookingBoxes()
    End Sub

    Private Sub btnNewBooking_Click(sender As Object, e As EventArgs) Handles btnNewBooking.Click
        Dim newId As Integer = getNewID()
        index = bookingMaxIndex
        txtId.Text = newId
        txtUser.Text = username
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
        txtUser.Text = bookingDataArray(index).Username
        comboRoom.SelectedIndex = comboRoom.Items.IndexOf(bookingDataArray(index).Roomname)
        txtPeriod.Text = bookingDataArray(index).Period
        datepick.Text = bookingDataArray(index).Day
    End Sub

    Sub UpdateBookingArray()
        bookingDataArray(index).Id = txtId.Text
        bookingDataArray(index).Username = txtUser.Text
        bookingDataArray(index).Roomname = comboRoom.SelectedItem
        bookingDataArray(index).Period = txtPeriod.Text
        bookingDataArray(index).Day = datepick.Text
    End Sub
End Class