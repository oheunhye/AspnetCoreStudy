using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample
{
    public partial class imageBtn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void imgbtn_Click(object sender, ImageClickEventArgs e)
        {
            Label1.Text = "이미지 클릭위치 정보" + e.X.ToString() +","+ e.Y.ToString();
        }
    }
}