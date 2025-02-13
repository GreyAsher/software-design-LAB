using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Lab2Task32 : Form
    {
        public Lab2Task32()
        {
            InitializeComponent();
        }

        private double Power(double x, int n)
        {
            if (n == 0) return 1;
            if (n < 0) return 1 / Power(x, -n);
            return x * Power(x, n - 1);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double x) && int.TryParse(txtExponent.Text, out int n))
            {
                double result = Power(x, n);
                lblResult.Text = $"{x}^{n} = {result}";
            }
            else
            {
                lblResult.Text = "Please enter valid numbers.";
            }
        }
    }
}
