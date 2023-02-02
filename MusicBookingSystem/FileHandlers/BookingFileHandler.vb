Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.UserFileHandler
Imports MusicBookingSystem.RoomFileHandler
Public Class BookingFileHandler
	Const fileName As String = "bookings.txt"
	Public Shared Sub ReadBookings()
		ReadUsers()
		ReadRooms()
		Array.Clear(bookingDataArray, 0, bookingMaxIndex)
		bookingMaxIndex = 0
		Dim tempUser, tempRoom As Integer
		FileOpen(1, fileName, OpenMode.Input)
		While Not EOF(1)
			Input(1, bookingDataArray(bookingMaxIndex).Id)
			Input(1, tempUser)
			bookingDataArray(bookingMaxIndex).User = userDataArray.First(Function(x) x.Id = tempUser)
			Input(1, tempRoom)
			bookingDataArray(bookingMaxIndex).Room = roomDataArray.First(Function(x) x.Id = tempRoom)
			Input(1, bookingDataArray(bookingMaxIndex).Period)
			Input(1, bookingDataArray(bookingMaxIndex).Day)
			bookingMaxIndex += 1
		End While
		FileClose(1)
	End Sub

	Public Shared Sub WriteBookings()
		FileOpen(1, fileName, OpenMode.Output)
		For i = 0 To bookingMaxIndex - 1
			WriteLine(1, bookingDataArray(i).Id, bookingDataArray(i).User, bookingDataArray(i).Room, bookingDataArray(i).Period, bookingDataArray(i).Day)
		Next
		FileClose(1)
	End Sub
End Class
