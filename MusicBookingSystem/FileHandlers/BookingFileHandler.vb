Imports MusicBookingSystem.DataStructures
Public Class BookingFileHandler
	Const fileName As String = "bookings.txt"
	Public Shared Sub ReadBookings()
		Array.Clear(bookingDataArray, 0, bookingMaxIndex)
		bookingMaxIndex = 0
		FileOpen(1, fileName, OpenMode.Input)
		While Not EOF(1)
			Input(1, bookingDataArray(bookingMaxIndex).Id)
			Input(1, bookingDataArray(bookingMaxIndex).Username)
			Input(1, bookingDataArray(bookingMaxIndex).Roomname)
			Input(1, bookingDataArray(bookingMaxIndex).Period)
			Input(1, bookingDataArray(bookingMaxIndex).Day)
			bookingMaxIndex += 1
		End While
		FileClose(1)
	End Sub

	Public Shared Sub WriteBookings()
		FileOpen(1, fileName, OpenMode.Output)
		For i = 0 To bookingMaxIndex - 1
			WriteLine(1, bookingDataArray(i).Id, bookingDataArray(i).Username, bookingDataArray(i).Roomname, bookingDataArray(i).Period, bookingDataArray(i).Day)
		Next
		FileClose(1)
	End Sub
End Class
