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
    public partial class EmployeeSignUpForm : Form
    {
        public EmployeeSignUpForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string fn = EFNTextBox.Text;
            string ln = ELNTextBox.Text;
            string username = EUserTextBox.Text;
            string pass = EPassTextBox.Text;
            if (fn == "" | ln == "" | username == "" | pass == "")
            {
                MessageBox.Show("Please fill in all information");

            }
            else 
            {
                addEmployee();
            }
            
            EFNTextBox.Clear();
            ELNTextBox.Clear();
            EUserTextBox.Clear();
            EPassTextBox.Clear();

        }

        private void addEmployee()
        {
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            string firstName = EFNTextBox.Text;
            string lastName = ELNTextBox.Text;
            string username = EUserTextBox.Text;
            string password = EPassTextBox.Text;
            con.Open();
            string query = "INSERT INTO salesperson values('" + lastName + "','" + firstName + "','" + username + "','" + password + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand(query, con);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Employee Added");
            cmd.Dispose();
            con.Close();
        }
    }
}
