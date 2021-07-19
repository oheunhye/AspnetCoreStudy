using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample.ServerNApplication
{
    public partial class Application_intro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //공유할 Application저장
            Application.Lock(); //사용중 누구도 접근못하게
            Application.Add("goods","까베르네쇼비뇽");
            Application.Add("qwe", 5);
            Application.UnLock(); //해제

            //Application 변수에 저장된 값을 가져오기
            TextBox1.Text = Application.Get("goods").ToString();
            TextBox2.Text = Application.Get("qwe").ToString();
        }
    }
}