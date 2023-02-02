Imports MusicBookingSystem.RoomFileHandler
Imports MusicBookingSystem.DataStructures
Public Class amendRoom
    Public index As Integer = 0
    Public IdFile As String = "roomId.txt"
    Private Sub amendBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadRooms()
        UpdateRoomBoxes()
    End Sub
    Private Sub btnNewRoom_Click(sender As Object, e As EventArgs) Handles btnNewRoom.Click
        Dim newId As Integer = getNewId()
        index = roomMaxIndex
        txtId.Text = newId
        txtName.Text = ""
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If index > 0 Then
            index -= 1
            UpdateRoomBoxes()
        Else
            MsgBox("cannot go to previous record")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If index < roomMaxIndex - 1 Then
            index += 1
            UpdateRoomBoxes()
        Else
            MsgBox("cannot go to next record")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UpdateRoomArray()
        WriteRooms()
        If (index = roomMaxIndex) Then
            IncrementId()
            roomMaxIndex += 1
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim f1 = New MainMenu
        f1.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For i = index To roomMaxIndex
            roomDataArray(i) = roomDataArray(i + 1)
        Next
        WriteRooms()
        If (index = roomMaxIndex) Then
            DecrementId()
            roomMaxIndex -= 1
        End If
        index -= 1
        UpdateRoomBoxes()
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
        Write(1, roomDataArray(index).Id + 1)
        FileClose(1)
    End Sub

    Sub DecrementId()
        FileOpen(1, IdFile, OpenMode.Output)
        Write(1, roomDataArray(index).Id - 1)
        FileClose(1)
    End Sub

    Sub UpdateRoomBoxes()
        txtId.Text = roomDataArray(index).Id
        txtName.Text = roomDataArray(index).Name
    End Sub

    Sub UpdateRoomArray()
        roomDataArray(index).Id = txtId.Text
        roomDataArray(index).Name = txtName.Text
    End Sub
End Class