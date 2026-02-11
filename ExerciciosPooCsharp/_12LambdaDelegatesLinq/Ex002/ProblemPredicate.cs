using ExerciciosPooCsharp._12LambdaDelegatesLinq.Ex002.Entites;
// Exemplo com RemoveAll
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

            list.RemoveAll(p => p.Price >= 100.0);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }    
    }
}
