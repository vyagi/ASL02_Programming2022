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