using System;
using Biblioteca_Matriz;

class exercicio4
{
    static void Main()
    {

        int linha, coluna, resul;

        Console.WriteLine("Digite quantas linhas e colunas vai ter na matriz:");
        linha = int.Parse(Console.ReadLine());
        coluna = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linha, coluna];
        Matriz.gerar(matriz);
        Matriz.mostra(matriz);
        Console.WriteLine();

          for (int i = 0; i < linha; i++)
           {
               for (int j = 0; j < coluna; j++)
               {
                   if (i == j)
                   {
                       Console.Write($"{matriz[i, j]} || ");
                   }
               }
           }

        Console.WriteLine("\n");
        Console.ReadKey();

    }
}