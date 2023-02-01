Public Class DataStructures

    Public Shared username As String = "Anonymous"

    Public Shared bookingDataArray(999) As Booking
    Public Shared bookingMaxIndex As Integer = 0
    Structure Booking
        Public Id As Integer
        Public Username As String
        Public Roomname As String
        Public Period As Integer
        Public Day As Date
    End Structure

    Public Shared lessonDataArray(999) As Lesson
    Public Shared lessonMaxIndex As Integer = 0
    Structure Lesson
        Public Id As Integer
        Public Subject As String
        Public Teacher As String
        Public Period As Integer
        Public Day As Date
    End Structure
End Class
