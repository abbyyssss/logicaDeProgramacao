using System;

class Program
{
    static void Main()
    {
        // Solicita o número de linhas e colunas das matrizes
        Console.Write("Quantas linhas vai ter cada matriz? ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Quantas colunas vai ter cada matriz? ");
        int N = int.Parse(Console.ReadLine());

        // Declaração das matrizes A, B e C
        int[,] A = new int[M, N];
        int[,] B = new int[M, N];
        int[,] C = new int[M, N];

        // Lê os valores da matriz A
        Console.WriteLine("Digite os valores da matriz A:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Lê os valores da matriz B
        Console.WriteLine("Digite os valores da matriz B:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Calcula a matriz C (soma dos elementos correspondentes)
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                C[i, j] = A[i, j] + B[i, j];
            }
        }

        // Imprime a matriz C
        Console.WriteLine("MATRIZ SOMA:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"{C[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
