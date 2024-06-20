Console.Write("Digite o valor de N (máximo 10): ");
int N = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de M (máximo 10): ");
int M = int.Parse(Console.ReadLine());

int[,] matriz = new int[N, M];

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {

        Console.Write($"Digite o valor para a posição [{i}, {j}]");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
//tentando exibir os valores negativos
Console.WriteLine("Valores negativos encontrados: ");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        if (matriz[i, j] < 0)
        {
            Console.WriteLine($"Posição [{i}, {j}]: {matriz[i, j]}");
        }
    }
}