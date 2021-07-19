using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample.SessionNViewState
{
    public partial class Session_intro : System.Web.UI.Page
    {
        //2차원 배열생성
        string[,] userInfo = new string[,]
        { { "momo98", "qq0026" }, { "happy00", "123qq321" },{"mobidic","qwe12" } };

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sw = 0;
            //배열.Length = 배열의 행수*열수 (현재 3*2=6) ->1차원 배열일때 사용
            //배열.GetLength(값)   값=0(1차원배열) 값=1(2차원배열의 요소길이)
            for(int i = 0; i < userInfo.GetLength(1); i++)
            {
                if(userInfo[i,0].Equals(TextBox1.Text) && userInfo[i,1].Equals(TextBox2.Text))
                {
                    sw = 1;
                    break;
                }
                
            }

            if(sw == 1)
            {
                //Session은 객체임
                Session["id"] = TextBox1.Text;
                Session["pw"] = TextBox2.Text;

                Response.Redirect("Session_main.aspx");
                //Server.Transfer("Session_main.aspx");
            }
            else
            {   
                //JS history.back(); 이전화면으로 돌리기
                Response.Write("<script>alert('아이디 또는 비밀번호가 일치하지 않습니다.');" +
                    "history.back();</script>");
                
            }




        }
    }
}