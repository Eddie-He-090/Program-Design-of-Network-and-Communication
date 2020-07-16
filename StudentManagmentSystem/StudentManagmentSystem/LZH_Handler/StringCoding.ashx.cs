using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace StudentManagmentSystem.LZH_Handler
{
    /// <summary>
    /// StringCoding 的摘要说明
    /// </summary>
    public class StringCoding : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string filePath = context.Server.MapPath("~/App_Data/LZH_Form/StringCoding.exe");
            FileStream fs = new FileStream(filePath, FileMode.Open);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Dispose();

            context.Response.ContentType = "application/octet-stream";
            context.Response.AddHeader("Content-Disposition", "attachment; filename=StringCoding.exe");
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