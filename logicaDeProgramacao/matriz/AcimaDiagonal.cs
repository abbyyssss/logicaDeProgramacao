using System;

class Program
{
    static void Main()
    {
        Console.Write("Qual a ordem da matriz? ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int somaAcimaDiagonal = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                somaAcimaDiagonal += matriz[i, j];
            }
        }

        Console.WriteLine($"SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = {somaAcimaDiagonal}");
    }
}
