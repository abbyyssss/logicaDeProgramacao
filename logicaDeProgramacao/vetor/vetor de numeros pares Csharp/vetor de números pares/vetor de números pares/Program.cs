Console.Write("Quantos numeros voce vai digitar? ");
int N = int.Parse(Console.ReadLine());
int[] numeros = new int[N];
int[] pares = new int[N];
int p = 0;

for (int i = 0; i < N; i++)
{
    Console.Write("Digite um número: ");
    numeros[i] = int.Parse(Console.ReadLine());
    if (numeros[i] % 2 == 0)
    {
        pares[p] = numeros[i];
        p++;
    }
}

Console.WriteLine("Numeros pares:");
for (int i = 0; i < p; i++)
{
    Console.Write(pares[i] + " ");
}

Console.WriteLine("\nQuantidade de numeros pares: " + p);

