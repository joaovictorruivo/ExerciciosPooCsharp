using ExerciciosPooCsharp._6HerancaPolimorfismo.Ex003.Entites.Enum;

namespace ExerciciosPooCsharp._6HerancaPolimorfismo.Ex003.Entites
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
