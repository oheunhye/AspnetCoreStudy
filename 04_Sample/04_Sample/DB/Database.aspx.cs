using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//추가
using System.Data;
using System.Data.SqlClient;

namespace _04_Sample.DB
{
    public partial class Database : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string source = @"Data Source =.\SQLEXPRESS;attchDbFileName=c:\SqlData\justsample.mdf;
            Intergrated Security = true;User Instance = true";

            SqlConnection conn = new SqlConnection(source);
            conn.Open();
            //명령실행동작
            //string sql = "SELECT * FROM info";
            //연산동작을 위한 작업
            string sql = "SELECT count(*) FROM info";

            SqlCommand cmd = new SqlCommand(sql, conn);
             SqlDataReader reader = cmd.ExecuteReader();
            //연산결과를 받기
            string cnt = cmd.ExecuteScalar().ToString();
            Response.Write("회원 총 인원수:"+cnt);
            //브라우저에 결과 표시
           
            Response.Write("<table border=1>");
            while(reader.Read())
            {
                Response.Write("<tr>");
                for(int i=0; i<reader.FieldCount;i++)
                {
                    Response.Write("<td>"+reader[i]+"/td");

                }
                Response.Write("</tr>");
            }
            Response.Write("/table");
            //연결해제
            reader.Close();
            conn.Close();
        }
    }
}