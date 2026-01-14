using System;
using System.Globalization;
/* Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
exemplo).
Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger
isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
suficiente para realizar o saque e/ou pagar a taxa.
Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre
mostrando os dados da conta após cada operação
*/


namespace ExerciciosPooCsharp.ConstrutoresThisSobrecargaEncaps.Ex002
{
    internal class ContaBancaria
    {
        public int NumeroConta {  get; private set; } // Número da conta (não pode ser alterado)
        public string Titular { get; set; } // Nome do titular (pode ser alterado)
        public double Saldo { get; private set; } // Saldo (controlado, só pode ser alterado por depósito ou saque)

        //Construtor
        //2 parametros
        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;  
        }
        //3 parametros
        public ContaBancaria(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            Saldo = saldo;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta 
                + ", Titular: " 
                + Titular 
                + ", Saldo: " 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        
        /*
        // Método para realizar depósitos
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        // Método para realizar saques (com taxa de $5.00)
        public void Sacar(double valor)
        {
            double valorComTaxa = valor + 5.0; // Considerando a taxa de saque
            if (Saldo >= valorComTaxa)
            {
                Saldo -= valorComTaxa;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque com a taxa.");
            }
        }

        // Método para mostrar os dados da conta
        public void MostrarDados()
        {
            Console.WriteLine($"Conta {NumeroConta}, Titular: {Titular}, Saldo: $ {Saldo:F2}");
        }*/

    }
}
