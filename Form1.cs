using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number, number2, result = 0;
        char click;
           
        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += button1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += button3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += button4.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += button5.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += button6.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += button7.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += button8.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += button9.Text;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            
            textBox.Text += button0.Text;
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            number = 0;
            number2 = 0;
            result = 0;
            click = ' ';
        }
        private void buttonAction_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            number = double.Parse(textBox.Text);
            click = button.Text[0];
            textBox.Clear();
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (click)
            {
                case '+':
                    {
                        number2 = double.Parse(textBox.Text);
                        result = number + number2;
                        break;
                    }
                case '-':
                    {
                        number2 = double.Parse(textBox.Text);
                        result = number - number2;
                        break;
                    }
                case '*':
                    {
                        number2 = double.Parse(textBox.Text);
                        result = number * number2;
                        break;
                    }
                case '/':
                    {
                        number2 = double.Parse(textBox.Text);
                        result = number / number2;
                        break;
                    }
                case '^':
                    {
                        number2 = double.Parse(textBox.Text);
                        result = Math.Pow(number, number2);
                        break;
                    }
                case 's':
                    {
                        result = (Math.Sqrt(number));
                        break;
                    }
            }
            textBox.Text = result.ToString();
        }
    }
}
