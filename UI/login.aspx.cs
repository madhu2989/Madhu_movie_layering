using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class login : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LoginBO lbo = new LoginBO();
            lbo.UserName = TextBox1.Text;
            LoginBLL lbll = new LoginBLL();
            DataSet ds = new DataSet();
            ds = lbll.login(lbo);

            if(ds!=null && ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0)
            {
                if (ds.Tables[0].Rows[0]["userPassword"].ToString() == TextBox2.Text)
                {
                    Session["userName"] = ds.Tables[0].Rows[0]["userName"].ToString();
                    Session["userId"] = ds.Tables[0].Rows[0]["userId"].ToString();
                    if(ds.Tables[0].Rows[0]["userId"].ToString()=="1")
                    {
                        
                        Response.Redirect("welcomeadmin.aspx");
                        
                    }
                    else
                    {
                        
                        Response.Redirect("welcomeguest.aspx");
                    }
                }
                else
                {
                    Label1.Text = "invalid credentials";
                    Response.Redirect("login.aspx");
                }
             
                
            }
        }
    }
}