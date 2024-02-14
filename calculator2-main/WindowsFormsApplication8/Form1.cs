using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            private void NumButton_Click(object sender, EventArgs e)
            {
                Button button = (Button)sender;
                textBox1.Text += button.Text;
            }

            private void OperatorButton_Click(object sender, EventArgs e)
            {
                Button button = (Button)sender;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
                textBox1.Tag = button.Text;
            }

            private void EqualsButton_Click(object sender, EventArgs e)
            {
                double operand1 = Convert.ToDouble(textBox1.Tag);
                double operand2 = Convert.ToDouble(textBox1.Text);
                double result = 0;

                switch (textBox1.Tag.ToString())
                {
                    case "+":
                        result = operand1 + operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "*":
                        result = operand1 * operand2;
                        break;
                    case "/":
                        result = operand1 / operand2;
                        break;
                }

                textBox1.Text = result.ToString();
            }

            private void ClearButton_Click(object sender, EventArgs e)
            {
                textBox1.Text = "";
                textBox1.Tag = null;
            }
        }
    }