using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssemblyyy;

namespace BasicCalculator
{
    public partial class frmBasicCalculator : Form
    {
        public frmBasicCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            float num1 = Convert.ToInt32(textBox1.Text);
            float num2 = Convert.ToInt32(textBox1.Text);

            BasicComputation compute = new BasicComputation();
            
            if (comboBox1.SelectedItem.Equals("+"))
            {
                total.Text = compute.addition(num1, num2).ToString();
            }
            else if (comboBox1.SelectedItem.Equals("-"))
            {
                total.Text = compute.subtraction(num1, num2).ToString();
            }
            else if (comboBox1.SelectedItem.Equals("*"))
            {
                total.Text = compute.multiplication(num1, num2).ToString();
            }
            else if (comboBox1.SelectedItem.Equals("/"))
            {
                total.Text = compute.division(num1, num2).ToString();
            }
        }
    }
}
