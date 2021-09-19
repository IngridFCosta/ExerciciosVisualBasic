Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Testando numeros primos")
        Dim numero As Integer
        Dim totDivisao As Integer = 0
        Console.WriteLine("Digite um numero qualquer:")
        numero = Console.ReadLine()

        For i = 1 To numero
            If numero Mod i = 0 Then
                totDivisao += 1
            End If
        Next
        If totDivisao > 2 Then
            Console.WriteLine("O número não é primo")
        Else
            Console.WriteLine("O número é primo")
        End If
    End Sub
End Module
