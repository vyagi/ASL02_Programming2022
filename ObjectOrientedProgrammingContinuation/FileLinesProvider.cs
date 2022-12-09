public class FileLinesProvider : IInvoiceLinesProvider
{
    public string[] GetLines() => 
        File.ReadAllLines("C:\\Users\\Marcin\\Desktop\\Invoices.txt").Skip(1).ToArray();
}