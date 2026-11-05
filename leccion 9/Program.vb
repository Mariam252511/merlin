Imports System

Module Program
    Sub Main()

        Dim segundos As Integer = 47
        Dim minutos As Integer
        Dim resto As Integer

        minutos = segundos / 5
        resto = segundos Mod 5
        Console.WriteLine("division: " & minutos)
        Console.WriteLine("numeero restante: " & resto)

        Console.ReadKey()
    End Sub
End Module
