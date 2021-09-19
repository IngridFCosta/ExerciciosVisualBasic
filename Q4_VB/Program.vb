Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Calculando total de compra com desconto")
        Dim totCompra, totDesconto As Double
        Dim percentDesconto As Integer = 10
        Console.WriteLine("Informe o total da compra: ")
        totCompra = Console.ReadLine()
        totDesconto = totCompra - (totCompra * 10 / 100)
        Console.WriteLine("O valor final da compra com desconto é: " & totDesconto)


    End Sub
End Module
