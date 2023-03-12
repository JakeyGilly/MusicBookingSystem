Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.UserFileHandler
Imports MusicBookingSystem.RoomFileHandler
Imports MusicBookingSystem.SearchAlgorithms
Public Class BookingFileHandler
	Const fileName As String = "bookings.txt"
	Public Shared Sub ReadBookings()
		' Read the users and rooms before reading the bookings
		ReadUsers()
		ReadRooms()
		' Clear the array and reset the index
		Array.Clear(bookingDataArray, 0, bookingMaxIndex)
		bookingMaxIndex = 0
		' temp variables to store the user and room ids
		Dim tempUser, tempRoom As Integer
		' open the file
		FileOpen(1, fileName, OpenMode.Input)
		' read the data from the file into the array
		While Not EOF(1)
			Input(1, bookingDataArray(bookingMaxIndex).Id)
			Input(1, tempUser)
			bookingDataArray(bookingMaxIndex).User = SearchUserId(tempUser)
			Input(1, tempRoom)
			bookingDataArray(bookingMaxIndex).Room = SearchRoomId(tempRoom)
			Input(1, bookingDataArray(bookingMaxIndex).Period)
			Input(1, bookingDataArray(bookingMaxIndex).Day)
			' increment the max index
			bookingMaxIndex += 1
		End While
		' close the file
		FileClose(1)
	End Sub

	Public Shared Sub WriteBookings()
		' open the file
		FileOpen(1, fileName, OpenMode.Output)
		' write the data from the array to the file
		For i = 0 To bookingMaxIndex - 1
			WriteLine(1, bookingDataArray(i).Id, bookingDataArray(i).User.Id, bookingDataArray(i).Room.Id, bookingDataArray(i).Period, bookingDataArray(i).Day)
		Next
		' close the file
		FileClose(1)
	End Sub
End Class
