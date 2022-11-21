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
            foreach(string key in Request.QueryString)
            {
                Response.Write("key:"+key+",keyvalue:"+Request.QueryString[key]+"<br>");
            }
            
            
        }
    }
}