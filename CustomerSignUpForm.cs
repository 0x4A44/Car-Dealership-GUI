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
    public partial class CustomerSignUpForm : Form
    {
        public CustomerSignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string fn = CFNTextBox.Text;
            string ln = CLNTextBox.Text;
            string pn = CPNTextBox.Text;
            string email = CUserTextBox.Text;
            string pass = CPassTextBox.Text;
            if (fn == "" | ln == "" | pn == "" | email == "" | pass == "")
            {
                MessageBox.Show("Please fill in all information");
                
            }
            else
            {
                addCustomer();
            }
            CFNTextBox.Clear();
            CLNTextBox.Clear();
            CPNTextBox.Clear();
            CUserTextBox.Clear();
            CPassTextBox.Clear();
        }

        private void addCustomer()
        {
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            string firstName = CFNTextBox.Text;
            string lastName = CLNTextBox.Text;
            string username = CUserTextBox.Text;
            string password = CPassTextBox.Text;
            string phonenumber = CPNTextBox.Text;
            con.Open();
            string query = "INSERT INTO customer values('" + lastName + "','" + firstName + "','" + username + "','" + password + "', '"+ phonenumber + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand(query, con);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Customer Added");
            cmd.Dispose();
            con.Close();
        }
    }
}
