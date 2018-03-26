using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj1
{
    public partial class Registeration_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnect db =new DBConnect();
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.DBConnectMethod("IDate");
        }
    }
}