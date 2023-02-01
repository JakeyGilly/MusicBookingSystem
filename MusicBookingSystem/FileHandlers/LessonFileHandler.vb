Imports MusicBookingSystem.DataStructures
Public Class LessonFileHandler
	Const fileName As String = "lessons.txt"
	Public Shared Sub ReadLessons()
		Array.Clear(lessonDataArray, 0, lessonMaxIndex)
		lessonMaxIndex = 0
		FileOpen(1, fileName, OpenMode.Input)
		While Not EOF(1)
			Input(1, lessonDataArray(lessonMaxIndex).Id)
			Input(1, lessonDataArray(lessonMaxIndex).Subject)
			Input(1, lessonDataArray(lessonMaxIndex).Teacher)
			Input(1, lessonDataArray(lessonMaxIndex).Period)
			Input(1, lessonDataArray(lessonMaxIndex).Day)
			lessonMaxIndex += 1
		End While
		FileClose(1)
	End Sub

	Public Shared Sub WriteLessons()
		FileOpen(1, fileName, OpenMode.Output)
		For i = 0 To lessonMaxIndex - 1
			WriteLine(1, lessonDataArray(i).Id, lessonDataArray(i).Subject, lessonDataArray(i).Teacher, lessonDataArray(i).Period, lessonDataArray(i).Day)
		Next
		FileClose(1)
	End Sub
End Class
