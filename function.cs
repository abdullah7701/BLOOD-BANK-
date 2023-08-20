using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class function
    {
        protected SqlConnection getconnection()
        {
         SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source = ABDULLAH-PC;Initial Catalog=bloodbank;integrated security = True";
            return con; 
        }
        public DataSet GetData(String query)//get data from data bsae
        {
            SqlConnection con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);   
            return ds;
        }
        public void setDate(String query)//insertion deletion and update
        {
            SqlConnection con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();  
            con.Close();
            MessageBox.Show("data processed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
