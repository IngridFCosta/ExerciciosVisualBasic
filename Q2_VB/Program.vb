Imports System

Module Program
    Sub Main(args As String())
        Dim num1, num2, num3, num4, soma As Integer
        Console.WriteLine("Somando numeros Inteiros: ")
        Console.WriteLine("Digite o 1º numero: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Digite o 2º numero: ")
        num2 = Console.ReadLine()
        Console.WriteLine("Digite o 3º numero: ")
        num3 = Console.ReadLine()
        Console.WriteLine("Digite o 4º numero:  ")
        num4 = Console.ReadLine()

        soma = num1 + num2 + num3 + num4
        Console.WriteLine("A Soma dos numeros é igual a {0}", soma)
    End Sub
End Module
