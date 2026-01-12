using ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex003;
using ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex004;
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


    }
}