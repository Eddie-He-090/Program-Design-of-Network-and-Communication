using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web.UI;

namespace StudentManagmentSystem
{
    public partial class pers_info_stu : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] != null)
            {
                var userrole = Session["UserRole"].ToString();
                switch (userrole)
                {
                    //导航栏设置
                    case "1": //家长
                        Panel1.Visible = true;
                        Panel2.Visible = false;
                        Panel3.Visible = false;
                    {
                        //读取数据库并填充个人信息
                        var table = "";
                        // string constr = @"Data Source=.\sqlexpress;Initial Catalog=dbsms;Integrated Security=True";
                        // string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=B7731CC6C5C3A96F73746FA3DB54FCD2_信程序设计ASSIGNMENTS\VISUAL STUDIO\STUDENTMANAGMENTSYSTEM\STUDENTMANAGMENTSYSTEM\APP_DATA\DBSMS.MDF;Integrated Security=True";
                        var constr = ConfigurationManager.AppSettings["ConnectionString"];
                        var cns = new SqlConnection(constr); //创建SqlConnection的对象
                        try
                        {
                            cns.Open(); //打开数据库连接
                            if (cns.State == ConnectionState.Open)
                            {
                                var cmd = new SqlCommand();
                                cmd.Connection = cns;
                                switch (userrole)
                                {
                                    case "1":
                                        table = "stu_users";
                                        break;
                                    case "2":
                                        table = "tea_users";
                                        break;
                                    case "3":
                                        table = "admin_users";
                                        break;
                                    default:
                                        return;
                                }

                                Label1.Text = Session["UserName"].ToString();

                                cmd.CommandText = "select Stu_id from " + table + " where UserName='" +
                                                  Session["UserName"] + "'";
                                var objid = cmd.ExecuteScalar();
                                if (objid != null)
                                    Label2.Text = objid.ToString();
                                else
                                    Label2.Text = "NULL";

                                cmd.CommandText = "select Sex from " + table + " where UserName='" +
                                                  Session["UserName"] + "'";
                                var objsex = cmd.ExecuteScalar();
                                if (objsex != null)
                                    Label3.Text = objsex.ToString();
                                else
                                    Label3.Text = "NULL";

                                cmd.CommandText = "select Class from " + table + " where UserName='" +
                                                  Session["UserName"] + "'";
                                var objclass = cmd.ExecuteScalar();
                                if (objid != null)
                                    Label4.Text = objclass.ToString();
                                else
                                    Label4.Text = "NULL";

                                Label5.Text = "学生";

                                cmd.CommandText = "select Position from " + table + " where UserName='" +
                                                  Session["UserName"] + "'";
                                var objposition = cmd.ExecuteScalar();
                                if (objposition != null)
                                    Label6.Text = objposition.ToString();
                                else
                                    Label6.Text = "NULL";
                            }

                            cns.Close(); //关闭数据库连接
                        }
                        catch (Exception e_msg)
                        {
                            Label1.Text = "连接数据库出错，请重试。" + e_msg.Message;
                        }

                        cns.Dispose();
                    }
                        break;
                    case "2": //教师
                        Panel1.Visible = true;
                        Panel2.Visible = true;
                        Panel3.Visible = false;
                        Response.Redirect("pers_info_tea.aspx");
                        break;
                    case "3": //管理员
                        Panel1.Visible = false;
                        Panel2.Visible = true;
                        Panel3.Visible = true;
                        break;
                    default:
                        return;
                }
            }
            else
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Response.Write("<script>alert('系统检查到您当前未登录，无权访问该页面，请登录并检查您的权限。')</script>");
            }
        }

        protected void LoginStatus1_LoggedOut(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Redirect("default.aspx");
        }
    }
}