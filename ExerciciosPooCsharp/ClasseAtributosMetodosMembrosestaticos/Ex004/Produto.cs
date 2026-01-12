using System;
using System.Globalization;

//ToString converte o objeto para string. Escrever override + ToString para completar.

namespace ExerciciosPooCsharp.ClasseAtributosMetodosMembrosestaticos.Ex004
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        //void = vazio(não retorna valor)
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        //void = vazio(não retorna valor)
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + "unidades, Total: $ " + ValorTotalEmEstoque();
        }

        
    }
}
