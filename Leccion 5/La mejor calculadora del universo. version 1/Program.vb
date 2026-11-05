Imports System

Module Program
    Sub Main()
        Dim n1, n2 As Double
        Dim opcion As String
        Dim resultado As Double
        Dim exponente As Double

        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("------------------------")
        Console.WriteLine("")
        Console.WriteLine("  --CALCULADORA--  ")
        Console.WriteLine("")
        Console.WriteLine("------------------------")
        Console.ResetColor()

        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.WriteLine("Elige un modo")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.DarkRed
        Console.WriteLine("1.Sumar")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("2.Restar")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.DarkYellow
        Console.WriteLine("3.Dividir")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("4.Multiplicar")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("5.Potencia")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.WriteLine("6.Raiz")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("7.Binario")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("8.Hexadecimal")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.DarkMagenta
        Console.WriteLine("9.Salir")
        Console.ResetColor()

        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("------------------------")
        Console.WriteLine("")
        Console.WriteLine("------------------------")
        Console.ResetColor()

        Console.Write("Elige una opcion:")
        opcion = Console.ReadLine()

        If opcion <> 7 Then
            Console.Write("Escribe el primer numero aqui:")
            n1 = CDbl(Console.ReadLine())
            Console.Write("Escribe el segundo numero aqui:")
            n2 = CDbl(Console.ReadLine())
        End If
        If opcion >= 7 Then
            Console.Write("Escribe el numero decimal:")
            n1 = CDbl(Console.ReadLine())
        End If
        Select Case opcion
            Case "1"
                resultado = n1 + n2
                Console.WriteLine("Resultado:" & resultado)

            Case "2"

                Console.WriteLine("Resultado:" & n1 - n2)

            Case "3"

                Console.WriteLine("Resultado:" & n1 / n2)

            Case "4"
                Console.WriteLine("Resultado:" & n1 * n2)

            Case "5"

                Console.WriteLine("Resultado:" & n1 ^ n2)

        End Select

        If opcion = 6 Then
            resultado = n1 ^ (1 / exponente)
            Console.WriteLine("Resultado:" & resultado)

        End If
        If opcion = 7 Then

            Console.WriteLine("Binario:" & Convert.ToString(CInt(n1), 2))
        End If
        If opcion = 8 Then

            Console.WriteLine("Hexadecimal:" & Convert.ToString(CInt(n1), 16))
        End If
        If opcion = 9 Then
            Console.WriteLine("Salir de la calculadora")

        Else
            Console.WriteLine("Opcion no valida")
        End If

        Console.ReadKey()

    End Sub
End Module
