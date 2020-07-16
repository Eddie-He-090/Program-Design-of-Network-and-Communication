using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace StudentManagmentSystem.LZH_Handler
{
    /// <summary>
    /// WebBrowser 的摘要说明
    /// </summary>
    public class WebBrowser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string filePath = context.Server.MapPath("~/App_Data/LZH_Form/webbrowser.exe");
            FileStream fs = new FileStream(filePath, FileMode.Open);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Dispose();

            context.Response.ContentType = "application/octet-stream";
            context.Response.AddHeader("Content-Disposition", "attachment; filename=WebBrowser.exe");
            context.Response.BinaryWrite(bytes);
            context.Response.Flush();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}