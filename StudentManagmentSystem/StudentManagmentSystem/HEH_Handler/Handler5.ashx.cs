using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace StudentManagmentSystem.HEH_Handler
{
    /// <summary>
    /// Summary description for Handler5
    /// </summary>
    public class Handler5 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            // context.Response.ContentType = "text/plain";
            // context.Response.Write("Hello World");

            string filePath = context.Server.MapPath("~/App_Data/HEH_Form/hashfile.exe");
            FileStream fs = new FileStream(filePath, FileMode.Open);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Dispose();

            context.Response.ContentType = "application/octet-stream";
            context.Response.AddHeader("Content-Disposition", "attachment; filename=文件HASH值计算器.exe");
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