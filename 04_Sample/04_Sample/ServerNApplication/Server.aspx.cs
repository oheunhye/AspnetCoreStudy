using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample.ServerNApplication
{
    public partial class Server : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          TextBox1.Text =  Server.MapPath(".");    //현재 페이지 기점으로 물리적 경로
          TextBox2.Text =  Server.MapPath("~");    //이 프로젝트의 루트부터의 경로
        }
    }
}