namespace ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex003;
using System;
using System.Globalization;
//Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
//médio dos funcionários.
//Exemplo:
//Dados do primeiro funcionário:
//Nome: Carlos Silva
//Salário: 6300.00
//Dados do segundo funcionário:
//Nome: Ana Marques
//Salário: 6700.00
//Salário médio = 6500.00

class FuncionarioSalario
{
    public static void Executar()
    {
        Funcionario f1 = new Funcionario();
        Funcionario f2 = new Funcionario();
        Console.WriteLine("Dados do primeiro funcionário:");
        Console.Write("Nome: ");
        f1.NomeFunc = Console.ReadLine();
        Console.Write("Salário: ");
        f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Dados do segundo funcionário:");
        Console.Write("Nome: ");
        f2.NomeFunc = Console.ReadLine();
        Console.Write("Salário: ");
        f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double media = (f1.Salario + f2.Salario) / 2.0;
        Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
}
