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
    public partial class welcomeguest : System.Web.UI.Page
    {
        MovieBO mbo = new MovieBO();
        DataSet ds = new DataSet();
        MovieBLL mbll = new MovieBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] != null)
            {
                if (Session["userId"].ToString() != "1")
                {
                    Label2.Text = "Welcome " + Session["userName"];
                    if (!Page.IsPostBack)
                    {
                        dropseat();
                        dropmovie();
                        if (Request.QueryString["id"] != null)
                        {
                            bindbydetails();
                        }
                    }
                }
                else
                {
                    Response.Redirect("welcomeadmin.aspx");
                }

            }
            else
            {
                Response.Redirect("login.aspx");
            }


        }

        public void bindbydetails()
        {
            int d = Convert.ToInt32(Request.QueryString["id"].ToString());
            ds = mbll.viewbyid(d);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                TextBox1.Text = ds.Tables[0].Rows[0]["cusName"].ToString();
                TextBox2.Text = ds.Tables[0].Rows[0]["mobileNo"].ToString();
                DropDownList1.Text = ds.Tables[0].Rows[0]["movieId"].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0]["NoOfTickets"].ToString();
                DropDownList2.Text = ds.Tables[0].Rows[0]["seatId"].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0]["amount"].ToString();

            }
        }

        public void dropmovie()
        {
            ds = mbll.dropmov();
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "movie";
            DropDownList1.DataValueField = "movieId";
            DropDownList1.DataBind();
        }

        public void dropseat()
        {
            ds = mbll.dropseat();
            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "seattype";
            DropDownList2.DataValueField = "seatId";
            DropDownList2.DataBind();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList2 != null)
            {
                int sid = Convert.ToInt32(DropDownList2.SelectedValue);
                double p = mbll.getprice(sid);
                double amt = p * (Convert.ToInt32(TextBox3.Text));
                TextBox4.Text = amt.ToString();
            }

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (TextBox3.Text != null)
            {
                int seatId = Convert.ToInt32(DropDownList2.SelectedValue);
                double p = mbll.getprice(seatId);
                double amt = p * (Convert.ToInt32(TextBox3.Text));
                TextBox4.Text = amt.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Request.QueryString["id"]!=null)
            {
                int d= Convert.ToInt32(Request.QueryString["id"].ToString());
            }
            else
            {
                mbo.CusId = 0;
            }                        
            mbo.CusName = TextBox1.Text;
            mbo.MobileNo = Convert.ToDouble(TextBox2.Text);
            mbo.MovieId = Convert.ToInt16(DropDownList1.SelectedValue);
            mbo.NoOfTickets = Convert.ToInt32(TextBox3.Text);
            mbo.SeatId = Convert.ToInt32(DropDownList2.SelectedValue);
            mbo.Totalamt = Convert.ToDouble(TextBox4.Text);

            int r = mbll.bookticket(mbo);
            if (r > 0)
            {
                Label2.Text = "your booking id is " + r;
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewguest.aspx");
        }
    }
}