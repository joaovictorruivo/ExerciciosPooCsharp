using ExerciciosPooCsharp._7TratamentoExcecoes.Ex002.Entites.Exceptions;
using ExerciciosPooCsharp._7TratamentoExcecoes.Ex002.Entites;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExerciciosPooCsharp._7TratamentoExcecoes.Ex002
{
    internal class Program72
    {
        public static void Executar()
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            String holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
