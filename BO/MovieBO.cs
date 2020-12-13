using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class MovieBO
    {
        int cusId;
        public int CusId { get; set; }

        string cusName;
        public string CusName { get; set; }

        int movieId;
        public int MovieId { get; set; }

        int noOfTickets;
        public int NoOfTickets { get; set; }

        int seatId;
        public int SeatId { get; set; }

        double totalamt;
        public double Totalamt { get; set; }


        double mobileNo;
        public double MobileNo { get; set; }
    }
}
