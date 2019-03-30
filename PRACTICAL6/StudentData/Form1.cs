using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string source = @"Data Source=ce3comp10\sqlexpress;Initial Catalog=Student;Integrated Security=True;Pooling=False";
            string select = "select count(*) from tblStudent";
            SqlConnection conn = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            int i = Convert.ToInt16(cmd.ExecuteScalar());
            int pkStudent = i + 1;

            string insert = "insert into Student_Data (pkStudent, fName,dob, imgStudent) values ( " + pkStudent + ",'" + txtFname.Text + "','" + dateDob.Value.Date + "','" + (imgPath == null ? "" : imgPath) + "' )";
            cmd = new SqlCommand(insert, conn);

            i = cmd.ExecuteNonQuery();
            if (imgPath != null)
                imgStudent.Image.Save(imgPath);
            MessageBox.Show("You are Done!!!");
            InitializeComponent();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpg|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgPath = @"D:\DOT NET\Images\" + openFileDialog1.SafeFileName;
                imgStudent.Image = Image.FromFile(openFileDialog1.FileName);
                MessageBox.Show(imgPath);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
