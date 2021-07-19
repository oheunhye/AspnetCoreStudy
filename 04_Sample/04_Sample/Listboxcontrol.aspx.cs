using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample
{
    public partial class Listboxcontrol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "선택한 항목은 ";
               for(int i =0; i< ListBox1.Items.Count; i++)
               {
                   if(ListBox1.Items[i].Selected)
                   {
                       str += ListBox1.Items[i].Text;
                   }
               }
               Label1.Text = str;
            messageBox.showMsg(str, this.Page);
            /*
            ListBox1.Items.Add(TextBox1.Text);
            TextBox1.Text = string.Empty;
           */
        }


    }
}