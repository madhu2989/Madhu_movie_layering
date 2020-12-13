using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class LoginBO
    {
        int userId;
        public int UserId
        {
            get { return userId; }
            set {  userId=value; }
        }

        string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
