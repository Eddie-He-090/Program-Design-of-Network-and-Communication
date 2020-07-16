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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //弹出消息框，并获取消息框的返回值
            DialogResult dr = MessageBox.Show(@"是否打开新窗体？", @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //如果消息框返回值是Yes，显示新窗体
            if (dr == DialogResult.Yes)
            {
                Form2 form2 = new Form2();
                // form2.ShowDialog();
                form2.Show();
            }
            //如果消息框返回值是No，关闭当前窗体
            else if (dr == DialogResult.No)
            {
                //关闭当前窗体
                this.Close();
                Environment.Exit(0);
            }
        }

        private string _temp1 = "Hello Rider!";
        private string _temp2;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // label1.Text=@"Hello Rider!";
            _temp2 = label1.Text;
            label1.Text = _temp1;
            _temp1 = _temp2;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                label1.Text = textBox1.Text;
                if ("123".Equals(textBox1.Text))
                {
                    MessageBox.Show("123");
                }
            }
        }
    }
}