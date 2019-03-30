using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace masternew
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            ((admin)Master).Btnsave.Click += new EventHandler(Btnsave_Click);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        void GetData()
        {
            string source =@"Data Source=mycomputer\sqlexpress;Initial Catalog=DBstudent;Integrated Security=True;Pooling=False";
            string select="select *from tblStudent where fname like''%"+((admin)Master).Txtname.Text+"%";
            SqlConnection con = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand(select, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridView2.DataSource = reader;
            GridView2.DataBind();
            con.Close();

        }

        protected void Btnsave_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }


}