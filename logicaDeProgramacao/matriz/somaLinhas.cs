
        Console.Write("Digite o valor de M (número de linhas): ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de N (número de colunas): ");
        int N = int.Parse(Console.ReadLine());

        // Criar a matriz
        double[,] matriz = new double[M, N];

        // Ler os elementos da matriz
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"Digite o elemento da posição [{i}, {j}]: ");
                matriz[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // Calcular as somas das linhas
        double[] vetorSomas = new double[M];
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                vetorSomas[i] += matriz[i, j];
            }
        }

        // Mostrar o vetor gerado
        Console.WriteLine("\nVetor de somas das linhas:");
        for (int i = 0; i < M; i++)
        {
            Console.WriteLine($"Linha {i}: {vetorSomas[i]}");
        }
    