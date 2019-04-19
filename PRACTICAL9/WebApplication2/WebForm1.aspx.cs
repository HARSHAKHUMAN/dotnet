using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        servicecalc.WebService1 c1 = new servicecalc.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            
            lblresult.Text = c1.add(Convert.ToInt16(txt1.Text),Convert.ToInt16(txt2.Text)).ToString();
        
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
        
            lblresult.Text = c1.sub(Convert.ToInt16(txt1.Text),Convert.ToInt16(txt2.Text)).ToString();
        
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            
            lblresult.Text = c1.mul(Convert.ToInt16(txt1.Text),Convert.ToInt16(txt2.Text)).ToString();
        
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            
            lblresult.Text = c1.div(Convert.ToDouble(txt1.Text),Convert.ToDouble(txt2.Text)).ToString();
        
        }
    }
}