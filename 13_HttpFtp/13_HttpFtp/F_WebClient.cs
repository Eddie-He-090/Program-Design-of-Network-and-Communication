using System;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Text;
using System.IO;

namespace _13_HttpFtp
{
    public partial class F_WebClient : Form
    {
        //WebClient client = new WebClient();
        //Thread thread;

        public F_WebClient()
        {
            InitializeComponent();


            //禁用线程安全异常，一般不禁用（Windows 窗体控件本质上不是线程安全的，访问不同线程上的控件会有该异常）
            //CheckForIllegalCrossThreadCalls = false;
        }

        //定义委托类型，因为待绑定的方法有一个参数，所以定义委托时方法签名与其保持一致
        public delegate void mydelegate(string path);

        /// <summary>
        /// 下载请求事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            //直接调用下载方法，在一个线程中完成
            //downfile(textBox1.Text);


            //创建一个新的委托，并绑定下载方法
            mydelegate mydl = new mydelegate(downfile);
            //在logs所在的句柄上启动异步委托，并提交一个参数（下载地址），将表示该委托状态的量赋给ir1
            IAsyncResult ir1 = logs.BeginInvoke(mydl, textBox1.Text);
            //需要同步，等待每一个委托完成
            logs.EndInvoke(ir1);

            /*
            */

            //所有任务/委托线程完成后显示下载按钮
            button1.Enabled = true;
        }

        /// <summary>
        /// 文件下载方法
        /// </summary>
        void downfile(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                //在网址中提取下载文件名
                int n = url.LastIndexOf('/');   //查找最后的一个/
                //获取文件名
                string frname = url.Substring(n + 1);
                //合并本地保存路径
                string path = @"D:\test\" + frname;

                //每个文件重复下载5次，浪费一下时间
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        //提示正在下载
                        logs.AppendText(url + " Downing..." + Environment.NewLine);

                        //下载文件
                        WebClient client = new WebClient();
                        client.DownloadFile(url, path);

                        //提示下载完成
                        logs.AppendText(url + " Downed" + Environment.NewLine);
                    }
                    catch (Exception msg)
                    {
                        logs.AppendText(url + " Failed：" + msg.Message + Environment.NewLine);
                    }
                    logs.ScrollToCaret();

                    //暂停50毫秒
                    Thread.Sleep(50);
                }


                ///WebRequest/WebResponse 演习代码，和下载器无关
                //访问某网站，并读取该网页流的大小及源码
                WebRequest wr = WebRequest.Create("http://physics.scnu.edu.cn/default.aspx");
                HttpWebRequest hwr = (HttpWebRequest)wr;
                hwr.Method = "Post";
                //hwr.st
                //获取该请求的响应数据
                //HttpWebResponse wrp = (HttpWebResponse)wr.GetResponse();
                WebResponse wrp = wr.GetResponse();
                //显示长度
                logs.AppendText(wrp.ContentLength.ToString());
                //空行
                logs.AppendText(Environment.NewLine);
                //读取网页流
                
                StreamReader stream = new StreamReader(wrp.GetResponseStream());
                //显示流的文本内容
                logs.AppendText(stream.ReadToEnd());
                /*
                */
            }
        }


        /// <summary>
        /// FTP操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //指定要访问的FTP站点，并判断资源是不是FTP地址
            Uri uristring = new Uri("ftp://beaming.name");
            if (uristring.Scheme != Uri.UriSchemeFtp)
            {
                return;
            }

            //发出连接请求
            WebRequest wr = WebRequest.Create(uristring);
            //指定连接账号密码
            wr.Credentials = new NetworkCredential("student", "686868");
            //显式转换该连接为FTP连接
            FtpWebRequest fwr = (FtpWebRequest)wr;
            //保持连接
            fwr.KeepAlive = true;
            //发出显示目录详细信息的命令
            fwr.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            //获得该连接上的响应
            FtpWebResponse response = (FtpWebResponse)wr.GetResponse();
            //显示回应代码及状态
            logs.Text = response.StatusDescription;
            //空行
            logs.AppendText(Environment.NewLine);
            //读取响应流并显示
            StreamReader stream = new StreamReader(response.GetResponseStream());
            logs.AppendText(stream.ReadToEnd());
        }
    }
}