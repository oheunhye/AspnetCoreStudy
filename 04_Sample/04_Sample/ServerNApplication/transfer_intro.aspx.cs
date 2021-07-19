using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample.ServerNApplication
{
    public partial class transfer_intro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //서버로 페이지 이동
            //페이지이동은 되지만 URL변경은 안보임
            Server.Transfer("transfer_main.aspx");
            //그저 응답만보내므로 url이 변경됌
            Response.Redirect("transfer_main.aspx");
        }
    }
}