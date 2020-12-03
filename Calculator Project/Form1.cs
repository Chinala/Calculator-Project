using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        double SecondNumber;
        double EndResult;


        public Form1()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null) // If text box = 0 and if the two operands are different it produces a 1 as shown on the next line.
            {
                textBox2.Text = "1"; //produces 1 on textbox if the statement above is true.
            }
            else // if there is 1 other operand other than 0, it produces another 1 alongside the previous number inputted.
            {
                textBox2.Text = textBox2.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "1";
            }
            else
            {
                textBox2.Text = textBox2.Text + 2;
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "3";
            }
            else
            {
                textBox2.Text = textBox2.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "4";
            }
            else
            {
                textBox2.Text = textBox2.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "5";
            }
            else
            {
                textBox2.Text = textBox2.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "6";
            }
            else
            {
                textBox2.Text = textBox2.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "7";
            }
            else
            {
                textBox2.Text = textBox2.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "8";
            }
            else
            {
                textBox2.Text = textBox2.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "9" && textBox2.Text != null)
            {
                textBox2.Text = "9";
            }
            else
            {
                textBox2.Text = textBox2.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "0";
            }
            else
            {
                textBox2.Text = textBox2.Text + "0";
            }
        }

        private void bc_Click(object sender, EventArgs e) // Erases all inputs, operations and numerical values.
        {
            textBox2.Text = "0";
            FirstNumber = 0;
            SecondNumber = 0;
            EndResult = 0;
            Operation = "0";
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }
        
        private void butadd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "0";
            Operation = "+";
        }

        private void buteq_Click(object sender, EventArgs e) // bug if "=" is clicked it will sqrt the previous input.
        {
            SecondNumber = Convert.ToDouble(textBox2.Text);

            if (Operation == "+") // if the operation is addition, the result will be the 1st number inputted + the 2nd number the result would end in a string.
            {
                EndResult = (FirstNumber + SecondNumber);
                textBox2.Text = Convert.ToString(EndResult);
                FirstNumber = EndResult;
            }
        }

    }
}