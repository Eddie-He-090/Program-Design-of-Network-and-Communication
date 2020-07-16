using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ADB.Properties;

namespace ADB
{
    public partial class Form1 : Form
    {
        // String cmd = "C:\\Users\\Eddie\\platform-tools\\adb.exe";
        private static string path = Application.StartupPath ;
        string cmd = path+ @"\\adbcopy\\adbcopy.exe";
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(path + @"\\adbcopy"))
            {
                Directory.CreateDirectory(path + @"\\adbcopy");
            }
            
            //获取C:\Windows\System32路径
            // string path = "C:\\Program Files (x86)";
            // 释放A.dll
             if (!File.Exists(path + @"\\adbcopy\\adbcopy.exe"))
             {
                 byte[] Save = global::ADB.Properties.Resources.adbcopy;
                 FileStream fsObj = new FileStream(path + @"\\adbcopy\\adbcopy.exe", FileMode.CreateNew);
                 fsObj.Write(Save, 0, Save.Length);
                 fsObj.Close();
                 //现在到系统目录中找一下释放的资源.exe吧
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo();
            p.StartInfo.FileName = cmd; //设定程序名
            //p.StartInfo.WorkingDirectory = path;
            p.StartInfo.UseShellExecute = false; //关闭shell的使用
            p.StartInfo.RedirectStandardInput = true; //重定向标准输入
            p.StartInfo.RedirectStandardOutput = true; //重定向标准输出
            p.StartInfo.RedirectStandardError = true; //重定向错误输出
            p.StartInfo.CreateNoWindow = true; //设置不显示窗口

            p.Start();
            textBox1.Text = p.StandardOutput.ReadToEnd();
            p.Close();

            p.StartInfo.Arguments = "shell getprop ro.product.brand";
            p.Start();
            textBox2.Text = p.StandardOutput.ReadToEnd();
            p.Close();

            p.StartInfo.Arguments = "shell getprop ro.product.model";
            p.Start();
            textBox3.Text = p.StandardOutput.ReadToEnd();
            p.Close();

            p.StartInfo.Arguments = "shell getprop ro.product.name";
            p.Start();
            textBox4.Text = p.StandardOutput.ReadToEnd();
            p.Close();

            p.StartInfo.Arguments = "shell getprop ro.product.board";
            p.Start();
            textBox5.Text = p.StandardOutput.ReadToEnd();
            p.Close();

            p.StartInfo.Arguments = "shell getprop ro.build.version.release";
            p.Start();
            textBox6.Text = p.StandardOutput.ReadToEnd();
            p.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tel = new Regex(@"^\d+$");
            if (tel.IsMatch(textBox7.Text))
            {
                var p = new Process();
                p.StartInfo = new ProcessStartInfo();
                p.StartInfo.FileName = cmd; //设定程序名
                p.StartInfo.UseShellExecute = false; //关闭shell的使用
                p.StartInfo.RedirectStandardInput = true; //重定向标准输入
                p.StartInfo.RedirectStandardOutput = true; //重定向标准输出
                p.StartInfo.RedirectStandardError = true; //重定向错误输出
                p.StartInfo.CreateNoWindow = true; //设置不显示窗口
                p.StartInfo.Arguments =
                    "shell am start -a android.intent.action.CALL tel:" +
                    textBox7.Text;
                p.Start();
                p.Close();
            }
            else
            {
                var dr = MessageBox.Show(@"Please input digits",
                    @"Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int) Keys.Enter) //如果输入的是回车键
            {
                button2_Click(sender, e); //触发button事件
                e.Handled = true; //按下回车的声音
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo();
            p.StartInfo.FileName = cmd; //设定程序名
            p.StartInfo.UseShellExecute = false; //关闭shell的使用
            p.StartInfo.RedirectStandardInput = true; //重定向标准输入
            p.StartInfo.RedirectStandardOutput = true; //重定向标准输出
            p.StartInfo.RedirectStandardError = true; //重定向错误输出
            p.StartInfo.CreateNoWindow = true; //设置不显示窗口
            p.StartInfo.Arguments = "shell input keyevent KEYCODE_ENDCALL";
            p.Start();
            p.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo();
            p.StartInfo.FileName = cmd; //设定程序名
            p.StartInfo.UseShellExecute = false; //关闭shell的使用
            p.StartInfo.RedirectStandardInput = true; //重定向标准输入
            p.StartInfo.RedirectStandardOutput = true; //重定向标准输出
            p.StartInfo.RedirectStandardError = true; //重定向错误输出
            p.StartInfo.CreateNoWindow = true; //设置不显示窗口
            p.StartInfo.Arguments = "shell input keyevent 24";
            p.Start();
            p.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo();
            p.StartInfo.FileName = cmd; //设定程序名
            p.StartInfo.UseShellExecute = false; //关闭shell的使用
            p.StartInfo.RedirectStandardInput = true; //重定向标准输入
            p.StartInfo.RedirectStandardOutput = true; //重定向标准输出
            p.StartInfo.RedirectStandardError = true; //重定向错误输出
            p.StartInfo.CreateNoWindow = true; //设置不显示窗口
            p.StartInfo.Arguments = "shell input keyevent 25";
            p.Start();
            p.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo();
            p.StartInfo.FileName = cmd; //设定程序名
            p.StartInfo.UseShellExecute = false; //关闭shell的使用
            p.StartInfo.RedirectStandardInput = true; //重定向标准输入
            p.StartInfo.RedirectStandardOutput = true; //重定向标准输出
            p.StartInfo.RedirectStandardError = true; //重定向错误输出
            p.StartInfo.CreateNoWindow = true; //设置不显示窗口
            p.StartInfo.Arguments = "shell input keyevent 26";
            p.Start();
            p.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo();
            p.StartInfo.FileName = cmd; //设定程序名
            p.StartInfo.UseShellExecute = false; //关闭shell的使用
            p.StartInfo.RedirectStandardInput = true; //重定向标准输入
            p.StartInfo.RedirectStandardOutput = true; //重定向标准输出
            p.StartInfo.RedirectStandardError = true; //重定向错误输出
            p.StartInfo.CreateNoWindow = true; //设置不显示窗口
            p.StartInfo.Arguments =
                "shell am start -a android.intent.action.MAIN -c android.intent.category.LAUNCHER -n com.tencent.mm/com.tencent.mm.ui.LauncherUI";
            p.Start();
            p.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo();
            p.StartInfo.FileName = cmd; //设定程序名
            p.StartInfo.UseShellExecute = false; //关闭shell的使用
            p.StartInfo.RedirectStandardInput = true; //重定向标准输入
            p.StartInfo.RedirectStandardOutput = true; //重定向标准输出
            p.StartInfo.RedirectStandardError = true; //重定向错误输出
            p.StartInfo.CreateNoWindow = true; //设置不显示窗口
            p.StartInfo.Arguments =
                "shell am start -a android.intent.action.MAIN -c android.intent.category.LAUNCHER -n com.tencent.mobileqq/com.tencent.mobileqq.activity.SplashActivity";
            p.Start();
            p.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo();
            p.StartInfo.FileName = cmd; //设定程序名
            p.StartInfo.UseShellExecute = false; //关闭shell的使用
            p.StartInfo.RedirectStandardInput = true; //重定向标准输入
            p.StartInfo.RedirectStandardOutput = true; //重定向标准输出
            p.StartInfo.RedirectStandardError = true; //重定向错误输出
            p.StartInfo.CreateNoWindow = true; //设置不显示窗口
            p.StartInfo.Arguments = "shell input keyevent 82";
            p.Start();
            p.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo();
            p.StartInfo.FileName = cmd; //设定程序名
            p.StartInfo.UseShellExecute = false; //关闭shell的使用
            p.StartInfo.RedirectStandardInput = true; //重定向标准输入
            p.StartInfo.RedirectStandardOutput = true; //重定向标准输出
            p.StartInfo.RedirectStandardError = true; //重定向错误输出
            p.StartInfo.CreateNoWindow = true; //设置不显示窗口
            p.StartInfo.Arguments = "shell input keyevent 3";
            p.Start();
            p.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo();
            p.StartInfo.FileName = cmd; //设定程序名
            p.StartInfo.UseShellExecute = false; //关闭shell的使用
            p.StartInfo.RedirectStandardInput = true; //重定向标准输入
            p.StartInfo.RedirectStandardOutput = true; //重定向标准输出
            p.StartInfo.RedirectStandardError = true; //重定向错误输出
            p.StartInfo.CreateNoWindow = true; //设置不显示窗口
            p.StartInfo.Arguments = "shell input keyevent 4";
            p.Start();
            p.Close();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Directory.Exists(path + "\\adbcopy"))
            {
                File.Delete(path + "\\adbcopy\\adbcopy.exe");
                Directory.Delete(path + "\\adbcopy");
                MessageBox.Show(@"已删除临时文件", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}