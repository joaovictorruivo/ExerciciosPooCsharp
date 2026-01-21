using ExerciciosPooCsharp._5EnumeracaoComposicao.Ex003.Entites.Enums;
using System;
using System.Globalization;
using System.Text;

namespace ExerciciosPooCsharp._5EnumeracaoComposicao.Ex003.Entites
{
    internal class Order03
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client03 Client { get; set; }
        public List<OrderItem03> Items { get; set; } = new List<OrderItem03>();

        public Order03()
        {
        }

        public Order03(DateTime moment, OrderStatus status, Client03 client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem03 item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem03 item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem03 item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem03 item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
