using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
            Button1.Attributes.Add("OnClick", "this.form.target =");
            Button2.Attributes.Add("OnClick", "this.form.target =''");
            Button3.Attributes.Add("OnClick", "this.form.target ='_blank'");
            Button4.Attributes.Add("OnClick", "this.form.target =''");

            //
            ClientScriptManager scriptManager = ((Page)System.Web.HttpContext.Current.Handler).ClientScript;
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
            string Constr = @"Data Source=.\sqlexpress;Initial Catalog=Database2;Integrated Security=True";
            SqlConnection cns = new SqlConnection(Constr);
            try
            {
                cns.Open();
                if (cns.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cns;
                    cmd.CommandText = "select count(*) from [Table] where Position='School'";
                    object obj = cmd.ExecuteScalar();
                    if (obj == null)
                    {
                        Label4.Text = "NULL";
                    }
                    else
                    {
                        Label4.Text = obj.ToString();
                    }

                    cmd.CommandText = "select count(*) from [Table] where Pick ='CowRoad'";
                    obj = cmd.ExecuteScalar();
                    if (obj == null)
                    {
                        Label2.Text = "NULL";
                    }
                    else
                    {
                        Label2.Text = obj.ToString();
                    }

                    cmd.CommandText = "select count(*) from [Table] where Pick ='SunRoad'";
                    obj = cmd.ExecuteScalar();
                    if (obj == null)
                    {
                        Label6.Text = "NULL";
                    }
                    else
                    {
                        Label6.Text = obj.ToString();
                    }
                }
                cns.Close();
                cns.Dispose();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
                scriptManager.RegisterStartupScript(typeof(string), "", "alert('Catch wrong!');", true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm4.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm5.aspx");
        }
    }
}
