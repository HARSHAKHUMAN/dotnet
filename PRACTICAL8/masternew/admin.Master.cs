using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace masternew
{
    public partial class admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public Button Btnsave
        {
            get { return btnsave; }
        }
        public TextBox Txtname
        {
            get { return txtname; }
        }

       
    }
}