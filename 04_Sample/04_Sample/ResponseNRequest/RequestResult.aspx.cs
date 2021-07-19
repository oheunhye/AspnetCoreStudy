using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample.ResponseNRequest
{
    public partial class RequestResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //get으로 요청된 값받기
            Label1.Text = Request.QueryString["irum"];
            Label2.Text = Request.QueryString["email"];
        }
    }
}