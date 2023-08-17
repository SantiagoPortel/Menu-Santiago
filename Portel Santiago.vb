Imports System

Module Program
    Sub Main(args As String())
        Dim variable As Integer
        Console.WriteLine("MENU")
        Do Until variable = 5
            Console.WriteLine("Presione 1 para ingresó el dato correctamente")
            Console.WriteLine("Presione 2 si el dato no ingresó correctamente")
            Console.WriteLine("Presione 3 para ingresar su Nombre y Apellido")
            Console.WriteLine("Presione 4 para realizar operaciones matemáticas")
            Console.WriteLine("Presione 5 para cerrar")
            variable = Console.ReadLine

            If variable = 1 Then
                Console.WriteLine("Dato ingresado Correctamente")
            ElseIf variable = 2 Then
                Console.WriteLine("Dato ingresado Incorrectamente")
            ElseIf variable = 3 Then
                Console.WriteLine("Ingrese su Nombre y Apellido")
            ElseIf variable = 4 Then
                Console.WriteLine("Seleccione la operación:")
                Console.WriteLine("1. Suma")
                Console.WriteLine("2. Resta")
                Console.WriteLine("3. Multiplicación")
                Console.WriteLine("4. División")
                Console.WriteLine("5. Potencia")
                Console.WriteLine("6. Raíz cuadrada")
                Dim operacion As Integer = Console.ReadLine()

                Select Case operacion
                    Case 1
                        Console.WriteLine("Ingrese el primer número:")
                        Dim num1 As Double = Double.Parse(Console.ReadLine())
                        Console.WriteLine("Ingrese el segundo número:")
                        Dim num2 As Double = Double.Parse(Console.ReadLine())
                        Console.WriteLine($"Suma: {num1 + num2}")
                    Case 2
                        Console.WriteLine("Ingrese el primer número:")
                        Dim num1 As Double = Double.Parse(Console.ReadLine())
                        Console.WriteLine("Ingrese el segundo número:")
                        Dim num2 As Double = Double.Parse(Console.ReadLine())
                        Console.WriteLine($"Resta: {num1 - num2}")
                    Case 3
                        Console.WriteLine("Ingrese el primer número:")
                        Dim num1 As Double = Double.Parse(Console.ReadLine())
                        Console.WriteLine("Ingrese el segundo número:")
                        Dim num2 As Double = Double.Parse(Console.ReadLine())
                        Console.WriteLine($"Multiplicación: {num1 * num2}")
                    Case 4
                        Console.WriteLine("Ingrese el primer número:")
                        Dim num1 As Double = Double.Parse(Console.ReadLine())
                        Console.WriteLine("Ingrese el segundo número:")
                        Dim num2 As Double = Double.Parse(Console.ReadLine())
                        If num2 <> 0 Then
                            Console.WriteLine($"División: {num1 / num2}")
                        Else
                            Console.WriteLine("No se puede dividir por cero.")
                        End If
                    Case 5
                        Console.WriteLine("Ingrese el primer número:")
                        Dim num1 As Double = Double.Parse(Console.ReadLine())
                        Console.WriteLine("Ingrese el segundo número:")
                        Dim num2 As Double = Double.Parse(Console.ReadLine())
                        Console.WriteLine($"Potencia: {num1 ^ num2}")
                    Case 6
                        Console.WriteLine("Ingrese el numero deseado:")
                        Dim num1 As Double = Double.Parse(Console.ReadLine())
                        Console.WriteLine($"Raíz cuadrada de: {Math.Sqrt(num1)}")
                    Case Else
                        Console.WriteLine("Operación inválida.")
                End Select
            End If

            Console.WriteLine("Presione una tecla para continuar...")
            Console.ReadKey()
            Console.Clear()
        Loop
    End Sub
End Module
