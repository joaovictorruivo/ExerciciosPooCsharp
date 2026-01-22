using ExerciciosPooCsharp._6HerancaPolimorfismo.Ex003.Entites.Enum;

namespace ExerciciosPooCsharp._6HerancaPolimorfismo.Ex003.Entites
{
    internal class Rectangle : Shape
    {
        public double Widht {  get; set; }
        public double Height { get; set; }

        public Rectangle(double widht, double height, Color color) 
            : base(color) 
        {
            Widht = widht;
            Height = height;
        }
        
        public override double Area()
        {
            return Widht * Height;
        }
    }
}
