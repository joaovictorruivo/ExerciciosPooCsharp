class ContaBancaria
{
    public int Numero;
    public string Titular;
    public double Saldo;

    // Construtor
    public ContaBancaria(int numero, string titular, double saldoInicial)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        Saldo -= valor;
    }
}