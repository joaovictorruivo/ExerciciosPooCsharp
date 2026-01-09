using System;

class Ex01_Retangulo
{
    public static void Executar()
    {
        Console.WriteLine("Executando exercício 1 - Retângulo");

        Console.Write("Largura: ");
        double largura = double.Parse(Console.ReadLine());

        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine());

        double area = largura * altura;
        double perimetro = 2 * (largura + altura);
        double diagonal = Math.Sqrt(largura * largura + altura * altura);

        Console.WriteLine("Área = " + area);
        Console.WriteLine("Perímetro = " + perimetro);
        Console.WriteLine("Diagonal = " + diagonal);
    }
}