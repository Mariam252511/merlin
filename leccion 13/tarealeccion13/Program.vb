Imports System

Module Program
    Sub Main()
        Dim opcion As Integer
        Dim num1, num2 As Double

        Do
            Console.WriteLine("MENÚ")
            Console.WriteLine("1. Sumar")
            Console.WriteLine("2. Restar")
            Console.WriteLine("3. Salir")
            Console.WriteLine("Elija una opción:")
            opcion = Console.ReadLine()

            If opcion = 1 Then
                Console.WriteLine("Ponga el primer número:")
                num1 = Console.ReadLine()

                Console.WriteLine("Ponga el segundo número:")
                num2 = Console.ReadLine()

                Console.WriteLine("Resultado: " & (num1 + num2))

            ElseIf opcion = 2 Then
                Console.WriteLine("Ponga el primer número:")
                num1 = Console.ReadLine()

                Console.WriteLine("Ponga el segundo número:")
                num2 = Console.ReadLine()

                Console.WriteLine("Resultado: " & (num1 - num2))

            ElseIf opcion = 3 Then
                Console.WriteLine("Saliendo del programa...")

            Else
                Console.WriteLine("Opción no válida.")
            End If

        Loop Until opcion = 3
    End Sub
End Module
