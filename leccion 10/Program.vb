Imports System

Module Program
    Sub Main()
        Dim edad As Integer
        Dim horas As Integer

        Console.Write("Digite su edad: ")
        edad = Convert.ToInt32(Console.ReadLine())

        Console.Write("Digite las horas de taller: ")
        horas = Convert.ToInt32(Console.ReadLine())

        If edad >= 15 AndAlso horas >= 40 Then
            Console.WriteLine("Certificado")

        End If

        Console.ReadKey()

    End Sub
End Module
