Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Calcular area do quadrado")
        Dim lado, area As Integer
        Console.WriteLine("Escreva a medida do lado do quadrado: ")
        lado = Console.ReadLine()
        area = Math.Pow(lado, 2)
        Console.WriteLine("A area do quadrado é: " & area)



    End Sub
End Module
