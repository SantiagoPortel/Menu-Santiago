Imports System

Module Program
    Sub Main(args As String())
        Dim variable As Integer
        Console.WriteLine("MENU")
        Do Until variable = 4
            Console.WriteLine("Presione 1 para ingresó el dato correctamente")
            Console.WriteLine("Presione 2 si el dato no ingresó correctamente")
            Console.WriteLine("Presione 3 para ingresar su Nombre y Apellido")
            Console.WriteLine("Presione 4 para cerrar")
            variable = Console.ReadLine
            If variable = 1 Then
                Console.WriteLine("Dato ingresado Correctamente")
            ElseIf variable = 2 Then
                Console.WriteLine("Dato ingresado Incorrectamente")
            ElseIf variable = 3 Then
                Console.WriteLine("Ingrese su Nombre y Apellido")
            End If
            Console.WriteLine("Salir")
        Loop
    End Sub
End Module
