using System;
using System.Globalization;

namespace ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex006
{
    internal class NotaAprovacao
    {
        public static void Executar()
        {
            Aluno Aluno1 = new Aluno();
            
            Console.Write("Nome do aluno: ");
            Aluno1.Nome = (Console.ReadLine());
            Console.WriteLine("Digite as Três notas do aluno: ");
            Aluno1.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno1.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno1.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + Aluno1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (Aluno1.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + Aluno1.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }

        }
    }
}
