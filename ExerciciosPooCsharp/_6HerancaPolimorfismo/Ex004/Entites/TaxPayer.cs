using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPooCsharp._6HerancaPolimorfismo.Ex004.Entites
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
