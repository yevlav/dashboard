/*Yevheniia Lavrova, 7.04.2021, form with 6 applications inside: 1. LottoMax - generates random numbers (7 + 1 Extra)
                                                                 2. Lotto649 - generates random numbers (6 + 1 Extra)
                                                                 3. Money Exchange - converts different currency
                                                                 4. Temperature Converter - converts temperature from C to F and vice versa
                                                                 5. Simple Calculator - performs arithmetical operations
                                                                 6. IP 4 Validator - validates entered IP address
 */                                                              
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application?", "Exit", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LottoMax obj = new LottoMax();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lotto649 obj = new Lotto649();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoneyEx obj = new MoneyEx();
            obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TempConv obj = new TempConv();
            obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SimpleCalc obj = new SimpleCalc();
            obj.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IP4 obj = new IP4();
            obj.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
