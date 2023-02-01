Imports MusicBookingSystem.LessonFileHandler
Imports MusicBookingSystem.DataStructures
Public Class amendLesson
    Public index As Integer = 0
    Public IdFile As String = "lessonId.txt"
    Private Sub amendBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadLessons()
        comboSubject.Items.AddRange({"Music Tech DMP", "Music"})
        comboTeacher.Items.AddRange({"Simon Lee", "James Quested"})
        UpdateLessonBoxes()
    End Sub
    Private Sub btnNewBooking_Click(sender As Object, e As EventArgs) Handles btnNewLesson.Click
        Dim newId As Integer = getNewID()
        index = lessonMaxIndex
        txtId.Text = newId
        comboSubject.SelectedIndex = -1
        comboTeacher.SelectedIndex = -1
        txtPeriod.Text = ""
        datepick.Text = ""
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If index > 0 Then
            index -= 1
            UpdateLessonBoxes()
        Else
            MsgBox("cannot go to previous record")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If index < lessonMaxIndex - 1 Then
            index += 1
            UpdateLessonBoxes()
        Else
            MsgBox("cannot go to next record")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UpdateLessonArray()
        WriteLessons()
        If (index = lessonMaxIndex) Then
            IncrementId()
            lessonMaxIndex += 1
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim f1 = New MainMenu
        f1.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        For i = index To lessonMaxIndex
            lessonDataArray(i) = lessonDataArray(i + 1)
        Next
        WriteLessons()
        If (index = lessonMaxIndex) Then
            DecrementId()
            lessonMaxIndex -= 1
        End If
        index -= 1
        UpdateLessonBoxes()
    End Sub

    Function getNewId()
        FileOpen(1, IdFile, OpenMode.Input)
        Dim Id As Integer
        Input(1, Id)
        FileClose(1)
        Return Id + 1
    End Function

    Sub IncrementId()
        FileOpen(1, IdFile, OpenMode.Output)
        Write(1, lessonDataArray(index).Id + 1)
        FileClose(1)
    End Sub

    Sub DecrementId()
        FileOpen(1, IdFile, OpenMode.Output)
        Write(1, lessonDataArray(index).Id - 1)
        FileClose(1)
    End Sub

    Sub UpdateLessonBoxes()
        txtId.Text = lessonDataArray(index).Id
        comboTeacher.SelectedIndex = comboTeacher.Items.IndexOf(lessonDataArray(index).Teacher)
        comboSubject.SelectedIndex = comboSubject.Items.IndexOf(lessonDataArray(index).Subject)
        txtPeriod.Text = lessonDataArray(index).Period
        datepick.Text = lessonDataArray(index).Day
    End Sub

    Sub UpdateLessonArray()
        lessonDataArray(index).Id = txtId.Text
        lessonDataArray(index).Teacher = comboTeacher.SelectedItem
        lessonDataArray(index).Subject = comboSubject.SelectedItem
        lessonDataArray(index).Period = txtPeriod.Text
        lessonDataArray(index).Day = datepick.Text
    End Sub
End Class