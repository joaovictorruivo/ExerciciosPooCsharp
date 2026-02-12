using ExerciciosPooCsharp._12LambdaDelegatesLinq.Ex002.Entites;
using System.Collections.Specialized;
using System.Linq;
//Fazer um programa que, a partir de uma lista de produtos, gere uma nova lista 
//contendo os nomes dos produtos em caixa alta.
namespace ExerciciosPooCsharp._12LambdaDelegatesLinq.Ex002
{
    internal class ProblemPredicate
    {
        public static void Executar()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, string> func = NameUpper;

            List<string> resulte = list.Select(func).ToList();
            foreach(string s in resulte)
            {
                Console.WriteLine(s);
            }
        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper(); 
        }

    }
}
