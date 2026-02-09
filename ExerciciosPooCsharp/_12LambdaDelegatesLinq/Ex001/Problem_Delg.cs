using ExerciciosPooCsharp._12LambdaDelegatesLinq.Ex001.Services;

namespace ExerciciosPooCsharp._12LambdaDelegatesLinq.Ex001
{
    delegate double BinaryNumerOperation(double n1, double n2);
    internal class Problem_Delg
    {
        public static void Executar()
        {
            double a = 10;
            double b = 12;

            //BinaryNumerOperation op = CalculationService.Sum;
            BinaryNumerOperation op = new BinaryNumerOperation(CalculationService.Sum);

            //double result = CalculationService.Sum(a, b);
            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}
