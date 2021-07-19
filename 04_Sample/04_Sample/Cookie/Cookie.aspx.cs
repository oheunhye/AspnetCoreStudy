using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample.Cookie
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Label1.Text = "guest님 처음 방문을 환영합니다.";
            }
            else
            {
                if(Request.Cookies["interest"] != null)
                {
                    //Cookie는 문자가 깨지는 경우가 빈번하므로 문자인코딩을 해야함
                    // Server.HtmlEncode
                    Label1.Text = " 지난 번 관심영역은 " +
                                  Server.HtmlEncode(Request.Cookies["interest"].Value) +
                                  "입니다.";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {   
            //쿠키 객체 생성
            HttpCookie cookie = new HttpCookie("interest");
            //쿠키값 저장
            cookie.Value = DropDownList1.SelectedValue;
            //쿠키의 만료일 지정 (1달)
            cookie.Expires = DateTime.Now.AddDays(30);
            //쿠키 객체를 추가
            Response.Cookies.Add(cookie);
        }
    }
}