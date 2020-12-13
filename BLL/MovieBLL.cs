using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MovieBLL
    {
        MovieDAL mdal = new MovieDAL();
        public int bookticket(MovieBO mbo)
        {
            return mdal.bookticket(mbo);
        }

        public double getprice(int id)
        {
            return mdal.getprice(id);
        }
        public DataSet dropmov()
        {
            return mdal.dropmov();
        }

        public DataSet dropseat()
        {
            return mdal.dropseat();
        }

        public int delete(int id)
        {
            return mdal.delete(id);
        }
        public DataSet display()
        {
            return mdal.display();
        }
        public DataSet viewbyid(int id)
        {
            return mdal.viewbyid(id);
        }
    }
}
