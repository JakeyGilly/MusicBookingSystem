Imports MusicBookingSystem.DataStructures
Public Class RoomFileHandler
	Const fileName As String = "rooms.txt"
	Public Shared Sub ReadRooms()
		' Clear the array and reset the index
		Array.Clear(roomDataArray, 0, roomMaxIndex)
		roomMaxIndex = 0
		' open the file
		FileOpen(1, fileName, OpenMode.Input)
		' read the data from the file into the array
		While Not EOF(1)
			Input(1, roomDataArray(roomMaxIndex).Id)
			Input(1, roomDataArray(roomMaxIndex).Name)
			' increment the max index
			roomMaxIndex += 1
		End While
		' close the file
		FileClose(1)
	End Sub

	Public Shared Sub WriteRooms()
		' open the file
		FileOpen(1, fileName, OpenMode.Output)
		' write the data from the array to the file
		For i = 0 To roomMaxIndex - 1
			WriteLine(1, roomDataArray(i).Id, roomDataArray(i).Name)
		Next
		' close the file
		FileClose(1)
	End Sub
End Class
