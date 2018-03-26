using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using BusinessLogic;

namespace Proj1
{
    public partial class Registeration_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i;
            try
            {
                UserBO obj = new UserBO();
                obj.Fname = fname.Text;
                obj.Lname = lname.Text;
                obj.Email = email.Text;
                obj.Pass = pass.Text;
                obj.Addr = addr.Text;

                obj.State = int.Parse(DropDownList1.SelectedValue);
                obj.City = int.Parse(DropDownList2.SelectedValue);

                UserBL ubl = new UserBL();
                 i = ubl.SaveUserRegisteration(obj);

                 if (i > 0)
                 {
                     Response.Write("<script>alert('Insert successful')</scipt>");
                 }

            }
            catch
            {


            }
            finally {

                
            }
        }
    }
}