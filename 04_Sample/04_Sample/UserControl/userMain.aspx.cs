using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample
{
    public partial class userMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(TextBox1.Text) >= 10)
            {
                //사용자 정의 컨트롤
                messageBox.SetMessage("주문오류 : 주문수량은 10개 미만만 가능합니다.", 0);
            }
            else
            {
                messageBox.SetMessage("주문성공 : 주문되었습니다.", 1);
            }
        }
    }
}