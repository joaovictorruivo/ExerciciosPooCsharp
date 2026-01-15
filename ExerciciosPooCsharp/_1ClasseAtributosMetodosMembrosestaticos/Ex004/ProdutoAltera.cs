using System;
using System.Globalization;

//Fazer um programa para ler os dados de um produto em estoque (nome, preço e
//quantidade no estoque). Em seguida:
//• Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no
//estoque)
//• Realizar uma entrada no estoque e mostrar novamente os dados do produto
//• Realizar uma saída no estoque e mostrar novamente os dados do produto

//Entre os dados do produto:
//Nome: TV
//Preço: 900.00
//Quantidade no estoque: 10
//Dados do produto: TV, $ 900.00, 10 unidades, Total: $ 9000.00
//Digite o número de produtos a ser adicionado ao estoque: 5
//Dados atualizados: TV, $ 900.00, 15 unidades, Total: $ 13500.00
//Digite o número de produtos a ser removido do estoque: 3
//Dados atualizados: TV, $ 900.00, 12 unidades, Total: $ 10800.00


namespace ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex004
{
    internal class ProdutoAltera
    {
        public static void Executar()
        {
            Produto p = new Produto();
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDados do produto: " + p);
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("\nDados atualizados: " + p);

            Console.Write("Digite o número de produtos a ser removidos: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("\nDados atualizados: " + p);

        }

    }
}
