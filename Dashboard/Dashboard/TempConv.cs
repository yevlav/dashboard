// Yevheniia Lavrova, 7.04.2021, Temperature Converter
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace Dashboard
{
    public partial class TempConv : Form
    {

        public TempConv()
        {
            InitializeComponent();
        }

        TempConv1 obj;

        string dir = "";
        string filePath = @"C:\Text\TempConversions.txt";
        FileStream temp = null;

        public class TempConv1
        {
            private double c;
            private double f;

            public double C
            {
                get
                {
                    return c;
                }
                set
                {
                    c = value;
                }
            }

            public double F
            {
                get
                {
                    return f;
                }
                set
                {
                    f = value;
                }
            }

            public TempConv1() { }

            public TempConv1(double C, double F)
            {
                this.C = c;
                this.F = f;
            }
            public double CtoF()
            {
                return (C * 9 / 5) + 32;
            }
            public double FtoC()
            {
                return (F - 32) * 5 / 9;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(temp);
            try
            {
                obj.C = Convert.ToDouble(textBox1.Text);

                if (radioButton1.Checked == true)
                {
                    double num1 = obj.CtoF();
                    textBox2.Text = num1.ToString();
                    textOut.Write("\n" + textBox1.Text + " C = ");
                    textOut.WriteLine(textBox2.Text + " F, " + DateTime.Now.ToString());
                    textOut.Close();

                    if (obj.C == 100)
                    {
                        textBox3.Text = "Water boils";
                    }
                    else if (obj.C == 40)
                    {
                        textBox3.Text = "Hot Bath";
                    }
                    else if (obj.C == 37)
                    {
                        textBox3.Text = "Body temperature";
                    }
                    else if (obj.C == 30)
                    {
                        textBox3.Text = "Beach weather";
                    }
                    else if (obj.C == 21)
                    {
                        textBox3.Text = "Room temperature";
                    }
                    else if (obj.C == 10)
                    {
                        textBox3.Text = "Cool day";
                    }
                    else if (obj.C == 0)
                    {
                        textBox3.Text = "Freezing point of water";
                    }
                    else if (obj.C == -18)
                    {
                        textBox3.Text = "Very Cold Day";
                    }
                    else if (obj.C == -40)
                    {
                        textBox3.Text = "Extremely Cold Day \n (and the same number!)";
                    }
                    else
                    {
                        textBox3.Text = "";
                    }
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
                textBox1.Focus();
            }

            try
            {
                obj.F = Convert.ToDouble(textBox1.Text);
                if (radioButton2.Checked == true)
                {
                    double num1 = obj.FtoC();
                    textBox2.Text = num1.ToString();
                    textOut.Write("\n" + textBox1.Text + " F = ");
                    textOut.WriteLine(textBox2.Text + " C, " + DateTime.Now.ToString());
                    textOut.Close();

                    if (obj.F == 212)
                    {
                        textBox3.Text = "Water boils";
                    }
                    else if (obj.F == 104)
                    {
                        textBox3.Text = "Hot Bath";
                    }
                    else if (obj.F == 98.6)
                    {
                        textBox3.Text = "Body temperature";
                    }
                    else if (obj.F == 86)
                    {
                        textBox3.Text = "Beach weather";
                    }
                    else if (obj.F == 70)
                    {
                        textBox3.Text = "Room temperature";
                    }
                    else if (obj.F == 50)
                    {
                        textBox3.Text = "Cool day";
                    }
                    else if (obj.F == 32)
                    {
                        textBox3.Text = "Freezing point of water";
                    }
                    else if (obj.F == 0)
                    {
                        textBox3.Text = "Very Cold Day";
                    }
                    else if (obj.F == -40)
                    {
                        textBox3.Text = "Extremely Cold Day \n (and the same number!)";
                    }
                    else
                    {
                        textBox3.Text = "";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number");
            }
        }

        private void TempConv_Load(object sender, EventArgs e)
        {
            obj = new TempConv1();
            dir = @".\Text\";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the Temperature Converter application?", "Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(temp);
            int tempo = 0;
            string Output = "\n";
            string string1, string2;

            while (textIn.Peek() != -1)
            {
                string1 = textIn.ReadLine();
                string2 = textIn.ReadLine();
                Output += string1 + " " + string2 + "\n";
                tempo++;

                if (tempo == 100)
                {
                    MessageBox.Show(Output);
                    tempo = 0;
                    Output = "";
                }
            }
            if (tempo != 0)
                MessageBox.Show(Output);
            textIn.Close();
        }
    }
}
