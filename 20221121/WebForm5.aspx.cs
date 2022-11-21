using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20221121
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox txt1;
            txt1 = (TextBox)PreviousPage.FindControl("TextBox1");
            Response.Write(txt1.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}