using ExerciciosPooCsharp._6HerancaPolimorfismo.Ex004.Entites;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExerciciosPooCsharp._6HerancaPolimorfismo.Ex004
{
    internal class Programm4
    {
        public static void Executar()
        {
            List<TaxPayer> list = new List<TaxPayer>();
            
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individueal or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }

            }
            double sum = 0.0;
            Console.WriteLine("\nTaxes Paid:");
            foreach (TaxPayer tp in list)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + ": $" + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }
            Console.WriteLine("\nTOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
