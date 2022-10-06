using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4_AlekseiPant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double number, factorial;
            number = double.Parse(textBox1.Text);
            factorial = 1;
            if ( number <= 0)
            {
                string message = "Please, enter a positive number!";
                string title = "Error Window";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (number >= 1)
            {
                while (number > 1)
                {
                    factorial = factorial * number;
                    number = number - 1;
                }
                factorialNum.Text = "Factorial is " + factorial;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void factorialNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            factorialNum.Clear();
            textBox1.Clear();
        }
    }
}
