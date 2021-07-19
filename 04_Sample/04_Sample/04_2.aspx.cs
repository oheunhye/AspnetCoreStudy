using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample
{
    public partial class _04_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl2.Text = TextBox1.Text + " 고객님  현재 접속하신 시간은 " + DateTime.Now;
        }
    }
} 