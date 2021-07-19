using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;    //page객체 사용

namespace _04_Sample
{
    public static class messageBox
    {
        /// <summary>
        /// static 공유가능하게
        /// 클라이언트에서 실행되는 자바스크립트를 서버사이드로 
        /// 자바스크립트 ->html 렌더링
        /// </summary>
        public static void showMsg(string msgText,Page myPage)
        {
            //클라이언트 사이드 스크립트를 시작할때 등록
            myPage.ClientScript.RegisterStartupScript(myPage.GetType(), "Messagebox", "alert('" + msgText + "')", true);
        }
    }
}