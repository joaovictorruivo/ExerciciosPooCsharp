using ExerciciosPooCsharp._9Interfaces.Ex001.Entites;

namespace ExerciciosPooCsharp._9Interfaces.Ex001.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {

        }
    }
}
