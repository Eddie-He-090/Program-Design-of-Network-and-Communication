using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;

namespace StudentManagmentSystem.Handler
{
    /// <summary>
    /// Summary description for Handler4
    /// </summary>
    public class Handler4 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            // context.Response.ContentType = "text/plain";
            // context.Response.Write("Hello World");

            //大文件下载的解决方案
            context.Response.ContentType = "application/x-zip-compressed";
            context.Response.AddHeader("Content-Disposition", "attachment;filename=安卓ADB调试器.7z");
            string filename = context.Server.MapPath("~/App_Data/HEH_Form/安卓ADB调试器.7z");
            context.Response.TransmitFile(filename);
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