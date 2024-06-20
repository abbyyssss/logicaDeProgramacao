using System;

class Program
{
    static void Main()
    {
        Console.Write("Qual a ordem da matriz? ");
        int n = int.Parse(Console.ReadLine());

        double[,] matriz = new double[n, n];

        // Ler os elementos da matriz
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // Calcular a soma dos elementos positivos
        double somaPositivos = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matriz[i, j] > 0)
                {
                    somaPositivos += matriz[i, j];
                }
            }
        }
        Console.WriteLine($"SOMA DOS POSITIVOS: {somaPositivos}");

        // Escolher uma linha e imprimir seus elementos
        Console.Write("Escolha uma linha: ");
        int linhaEscolhida = int.Parse(Console.ReadLine());
        Console.Write("LINHA ESCOLHIDA: ");
        for (int j = 0; j < n; j++)
        {
            Console.Write(matriz[linhaEscolhida, j] + " ");
        }
        Console.WriteLine();

        // Escolher uma coluna e imprimir seus elementos
        Console.Write("Escolha uma coluna: ");
        int colunaEscolhida = int.Parse(Console.ReadLine());
        Console.Write("COLUNA ESCOLHIDA: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(matriz[i, colunaEscolhida] + " ");
        }
        Console.WriteLine();

        // Imprimir os elementos da diagonal principal
        Console.Write("DIAGONAL PRINCIPAL: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }
        Console.WriteLine();

        // Elevar ao quadrado os números negativos e imprimir a matriz alterada
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matriz[i, j] < 0)
                {
                    matriz[i, j] *= matriz[i, j]; // Eleva ao quadrado
                }
            }
        }

        Console.WriteLine("MATRIZ ALTERADA:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
