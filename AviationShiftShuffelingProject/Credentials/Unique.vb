Public Class Unique

    Private _myString As String = "Hello, World!"

    Public ReadOnly Property MyString() As String
        'set readOnly'
        Get
            Return _myString
        End Get
    End Property

End Class
