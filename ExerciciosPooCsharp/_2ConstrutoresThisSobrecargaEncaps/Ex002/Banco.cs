using System;
using System.Globalization;
//Programa principal
namespace ExerciciosPooCsharp.ConstrutoresThisSobrecargaEncaps.Ex002
{
    internal class Banco
    {
        public static void Executar()
        {
            ContaBancaria conta;//atribuição para ficar fora do if;

            //Interação com usuário;
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine()); //char = para validar caracter.
            
            
            if (resposta == 's' || resposta == 'S')//validação de char
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Aqui pegamos o valor do depósito
                conta = new ContaBancaria(numeroConta, titular, depositoInicial);//chamando construtor com 2 argumentos
            }
            else
            {
                 conta = new ContaBancaria(numeroConta, titular); //chamando construtor com 2 argumentos, jogando saldo 0 pra conta.
            }

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(conta);

            Console.Write("\nEntre o valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//variavel aqui declarada
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("\nEntre o valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// variavel sem o double na frente pois ja foi declarada acima.
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


        }
    }
}
