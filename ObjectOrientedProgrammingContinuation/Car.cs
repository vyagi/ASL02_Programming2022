public class Car
{
    private readonly string _brand;

    public static int CarsCreated { get; private set; }

    public Car(string brand)
    {
        CarsCreated++;
        _brand = brand;
    }
}