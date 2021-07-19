using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample.ServerNApplication
{
    public partial class Application_main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Application변수가 잘 공유되는지 확인
            TextBox1.Text = Application.Get("qwe").ToString();
            int price = 27000 * int.Parse(Application.Get("qwe").ToString());
            Response.Write("총 판매금액은 " + price+"원입니다.");
        }
    }
}