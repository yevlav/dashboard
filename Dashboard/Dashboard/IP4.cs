// Yevheniia Lavrova, 7.04.2021, IP4 
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
    public partial class IP4 : Form
    {
        public IP4()
        {
            InitializeComponent();
        }

        string dir = "";
        string filePath = @"C:\Text\IP4.txt"; 
        FileStream IP = null;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Regex ipAddress = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");

                if (ipAddress.IsMatch(textBox2.Text.Trim()))
                {
                    MessageBox.Show("The IP is correct", textBox2.Text.ToString());
                    IP = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(IP);
                    try
                    {
                        textOut.WriteLine(DateTime.Now.ToString() + ", IP: " + textBox2.Text.ToString());
                        textOut.Close();
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show(filePath + " not found.", "File Not Found");
                    }
                    catch (IOException ex)
                    { 
                        MessageBox.Show(ex.Message, "IO Exception"); 
                    }
                    finally
                    {
                        IP.Close();
                    }
                }
                else
                {
                    MessageBox.Show("The IP must have 4 bytes \n integer number between 0 to 255 \n separated by dot (255.255.255.255)", textBox2.Text.ToString());
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the IP4 Validator application?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void IP4_Load(object sender, EventArgs e)
        {
            label3.Text += DateTime.Today.ToLongDateString();
            dir = @".\Text\";
        }
    }
}
