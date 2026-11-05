Imports System
Imports System.Xml

Module Program
    Sub Main()
        Console.WriteLine("cuanto sacaste en matematicas ?")
        Dim nota As Integer = CInt(Console.ReadLine())
        Console.WriteLine($"En matematicas sacaste {nota}")
        Console.ReadKey()
    End Sub
End Module
