Imports MusicBookingSystem.DataStructures
Public Class RoomFileHandler
	Const fileName As String = "rooms.txt"
	Public Shared Sub ReadRooms()
		Array.Clear(roomDataArray, 0, roomMaxIndex)
		roomMaxIndex = 0
		FileOpen(1, fileName, OpenMode.Input)
		While Not EOF(1)
			Input(1, roomDataArray(roomMaxIndex).Id)
			Input(1, roomDataArray(roomMaxIndex).Name)
			roomMaxIndex += 1
		End While
		FileClose(1)
	End Sub

	Public Shared Sub WriteRooms()
		FileOpen(1, fileName, OpenMode.Output)
		For i = 0 To roomMaxIndex - 1
			WriteLine(1, roomDataArray(i).Id, roomDataArray(i).Name)
		Next
		FileClose(1)
	End Sub
End Class
