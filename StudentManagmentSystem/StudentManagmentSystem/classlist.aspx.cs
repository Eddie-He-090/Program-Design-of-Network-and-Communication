using System;
using System.Web.Security;
using System.Web.UI;

namespace StudentManagmentSystem
{
    public partial class classlist : Page
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
                        break;
                    case "2": //教师
                        Panel1.Visible = true;
                        Panel2.Visible = true;
                        Panel3.Visible = false;
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
            }

            Label1.Text = "班级：" + Session["Class"];
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