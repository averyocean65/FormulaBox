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
                .Where(x => !string.IsNullOrEmpty(x));

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
            string filledFormula = formulaBox.Text;
            for(int i = 0; i < FormulaRecursionLimit; i++)
            {
                foreach (Control control in variableList.Controls)
                {
                    if (control is not Variable v)
                    {
                        continue;
                    }

                    filledFormula = filledFormula.Replace(v.Title, v.Value);
                }
            }

            MessageBox.Show(filledFormula);
        }
    }
}
