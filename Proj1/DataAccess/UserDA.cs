using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BusinessObject;

namespace DataAccess
{
   public class UserDA
    {


        public SqlConnection scon;
        public SqlCommand scmd;

        public int DBConnectMethod(UserBO bo)
        {
            

            try
            {

                scon = new SqlConnection();
                scmd = new SqlCommand();
                scon.ConnectionString = "Data Source=ROCK;Initial Catalog=MyProject;Integrated Security=True";
                scon.Open();
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.CommandText = "IData";
                scmd.Connection = scon;
                scmd.Parameters.Add("@fname", SqlDbType.VarChar, 10).Value = bo.Fname;
                scmd.Parameters.Add("@lname", SqlDbType.VarChar, 10).Value = bo.Lname;
                scmd.Parameters.Add("@email", SqlDbType.VarChar, 10).Value = bo.Email;
                scmd.Parameters.Add("@pass", SqlDbType.VarChar, 10).Value = bo.Pass;
                scmd.Parameters.Add("@addr", SqlDbType.VarChar, 10).Value = bo.Addr;
                scmd.Parameters.Add("@state", SqlDbType.Int).Value = bo.State;
                scmd.Parameters.Add("@city", SqlDbType.Int).Value = bo.City;

                int i = scmd.ExecuteNonQuery();
                return i;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally {

                scon.Close();
            }


        }
    }
}
