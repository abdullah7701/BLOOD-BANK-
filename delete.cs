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
    public partial class delete : Form
    {
        function fn = new function();
        string query;
        public delete()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newID_TextChanged(object sender, EventArgs e)
        {
            if (newID.Text == "")
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
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(newID.Text.ToString());
            query = "select * from newDonor where did = " + id + "";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                txtname.Text = ds.Tables[0].Rows[0][1].ToString();
                txtfather.Text = ds.Tables[0].Rows[0][2].ToString();
                txtdob.Text = ds.Tables[0].Rows[0][3].ToString();
                txtmobile.Text = ds.Tables[0].Rows[0][4].ToString();
                txtgender.Text = ds.Tables[0].Rows[0][5].ToString();
                txtemail.Text = ds.Tables[0].Rows[0][6].ToString();
                txtblood.Text = ds.Tables[0].Rows[0][7].ToString();
                txtcity.Text = ds.Tables[0].Rows[0][8].ToString();
                txtadd.Text = ds.Tables[0].Rows[0][9].ToString();
            }
            else
            {
                MessageBox.Show("INVALID ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newID.Clear();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            newID.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure?","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                query = $"delete from newDonor where did = " + newID.Text + "";
                fn.setDate(query);
            }
        }
    }
}
