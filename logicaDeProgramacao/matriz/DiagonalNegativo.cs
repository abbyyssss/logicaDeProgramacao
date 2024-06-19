Console.Write("Digite o valor de N (máximo 10): ");
int N = int.Parse(Console.ReadLine());

// Criar a matriz quadrada de ordem N
int[,] matriz = new int[N, N];

// Preencher a matriz com valores
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write($"Digite o valor para a posição [{i}, {j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

// Exibir a diagonal principal
Console.WriteLine("Diagonal principal:");
for (int i = 0; i < N; i++)
{
    Console.Write(matriz[i, i] + " ");
}

// Contar valores negativos
int negativos = 0;
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (matriz[i, j] < 0)
        {
            negativos++;
        }
    }
}

Console.WriteLine($"Quantidade de valores negativos na matriz: {negativos}");