namespace ExerciciosPooCsharp._9Interfaces.Ex002.Service
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
