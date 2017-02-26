using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace CalculatorUI
{
    public partial class Form1 : Form
    {
        ServiceReference1.CalculatorClient Math;
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Result.Text = Math.Add(Convert.ToDouble(FirstNumber.Text), Convert.ToDouble(SecondNumber.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Math = new ServiceReference1.CalculatorClient();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            Result.Text = Math.Subtract(Convert.ToDouble(FirstNumber.Text), Convert.ToDouble(SecondNumber.Text)).ToString();
        }

        private void MultButton_Click(object sender, EventArgs e)
        {
            Result.Text = Math.Multiply(Convert.ToDouble(FirstNumber.Text), Convert.ToDouble(SecondNumber.Text)).ToString();
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            Result.Text = Math.Divide(Convert.ToDouble(FirstNumber.Text), Convert.ToDouble(SecondNumber.Text)).ToString();
        }
    }
}
