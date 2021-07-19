using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample
{
    public partial class dropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = string.Empty;
            if(DropDownList1.SelectedIndex <= 2)
            {
                str = "기본지출항목입니다. 물가상승에 주의하세요";
                Response.Write("<span style='color:blue'>" + str + "</span>");
                messageBox.showMsg(str, this.Page);
            }
            else
            {
                str = "부수적 지출항목입니다. 지출을 줄이세요";
                Response.Write("<span style='color:red'>" + str + "</span>");
                messageBox.showMsg(str, this.Page);
            }
        }
    }
}