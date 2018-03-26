using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
   public class UserBO
    {
        string fname,lname,email,pass,addr;
        int state, city;



        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Pass { get { return pass; } set { pass = value; } }
        public string Addr { get { return addr; } set { addr = value; } }
        public int State { get { return state; } set { state = value; } }
        public int City { get { return city; } set { city = value; } }



    }
}
