Imports MusicBookingSystem.DataStructures
Public Class UserFileHandler
	Const fileName As String = "users.txt"
	Public Shared Sub ReadUsers()
		Array.Clear(userDataArray, 0, userMaxIndex)
		userMaxIndex = 0
		FileOpen(1, fileName, OpenMode.Input)
		While Not EOF(1)
			Input(1, userDataArray(userMaxIndex).Id)
			Input(1, userDataArray(userMaxIndex).Username)
			Input(1, userDataArray(userMaxIndex).Password)
			Input(1, userDataArray(userMaxIndex).UserType)
			userMaxIndex += 1
		End While
		FileClose(1)
	End Sub

	Public Shared Sub WriteUsers()
		FileOpen(1, fileName, OpenMode.Output)
		For i = 0 To userMaxIndex - 1
			WriteLine(1, userDataArray(i).Id, userDataArray(i).Username, userDataArray(i).Password, userDataArray(i).UserType)
		Next
		FileClose(1)
	End Sub
End Class
