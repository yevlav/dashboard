// Yevheniia Lavrova, 7.04.2021, Simple Calculator
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Dashboard
{
    public partial class SimpleCalc : Form
    {
        private SimpleCalc1 obj;
        private bool equalButton = false;
        public SimpleCalc()
        {
            InitializeComponent();
        }

        public void Operation(string displayValue)
        {
            Calc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(Calc);
            textOut.Write(textBox1.Text);
            textOut.Close();
        }

        string dir = "";
        string filePath = @"C:\Text\Calculator.txt";
        FileStream Calc = null;

        private void button18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the Simple Calculator application?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void SimpleCalc_Load(object sender, EventArgs e)
        {
            obj = new SimpleCalc1();
            dir = @".\Text\";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        public class SimpleCalc1
        {
            private decimal operand1;
            private decimal operand2;
            private string op;
            private decimal currentValue;

            public decimal CurrentValue
            {
                get
                {
                    return currentValue;
                }
                set
                {
                    currentValue = value;
                }
            }
            public SimpleCalc1()
            {
            }

            public SimpleCalc1(decimal currentValue)
            {
                this.CurrentValue = currentValue;
            }

            public void Add(string displayValue)
            {
                operand1 = Convert.ToDecimal(displayValue);
                currentValue = operand1;
                op = "+";
            }

            public void Subtract(string displayValue)
            {
                operand1 = Convert.ToDecimal(displayValue);
                currentValue = operand1;
                op = "-";
            }

            public void Multiply(string displayValue)
            {
                operand1 = Convert.ToDecimal(displayValue);
                currentValue = operand1;
                op = "*";
            }

            public void Divide(string displayValue)
            {
                operand1 = Convert.ToDecimal(displayValue);
                currentValue = operand1;
                op = "/";
            }

            public void Equals(string displayValue)
            {
                operand2 = Convert.ToDecimal(displayValue);
                switch (op)
                {
                    case "+":
                        operand1 = operand1 + operand2; break;
                    case "-":
                        operand1 = operand1 - operand2; break;
                    case "*":
                        operand1 = operand1 * operand2; break;
                    case "/":
                        try
                        {
                            operand1 = operand1 / operand2;
                        }
                        catch
                        {
                            currentValue = 0;
                            operand1 = 0;
                            operand2 = 0;
                        } break;
                    default: break;
                }
                currentValue = operand1;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+")
            {
                textBox1.Text = "";
            }
            else if (textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            else if (textBox1.Text == "/")
            {
                textBox1.Text = "";
            }
            else if (textBox1.Text == "*")
            {
                textBox1.Text = "";
            }
            else if (equalButton)
            {
                equalButton = false;
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 1;
            Operation(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "/")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "*")
            {
                textBox1.Text = "";
            }
            if (equalButton)
            {
                equalButton = false;
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 2;
            Operation(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "/")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "*")
            {
                textBox1.Text = "";
            }
            if (equalButton)
            {
                equalButton = false;
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 3;
            Operation(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "/")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "*")
            {
                textBox1.Text = "";
            }
            if (equalButton)
            {
                equalButton = false;
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 4;
            Operation(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "/")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "*")
            {
                textBox1.Text = "";
            }
            if (equalButton)
            {
                equalButton = false;
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 5;
            Operation(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "/")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "*")
            {
                textBox1.Text = "";
            }
            if (equalButton)
            {
                equalButton = false;
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 6;
            Operation(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "/")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "*")
            {
                textBox1.Text = "";
            }
            if (equalButton)
            {
                equalButton = false;
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 7;
            Operation(textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "/")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "*")
            {
                textBox1.Text = "";
            }
            if (equalButton)
            {
                equalButton = false;
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 8;
            Operation(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "/")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "*")
            {
                textBox1.Text = "";
            }
            if (equalButton)
            {
                equalButton = false;
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 9;
            Operation(textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "/")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "*")
            {
                textBox1.Text = "";
            }
            if (equalButton)
            {
                equalButton = false;
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 0;
            Operation(textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            obj.Add(textBox1.Text);
            textBox1.Text = "+";
            textBox1.Focus();
            Operation(textBox1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            obj.Equals(textBox1.Text);
            textBox1.Text = obj.CurrentValue.ToString();
            obj.CurrentValue = 0;
            equalButton = true;

            try
            {
                Calc = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(Calc);
                textOut.WriteLine("=" + textBox1.Text + ", " + DateTime.Now.ToString());
                textOut.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(filePath + " not found.", "File Not Found");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            obj.Subtract(textBox1.Text);
            textBox1.Text = "-";
            textBox1.Focus();
            Operation(textBox1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            obj.Multiply(textBox1.Text);
            textBox1.Text = "*";
            textBox1.Focus();
            Operation(textBox1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            obj.Divide(textBox1.Text);
            textBox1.Text = "/";
            textBox1.Focus();
            Operation(textBox1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "/")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "*")
            {
                textBox1.Text = "";
            }
            if (equalButton)
            {
                equalButton = false;
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + ".";
            Operation(textBox1.Text);
        }
    }
}
