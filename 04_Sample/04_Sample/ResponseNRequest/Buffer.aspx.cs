using _04_Sample.NewFolder1;
using _04_Sample.pro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static _04_Sample.pro.Model;

namespace _04_Sample.ResponseNRequest
{
    public partial class Buffer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //결과를 뿌려줌
            Response.Write(DateTime.Now.ToString("yyyy-MM-dd"));
            Response.Write("에 남긴 메세지" + TextBox1.Text);

            //Response.Flush(); 버퍼에 저장된 정보 모두 보여줌
            //Response.Clear(); 위 삭제되고 아래 내용만 출력
            Response.End(); //버퍼가 종료되 아래 내용은 출력되지 않음
            Response.Write("고객님 성원에 감사룽");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            info model = new info();
            model.ID = "hae0905";
            model.name = "오은혜";
            model.sex = "Famle";
            model.age = "29";
            model.phone = "01050091617";
            model.address = "tokyo, nerima-ku";

            bool result = new repository().UpdateInfo(model);
        }
    }
}