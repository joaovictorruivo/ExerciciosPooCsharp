using ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex003;
using System;
using System.Globalization;

namespace ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex005
{
    internal class Funcionario1
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double aumSalPorCent)
        {
            SalarioBruto = ((SalarioBruto * aumSalPorCent) / 100) + SalarioBruto;
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }


    }

    


}
