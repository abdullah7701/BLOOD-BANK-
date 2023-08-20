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
    public partial class board : Form
    {
        public board()
        {
            InitializeComponent();
        }

        private void board_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dONORToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addnew_donor and = new Addnew_donor();
            and.Show();
        }

        private void updateAllDetialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update udd = new update();
            udd.Show();
        }

        private void allDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            details add = new details();
            add.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchadd sba = new searchadd();
            sba.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchb sd = new searchb();
            sd.Show();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock si = new stock();
            si.Show();
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsstock ds = new dsstock();
            ds.Show();
        }

        private void deleteDonorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delete ds = new delete();
            ds.Show();
        }
    }
}

