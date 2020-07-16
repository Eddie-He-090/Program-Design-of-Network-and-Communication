using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.UI;

namespace StudentManagmentSystem
{
    public partial class pickup : Page
    {
        public string Status;

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
                        Status = "家长";
                        break;
                    case "2": //教师
                        Panel1.Visible = true;
                        Panel2.Visible = true;
                        Panel3.Visible = false;
                        Status = "教师";
                        break;
                    case "3": //管理员
                        Panel1.Visible = false;
                        Panel2.Visible = true;
                        Panel3.Visible = true;
                        Status = "管理员";
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

            //
            Button1.Attributes.Add("OnClick", "this.form.target =");
            Button2.Attributes.Add("OnClick", "this.form.target =''");
            Button3.Attributes.Add("OnClick", "this.form.target =''");

            //
            var scriptManager = ((Page) HttpContext.Current.Handler).ClientScript;
            if (Session["Position"] is "School")
            {
                scriptManager.RegisterStartupScript(typeof(string), "1", "alert('学生到校登记成功');", true);
                Session["Position"] = null;
            }
            else if (Session["Position"] is "Out")
            {
                scriptManager.RegisterStartupScript(typeof(string), "2", "alert('学生离校登记成功');", true);
                Session["Position"] = null;
            }

            if (Session["Pick"] is "CowRoad")
            {
                scriptManager.RegisterStartupScript(typeof(string), "3", "alert('家长接送申请成功，申请接送地点为：金牛路门口');", true);
                Session["Pick"] = null;
            }
            else if (Session["Pick"] is "SunRoad")
            {
                scriptManager.RegisterStartupScript(typeof(string), "4", "alert('家长接送申请成功，申请接送地点为：向阳路门口');", true);
                Session["Pick"] = null;
            }
            else if (Session["Pick"] is "0")
            {
                scriptManager.RegisterStartupScript(typeof(string), "5", "alert('家长接送申请已取消');", true);
                Session["Pick"] = null;
            }

            //Population of school
            // string Constr = @"Data Source=.\sqlexpress;Initial Catalog=dbsms;Integrated Security=True";
            // string Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=B7731CC6C5C3A96F73746FA3DB54FCD2_信程序设计ASSIGNMENTS\VISUAL STUDIO\STUDENTMANAGMENTSYSTEM\STUDENTMANAGMENTSYSTEM\APP_DATA\DBSMS.MDF;Integrated Security=True";
            var Constr = ConfigurationManager.AppSettings["ConnectionString"];
            var cns = new SqlConnection(Constr);
            try
            {
                cns.Open();
                if (cns.State == ConnectionState.Open)
                {
                    var cmd = new SqlCommand();
                    cmd.Connection = cns;
                    cmd.CommandText = "select count(*) from stu_users where Position='School'";
                    var obj = cmd.ExecuteScalar();
                    if (obj == null)
                        Label4.Text = "NULL";
                    else
                        Label4.Text = obj.ToString();

                    cmd.CommandText = "select count(*) from stu_users where Pick ='CowRoad'";
                    obj = cmd.ExecuteScalar();
                    if (obj == null)
                        Label2.Text = "NULL";
                    else
                        Label2.Text = obj.ToString();

                    cmd.CommandText = "select count(*) from stu_users where Pick ='SunRoad'";
                    obj = cmd.ExecuteScalar();
                    if (obj == null)
                        Label6.Text = "NULL";
                    else
                        Label6.Text = obj.ToString();
                }

                cns.Close();
                cns.Dispose();

                if (Session["UserName"] != null) Label7.Text = "您的用户名是：" + Session["UserName"] + "。你的身份是：" + Status;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
                //scriptManager.RegisterStartupScript(typeof(string), "", "alert('Catch wrong!');", true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //学生到校登记
            // string Constr = @"Data Source=.\sqlexpress;Initial Catalog=dbsms;Integrated Security=True";
            // string Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=B7731CC6C5C3A96F73746FA3DB54FCD2_信程序设计ASSIGNMENTS\VISUAL STUDIO\STUDENTMANAGMENTSYSTEM\STUDENTMANAGMENTSYSTEM\APP_DATA\DBSMS.MDF;Integrated Security=True";
            var Constr = ConfigurationManager.AppSettings["ConnectionString"];
            var scriptManager = ((Page) HttpContext.Current.Handler).ClientScript;
            var cns = new SqlConnection(Constr);
            try
            {
                cns.Open();
                if (cns.State == ConnectionState.Open)
                {
                    var cmd = new SqlCommand();
                    cmd.Connection = cns;
                    cmd.CommandText = "update stu_users set Position = 'School' where UserName = '" +
                                      Session["UserName"] + "'";
                    cmd.ExecuteNonQuery();
                    Session["Position"] = "School";
                }

                cns.Close();
                cns.Dispose();
                //Response.Write("<script>alert('学生到校登记成功!')</script>");
                //Session["Position"] = null;
                Response.Redirect("pickup.aspx");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
                scriptManager.RegisterStartupScript(typeof(string), "2", "alert('Catch wrong!');", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //家长接送申请、修改、取消
            var value = DropDownList1.SelectedValue;
            // string Constr = @"Data Source=.\sqlexpress;Initial Catalog=dbsms;Integrated Security=True";
            // string Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=B7731CC6C5C3A96F73746FA3DB54FCD2_信程序设计ASSIGNMENTS\VISUAL STUDIO\STUDENTMANAGMENTSYSTEM\STUDENTMANAGMENTSYSTEM\APP_DATA\DBSMS.MDF;Integrated Security=True";
            var Constr = ConfigurationManager.AppSettings["ConnectionString"];
            var scriptManager = ((Page) HttpContext.Current.Handler).ClientScript;
            var cns = new SqlConnection(Constr);
            try
            {
                cns.Open();
                if (cns.State == ConnectionState.Open)
                {
                    var cmd = new SqlCommand();
                    cmd.Connection = cns;
                    if (value != "0")
                    {
                        cmd.CommandText = "update stu_users set Pick = '" + value + "' where UserName = '" +
                                          Session["UserName"] + "'";
                        cmd.ExecuteNonQuery();
                        Session["Pick"] = value;
                    }
                    else if (value == "0")
                    {
                        cmd.CommandText = "update stu_users set Pick = null where UserName= '" + Session["UserName"] +
                                          "'";
                        cmd.ExecuteNonQuery();
                        Session["Pick"] = value;
                    }
                }

                cns.Close();
                cns.Dispose();
                Response.Redirect("pickup.aspx");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
                scriptManager.RegisterStartupScript(typeof(string), "2", "alert('Catch wrong!');", true);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //学生离校登记
            // string Constr = @"Data Source=.\sqlexpress;Initial Catalog=dbsms;Integrated Security=True";
            // string Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=B7731CC6C5C3A96F73746FA3DB54FCD2_信程序设计ASSIGNMENTS\VISUAL STUDIO\STUDENTMANAGMENTSYSTEM\STUDENTMANAGMENTSYSTEM\APP_DATA\DBSMS.MDF;Integrated Security=True";
            var Constr = ConfigurationManager.AppSettings["ConnectionString"];
            var scriptManager = ((Page) HttpContext.Current.Handler).ClientScript;
            var cns = new SqlConnection(Constr);
            try
            {
                cns.Open();
                if (cns.State == ConnectionState.Open)
                {
                    var cmd = new SqlCommand();
                    cmd.Connection = cns;
                    cmd.CommandText = "update stu_users set Position = null, Pick = null where UserName = '" +
                                      Session["UserName"] + "'";
                    cmd.ExecuteNonQuery();
                    Session["Position"] = "Out";
                }

                cns.Close();
                cns.Dispose();
                Response.Redirect("pickup.aspx");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
                scriptManager.RegisterStartupScript(typeof(string), "2", "alert('Catch wrong!');", true);
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