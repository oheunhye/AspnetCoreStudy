using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample
{
    public partial class _05_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = "반갑습니다. 고객님";
            }
            else
            {
                Label1.Text = "요청하신 현재시간은" + DateTime.Now;
            }
        }
    }
}