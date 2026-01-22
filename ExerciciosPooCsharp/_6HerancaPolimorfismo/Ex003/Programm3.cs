using ExerciciosPooCsharp._6HerancaPolimorfismo.Ex003.Entites;
using ExerciciosPooCsharp._6HerancaPolimorfismo.Ex003.Entites.Enum;
using System.Globalization;
namespace ExerciciosPooCsharp._6HerancaPolimorfismo.Ex003

/*
Fazer um programa para ler os dados de N figuras (N fornecido
pelo usuário), e depois mostrar as áreas destas figuras na
mesma ordem em que foram digitadas.

Enter the number of shapes: 2
Shape #1 data:
Rectangle or Circle (r/c)? r
Color (Black/Blue/Red): Black
Width: 4.0
Height: 5.0
Shape #2 data:
Rectangle or Circle (r/c)? c
Color (Black/Blue/Red): Red
Radius: 3.0
SHAPE AREAS:
20.00
28.27
*/
{
    internal class Programm3
    {
        public static void Executar()
        {
            List<Shape> list = new List<Shape>();
            
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Widht: ");
                    double widht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(widht, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }

            }
            Console.WriteLine("\nShape areas:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }



        }
    }
}
