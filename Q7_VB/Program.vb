Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Tipos de pagamento em supermercado")
        Dim valorCompra As Double
        Dim totFinal As Double
        Dim tipoPagamento As String

        Console.WriteLine("Informe o valor da compra: ")
        valorCompra = Console.ReadLine()
        Console.WriteLine("Informe o tipo de pagamento: ")
        tipoPagamento = Console.ReadLine()

        If tipoPagamento = "a vista" Then
            totFinal = valorCompra - (valorCompra * 15 / 100)
        ElseIf tipoPagamento = "cartão" Then
            totFinal = valorCompra + (valorCompra * 4 / 100)
        End If

        Console.WriteLine("O valor final da compra é igual a: " & totFinal.ToString("C"))


    End Sub
End Module
