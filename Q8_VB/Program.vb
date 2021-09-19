Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Sistema SuperMercado XYZ")
        Dim totCompra As Double
        Dim dia As String
        Dim respCartao As String

        Console.WriteLine("Qual o valor da compra? ")
        totCompra = Console.ReadLine()
        Console.WriteLine("Possui cartão do Supermercado: ")
        respCartao = Console.ReadLine()
        Console.WriteLine("Qual o dia da semana?: ")
        dia = Console.ReadLine()

        If dia = "terça feira" And respCartao = "sim" Then
            totCompra = totCompra - (totCompra * 22 / 100)
            Console.WriteLine("Você recebeu um desconto de 22% ")
            Console.WriteLine("O valor final da compra é de: " & totCompra.ToString("C"))
        Else
            Console.WriteLine("O valor final da compra é de: " & totCompra.ToString("C"))

        End If




    End Sub
End Module
