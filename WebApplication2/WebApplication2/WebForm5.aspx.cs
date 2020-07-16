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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //学生离校登记
            string Constr = @"Data Source=.\sqlexpress;Initial Catalog=Database2;Integrated Security=True";
            ClientScriptManager scriptManager = ((Page)System.Web.HttpContext.Current.Handler).ClientScript;
            SqlConnection cns = new SqlConnection(Constr);
            try
            {
                cns.Open();
                if (cns.State == ConnectionState.Open)
                {
                    // Label1.Text = Login1.UserName;
                    // Label2.Text = Login1.Password;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cns;
                    cmd.CommandText = "select Id from [Table] where Name = N'" + Login1.UserName + "'";
                    // cmd.CommandText = "select Name from [Table] where Id ='"+Login1.Password+"'";
                    object obj = cmd.ExecuteScalar();
                    if (obj == null)
                    {
                        scriptManager.RegisterStartupScript(typeof(string), "1", "alert('obj==null');", true);
                    }
                    else
                    {
                        if (obj.ToString() == Login1.Password)
                        {
                            cmd.CommandText = "update [Table] set Position= null, Pick=null where Id='" + Login1.Password + "'";
                            cmd.ExecuteNonQuery();
                            Session["Position"] = "Out";
                            e.Authenticated = true;
                        }

                    }
                }
                cns.Close();
                cns.Dispose();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
                scriptManager.RegisterStartupScript(typeof(string), "2", "alert('Catch wrong!');", true);
            }
        }
    }
}