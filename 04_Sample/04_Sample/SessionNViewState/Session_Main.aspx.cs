using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample.SessionNViewState
{
    public partial class Session_Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "id :" + Session["id"] + " pw :" + Session["pw"]+"접속하셨습니다.";
        }
    }
}