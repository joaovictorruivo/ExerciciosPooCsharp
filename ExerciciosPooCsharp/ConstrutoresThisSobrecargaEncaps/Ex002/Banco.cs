using System;
using System.Globalization;

namespace ExerciciosPooCsharp.ConstrutoresThisSobrecargaEncaps.Ex002
{
    internal class Banco
    {
        public static void Executar()
        {
            ContaBancaria conta;


            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            
            
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Aqui pegamos o valor do depósito
                conta = new ContaBancaria(numeroConta, titular, depositoInicial);
            }
            else
            {
                 conta = new ContaBancaria(numeroConta, titular);
            }

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(conta);

            Console.Write("\nEntre o valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("\nEntre o valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


        }
    }
}
