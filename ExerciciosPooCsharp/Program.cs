using ExerciciosPooCsharp._3ComportamentoMemoriaArraysListas.Ex001;
using ExerciciosPooCsharp._3ComportamentoMemoriaArraysListas.Ex002;
using ExerciciosPooCsharp._3ComportamentoMemoriaArraysListas.Ex003;
using ExerciciosPooCsharp._4TopicosEspeciaisC_Parte1;
using ExerciciosPooCsharp._5EnumeracaoComposicao.Ex001;
using ExerciciosPooCsharp._5EnumeracaoComposicao.Ex002;
using ExerciciosPooCsharp._5EnumeracaoComposicao.Ex003;
using ExerciciosPooCsharp._6HerancaPolimorfismo.Ex001;
using ExerciciosPooCsharp._6HerancaPolimorfismo.Ex002;
using ExerciciosPooCsharp._6HerancaPolimorfismo.Ex003;
using ExerciciosPooCsharp._6HerancaPolimorfismo.Ex004;
using ExerciciosPooCsharp._7TratamentoExcecoes.Ex001;
using ExerciciosPooCsharp._7TratamentoExcecoes.Ex002;
using ExerciciosPooCsharp._9Interfaces.Ex001;
using ExerciciosPooCsharp._9Interfaces.Ex002;
using ExerciciosPooCsharp.AGenericsSetDictionary.Ex001;
using ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex003;
using ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex004;
using ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex005;
using ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex006;
using ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex007;
using ExerciciosPooCsharp.ConstrutoresThisSobrecargaEncaps.Ex002;
using System;
using System.Collections.Generic;
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
        Console.WriteLine("9 - Conta bancaria (ESPECIAL)");
        Console.WriteLine("10 - Estudante Aluguel");
        Console.WriteLine("11 - Listas - Employees");
        Console.WriteLine("12 - Matrix");
        Console.WriteLine("13 - Tópicos especiais em C# Parte 1");
        Console.WriteLine("14 - Contrato de trabalhador");
        Console.WriteLine("15 - Post de comentários");
        Console.WriteLine("16 - Pedido de cliente");
        Console.WriteLine("17 - Funcionarios Pagamentos");
        Console.WriteLine("18 - Produtos faturados");
        Console.WriteLine("19 - Areas circle e rectangle");
        Console.WriteLine("20 - Imposto empresa e individuo");
        Console.WriteLine("21 - Tratando exceção");
        Console.WriteLine("22 - Processo conta com exceção");
        Console.WriteLine("24 - Aluguel de carro (Avanç.)");
        Console.WriteLine("25 - Promissorias mensais com Juros");
        Console.WriteLine("26 - Print Service");

        Console.Write("\nEscolha: ");
        Console.WriteLine();

        int op = int.Parse(Console.ReadLine());

        // Limpar o terminal após a escolha
        Console.Clear();

        // Dicionário de opções e seus respectivos métodos
        var options = new Dictionary<int, Action>
        {
            { 1, Ex01_Retangulo.Executar },
            { 2, PessoaMaisVelha.Executar },
            { 3, FuncionarioSalario.Executar },
            { 4, Ex001_Conta.Executar },
            { 5, ProdutoAltera.Executar },
            { 6, FuncionarioSalario1.Executar },
            { 7, NotaAprovacao.Executar },
            { 8, ConversorDeMoeda.Executar },
            { 9, Banco.Executar },
            { 10, EstudentAluguel.Executar },
            { 11, EmployeeList.Executar },
            { 12, Matrix.Executar },
            { 13, Topicos.Executar },
            { 14, Programa.Executar },
            { 15, Program2.Executar },
            { 16, Program3.Executar },
            { 17, Programm.Executar },
            { 18, Programm2.Executar },
            { 19, Programm3.Executar },
            { 20, Programm4.Executar },
            { 21, Program71.Executar  },
            { 22, Program72.Executar },
            { 24, Program_9.Executar },
            { 25, Program9_2.Executar },
            { 26, Problem001.Executar }


        };

        // Verificar se a opção escolhida existe no dicionário e executar
        if (options.ContainsKey(op))
        {
            options[op]();
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }
}