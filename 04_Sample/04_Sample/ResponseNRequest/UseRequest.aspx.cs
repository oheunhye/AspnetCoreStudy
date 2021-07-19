using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample.ResponseNRequest
{
    public partial class UseRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Request로 들어온 정보를 get으로 다른 페이지로 보냄
            string urlInfo;
            urlInfo = "RequestResult.aspx?irum="+TextBox1.Text+"&email="+TextBox2.Text;
            Response.Redirect(urlInfo);
        }
    }
}