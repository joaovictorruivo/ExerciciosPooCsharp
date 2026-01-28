using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using ExerciciosPooCsharp._9Interfaces.Ex001.Entites;

namespace ExerciciosPooCsharp._9Interfaces.Ex001
{
    internal class Program_9
    {
        public static void Executar()
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));





        }
    }
}
