using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Threading;

namespace _13_HttpFtp
{
    public partial class F_MyMail : Form
    {
        public F_MyMail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string mymailadd = "tangxy@scnu.edu.cn";
            // string psw = "";
            // string host = "scnu.edu.cn";
            string mymailadd = "cy0240@126.com";
            string psw = "VLSHXPAOYNGSQTBK";
            string host = "smtp.126.com";

            //定义邮件内容
            MailMessage mm = new MailMessage();
            mm.From = new MailAddress(mymailadd);
            mm.To.Add(tbMailTo.Text);
            mm.Subject = tbMailTitle.Text;
            mm.Body = tbMailBody.Text;
            //指定附件
            //mm.Attachments= new Attachment(filename)

            //邮件发送
            SmtpClient sc = new SmtpClient(host, 25);
            sc.UseDefaultCredentials = true;
            sc.Credentials = new NetworkCredential(mymailadd, psw);
            try
            {
                sc.Send(mm);
                MessageBox.Show("发送成功");
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbMailTo.Text = textBox1.Text.Replace("\n", ",");
            tbMailTo.Text = tbMailTo.Text.Replace("\r", "");
        }
    }
}