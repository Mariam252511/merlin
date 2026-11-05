Imports System
Imports System.Numerics

Module Program
    Sub Main()
        Dim total As Integer = 0
        For i As Integer = 1 To 100
            total = total + i

        Next
        Console.WriteLine("Total:" & total)
        Console.ReadKey()
    End Sub
End Module
