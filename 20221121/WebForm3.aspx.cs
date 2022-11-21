using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20221121
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] html_value = new string[5];
            if (Request.QueryString != null)
            {
                for(int i = 0; i < Request.QueryString.Count; i++)
                {
                    html_value[i] = Server.UrlDecode(Request.QueryString[i]);
                }
            }
            Label1.Text = html_value[0];
            Label2.Text = html_value[1];
        }
    }
}