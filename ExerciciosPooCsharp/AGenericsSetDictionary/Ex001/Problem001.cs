
namespace ExerciciosPooCsharp.AGenericsSetDictionary.Ex001
{
    internal class Problem001
    {
        public static void Executar()
        {
            //PrintService printService = new PrintService();//instanciar agora do nosso jeito.
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());

        }
    }
}
