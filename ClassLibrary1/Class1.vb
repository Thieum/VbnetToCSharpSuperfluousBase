Public Class A

    Protected Friend Overridable Sub Test()
        Console.WriteLine("From A")
    End Sub

End Class

Public Class B
    Inherits A

    Public Sub TestCaller()
        Console.WriteLine("From B")
        Test()
    End Sub

End Class