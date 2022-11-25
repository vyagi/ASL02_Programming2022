namespace InvoiceAppliaction
{
    public partial class InvoiceAppForm : Form
    {
        public InvoiceAppForm()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            var (lines, success) = ReadFile(pathTextBox.Text);

            if (!success)
            {
                MessageBox.Show("File does not exist or is not accesible");
                return;
            }

            Display(ParseLines(lines));
        }
        
        private void categoryButton_Click(object sender, EventArgs e)
        {
            var (lines, success) = ReadFile(pathTextBox.Text);

            if (!success)
            {
                MessageBox.Show("File does not exist or is not accesible");
                return;
            }
            
            var dictionary = GroupByCategory(lines);

            var linesToDisplay = ConvertToOutputLines(dictionary);

            Display(linesToDisplay);
        }

        private void monthButton_Click(object sender, EventArgs e)
        {
            //Home work
        }

        private (string[] Lines, bool Success) ReadFile(string path)
        {
            try
            {
                return (File.ReadAllLines(path), true);
            }
            catch
            {
                return (Array.Empty<string>(), false);
            }
        }

        private string[] ParseLines(string[] lines)
        {
            var result = new List<string>();

            foreach (var line in lines)
            {
                result.Add(line.Replace(";", "\t"));
            }

            return result.ToArray();
        }

        private Dictionary<string, decimal> GroupByCategory(string[] lines)
        {
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
        
        private string[] ConvertToOutputLines(Dictionary<string, decimal> dictionary)
        {
            var result = new List<string>();

            result.Add("Category\tAmount");

            foreach (var entry in dictionary)
            {
                result.Add($"{entry.Key}\t{entry.Value}");
            }

            return result.ToArray();
        }

        private void Display(string[] lines)
        {
            outputTextBox.Clear();

            foreach (var line in lines)
            {
                outputTextBox.Text += $"{line}{Environment.NewLine}";
            }
        }
    }
}