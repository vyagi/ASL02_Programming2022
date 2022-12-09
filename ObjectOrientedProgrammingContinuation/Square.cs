public class Square : Shape
{
    private readonly double _side;

    public Square(double side) => _side = side;

    public override double Area() => _side * _side;

    public override double Perimeter() => 4 * _side;
}