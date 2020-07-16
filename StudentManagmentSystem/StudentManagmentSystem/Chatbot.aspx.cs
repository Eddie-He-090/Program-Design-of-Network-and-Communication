using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace StudentManagmentSystem
{
    public partial class Chatbot : System.Web.UI.Page
    {
        public string url = "http://api.qingyunke.com/api.php?key=free&appid=0&msg=";

        [DataContract]
        public class Result
        {
            [DataMember]
            public int result { get; set; }

            [DataMember]
            public string content { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url_msg = url + TextBox1.Text;
            //发送请求
            HttpWebRequest wr = HttpWebRequest.Create(url_msg) as HttpWebRequest;

            //读取返回值
            HttpWebResponse response = wr.GetResponse() as HttpWebResponse;
            Stream rsp = response.GetResponseStream();
            StreamReader sr = new StreamReader(rsp, Encoding.UTF8);
            string json = sr.ReadToEnd();
            sr.Close();
            rsp.Close();
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer deseralizer = new DataContractJsonSerializer(typeof(Result));
                Result result = (Result)deseralizer.ReadObject(ms);// //反序列化ReadObject
                string content = result.content.ToString();
                TextBox2.Text = content.Replace("{br}", "\r\n");
            }
        }
    }
}