using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample
{
    public partial class userMsg : System.Web.UI.UserControl
    {   
        /// <summary>
        ///외부페이지에서 서식 요청이 들어옴
        ///외부의 페이지로 부터 들어오는 값에 따라 속성을 달리가짐
        /// 0일때 애러, 1일때 성공
        /// css의 클래스를 선택하여 뿌려줌
        /// </summary>
        public enum MessageType: int
        {
            Error = 0, Success = 1
        }
        
        public void SetMessage(string sMessage, int a)
        {
            if(a == 0)
            {
                ShowMsg(sMessage, MessageType.Error);
            }
            else if(a == 1)
            {
                ShowMsg(sMessage, MessageType.Success);
            }
        }

        public void ShowMsg(string sMessage, MessageType mType)
        {
            if(mType == MessageType.Error)
            {
                pnlMessage.CssClass = "msg message-error";
            }
            else if(mType == MessageType.Success)
            {
                pnlMessage.CssClass = "msg message-success";
            }

            pnlMessage.Visible = (sMessage.Length > 0);
            litMsg.Text = sMessage;
            litMsg.Visible = true;
        }

        //클릭시 창 닫기
        protected void btnOk_Click(object sender, EventArgs e)
        {
            litMsg.Text = string.Empty;
            pnlMessage.Visible = false;
        }
    }
}