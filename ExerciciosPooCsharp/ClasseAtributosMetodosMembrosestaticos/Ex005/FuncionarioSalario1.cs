using System;
using System.ComponentModel;
using System.Globalization;
//Fazer um programa para ler os dados de um funcionário (nome,
//salário bruto e imposto). Em seguida, mostrar os dados do
//funcionário (nome e salário líquido). Em seguida, aumentar o salário
//do funcionário com base em uma porcentagem dada (somente o
//salário bruto é afetado pela porcentagem) e mostrar novamente os
//dados do funcionário

//Nome: Joao Silva
//Salário bruto: 6000.00
//Imposto: 1000.00
//Funcionário: Joao Silva, $ 5000.00
//Digite a porcentagem para aumentar o salário: 10.0
//Dados atualizados: Joao Silva, $ 5600.00

namespace ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex005
{
    internal class FuncionarioSalario1
    {
        public static void Executar()
        {
            Funcionario1 func = new Funcionario1();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nFuncionário: " + func);
                  
            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double aumSalPorCent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(aumSalPorCent);
            Console.WriteLine("\nDados atualizados: " + func);



        }
    }
}
