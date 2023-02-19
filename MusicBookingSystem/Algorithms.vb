Imports MusicBookingSystem.DataStructures
Public Class Algorithms
    Public Shared Function GetNewId(idFile As String)
        ' opens id file and reads the id from it
        FileOpen(1, idFile, OpenMode.Input)
        Dim Id As Integer
        Input(1, Id)
        FileClose(1)
        Return Id
    End Function

    Public Shared Sub IncrementId(idFile As String, dataArray As Array, index As Integer)
        ' opens id file and writes the dataArray(index).Id + 1
        FileOpen(1, idFile, OpenMode.Output)
        Write(1, dataArray(index).Id + 1)
        FileClose(1)
    End Sub
End Class
