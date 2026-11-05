Imports System
Imports System.IO

Module Program
    Sub Main()
        Dim cont As Integer = 1
        While cont <= 3
            Console.WriteLine("Vuelva" & cont)
            cont = cont + 1
        End While
        Console.WriteLine("Sali del While")

    End Sub
End Module
