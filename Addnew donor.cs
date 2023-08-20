using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Addnew_donor : Form
    {
        function fn = new function();
        public Addnew_donor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addnew_donor_Load(object sender, EventArgs e)
        {
            string query = $"select max(did) from newDonor";
            DataSet ds = fn.GetData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
           newID.Text = (count+1).ToString();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtname.Text!="" && txtfather.Text!="" && txtdob.Text!="" && txtblood.Text!="")
            {
                String dname = txtname.Text;
                String fname = txtfather.Text;
                String dob = txtdob.Text;
                Int64 mobile = Int64.Parse(txtmobile.Text);
                String gender = txtgender.Text;
                String email = txtemail.Text;
                String blood = txtblood.Text;
                String city = txtcity.Text;
                String daddress = txtadd.Text;

                string query = $"insert into newDonor (dname,fname,dob,mobile,gender,email,blood,city,daddress) values('" + dname + "','" + fname + "','" + dob + "'," + mobile + ",'" + gender + "','" + email + "','" + blood + "','" + city + "','" + daddress + "')";
                fn.setDate(query);
            }
            else
            {
                MessageBox.Show("Fill all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtfather.Clear();
            txtdob.ResetText();
            txtmobile.Clear();
            txtgender.ResetText();
            txtemail.Clear();
            txtblood.ResetText();
            txtcity.Clear();
            txtadd.Clear();
        }

        private void Addnew_donor_Shown(object sender, EventArgs e)
        {

        }
    }
}
