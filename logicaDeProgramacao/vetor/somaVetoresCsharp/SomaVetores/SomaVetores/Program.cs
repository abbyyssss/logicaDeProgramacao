
        Console.Write("Quantos valores vai ter cada vetor? ");
        int N = int.Parse(Console.ReadLine());

        int[] A = new int[N];
        int[] B = new int[N];
        int[] C = new int[N];

        Console.WriteLine("Digite os valores do vetor A:");
        for (int i = 0; i < N; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite os valores do vetor B:");
        for (int i = 0; i < N; i++)
        {
            B[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            C[i] = A[i] + B[i];
        }

        Console.WriteLine("VETOR RESULTANTE:");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(C[i]);
        }
    

