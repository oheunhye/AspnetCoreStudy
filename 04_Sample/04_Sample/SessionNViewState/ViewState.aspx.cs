using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample.SessionNViewState
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //맨처음 접속시 시간
            if(!IsPostBack)
            {
                ViewState["inTime"] = DateTime.Now;
                Label1.Text = "현재시간 " +ViewState["inTime"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //나갈때 시간
            Label1.Text = "처음 접속시간:" + ViewState["inTime"].ToString()
                + "  현재 종료시간:" + DateTime.Now;
        }
    }
}