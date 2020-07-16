using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = int.Parse(label1.Text) - 1 + ""; //label1的数字立即-1
            timer1.Interval = 2000; //timer1_Tick那段代码每2秒执行一次，初始执行，在2秒之后才正式开始
            timer1.Enabled = true; //开启timer1
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            //无论用户在2s内还是在2s之后就松开鼠标，就马上停止timer1,timer2的代码执行
            //如果用户在2s内松开鼠标,time3_Tick根本1次都不会执行
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 50; //timer1的代码每0.05s执行一次
            timer2.Enabled = true; //开始timer2
            timer1.Enabled = false; //timer1_Tick这段代码就不要每2秒执行一次了，执行1次就好
            //这句话就完成timer1与timer2的线程同步
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = int.Parse(label1.Text) - 1 + "";
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = int.Parse(label1.Text) + 1 + ""; //label1的数字立即+1
            timer3.Interval = 2000; //timer3_Tick那段代码每2秒执行一次，初始执行，在2秒之后才正式开始
            timer3.Enabled = true; //开启timer1        }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            //无论用户在2s内还是在2s之后就松开鼠标，就马上停止timer1,timer2的代码执行
            //如果用户在2s内松开鼠标,time3_Tick根本1次都不会执行
            timer3.Enabled = false;
            timer4.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer4.Interval = 50; //timer4的代码每0.05s执行一次
            timer4.Enabled = true; //开始timer4
            timer3.Enabled = false; //timer3_Tick这段代码就不要每2秒执行一次了，执行1次就好
            //这句话就完成timer3与timer4的线程同步
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label1.Text = int.Parse(label1.Text) + 1 + "";
        }
    }
}