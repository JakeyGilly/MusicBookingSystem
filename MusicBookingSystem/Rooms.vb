Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.RoomFileHandler
Imports MusicBookingSystem.Validation
Imports MusicBookingSystem.Algorithms

Public Class Rooms
    Public index As Integer = 0
    Public IdFile As String = "roomId.txt"
    Public newRoom As Boolean = False
    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Read all data from files
        ReadRooms()
        ' Populate the list box with the rooms
        Dim rooms = Array.FindAll(roomDataArray, Function(x) x.Name <> Nothing)
        For Each room In rooms
            lstRooms.Items.Add(room.Id)
        Next
        ' Disable the input boxes
        chkUpdate.Checked = False
        txtId.Enabled = False
        txtName.Enabled = False
    End Sub

    Private Sub lstRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRooms.SelectedIndexChanged
        ' If the user has selected a room, update the input boxes
        If lstRooms.SelectedIndex = -1 Then
            Exit Sub
        End If
        index = Array.FindIndex(roomDataArray, Function(x) x.Id = lstRooms.SelectedItem)
        UpdateRoomBoxes()
    End Sub

    Private Sub chkUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles chkUpdate.CheckedChanged
        ' Enable or disable the input boxes
        txtName.Enabled = chkUpdate.Checked
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Check if all fields are filled in
        If Not PresenceCheck(txtName.Text) Then
            MsgBox("Please fill in all fields")
            Exit Sub
        End If
        ' Update the room data
        UpdateRoomArray()
        ' if the room is new, add it to the list box and increment the id
        If newRoom Then
            IncrementId(IdFile, roomDataArray, index)
            roomMaxIndex += 1
            newRoom = False
            lstRooms.Items.Add(roomDataArray(index).Id)
        End If
        ' Disable the input boxes
        chkUpdate.Checked = False
        ' Save the data to the files
        WriteRooms()
    End Sub

    Private Sub btnNewRoom_Click(sender As Object, e As EventArgs) Handles btnNewRoom.Click
        ' Generate a new id
        Dim newId As Integer = GetNewId(IdFile)
        ' Update the input boxes
        txtId.Text = newId
        txtName.Text = ""
        ' Set the index to the end of the array
        index = roomMaxIndex
        newRoom = True
        ' Enable the input boxes
        chkUpdate.Checked = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' If the room is new, just remove it from the list box
        If newRoom Then
            index -= 1
            newRoom = False
            UpdateRoomBoxes()
            Exit Sub
        End If
        ' If the room is not new, ask the user if they are sure they want to delete it
        Dim result = MsgBox("Are you sure you want to delete this room?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            ' Remove the room from the list box
            Dim item = lstRooms.SelectedItem
            Dim itemindex = lstRooms.SelectedIndex
            lstRooms.SelectedIndex -= 1
            lstRooms.Items.Remove(item)
            ' Shift the array down
            For i = itemindex To roomMaxIndex - 1
                roomDataArray(i) = roomDataArray(i + 1)
            Next
            roomMaxIndex -= 1
            WriteRooms()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Return to the main menu
        Me.Hide()
        AdminMenu.Show()
    End Sub

    Sub UpdateRoomBoxes()
        ' Update the input boxes with the room data
        txtId.Text = roomDataArray(index).Id
        txtName.Text = roomDataArray(index).Name
    End Sub

    Sub UpdateRoomArray()
        ' Update the room data array
        roomDataArray(index).Id = txtId.Text
        roomDataArray(index).Name = txtName.Text
    End Sub
End Class