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
    public partial class Lab2Task3 : Form
    {
        public Lab2Task3()
        {
            InitializeComponent();
        }

        private int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int n) && n >= 0)
            {
                int result = Fibonacci(n);
                lblResult.Text = $"Fibonacci({n}) = {result}";
            }
            else
            {
                lblResult.Text = "Please enter a valid non-negative number.";
            }
        }
    }
}
