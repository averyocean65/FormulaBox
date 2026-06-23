using System.Text.RegularExpressions;

namespace FormulaBox
{
    public partial class MainWindow : Form
    {
        private const int FormulaRecursionLimit = 5;
        private const string FormulaRegEx = "[^a-zA-Z]+";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sampleButton_Click(object sender, EventArgs e)
        {
            variableList.Controls.Clear();

            IEnumerable<string> variables = Regex
                .Split(formulaBox.Text, FormulaRegEx)
                .Where(x => !string.IsNullOrEmpty(x))
                .Distinct();

            foreach(string variable in variables)
            {
                Variable control = new Variable(variable);
                control.AutoSize = true;
                control.Width = variableList.Width;

                variableList.Controls.Add(control);
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string ReplaceFormulaChunk(string input, int index, string original, string value)
            {
                string output = input.Substring(0, index) + value;

                int continueIndex = index + original.Length;
                if(continueIndex < input.Length)
                {
                    output += input.Substring(continueIndex);
                }

                // MessageBox.Show("intermediate out: " + output);
                return output;
            }

            string filledFormula = formulaBox.Text;
            for(int i = 0; i < FormulaRecursionLimit; i++)
            {
                foreach (Control control in variableList.Controls)
                {
                    if (control is not Variable v)
                    {
                        continue;
                    }

                    int index = filledFormula.IndexOf(v.Title);
                    if(index < 0)
                    {
                        continue;
                    }

                    if(index < 1)
                    {
                        filledFormula = ReplaceFormulaChunk(filledFormula, index, v.Title, v.Value);
                        continue;
                    }

                    char before = filledFormula[index - 1];
                    string value = v.Value;
                    if(char.IsLetterOrDigit(before))
                    {
                        value = "*" + value;
                    }

                    filledFormula = ReplaceFormulaChunk(filledFormula, index, v.Title, value);
                }
            }

            MessageBox.Show(filledFormula);
        }
    }
}
