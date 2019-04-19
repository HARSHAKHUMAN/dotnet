using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebService1 calc = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            lblresult.Text = calc.add(Convert.ToInt16(txta.Text),Convert.ToInt16(txtb.Text)).ToString();
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            lblresult.Text = calc.sub(Convert.ToInt16(txta.Text), Convert
                .ToInt16(txtb.Text)).ToString();
        
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            lblresult.Text = calc.mul(Convert.ToInt16(txta.Text), Convert
                .ToInt16(txtb.Text)).ToString();
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            lblresult.Text = calc.div(Convert.ToDouble(txta.Text), Convert
                 .ToDouble(txtb.Text)).ToString();
        }
    }
}