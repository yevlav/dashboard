// Yevheniia Lavrova, 7.04.2021, Lotto649
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
    public partial class Lotto649 : Form
    {
        public Lotto649()
        {
            InitializeComponent();
        }
        string dir = "";
        string filePath = @"C:\Text\LottoNbrs.txt";
        FileStream Lotto = null;

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arrNumbers = new int[7];
            Random random = new Random();
            int randomNumber = 0;
            string tempo = "";
            arrNumbers[0] = random.Next(1, 49);
            bool equal = false;

            for (int i = 1; i < 7; i++)
            {
                randomNumber = random.Next(1, 49);

            label1:
                foreach (int nbr in arrNumbers)
                {
                    if (nbr == randomNumber)
                    {
                        randomNumber = random.Next(1, 49);
                        equal = true;
                        break;
                    }
                }

                if (equal == true)
                {
                    randomNumber = random.Next(1, 49);
                    equal = false;
                    goto label1;
                }
                else
                {
                    arrNumbers[i] = randomNumber;
                }
            }

            for (int j = 0; j < 6; j++)
            {
                tempo = tempo + arrNumbers[j] + " ";
            }

            tempo = tempo + arrNumbers[6];
            textBox1.Text = tempo;
            
            try
            {
                Lotto = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(Lotto);
                textOut.Write("\n" + "649, " + DateTime.Now.ToString());

                for (int i = 0; i < 6; i++)
                {
                    textOut.Write(", " + arrNumbers[i]);
                }
                textOut.Write(", Extra: " + arrNumbers[6]);
                textOut.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(filePath + " not found.", "File Not Found");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the Lotto649 application?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void Lotto649_Load(object sender, EventArgs e)
        {
            dir = @".\Text\";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lotto = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(Lotto);
            
            

            string Output = "\n";
            string Inpute;
            int tempo = 0;

            while (textIn.Peek() != -1)
            {
                Inpute = textIn.ReadLine();

                Output += "\n" + Inpute + " ";
                tempo++;

                if (tempo == 100)
                {
                    MessageBox.Show(Output);
                    tempo = 0;
                    Output = "";
                }
            }
            if (tempo != 0)
            {
                MessageBox.Show(Output);
                textIn.Close();
           }
        }
    }
}
