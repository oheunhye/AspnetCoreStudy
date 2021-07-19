using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample
{
    public partial class radiobtn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void r1_CheckedChanged(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                r1.Text = "예, 받아보겠습니다.";
                r2.Text = "아니요";
            }
        }
        protected void r2_CheckedChanged(object sender, EventArgs e)
        {
            if (r2.Checked)
            {
                r2.Text = "아니요, 받지 않겠습니다";
                r1.Text = "예";
            }
        }
    }
}