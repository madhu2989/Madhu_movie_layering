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
    public partial class view1 : System.Web.UI.Page
    {
        MovieBLL mbll = new MovieBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["userId"]!=null)
                {
                    if (Session["userId"].ToString() != "1")
                    {
                        Response.Redirect("login.aspx");
                    }
                   
                }
                else
                {
                    binddetails();
                }
            }
               
           
        }
        public void binddetails()
        {
            DataSet ds = new DataSet();
            ds = mbll.display();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandArgument!=null)
            {
                if(e.CommandName.ToLower()=="cmddelete")
                {
                    int d = Convert.ToInt16(e.CommandArgument);                    
                    mbll.delete(d);
                    Response.Redirect("view.aspx");
                }
            }
        }
    }
}