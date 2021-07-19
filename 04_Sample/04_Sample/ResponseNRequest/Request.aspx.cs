using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample.ResponseNRequest
{
    public partial class Request : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Request.UserHostAddress;
            HttpBrowserCapabilities browser = Request.Browser;
            TextBox2.Text = browser.Type;
            TextBox3.Text = browser.Platform;
        }
    }
}