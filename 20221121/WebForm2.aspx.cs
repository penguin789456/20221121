using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20221121
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("尚未回傳");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = namebox.Text,gender=genserbox.Text;
            Response.Redirect("WebForm3.aspx?name="+Server.UrlEncode(name)+"&gender="+ Server.UrlEncode(gender));
            
        }
    }
}