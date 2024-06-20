Console.Write("Qual a ordem da matriz: ");
int N = int.Parse(Console.ReadLine());

int[,] matriz = new int[N, N];

// adicionando valores na matriz

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write($"Digite o valor para a posição [{i}, {j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

// exibindo os maiores valores de cada linha
for (int i = 0; i < N; i++)
{
    int maiorValorLinha = matriz[i, 0]; // atribui o primeiro valor da linha como o maior
    for (int j = 1; j < N; j++)
    {
        if (matriz[i, j] > maiorValorLinha)
        {
            maiorValorLinha = matriz[i, j];
        }
    }
    Console.WriteLine($"Maior valor da {i + 1}ª linha: {maiorValorLinha}");
}
