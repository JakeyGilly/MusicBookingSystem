Imports MusicBookingSystem.DataStructures
Public Class SearchAlgorithms
    ' searches for a user's username, Returns index if found
    Public Shared Function SearchUserUsername(Username As String)
        For Each user In userDataArray
            If user.Username = Username Then
                Return user
            End If
        Next
        Return Nothing
    End Function
    ' searches for a user's Id, Returns index if found
    Public Shared Function SearchUserId(Id As Integer)
        For Each user In userDataArray
            If user.Id = Id Then
                Return user
            End If
        Next
        Return Nothing
    End Function
    ' searches for a rooms's Id, Returns index if found
    Public Shared Function SearchRoomId(Id As Integer)
        For Each room In roomDataArray
            If room.Id = Id Then
                Return room
            End If
        Next
        Return Nothing
    End Function
End Class
