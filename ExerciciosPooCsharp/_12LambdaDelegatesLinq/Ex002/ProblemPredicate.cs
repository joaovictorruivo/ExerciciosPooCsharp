using ExerciciosPooCsharp._12LambdaDelegatesLinq.Ex002.Entites;
// Action Exemplo com Action ForEach
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

            list.ForEach(p => { p.Price += p.Price * 0.1; }); //inline argumento do foreach
            foreach (Product p in list)
            {
                Console.WriteLine(p);

            }
        }

    }
}
