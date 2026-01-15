using System;

class Ex001_Conta
{
    public static void Executar()
    {
        Console.Write("Número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Titular: ");
        string titular = Console.ReadLine();

        Console.Write("Saldo inicial: ");
        double saldo = double.Parse(Console.ReadLine());

        ContaBancaria conta = new ContaBancaria(numero, titular, saldo);

        Console.WriteLine("Dados da conta:");
        Console.WriteLine("Número: " + conta.Numero);
        Console.WriteLine("Titular: " + conta.Titular);
        Console.WriteLine("Saldo: " + conta.Saldo);

        Console.Write("Valor para depósito: ");
        double dep = double.Parse(Console.ReadLine());
        conta.Depositar(dep);

        Console.WriteLine("Saldo atualizado: " + conta.Saldo);
    }
}