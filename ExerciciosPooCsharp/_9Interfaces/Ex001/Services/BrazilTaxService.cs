namespace ExerciciosPooCsharp._9Interfaces.Ex001.Services
{
    internal class BrazilTaxService : ITaxService //agora é um subtipo de tax service
        //obs: não é herança é realização de interface.
    {
        public double Tax(double amount)
        {
            if (amount <= 100) {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }

        }
    }
}
