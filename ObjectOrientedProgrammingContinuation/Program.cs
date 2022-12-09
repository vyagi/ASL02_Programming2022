//var n = new A();
//n.Method();

//var m = new B();
//m.Method();
//m.NewMethod();

//var q = new C();
//q.Method();
//q.NewMethod();

//above - some example for technical aspects of inheritance

public interface IInvoiceLinesProvider
{
    string[] GetLines();
}

public class FileLinesProvider : IInvoiceLinesProvider
{
    public string[] GetLines() => 
        File.ReadAllLines("C:\\Users\\Marcin\\Desktop\\Invoices.txt").Skip(1).ToArray();
}

public class MockLinesProvider : IInvoiceLinesProvider
{
    public string[] GetLines() =>
        new string[]
        {
            "Bread;Food;100;2022-11-25",
            "Trousers;Clothing;300.50;2022-10-1",
            "Beer;Food;250;2022-11-24"
        };
}

public class InvoiceProcessor
{
    private readonly IInvoiceLinesProvider _invoiceLinesProvider;

    public InvoiceProcessor(IInvoiceLinesProvider invoiceLinesProvider) => 
        _invoiceLinesProvider = invoiceLinesProvider;

    public Dictionary<string, decimal> GroupByCategory()
    {
        var lines = _invoiceLinesProvider.GetLines();

        var dictionary = new Dictionary<string, decimal>();

        for (var i = 1; i < lines.Length; i++)
        {
            var line = lines[i];
            var split = line.Split(";");

            var category = split[1];
            var amount = Convert.ToDecimal(split[2].Replace(".", ","));

            if (dictionary.ContainsKey(category))
            {
                dictionary[category] += amount;
            }
            else
            {
                dictionary[category] = amount;
            }
        }

        return dictionary;
    }
}


public class Program
{
    public static void Main(string[] args)
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