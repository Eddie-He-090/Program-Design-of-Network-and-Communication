using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web.UI;

namespace StudentManagmentSystem
{
    public partial class login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //form1.DefaultButton = "Button1";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var userrole = 0;
            try
            {
                if (RadioButton1.Checked)
                {
                    Label1.Text = "你的用户身份是家长";
                    userrole = 1;
                }
                else if (RadioButton2.Checked)
                {
                    Label1.Text = "你的用户身份是老师";
                    userrole = 2;
                }
                else if (RadioButton3.Checked)
                {
                    Label1.Text = "你的用户身份是管理员";
                    userrole = 3;
                }
                else
                {
                    return;
                }
            }
            catch (Exception e_msg)
            {
                Label1.Text = "系统出错，请重试。" + e_msg.Message;
            }

            var usn = TextBox1.Text;
            var psw = TextBox2.Text;
            var table = "";

            //读取数据库并进行用户密码判断
            // string constr = @"Data Source=.\sqlexpress;Initial Catalog=dbsms;Integrated Security=True";
            // string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=B7731CC6C5C3A96F73746FA3DB54FCD2_信程序设计ASSIGNMENTS\VISUAL STUDIO\STUDENTMANAGMENTSYSTEM\STUDENTMANAGMENTSYSTEM\APP_DATA\DBSMS.MDF;Integrated Security=True";
            var constr = ConfigurationManager.AppSettings["ConnectionString"];
            var cns = new SqlConnection(constr); //创建SqlConnection的对象
            try
            {
                cns.Open(); //打开数据库连接
                if (cns.State == ConnectionState.Open)
                {
                    //Label1.Text = "数据库连接成功";
                    var cmd = new SqlCommand();
                    cmd.Connection = cns;
                    switch (userrole)
                    {
                        case 1:
                            table = "stu_users";
                            break;
                        case 2:
                            table = "tea_users";
                            break;
                        case 3:
                            table = "admin_users";
                            break;
                        default:
                            return;
                    }

                    cmd.CommandText =
                        "select Password from " + table + " where UserName='" + usn + "'"; //sql操作，拼接常量容易受到sql的注入攻击
                    var objpsw = cmd.ExecuteScalar(); //获取数据，装箱操作。Scalar只能返回一个值
                    if (objpsw == null) //obj=null是查询不到用户名
                    {
                        Label1.Text = "用户名/密码不正确";
                    }
                    else
                    {
                        if (objpsw.ToString() == psw)
                        {
                            Label1.Text = "用户名密码正确，登录成功";
                            //写入登录标志
                            Session["UserName"] = usn;
                            Session["UserRole"] = userrole;
                            if (userrole == 1 || userrole == 2)
                            {
                                cmd.CommandText = "select Class from " + table + " where UserName='" + usn + "'";
                                var objclass = cmd.ExecuteScalar();
                                Session["Class"] = objclass.ToString();
                            }

                            FormsAuthentication.RedirectFromLoginPage(usn, false);
                            Response.Redirect("default.aspx");
                        }
                        else
                        {
                            Label1.Text = "用户名/密码不正确";
                        }
                    }
                }

                cns.Close(); //关闭数据库连接
            }
            catch (Exception e_msg)
            {
                Label1.Text = "连接数据库出错，请重试。" + e_msg.Message; //具体出错信息通常只保存在后台为调试所用
            }

            cns.Dispose(); //清除cns这个对象所占用的内存空间（可有可无，此方法运行完自动擦掉）
        }
    }
}