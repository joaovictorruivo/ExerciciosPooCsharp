using ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex003;
using ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex004;
using ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex005;
using ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex006;
using ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex007;
using System;
//Este é um arquivo principal com o metodo main (unico ponto de entrada), onde escolhemos um exercíco para Rodar.
//
class Program
{
        static void Main(string[] args)
    {
        Console.WriteLine("=== Exercícios de POO em C# ===");
        Console.WriteLine("1 - Retângulo");
        Console.WriteLine("2 - Pessoa Mais velha");
        Console.WriteLine("3 - Funcionario Salario");
        Console.WriteLine("4 - Conta Bancaria(Construtor)");
        Console.WriteLine("5 - Produto Altera");
        Console.WriteLine("6 - Funcionario Salario Imposto");
        Console.WriteLine("7 - Nota de Aprovação");
        Console.WriteLine("8 - Conversor de Moedas");

        Console.Write("Escolha: ");
        int op = int.Parse(Console.ReadLine());

        if (op == 1)
        {
            Ex01_Retangulo.Executar();
        }
        else if (op == 2)
        {
            PessoaMaisVelha.Executar();
        }
        else if (op == 3)
        {
            FuncionarioSalario.Executar();
        }
        else if (op == 4)
        {
            Ex001_Conta.Executar();
        }
        else if (op == 5)
        {
            ProdutoAltera.Executar();
        }

        else if (op == 6)
        {
            FuncionarioSalario1.Executar();
        }

        else if (op == 7)
        {
            NotaAprovacao.Executar();
        }
        else if (op == 8)
        {
            ConversorDeMoeda.Executar();
        }
    }
}