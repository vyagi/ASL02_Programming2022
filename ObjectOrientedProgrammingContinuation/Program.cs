//var n = new A();
//n.Method();

//var m = new B();
//m.Method();
//m.NewMethod();

//var q = new C();
//q.Method();
//q.NewMethod();

//above - some example for technical aspects of inheritance

public class Program
{
    public static void Main(string[] args)
    {
        var c1 = new Car("Ford Mondeo");
        var c2 = new Car("Opel Astra");
        var c3 = new Car("Mercedes E200");
        var c4 = new Car("Tesla");

        //Car.CarsCreated = 100; // no longer possible
        Console.WriteLine(Car.CarsCreated);
    }

    public static void InterfacesDemo()
    {
        var x = new ElectricalCar();
        x.Drive();
        Console.WriteLine(x.IsCharged());

        var processor = new InvoiceProcessor(new FileLinesProvider());
        var groupByCategory = processor.GroupByCategory();

        var processorTest = new InvoiceProcessor(new MockLinesProvider());
        var byCategory = processorTest.GroupByCategory();
    }

    public static void InheritanceDemo(string[] args)
    {
        var s = new Square(5);
        var t = new Triangle(3, 4, 5);
        var r = new Rectangle(5, 6);
        var c = new Circle(3);

        Console.WriteLine($"The area is {s.Area()} and the perimeter is {s.Perimeter()}");
        Console.WriteLine($"The area is {t.Area()} and the perimeter is {t.Perimeter()}");
        Console.WriteLine($"The area is {r.Area()} and the perimeter is {r.Perimeter()}");
        Console.WriteLine($"The area is {c.Area()} and the perimeter is {c.Perimeter()}");

        DisplayArea(s);
        DisplayArea(t);
        DisplayArea(r);
        DisplayArea(c);

        //no longer possible, because Shape became abstract
        //var x = new Shape();
        //DisplayArea(x);
    }

    public static void DisplayArea(Shape shape)
    {
        Console.WriteLine($"The area is {shape.Area()} and the perimeter is {shape.Perimeter()}");
    }
}