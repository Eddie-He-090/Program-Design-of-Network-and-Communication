using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace StudentManagmentSystem.LZH_Handler
{
    /// <summary>
    /// SlidingWindow 的摘要说明
    /// </summary>
    public class SlidingWindow : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string filePath = context.Server.MapPath("~/App_Data/LZH_Form/SlidingWindow.exe");
            FileStream fs = new FileStream(filePath, FileMode.Open);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Dispose();

            context.Response.ContentType = "application/octet-stream";
            context.Response.AddHeader("Content-Disposition", "attachment; filename=TCP滑动窗口协议演示程序.exe");
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