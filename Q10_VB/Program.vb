Imports System

Module Program
    Sub Main(args As String())
        Dim numero As Integer
        Console.WriteLine("Digite um numero qualquer: ")
        numero = Console.ReadLine()

        If numero Mod 5 = 0 Then
            Console.WriteLine("O numero � multiplo de 5")
        Else
            Console.WriteLine("O numero n�o � multiplo de 5")
        End If
    End Sub
End Module
