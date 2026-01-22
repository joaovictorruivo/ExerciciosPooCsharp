using ExerciciosPooCsharp._6HerancaPolimorfismo.Ex003.Entites.Enum;
namespace ExerciciosPooCsharp._6HerancaPolimorfismo.Ex003.Entites
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
