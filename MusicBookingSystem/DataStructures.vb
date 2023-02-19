Public Class DataStructures
    ' Array for storing room data and the maximum index
    Public Shared bookingDataArray(999) As Booking
    Public Shared bookingMaxIndex As Integer = 0
    ' Structure for storing booking data
    Structure Booking
        Public Id As Integer
        Public User As User
        Public Room As Room
        Public Period As Integer
        Public Day As Date
    End Structure
    ' Array for storing lesson data and the maximum index
    Public Shared lessonDataArray(999) As Lesson
    Public Shared lessonMaxIndex As Integer = 0
    ' Structure for storing lesson data
    Structure Lesson
        Public Id As Integer
        Public Subject As String
        Public Teacher As String
        Public Period As Integer
        Public Day As Integer
    End Structure
    ' Array for storing user data and the maximum index
    Public Shared userDataArray(999) As User
    Public Shared userMaxIndex As Integer = 0
    ' Variable for storing the currently logged in user
    Public Shared currentlyLoggedInUser As User
    ' Structure for storing user data
    Structure User
        Public Id As Integer
        Public Username As String
        Public Password As String
        Public UserType As String
    End Structure
    ' Array for storing room data and the maximum index
    Public Shared roomDataArray(999) As Room
    Public Shared roomMaxIndex As Integer = 0
    ' Structure for storing room data
    Structure Room
        Public Id As Integer
        Public Name As String
    End Structure
End Class
