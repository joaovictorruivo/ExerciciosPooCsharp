using System;
using System.Globalization;
namespace ExerciciosPooCsharp._5EnumeracaoComposicao.Ex003.Entites
{
    internal class OrderItem03
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product03 Product { get; set; }


        public OrderItem03()
        {
        }

        public OrderItem03(int quantity, double price, Product03 product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
