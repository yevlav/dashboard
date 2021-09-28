// Yevheniia Lavrova, 7.04.2021, Money Exchange
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
using System.Windows.Forms.VisualStyles;

namespace Dashboard
{
    public partial class MoneyEx : Form
    {
        public MoneyEx()
        {
            InitializeComponent();
        }
        string dir = "";
        string filePath = @"C:\Text\MoneyConversions.txt";
        FileStream MoneyExx = null;

        MoneyEx1 obj;

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the Money Exchange application?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoneyExx = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(MoneyExx);

            if (radioButton1.Checked == true) {
                try
                {
                    obj.Num = Convert.ToDouble(textBox1.Text);
                    if (radioButton9.Checked == true)
                    {
                        double num1 = obj.CADtoUSD();
                        textBox2.Text = num1.ToString();

                            textOut.Write(textBox1.Text + " CAD = ");
                            textOut.WriteLine(textBox2.Text + " USD" + ", " + DateTime.Now.ToString() + "\n");
                            textOut.Close();
                    }
                    else if (radioButton8.Checked == true)
                    {
                        double num1 = obj.CADtoEUR();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " CAD = ");
                        textOut.WriteLine(textBox2.Text + " EUR" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close();
                    }
                    else if (radioButton7.Checked == true)
                    {
                        double num1 = obj.CADtoGBP();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " CAD = ");
                        textOut.WriteLine(textBox2.Text + " GBP" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close(); 
                    }
                    else if (radioButton6.Checked == true)
                    {
                        double num1 = obj.CADtoRUB();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " CAD = ");
                        textOut.WriteLine(textBox2.Text + " RUB" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close(); 
                    }
                    else if (radioButton10.Checked == true)
                    {
                        MessageBox.Show("You can't convert the same currency", "Attention",
                        MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Focus();
                }
            }
            else if (radioButton2.Checked == true) {
                try
                {
                    obj.Num = Convert.ToDouble(textBox1.Text);
                    if (radioButton10.Checked == true)
                    {
                        double num1 = obj.USDtoCAD();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " USD = ");
                        textOut.WriteLine(textBox2.Text + " CAD" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close();
                    }
                    else if (radioButton8.Checked == true)
                    {
                        double num1 = obj.USDtoEUR();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " USD = ");
                        textOut.WriteLine(textBox2.Text + " EUR" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close();
                    }
                    else if (radioButton7.Checked == true)
                    {
                        double num1 = obj.USDtoGBP();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " USD = ");
                        textOut.WriteLine(textBox2.Text + " GBP" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close(); 
                    }
                    else if (radioButton6.Checked == true)
                    {
                        double num1 = obj.USDtoRUB();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " USD = ");
                        textOut.WriteLine(textBox2.Text + " RUB" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close();  
                    }
                    else if (radioButton9.Checked == true)
                    {
                        MessageBox.Show("You can't convert the same currency", "Attention",
                        MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Focus();
                }
            }
            else if (radioButton3.Checked == true)
            {
                try
                {
                    obj.Num = Convert.ToDouble(textBox1.Text);
                    if (radioButton10.Checked == true)
                    {
                        double num1 = obj.EURtoCAD();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " EUR = ");
                        textOut.WriteLine(textBox2.Text + " CAD" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close();  
                    }
                    else if (radioButton9.Checked == true)
                    {
                        double num1 = obj.EURtoUSD();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " EUR = ");
                        textOut.WriteLine(textBox2.Text + " USD" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close();
                    }
                    else if (radioButton7.Checked == true)
                    {
                        double num1 = obj.EURtoGBP();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " EUR = ");
                        textOut.WriteLine(textBox2.Text + " GBP" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close(); 
                    }
                    else if (radioButton6.Checked == true)
                    {
                        double num1 = obj.EURtoRUB();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " EUR = ");
                        textOut.WriteLine(textBox2.Text + " RUB" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close(); 
                    }
                    else if (radioButton8.Checked == true)
                    {
                        MessageBox.Show("You can't convert the same currency", "Attention",
                        MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Focus();
                }
            }
            else if (radioButton4.Checked == true)
            {
                try
                {
                    obj.Num = Convert.ToDouble(textBox1.Text);
                    if (radioButton10.Checked == true)
                    {
                        double num1 = obj.GBPtoCAD();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " GBP = ");
                        textOut.WriteLine(textBox2.Text + " CAD" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close();
                    }
                    else if (radioButton9.Checked == true)
                    {
                        double num1 = obj.GBPtoUSD();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " GBP = ");
                        textOut.WriteLine(textBox2.Text + " USD" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close(); 
                    }
                    else if (radioButton8.Checked == true)
                    {
                        double num1 = obj.GBPtoEUR();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " GBP = ");
                        textOut.WriteLine(textBox2.Text + " EUR" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close();  
                    }
                    else if (radioButton6.Checked == true)
                    {
                        double num1 = obj.GBPtoRUB();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " GBP = ");
                        textOut.WriteLine(textBox2.Text + " RUB" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close();
                    }
                    else if (radioButton7.Checked == true)
                    {
                        MessageBox.Show("You can't convert the same currency", "Attention",
                        MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Focus();
                }
            }
            else if (radioButton5.Checked == true)
            {
                try
                {
                    obj.Num = Convert.ToDouble(textBox1.Text);
                    if (radioButton10.Checked == true)
                    {
                        double num1 = obj.RUBtoCAD();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " RUB = ");
                        textOut.WriteLine(textBox2.Text + " CAD" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close();  
                    }
                    else if (radioButton9.Checked == true)
                    {
                        double num1 = obj.RUBtoUSD();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " RUB = ");
                        textOut.WriteLine(textBox2.Text + " USD" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close();
                    }
                    else if (radioButton8.Checked == true)
                    {
                        double num1 = obj.RUBtoEUR();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " RUB = ");
                        textOut.WriteLine(textBox2.Text + " EUR" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close(); 
                    }
                    else if (radioButton7.Checked == true)
                    {
                        double num1 = obj.RUBtoGBP();
                        textBox2.Text = num1.ToString();
                        textOut.Write(textBox1.Text + " RUB = ");
                        textOut.WriteLine(textBox2.Text + " GBP" + ", " + DateTime.Now.ToString() + "\n");
                        textOut.Close();    
                    }
                    else if (radioButton6.Checked == true)
                    {
                        MessageBox.Show("You can't convert the same currency", "Attention",
                        MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Focus();
                }
            }
        }

        public class MoneyEx1
        {
            private double num;

            public double Num
            {
                get
                {
                    return num;
                }
                set
                {
                    num = value;
                }
            }

            public MoneyEx1() { }

            public MoneyEx1(double val)
            {
                this.Num = num;
            }

            public double CADtoUSD()
            {
                return Num * 0.79;
            }
            public double CADtoEUR()
            {
                return Num * 0.66;
            }
            public double CADtoGBP()
            {
                return Num * 0.57;
            }
            public double CADtoRUB()
            {
                return Num * 58.28;
            }

            public double USDtoCAD()
            {
                return Num * 1.26;
            }
            public double USDtoEUR()
            {
                return Num * 0.84;
            }
            public double USDtoGBP()
            {
                return Num * 0.72;
            }
            public double USDtoRUB()
            {
                return Num * 73.64;
            }

            public double EURtoCAD()
            {
                return Num * 1.51;
            }
            public double EURtoUSD()
            {
                return Num * 1.19;
            }
            public double EURtoGBP()
            {
                return Num * 0.86;
            }
            public double EURtoRUB()
            {
                return Num * 87.81;
            }

            public double GBPtoCAD()
            {
                return Num * 1.76;
            }
            public double GBPtoUSD()
            {
                return Num * 1.39;
            }
            public double GBPtoEUR()
            {
                return Num * 1.17;
            }
            public double GBPtoRUB()
            {
                return Num * 102.58;
            }

            public double RUBtoCAD()
            {
                return Num * 0.017;
            }
            public double RUBtoUSD()
            {
                return Num * 0.014;
            }
            public double RUBtoEUR()
            {
                return Num * 0.011;
            }
            public double RUBtoGBP()
            {
                return Num * 0.0097;
            }
        }
        private void MoneyEx_Load(object sender, EventArgs e)
        {
            obj = new MoneyEx1();
            dir = @".\Text\";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoneyExx = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(MoneyExx);

            string Output = " ";
            string string1, string2;
            int tempo = 0;
            
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
