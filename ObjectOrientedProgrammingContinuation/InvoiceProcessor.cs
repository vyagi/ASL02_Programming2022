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