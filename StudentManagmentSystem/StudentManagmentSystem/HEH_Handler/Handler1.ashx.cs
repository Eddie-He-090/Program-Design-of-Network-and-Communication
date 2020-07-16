using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace StudentManagmentSystem
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            // context.Response.ContentType = "text/plain";
            // context.Response.Write("Hello World");

            string filePath = context.Server.MapPath("~/App_Data/HEH_Form/WindowsFormsApp2.exe");
            FileStream fs = new FileStream(filePath, FileMode.Open);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Dispose();

            context.Response.ContentType = "application/octet-stream";
            context.Response.AddHeader("Content-Disposition", "attachment; filename=编解码器及身份证出生年月日提取器.exe");
            context.Response.BinaryWrite(bytes);
            context.Response.Flush();

            //大文件下载的解决方案
            //context.Response.ContentType = "application/x-zip-compressed";
            //context.Response.AddHeader("Content-Disposition", "attachment;filename=z.zip");
            //string filename = Server.MapPath("~/App_Data/move.zip");
            //context.Response.TransmitFile(filename);
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