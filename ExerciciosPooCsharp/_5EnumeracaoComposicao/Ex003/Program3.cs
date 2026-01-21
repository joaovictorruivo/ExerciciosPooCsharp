using ExerciciosPooCsharp._5EnumeracaoComposicao.Ex003.Entites;
using ExerciciosPooCsharp._5EnumeracaoComposicao.Ex003.Entites.Enums;
using System;
using System.Globalization;
using System.Text;
/*Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um
sumário do pedido conforme exemplo (próxima página). Nota: o instante do pedido deve ser
o instante do sistema: DateTime.Now*/

/*Enter cliente data:
Name: Alex Green
Email: alex @gmail.com
Birth date (DD/MM/YYYY): 15 / 03 / 1985
Enter order data:
Status: Processing
How many items to this order? 2
Enter #1 item data:
Product name: TV
Product price: 1000.00
Quantity: 1
Enter #2 item data:
Product name: Mouse
Product price: 40.00
Quantity: 2
ORDER SUMMARY:
Order moment: 20 / 04 / 2018 11:25:09
Order status: Processing
Client: Alex Green(15/03/1985) -alex@gmail.com
Order items:
TV, $1000.00, Quantity: 1, Subtotal: $1000.00
Mouse, $40.00, Quantity: 2, Subtotal: $80.00
Total price: $1080.00*/



namespace ExerciciosPooCsharp._5EnumeracaoComposicao.Ex003
{
    internal class Program3
    {
        public static void Executar()
        {
            Console.WriteLine("Enter Cliente data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            String email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data");
            Console.Write("Status: ");

            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client03 client = new Client03(clientName, email, birthDate);
            Order03 order03 = new Order03(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product03 product = new Product03(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem03 orderItem = new OrderItem03(quantity, price, product);
                order03.AddItem(orderItem);

            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order03);



        }
    }
}
