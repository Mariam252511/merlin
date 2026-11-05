Imports System

Module Program
    Sub Main()

        Console.WriteLine("1. medir voltaje")
        Console.WriteLine("2. medir corriente CD")
        Console.WriteLine("3. medir corriente AC")
        Console.WriteLine("4. Probar continuidad")
        Console.WriteLine("5. Probar diodo")
        Console.WriteLine("6. Medir resistencia")
        Console.WriteLine("7. Medir capacitancia")
        Console.WriteLine("8. Medir frecuencia")
        Console.WriteLine("9. Salir")

        Console.Write("Opcion (1 a 9):")
        Dim op As Integer = CInt(Console.ReadLine())
        Select Case op
            Case 1
                Console.WriteLine("Medir voltaje")
            Case 2, 3
                Console.WriteLine("Medir corriente")
            Case 4 To 8
                Console.WriteLine("Otra funcion")
            Case 9
                Console.WriteLine("Hasta Luego")
            Case Else
                Console.WriteLine("opcion no valida")


        End Select
        Console.ReadKey()

    End Sub

End Module
