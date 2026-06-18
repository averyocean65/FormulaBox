using System.Text.RegularExpressions;

namespace FormulaBox
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sampleButton_Click(object sender, EventArgs e)
        {
            string[] variables = Regex
                .Split(formulaBox.Text, "[^a-zA-Z]+")
                .Where(x => !string.IsNullOrEmpty(x))
                .ToArray();

            string output = "[\n";
            foreach(string variable in variables)
            {
                output += $"{{{variable}}},\n";
            }
            output += "]";

            MessageBox.Show(output);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO");
        }
    }
}
