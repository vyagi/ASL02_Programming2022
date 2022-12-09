public class Circle : Shape
{
    private readonly double _radius;

    public Circle(double radius) => _radius = radius;

    public override double Area() => Math.PI * _radius * _radius;

    public override double Perimeter() => 2 * Math.PI * _radius;
}