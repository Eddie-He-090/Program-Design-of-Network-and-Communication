using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private double _i, _j;
        private string _k = "0";

        public Form1()
        {
            InitializeComponent();
        }

        public void Blank()
        {
            if (_k == "!")
            {
                textBox1.Text = "";
                _k = "0";
            }
        }

        public void Converter()
        {
            if (_k == "0")
            {
                _i = Convert.ToDouble(textBox1.Text);
                textBox1.Text = _i.ToString();
            }
            else
            {
                _j = Convert.ToDouble(textBox1.Text);
                textBox1.Text = _j.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Blank();
            textBox1.Text = textBox1.Text + '1';
            Converter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Blank();
            textBox1.Text = textBox1.Text + '2';
            Converter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Blank();
            textBox1.Text = textBox1.Text + '3';
            Converter();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Blank();
            textBox1.Text = textBox1.Text + '4';
            Converter();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Blank();
            textBox1.Text = textBox1.Text + '5';
            Converter();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Blank();
            textBox1.Text = textBox1.Text + '6';
            Converter();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Blank();
            textBox1.Text = textBox1.Text + '7';
            Converter();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Blank();
            textBox1.Text = textBox1.Text + '8';
            Converter();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Blank();
            textBox1.Text = textBox1.Text + '9';
            Converter();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Blank();
            textBox1.Text = textBox1.Text + '0';
            Converter();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            _k = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            _k = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            _k = "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            _k = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (_k)
            {
                case "+":
                    textBox1.Text = (_i + _j).ToString();
                    break;
                case "-":
                    textBox1.Text = (_i - _j).ToString();
                    break;
                case "*":
                    textBox1.Text = (_i * _j).ToString();
                    break;
                case "/":
                    textBox1.Text = (_i / _j).ToString();
                    break;
            }

            _k = "!";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            Converter();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            _k = "!";
            Blank();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}