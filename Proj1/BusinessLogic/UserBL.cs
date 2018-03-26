using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using BusinessObject;
using DataAccess;

namespace BusinessLogic
{
     public class UserBL
    {
        public int SaveUserRegisteration(UserBO obj)
        {

            try
            {
                UserDA uda = new UserDA();

                uda.DBConnectMethod(obj);



                int a = 10;
                return a;
            }

            catch (Exception ex)
            {

                throw;

            }
          
        
        
        }


    }
}
