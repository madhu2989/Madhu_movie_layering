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
    public class MovieDAL
    {
        string conString = "Data Source=LENOVO\\SQLEXPRESS; Initial Catalog=Nikhil; Integrated Security=true;";
        SqlConnection con;

        public int bookticket(MovieBO mbo)
        {
            int retid = 0;
            try
            {
                con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("sp_insertbook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cusId", mbo.CusId);
                cmd.Parameters.AddWithValue("@cusName", mbo.CusName);
                cmd.Parameters.AddWithValue("@mobileNo", mbo.MobileNo);
                cmd.Parameters.AddWithValue("@movieId", mbo.MovieId);
                cmd.Parameters.AddWithValue("@NoOfTickets", mbo.NoOfTickets);
                cmd.Parameters.AddWithValue("@seatId", mbo.SeatId);
                cmd.Parameters.AddWithValue("@amount", mbo.Totalamt);

                SqlParameter para = new SqlParameter("@cusIdout", SqlDbType.Int);
                para.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(para);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    retid = Convert.ToInt32(para.Value);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return retid;
        }

        public double getprice(int id)
        {
            try
            {
                con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("getprice", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@seatId", id);
                con.Open();
                double p = Convert.ToDouble(cmd.ExecuteScalar());
                con.Close();
                return p;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet dropmov()
        {
            try
            {
                con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("sp_viewdropmovie", con);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public DataSet dropseat()
        {
            try
            {
                con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("sp_viewdropseat", con);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public int delete(int id)
        {
            try
            {
                con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("sp_deletebookbyid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cusId", id);
                con.Open();
                int p = cmd.ExecuteNonQuery();
                con.Close();
                return p;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet display()
        {
            try
            {
                con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("sp_viewbook", con);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public DataSet viewbyid(int id)
        {
            try
            {
                con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("sp_viewbookbyid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cusId", id);
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
