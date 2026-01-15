using System;
using System.Globalization;
//Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
//uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
//que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
//para ser responsável pelos cálculos.
//Exemplo:
//Qual é a cotação do dólar? 3.10
//Quantos dólares você vai comprar? 200.00
//Valor a ser pago em reais = 657.20

namespace ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex007
{
    internal class ConversorDeMoeda
    {
        public static void Executar()
        {

            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos Dólares você deseja comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = Cotacao.DolarParaReal(quantia,  cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
