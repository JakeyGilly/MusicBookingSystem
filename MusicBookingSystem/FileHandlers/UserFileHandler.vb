Imports MusicBookingSystem.DataStructures
Public Class UserFileHandler
	Const fileName As String = "users.txt"
	Public Shared Sub ReadUsers()
		' Clear the array and reset the index
		Array.Clear(userDataArray, 0, userMaxIndex)
		userMaxIndex = 0
		' open the file
		FileOpen(1, fileName, OpenMode.Input)
		' read the data from the file into the array
		While Not EOF(1)
			Input(1, userDataArray(userMaxIndex).Id)
			Input(1, userDataArray(userMaxIndex).Username)
			Input(1, userDataArray(userMaxIndex).Password)
			Input(1, userDataArray(userMaxIndex).UserType)
			' increment the max index
			userMaxIndex += 1
		End While
		' close the file
		FileClose(1)
	End Sub

	Public Shared Sub WriteUsers()
		' open the file
		FileOpen(1, fileName, OpenMode.Output)
		' write the data from the array to the file
		For i = 0 To userMaxIndex - 1
			WriteLine(1, userDataArray(i).Id, userDataArray(i).Username, userDataArray(i).Password, userDataArray(i).UserType)
		Next
		' close the file
		FileClose(1)
	End Sub
End Class
