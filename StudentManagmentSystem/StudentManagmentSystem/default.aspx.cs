using System;
using System.Web;
using System.Web.Security;
using System.Web.UI;

namespace StudentManagmentSystem
{
    public partial class _default : Page
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

            //MenuTest.Items.Clear();//首先清空Menu。这一步一定要做，否则会持续向该对象中添加菜单项。       
            //                       //创建一个一级菜单项，并添加到MenuTest菜单控件中     
            //MenuItem itemA = new MenuItem();
            //itemA.Text = "Home Page";
            //itemA.NavigateUrl = "index1.html";
            //MenuTest.Items.Add(itemA);     //创建一个二级菜单项，并添加到MenuTest菜单控件中            
            //MenuItem itemB = new MenuItem();
            //itemB.Text = "Leve 1";

            //MenuItem subItemA = new MenuItem();
            //subItemA.Text = "Level 2.1";
            //subItemA.NavigateUrl = "index2.html";
            //itemB.ChildItems.Add(subItemA);
            //MenuItem subItemB = new MenuItem();
            //subItemB = new MenuItem();
            //subItemB.Text = "Level 2.2";
            //subItemB.NavigateUrl = "index3.html";
            //itemB.ChildItems.Add(subItemB);
            //MenuTest.Items.Add(itemB);
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