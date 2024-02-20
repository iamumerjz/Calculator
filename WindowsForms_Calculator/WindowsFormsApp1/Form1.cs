using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class lab : Form
    {
        double num1;
        string Operation;
        public lab()
        {
            InitializeComponent();
        }

        private void lab_Load(object sender, EventArgs e)
        {

        }


        private void resultbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "1";
            }

            else
            {
                resultBox.Text = resultBox.Text + "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "2";
            }

            else
            {
                resultBox.Text = resultBox.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "3";
            }

            else
            {
                resultBox.Text = resultBox.Text + "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "4";
            }

            else
            {
                resultBox.Text = resultBox.Text + "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "5";
            }

            else
            {
                resultBox.Text = resultBox.Text + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "6";
            }

            else
            {
                resultBox.Text = resultBox.Text + "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "7";
            }

            else
            {
                resultBox.Text = resultBox.Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "8";
            }

            else
            {
                resultBox.Text = resultBox.Text + "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "9";
            }

            else
            {
                resultBox.Text = resultBox.Text + "9";
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //clear
        {
            resultBox.Text = "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(resultBox.Text);
            resultBox.Text = "";
            Operation = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(resultBox.Text);
            resultBox.Text = "";
            Operation = "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(resultBox.Text);
            resultBox.Text = "";
            Operation = "*";
        }

        private void divide_Click_1(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(resultBox.Text);
            resultBox.Text = "";
            Operation = "/";
        }


        private void equal_Click(object sender, EventArgs e)
        {
            double num2;
            double Result;

            num2 = Convert.ToDouble(resultBox.Text);

            if (Operation == "+")
            {
                Result = (num1 + num2);
                resultBox.Text = Convert.ToString(Result);
                num1 = Result;
            }

            if (Operation == "-")
            {
                Result = (num1 - num2);
                resultBox.Text = Convert.ToString(Result);
                num1 = Result;
            }

            if (Operation == "*")
            {
                Result = (num1 * num2);
                resultBox.Text = Convert.ToString(Result);
                num1 = Result;
            }

            if (Operation == "/")
            {
                if (num2 != 0)
                {
                    Result = (num1 / num2);
                    resultBox.Text = Convert.ToString(Result);
                    num1 = Result;
                }
                else
                {
                    resultBox.Text = "Error";
                }
            }

        }

    }
}
