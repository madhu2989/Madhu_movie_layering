using BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        string conString = "Data Source=LENOVO\\SQLEXPRESS; Initial Catalog=Nikhil; Integrated Security=true;";
        SqlConnection con;

        public DataSet login(LoginBO lbo)
        {
            try
            {
                con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("sp_viewlogmov", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userName", lbo.UserName);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
