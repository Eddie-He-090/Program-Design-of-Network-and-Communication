using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _13_HttpFtp
{
    public partial class F_WebBrowser : Form
    {
        public F_WebBrowser()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            navigate();
        }

        private void combogo(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//回车键
            {
                navigate();
            }
        }

        void navigate()
        {
            string url = toolStripComboBox1.Text;
            //webBrowser1.Url = new Uri(url);
            webBrowser1.Navigate(url);

            /*
            if (!string.IsNullOrEmpty(url))
            {
                if (url.ToLower().IndexOf("http://") < 0)
                {
                    url = "http://" + url;
                }
                webBrowser1.Navigate(url);
            }
            else
            {
                MessageBox.Show("请输入有效的网络地址");
            }
            */
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

    }
}
