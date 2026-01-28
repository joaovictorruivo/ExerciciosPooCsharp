using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using ExerciciosPooCsharp._9Interfaces.Ex001.Entites;
using ExerciciosPooCsharp._9Interfaces.Ex001.Services;

namespace ExerciciosPooCsharp._9Interfaces.Ex001
{
    internal class Program_9
    {
        public static void Executar()
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price por hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price por day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("\nINVOICE: ");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
