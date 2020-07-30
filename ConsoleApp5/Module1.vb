Imports ClassLibrary1

Module Module1

    Public Class C
        Inherits B

        Protected Overrides Sub Test()
            Console.WriteLine("From C")
        End Sub

    End Class


    Sub Main()
        Dim c As New C
        c.TestCaller()
        Console.ReadLine()
    End Sub

End Module
