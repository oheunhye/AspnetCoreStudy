using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
//StringBuilder
using System.Text;


namespace _04_Sample.Practice
{
    public partial class SatisPrint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //스트링빌더 객체생성
            StringBuilder sb = new StringBuilder();
            sb.Append(txtID.Text);
            sb.Append(" ");
            sb.Append(txtEmail.Text);
            sb.Append(" ");
            //관심항목 복수반복
            for (int i=0; i < chkList1.Items.Count; i++)
            {
                if(chkList1.Items[i].Selected)
                {
                    sb.Append(chkList1.Items[i].Value);
                    sb.Append(" ");
                }
            }
            sb.Append(txtMore.Text);
            sb.Append("\r\n");

            //파일에 저장하기
            FileStream fs = new FileStream(@"C:\Users\Y700\Desktop\dataResult.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);

            sw.WriteLine(sb.ToString());
            sw.Close();

        }


    }
}