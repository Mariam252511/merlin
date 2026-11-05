Imports System
Imports System.Globalization

Module Program
    Sub Main()
        Dim opcion As String
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("------------------------")
        Console.WriteLine("Elija el tipo de calculadora:")
        Console.WriteLine("1. Calculadora Basica")
        Console.WriteLine("2. Calculadora De Conversiones")
        Console.WriteLine("0. Salir")
        Console.WriteLine("")
        Console.Write("Elige una opcion: ")
        opcion = Console.ReadLine()
        Console.WriteLine("------------------------")
        Console.ResetColor()

        Select Case opcion
            Case 1
                MenuCalculadora()
            Case 2
                MenuConversiones()
            Case 0
                Console.WriteLine("Saliendo...")
            Case Else
                Console.WriteLine("Opcion no valida. Intente de nuevo.")
                Main()
        End Select
    End Sub

    Sub MenuCalculadora()
        Dim opcion As String
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("------------------------")
        Console.WriteLine("")
        Console.WriteLine("  --CALCULADORA--  ")
        Console.WriteLine("")
        Console.WriteLine("------------------------")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.WriteLine("MENU:")
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
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("6.Raiz")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine("0.Volver al menu principal")
        Console.ResetColor()
        Console.WriteLine()

        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.Write("Elige una opcion: ")
        opcion = Console.ReadLine()
        Console.ResetColor()

        If opcion = 0 Then
            Main()
            Return
            'El return acaba con la ejecucion del metodo
        ElseIf opcion < 1 Or opcion > 6 Then
            Console.WriteLine("Opcion no valida. Intente de nuevo.")
            MenuCalculadora()
            Return
        End If

        Calculadora(opcion)
    End Sub

    Sub Calculadora(opcion As String)
        Dim n1, n2 As Double

        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("------------------------")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write("Digite el primer numero:")
        Console.ResetColor()
        n1 = CDbl(Console.ReadLine())
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.Write("Digite el  segundo numero:")
        n2 = CDbl(Console.ReadLine())
        Console.ResetColor()

        If (opcion = 3 Or opcion = 6) And n2 = 0 Then
            Console.WriteLine("Error: No se puede dividir entre cero.")
            Calculadora(opcion)
            Return
        End If

        Select Case opcion
            Case "1"
                Console.WriteLine("Resultado: " & n1 + n2)
            Case "2"
                Console.WriteLine("Resultado: " & n1 - n2)
            Case "3"
                Console.WriteLine("Resultado: " & n1 / n2)
            Case "4"
                Console.WriteLine("Resultado: " & n1 * n2)
            Case "5"
                Console.WriteLine("Resultado: " & n1 ^ n2)
            Case "6"
                Console.WriteLine("Resultado: " & n1 ^ (1 / n2))
                'Toda raiz es una potencia de exponente fracional
                'Por ejemplo, la raiz cuadrada es una potencia de exponente 1/2
                'Digase n1 ^ (1/2) = raiz cuadrada de n1
            Case Else
                Console.WriteLine("Opcion no valida. Intente de nuevo.")
                MenuCalculadora()
                Return

        End Select

        Main()
    End Sub

    Sub MenuConversiones()
        Dim opcion As String
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("------------------------")
        Console.WriteLine("")
        Console.WriteLine("  --CONVERSIONES--  ")
        Console.WriteLine("")
        Console.WriteLine("------------------------")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.WriteLine("MENU:")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("1.Convierte a Binario")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("2.Convierte a Hex")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("3.Convierte a Octal")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("0.Volver al menu principal")
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.Write("Elige una opcion: ")
        opcion = Console.ReadLine()
        Console.ResetColor()
        If opcion = 0 Then
            Main()
            Return
        ElseIf opcion < 1 Or opcion > 3 Then
            Console.WriteLine("Opcion no valida. Intente de nuevo.")
            MenuConversiones()
            Return
        End If

        Conversiones(opcion)
    End Sub

    Sub Conversiones(opcion As String)
        Dim n1 As Integer
        Console.Write("Digite el numero a convertir: ")
        n1 = CInt(Console.ReadLine())

        If n1 < 0 Then
            Console.WriteLine("Error: No se puede convertir un numero negativo.")
            Conversiones(opcion)
            Return
        End If

        Select Case opcion
            Case "1"
                Console.WriteLine("Resultado: " & Convert.ToString(n1, 2))
            Case "2"
                Console.WriteLine("Resultado: " & Convert.ToString(n1, 16))
            Case "3"
                Console.WriteLine("Resultado: " & Convert.ToString(n1, 8))
            Case Else
                Console.WriteLine("Opcion no valida. Intente de nuevo.")
                MenuConversiones()
                Return
        End Select

        Main()
    End Sub
End Module

