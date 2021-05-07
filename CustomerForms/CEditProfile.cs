using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class CEditProfile : Form
    {
        string customerid = "";
        public CEditProfile()
        {
            InitializeComponent();
        }

        private void nameChangeButton_Click(object sender, EventArgs e)
        {
            if(CLNTextBox.Text == "")
            {
                MessageBox.Show("Please Fill in All Information");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
                con.Open();
                string query = "update customer set customerLN = '" + CLNTextBox.Text + "'where customerid = " + customerid;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand(query, con);
                da.InsertCommand.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                CLNTextBox.Clear();
                MessageBox.Show("Last Name Changed");

            }
        }

        public void setCustomerID(string id)
        {
            customerid = id;
        }

        private void CEditProfile_Deactivate(object sender, EventArgs e)
        {
            updateName();
        }
        public string updateName()
        {
            string lName = "";
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            SqlCommand cmd = new SqlCommand("select customerLN from customer where customerid = " + customerid);
            cmd.Connection = con;
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lName = reader["customerLN"].ToString();
            }
            con.Close();
            return lName;
        }
    }
}
