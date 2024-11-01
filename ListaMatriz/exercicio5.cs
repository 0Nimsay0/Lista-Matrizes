using System;
using Biblioteca_Matriz;

class exercicio5
{
    static void Main()
    {

        int linha, coluna;
        Console.WriteLine("Digite quantas linhas e colunas vai ter na matriz:");
        linha = int.Parse(Console.ReadLine());
        coluna = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linha, coluna];
        Matriz.gerar(matriz);
        Matriz.mostra(matriz);
        Console.WriteLine();

        for (int i = 0; i < coluna; i++)
        {
            Console.Write($"{matriz[i, coluna - 1 - i]} || ");
        } 

        Console.WriteLine("\n");
        Console.ReadKey();

    }
}