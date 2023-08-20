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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                btnlogin.Enabled = true;
            }
            else 
            {
                btnlogin.Enabled = false;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "xxxflow" && txtpassword.Text == "1234")
            {
                board db = new board();
                db.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Enter valid username or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogin.Enabled = false;
        }
    }
}
