using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Sample
{
    public partial class checkBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = string.Empty;
            if (CheckBox1.Checked)
            {
                s += CheckBox1.Text;
            }
            if (CheckBox2.Checked)
            {
                s += CheckBox2.Text;
            }
            if (CheckBox3.Checked)
            {
                s += CheckBox3.Text;
            }
            if (CheckBox4.Checked)
            {
                s += CheckBox4.Text;
            }
            if (CheckBox5.Checked)
            {
                s += CheckBox5.Text;
            }

            lbl결과.Text = s;
        }
    }
}