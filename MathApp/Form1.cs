using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class mathsApp : Form
    {
        public mathsApp()
        {
            InitializeComponent();
            resultTextbox.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float result;
            firstNumber = Convert.ToInt32(firstNumberTextbox.Text);
            secondNumber = Convert.ToInt32(secondNumberTextbox.Text);
            result = firstNumber + secondNumber;
            resultTextbox.Text = (result.ToString());
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float result;
            firstNumber = Convert.ToInt32(firstNumberTextbox.Text);
            secondNumber = Convert.ToInt32(secondNumberTextbox.Text);
            result = firstNumber - secondNumber;
            resultTextbox.Text = (result.ToString());
        }

        private void diviteButton_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float result;
            firstNumber = Convert.ToInt32(firstNumberTextbox.Text);
            secondNumber = Convert.ToInt32(secondNumberTextbox.Text);
            result = firstNumber / secondNumber;
            resultTextbox.Text = (result.ToString());
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float result;
            firstNumber = Convert.ToInt32(firstNumberTextbox.Text);
            secondNumber = Convert.ToInt32(secondNumberTextbox.Text);
            result = firstNumber * secondNumber;
            resultTextbox.Text = (result.ToString());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumberTextbox.Text = "";
            secondNumberTextbox.Text = "";
            resultTextbox.Text = "";
        }
    }
}
