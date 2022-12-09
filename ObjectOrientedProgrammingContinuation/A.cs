public class A
{
    protected void PrivateMethod()
    {
        Console.WriteLine("A protected (formely private) method has been called");
    }

    public void Method()
    {
        PrivateMethod();
        Console.WriteLine("A method has been called");
    }
}