using System;

class Program
{
    static string[] produtos = new string[100];
    static int[] estoque = new int[100];
    static int contador = 0;

    static void Main()
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("[1] Novo Produto");
            Console.WriteLine("[2] Listar Produto");
            Console.WriteLine("[3] Remover Produto");
            Console.WriteLine("[4] Entrada do Estoque");
            Console.WriteLine("[5] Saída do Estoque");
            Console.WriteLine("[0] Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarProduto();
                    break;
                case 2:
                    ListarProdutos();
                    break;
                case 3:
                    RemoverProduto();
                    break;
                case 4:
                    EntradaEstoque();
                    break;
                case 5:
                    SaidaEstoque();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

        } while (opcao != 0);
    }

    static void AdicionarProduto()
    {
        if (contador >= produtos.Length)
        {
            Console.WriteLine("Limite de produtos alcançado.");
            return;
        }

        Console.Write("Digite o nome do produto: ");
        produtos[contador] = Console.ReadLine();
        estoque[contador] = 0; 
        contador++;
        Console.WriteLine("Produto adicionado com sucesso!");
    }

    static void ListarProdutos()
    {
        Console.WriteLine("Lista de Produtos:");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"[{i}] {produtos[i]} - Estoque: {estoque[i]}");
        }
    }

    static void RemoverProduto()
    {
        ListarProdutos();
        Console.Write("Digite o índice do produto que deseja remover: ");
        int indice = int.Parse(Console.ReadLine());

        if (indice >= 0 && indice < contador)
        {
            for (int i = indice; i < contador - 1; i++)
            {
                produtos[i] = produtos[i + 1];
                estoque[i] = estoque[i + 1];
            }
            produtos[contador - 1] = null; // Limpa o último item
            estoque[contador - 1] = 0; // Limpa o estoque
            contador--;
            Console.WriteLine("Produto removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Índice inválido!");
        }
    }

    static void EntradaEstoque()
    {
        ListarProdutos();
        Console.Write("Digite o índice do produto para adicionar estoque: ");
        int indice = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade a adicionar: ");
        int quantidade = int.Parse(Console.ReadLine());

        if (indice >= 0 && indice < contador)
        {
            estoque[indice] += quantidade;
            Console.WriteLine("Estoque atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Índice inválido!");
        }
    }

    static void SaidaEstoque()
    {
        ListarProdutos();
        Console.Write("Digite o índice do produto para remover estoque: ");
        int indice = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade a remover: ");
        int quantidade = int.Parse(Console.ReadLine());

        if (indice >= 0 && indice < contador)
        {
            if (estoque[indice] >= quantidade)
            {
                estoque[indice] -= quantidade;
                Console.WriteLine("Estoque atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Quantidade maior que o estoque disponível!");
            }
        }
        else
        {
            Console.WriteLine("Índice inválido!");
        }
    }
}
