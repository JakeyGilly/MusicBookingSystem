Public Class DataStructures
    Public Shared bookingDataArray(999) As Booking
    Public Shared bookingMaxIndex As Integer = 0
    Structure Booking
        Public Id As Integer
        Public User As User
        Public Room As Room
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
        Public Day As String
    End Structure

    Public Shared userDataArray(999) As User
    Public Shared userMaxIndex As Integer = 0
    Public Shared anonUser As User = New User() With {
        .Id = 0,
        .Username = "Anonymous",
        .Password = "password",
        .UserType = "User"
        }
    Public Shared currentlyLoggedInUser As User = anonUser
    Structure User
        Public Id As Integer
        Public Username As String
        Public Password As String
        Public UserType As String
    End Structure

    Public Shared roomDataArray(999) As Room
    Public Shared roomMaxIndex As Integer = 0
    Structure Room
        Public Id As Integer
        Public Name As String
    End Structure
End Class
