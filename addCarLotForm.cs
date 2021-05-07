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
    public partial class addCarLotForm : Form
    {
        public addCarLotForm()
        {
            InitializeComponent();
        }
        private void addLot()
        {

            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            string streetName = StreetNameTextBox.Text;
            string streetNum = StreetNumTextBox.Text;
            string state = StateTextBox.Text;
            string city = CityTextBox.Text;
            string zipcode = ZipcodeTextBox.Text;
            if(streetName == "" || streetNum == "" || state == "" || city == "" || zipcode == "") 
            {
                MessageBox.Show("Please Fill in All Information");
            }
            else
            {
                con.Open();
                string query = "INSERT INTO lot values('" + streetNum + "','" + streetName + "','" + state + "','" + city + "','" + zipcode + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand(query, con);
                da.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Lot Added");
                cmd.Dispose();
                con.Close();
                StreetNameTextBox.Clear();
                StreetNumTextBox.Clear();
                StateTextBox.Clear();
                CityTextBox.Clear();
                ZipcodeTextBox.Clear();
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            addLot();
        }
    }
}
