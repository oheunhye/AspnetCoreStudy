using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//FileStream사용
using System.IO;
using System.Text;

namespace _04_Sample.File
{
    public partial class File : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //파일업로드버튼은 보안업그레이드로 서버에 올라가있는것으로 가정하므로
            //로컬에서 가져오면 경로를 못차는 에러가 난다.

            string fullPath = string.Empty;
            fullPath = @"C:\Users\Y700\Desktop\자료\주문목록.txt";
            string a, b = string.Empty;
            //파일읽어오기 준비
            FileStream file = new FileStream(fullPath, FileMode.Open);
            //System.Text.Encoding.Default 기본 문자형식으로 가져옴(=UTF-8)
            StreamReader sIn = new StreamReader(file, System.Text.Encoding.Default);

            //읽어오기
            do
            {
                //한줄씩 읽어 저장
                a = sIn.ReadLine();
                b += a + "\r\n";  //개행문자추가
            } while (a != null);

            //파일 닫기
            sIn.Close();

            TextBox1.Text = b;
        }
    }
}