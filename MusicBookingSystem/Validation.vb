Public Class Validation
    ' The presence check function checks if a value is present
    Public Shared Function PresenceCheck(value As String)
        Return value <> ""
    End Function
    ' The mass presence check function checks if multiple values are present
    Public Shared Function MassPresenceCheck(values As String())
        For Each value In values
            If value = "" Then
                Return False
            End If
        Next
        Return True
    End Function
    ' The equality check function checks if two values are equal
    Public Shared Function EqualsCheck(value1 As String, value2 As String)
        Return value1 = value2
    End Function
    ' The minimum length check function checks if a value is at least a certain length
    Public Shared Function MinimumLengthCheck(value As String, minimumLength As Integer)
        Return value.Length >= minimumLength
    End Function
    ' The maximum length check function checks if a value is at most a certain length
    Public Shared Function MaximumLengthCheck(value As String, maximumLength As Integer)
        Return value.Length <= maximumLength
    End Function
    ' The range check function checks if a value is between two numbers
    Public Shared Function RangeCheck(value As Integer, min As Integer, max As Integer)
        Return value >= min And value <= max
    End Function
    ' The format check function checks if a value matches a certain pattern
    Function FormatCheck(value As String, pattern As String)
        Return value Like pattern
    End Function
End Class
