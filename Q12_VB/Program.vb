Imports System

Module Program
    Sub Main(args As String())

        Dim totDivisao As Integer = 0
        Console.WriteLine("Numeros primos entre 1 e 100")

        For i = 1 To 100 Step 1
            If i Mod i = 0 Then
                totDivisao += 1
            End If
            If totDivisao = 2 Then
                Console.WriteLine(i)
            End If

        Next



    End Sub
End Module
