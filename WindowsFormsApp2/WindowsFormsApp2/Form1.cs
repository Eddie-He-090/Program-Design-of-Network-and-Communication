using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] temp;
            switch (comboBox1.Text)
            {
                case "Base64":
                    temp = Encoding.UTF8.GetBytes(textBox1.Text);
                    textBox2.Text = Convert.ToBase64String(temp);
                    break;
                case "ASCII":
                    temp = Encoding.ASCII.GetBytes(textBox1.Text);
                    textBox2.Text = "";
                    for (int i = 0; i < temp.Length; i++)
                    {
                        textBox2.Text = textBox2.Text + temp[i].ToString("X2");
                    }

                    break;
                case "Unicode":
                    temp = Encoding.Unicode.GetBytes(textBox1.Text);
                    textBox2.Text = "";
                    for (int i = 0; i < temp.Length; i++)
                    {
                        textBox2.Text = textBox2.Text + temp[i].ToString("X2");
                    }

                    break;
                case "UTF-8":
                    temp = Encoding.UTF8.GetBytes(textBox1.Text);
                    textBox2.Text = "";
                    for (int i = 0; i < temp.Length; i++)
                    {
                        textBox2.Text = textBox2.Text + temp[i].ToString("X2");
                    }

                    break;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length.Equals(18) || textBox3.Text.Length.Equals(19))
            {
                string str = textBox3.Text.Substring(6, 8);
                textBox4.Text = str.Substring(0, 4) + '/' + str.Substring(4, 2) + '/' + str.Substring(6, 2);
            }
            else
            {
                System.Windows.Forms.DialogResult dr = MessageBox.Show("输入错误", "", MessageBoxButtons.OK);
            }
        }
    }
}