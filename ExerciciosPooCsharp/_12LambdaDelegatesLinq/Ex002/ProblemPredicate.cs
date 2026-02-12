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

            //Func<Product, string> func = p => p.Name.ToUpper();//se usar {chaves}, obrigado colocar a palavra return
            
            List<string> resulte = list.Select(p => p.Name.ToUpper()).ToList(); //Usando LAMBDA Inline
            foreach(string s in resulte)
            {
                Console.WriteLine(s);
            }
        }      
    }
}
