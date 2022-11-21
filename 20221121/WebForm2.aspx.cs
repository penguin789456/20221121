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
            TextBox[] userbox = { namebox, genserbox };
            string[] userinfor = new string[userbox.Length];
            for(int i = 0; i < userinfor.Length; i++)
            {
                userinfor[i] = Server.UrlEncode(userbox[i].Text);
            }
            Response.Redirect("WebForm3.aspx?name="+userinfor[0]+"&gender="+ userinfor[1]);
            
        }
    }
}