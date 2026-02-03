using ExerciciosPooCsharp._10GenericsSetDictionary.Ex002.Services;
using ExerciciosPooCsharp._10GenericsSetDictionary.Ex002.Entites;
using System.Globalization;
/* Uma empresa de consultoria deseja avaliar a performance de produtos,
funcionários, dentre outras coisas. Um dos cálculos que ela precisa é encontrar
o maior dentre um conjunto de elementos. Fazer um programa que leia um
conjunto de N produtos, conforme exemplo, e depois mostre o mais caro deles.

Enter N: 3 
Computer,890.50
IPhone X,910.00
Tablet,550.00
Max:
IPhone, 910.00
*/
namespace ExerciciosPooCsharp._10GenericsSetDictionary.Ex002
{
    internal class Problem02
    {
        public static void Executar()
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(vect[0], price));
            }

            CalculationService calculationService = new CalculationService();

            Product p = calculationService.Max(list); // <Product> is optional

            Console.WriteLine("Max:");
            Console.WriteLine(p);
        }
    }
    
}
