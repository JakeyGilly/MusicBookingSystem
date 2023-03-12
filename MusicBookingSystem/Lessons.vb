Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.LessonFileHandler
Imports MusicBookingSystem.Validation
Imports MusicBookingSystem.Algorithms

Public Class Lessons
    Public index As Integer = 0
    Public IdFile As String = "lessonId.txt"
    Public newLesson As Boolean = False
    Private Sub Lessons_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Read all data from files
        ReadLessons()
        ' Set up the input boxes
        comboSubject.DropDownStyle = ComboBoxStyle.DropDownList
        comboTeacher.DropDownStyle = ComboBoxStyle.DropDownList
        comboDay.DropDownStyle = ComboBoxStyle.DropDownList
        comboSubject.Items.AddRange({"Music Tech DMP", "Music"})
        comboTeacher.Items.AddRange({"Simon Lee", "James Quested"})
        comboDay.Items.AddRange({"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        ' Populate the list box with the lessons
        For i = 0 To lessonMaxIndex - 1
            lstLessons.Items.Add(lessonDataArray(i).Id)
        Next
        ' Disable the input boxes
        chkUpdate.Checked = False
        txtId.Enabled = False
        comboSubject.Enabled = False
        comboTeacher.Enabled = False
        numPeriod.Enabled = False
        comboDay.Enabled = False
    End Sub

    Private Sub lstLessons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLessons.SelectedIndexChanged
        ' If the user has selected a lesson, update the input boxes
        If lstLessons.SelectedIndex = -1 Then
            Return
        End If
        Dim tempIndex As Integer = -1
        For i = 0 To lessonMaxIndex - 1
            If lessonDataArray(i).Id = lstLessons.SelectedItem Then
                tempIndex = i
            End If
        Next
        If tempIndex <> -1 Then
            index = tempIndex
        Else
            MsgBox("Error selecting item.")
            Return
        End If
        UpdateLessonBoxes()
    End Sub

    Private Sub chkUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles chkUpdate.CheckedChanged
        ' Enable or disable the input boxes
        comboSubject.Enabled = chkUpdate.Checked
        comboTeacher.Enabled = chkUpdate.Checked
        numPeriod.Enabled = chkUpdate.Checked
        comboDay.Enabled = chkUpdate.Checked
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Check if all fields are filled in
        If Not PresenceCheck(numPeriod.Text) And comboSubject.SelectedIndex <> -1 And comboTeacher.SelectedIndex <> -1 And comboDay.SelectedIndex <> -1 And RangeCheck(numPeriod.Value, 0, 4) Then
            MsgBox("Please fill in all fields")
            Return
        End If
        ' Update the lesson data
        UpdateLessonArray()
        ' if the lesson is new, add it to the list box and increment the id
        If newLesson Then
            IncrementId(IdFile, lessonDataArray, index)
            lessonMaxIndex += 1
            newLesson = False
            lstLessons.Items.Add(lessonDataArray(index).Id)
        End If
        ' Disable the input boxes
        chkUpdate.Checked = False
        ' Save the data to the files
        WriteLessons()
    End Sub

    Private Sub btnNewLesson_Click(sender As Object, e As EventArgs) Handles btnNewLesson.Click
        ' Generate a new id
        Dim newId As Integer = GetNewId(IdFile)
        ' Update the input boxes
        txtId.Text = newId
        comboSubject.SelectedIndex = -1
        comboTeacher.SelectedIndex = -1
        numPeriod.Value = 0
        comboDay.SelectedIndex = -1
        ' Set the index to the end of the array
        index = lessonMaxIndex
        newLesson = True
        ' Enable the input boxes
        chkUpdate.Checked = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' If the lesson is new, just remove it from the list box
        If newLesson Then
            index -= 1
            newLesson = False
            UpdateLessonBoxes()
            Return
        End If
        ' If the lesson is not new, ask the user if they are sure they want to delete it
        Dim result = MsgBox("Are you sure you want to delete this lesson?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            ' Remove the lesson from the list box
            Dim item = lstLessons.SelectedItem
            Dim itemindex = lstLessons.SelectedIndex
            lstLessons.SelectedIndex -= 1
            lstLessons.Items.Remove(item)
            ' Shift the array down
            For i = itemindex To lessonMaxIndex - 1
                lessonDataArray(i) = lessonDataArray(i + 1)
            Next
            lessonMaxIndex -= 1
            WriteLessons()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Return to the main menu
        Me.Hide()
        AdminMenu.Show()
    End Sub

    Sub UpdateLessonBoxes()
        ' Update the input boxes with the lesson data
        txtId.Text = lessonDataArray(index).Id
        comboSubject.SelectedItem = lessonDataArray(index).Subject
        comboTeacher.SelectedItem = lessonDataArray(index).Teacher
        numPeriod.Value = lessonDataArray(index).Period
        comboDay.SelectedItem = comboDay.Items(lessonDataArray(index).Day)
    End Sub

    Sub UpdateLessonArray()
        ' Update the lesson data array
        lessonDataArray(index).Id = txtId.Text
        lessonDataArray(index).Subject = comboSubject.SelectedItem
        lessonDataArray(index).Teacher = comboTeacher.SelectedItem
        lessonDataArray(index).Period = numPeriod.Value
        lessonDataArray(index).Day = comboDay.SelectedIndex
    End Sub
End Class