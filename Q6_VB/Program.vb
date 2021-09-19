Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("Simulação de Login ")
        Dim usuario, senha As String
        Dim userPadrao As String = "User"
        Dim senhaPadrao As String = "1234"

        Console.WriteLine("Usuario: ")
        usuario = Console.ReadLine()
        Console.WriteLine("Senha: ")
        senha = Console.ReadLine()

        If usuario = userPadrao And senha = senhaPadrao Then
            Console.WriteLine("Bem Vindo(a) ao sistema")
        Else
            Console.WriteLine("Usuario ou senha incorretos")
        End If


    End Sub
End Module
