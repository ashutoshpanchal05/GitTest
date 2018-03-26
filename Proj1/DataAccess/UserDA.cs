using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    class UserDA
    {


        public SqlConnection scon;
        public SqlCommand scmd;

        public void DBConnectMethod(String tcmd)
        {
            

            try
            {

                scon = new SqlConnection();
                scmd = new SqlCommand();
                scon.ConnectionString = "Data Source=ROCK;Initial Catalog=MyProject;Integrated Security=True";
                scon.Open();
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.CommandText = tcmd;
                scmd.Connection = scon;
                scmd.Parameters.Add("@fname", SqlDbType.VarChar, 10).Value = tb1.Text;
                scmd.Parameters.Add("@lname", SqlDbType.VarChar, 10).Value = tb2.Text;
                scmd.Parameters.Add("@email", SqlDbType.VarChar, 10).Value = tb3.Text;
                scmd.Parameters.Add("@pass", SqlDbType.VarChar, 10).Value = tb4.Text;
                scmd.Parameters.Add("@addr", SqlDbType.VarChar, 10).Value = tb5.Text;
                scmd.Parameters.Add("@state", SqlDbType.Int).Value = d1.SelectedValue;
                scmd.Parameters.Add("@city", SqlDbType.Int).Value = d2.SelectedValue;

                int i = scmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            { }
            finally { }


        }
    }
}
