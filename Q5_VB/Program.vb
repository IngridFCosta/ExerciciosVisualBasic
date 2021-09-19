Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Maior entre 3 numeros")
        Dim num1, num2, num3 As Integer
        Console.WriteLine("Digite o 1º numero: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Digite o 2º numero: ")
        num2 = Console.ReadLine()
        Console.WriteLine("Digite o 3º numero: ")
        num3 = Console.ReadLine()

        If num1 > num2 And num1 > num3 Then
            Console.WriteLine("O primeiro é o maior")
        ElseIf num2 > num1 And num2 > num3 Then
            Console.WriteLine("O segundo é o maior")
        Else
            Console.WriteLine("O Terceiro é o maior ")
        End If



    End Sub
End Module
