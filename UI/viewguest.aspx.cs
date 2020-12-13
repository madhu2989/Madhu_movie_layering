using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class viewguest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["userName"]!=null && Session["userId"].ToString() != "1")
                {
                    binddetails();
                    
                }
                else
                {
                    Response.Redirect("login.aspx");
                }
            }
        }
        public void binddetails()
        {
            MovieBLL mbll = new MovieBLL();
            DataSet ds = new DataSet();
            ds = mbll.display();
            GridView2.DataSource = ds;
            GridView2.DataBind();
        }


        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandArgument!=null)
            {
                if(e.CommandName.ToLower()=="cmdedit")
                {
                    Response.Redirect("welcomeguest.aspx?id="+e.CommandArgument);
                }
            }
        }
    }
}