Imports MusicBookingSystem.DataStructures
Public Class LessonFileHandler
	Const fileName As String = "lessons.txt"
	Public Shared Sub ReadLessons()
		' Clear the array and reset the index
		Array.Clear(lessonDataArray, 0, lessonMaxIndex)
		lessonMaxIndex = 0
		' open the file
		FileOpen(1, fileName, OpenMode.Input)
		' read the data from the file into the array
		While Not EOF(1)
			Input(1, lessonDataArray(lessonMaxIndex).Id)
			Input(1, lessonDataArray(lessonMaxIndex).Subject)
			Input(1, lessonDataArray(lessonMaxIndex).Teacher)
			Input(1, lessonDataArray(lessonMaxIndex).Period)
			Input(1, lessonDataArray(lessonMaxIndex).Day)
			' increment the max index
			lessonMaxIndex += 1
		End While
		' close the file
		FileClose(1)
	End Sub

	Public Shared Sub WriteLessons()
		' open the file
		FileOpen(1, fileName, OpenMode.Output)
		' write the data from the array to the file
		For i = 0 To lessonMaxIndex - 1
			WriteLine(1, lessonDataArray(i).Id, lessonDataArray(i).Subject, lessonDataArray(i).Teacher, lessonDataArray(i).Period, lessonDataArray(i).Day)
		Next
		' close the file
		FileClose(1)
	End Sub
End Class
