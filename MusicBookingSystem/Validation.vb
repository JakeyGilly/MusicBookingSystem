Public Class Validation
    Function PresenceCheck(value As String)
        Return value <> ""
    End Function

    Function MinimumLengthCheck(value As String, minimumLength As Integer)
        Return value.Length >= minimumLength
    End Function

    Function MaximumLengthCheck(value As String, maximumLength As Integer)
        Return value.Length <= maximumLength
    End Function

    Function RangeCheck(value As Integer, min As Integer, max As Integer)
        Return value > min And value < max
    End Function

    Function FormatCheck(value As String, pattern As String)
        Return value Like pattern
    End Function
End Class
