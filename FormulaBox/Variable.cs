using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulaBox
{
    public partial class Variable : UserControl
    {
        public string Title => variableTitle.Text;
        public string Value => variableValue.Text;

        public Variable()
        {
            InitializeComponent();
        }

        public Variable(string name)
        {
            InitializeComponent();
            variableTitle.Text = name;
        }
    }
}
