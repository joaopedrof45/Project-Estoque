

using System;
using System.Globalization;
using System.Net.Http.Headers;
using PrimeiroApp;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            int opcao = 0;
            int qtd = 0;
            int produtoIndex = 0;

            while (opcao != 5)
            {
                Console.WriteLine("Bem Vindo ao Estoque do João");
                Console.WriteLine("para prosseguir escolha uma das opções abaixo:");
                Console.WriteLine("[1] - Ver dados do Produto");
                Console.WriteLine("[2] - Adicionar Produto");
                Console.WriteLine("[3] - Adicionar Quantidade em Estoque");
                Console.WriteLine("[4] - Retirar Preço em Estoque");
                Console.WriteLine("[5] - Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine(opcao.ToString());
               

                // logica que adiciona ou remove quantidade do produto no estoque  de acordo com 
                // opção escolhida pelo usuário

                if (opcao == 1) {
                    Console.Clear();
                    Console.WriteLine("Escolha o índice do produto para visualizar (0 a " + (produtos.Count - 1) + "):");
                    produtoIndex = int.Parse(Console.ReadLine());
                    
                    if(produtoIndex >= 0 && produtoIndex < produtos.Count)
                    {
                        Console.WriteLine(produtos[produtoIndex].ToString());
                    }
                    else
                    {
                        Console.WriteLine("Indice Inválido!!!");
                    }

          
                } else if (opcao == 2) {
                    Console.Clear();
                    Console.WriteLine("Digite o nome do produto:");
                    string nomeProduto = Console.ReadLine();
                    Console.WriteLine("Digite o saldo inicial do produto:");
                    int saldoProduto = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o Preço inicial do produto:");
                    double precoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    Produto novoProduto = new Produto();
                    novoProduto.nome = nomeProduto;
                    novoProduto.AdicionarSaldo(saldoProduto);
                    novoProduto.preco = precoProduto;

                    produtos.Add(novoProduto);
                    Console.WriteLine($"Produto {nomeProduto} adicionado com saldo inicial de {saldoProduto}.");
                }
                else if (opcao == 3)
                {
                    // Adicionar quantidade em estoque de um produto
                    Console.Clear();
                    Console.WriteLine("Escolha o índice do produto para adicionar quantidade (0 a " + (produtos.Count - 1) + "):");
                    produtoIndex = int.Parse(Console.ReadLine());

                    if (produtoIndex >= 0 && produtoIndex < produtos.Count)
                    {
                        Console.WriteLine("Digite a quantidade que deseja adicionar:");
                        qtd = int.Parse(Console.ReadLine());
                        produtos[produtoIndex].AdicionarSaldo(qtd);
                    }
                    else
                    {
                        Console.WriteLine("Índice inválido.");
                    }
                }
                else if (opcao == 4)
                {
                    // Retirar quantidade de estoque de um produto
                    Console.Clear();
                    Console.WriteLine("Escolha o índice do produto para retirar quantidade (0 a " + (produtos.Count - 1) + "):");


                    produtoIndex = int.Parse(Console.ReadLine());


                    //verifica se o indice indicado não é zero e se está tentando acessar um indice que n maior do que a lista
                    if (produtoIndex >= 0 && produtoIndex < produtos.Count)
                    {
                        Console.WriteLine("Digite a quantidade que deseja retirar:");
                        qtd = int.Parse(Console.ReadLine());
                        produtos[produtoIndex].RemoverSaldo(qtd);
                    }
                    else
                    {
                        Console.WriteLine("Índice inválido.");
                    }

                }

            }
        }
    }
}

