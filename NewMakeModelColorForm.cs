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
    public partial class NewMakeModelColorForm : Form
    {
        public NewMakeModelColorForm()
        {
            InitializeComponent();
            string query = "SELECT * FROM make";
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            makeComboBox.DataSource = dt;
            makeComboBox.DisplayMember = ("make");
            makeComboBox.ValueMember = ("makeid");
            makeComboBox.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMake()
        {
            string make = makeTextBox.Text;
            if (make == "")
            {
                MessageBox.Show("Please Fill in All Information");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
                con.Open();
                string query = "INSERT INTO make values('" + make + "');";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand(query, con);
                da.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("You have added a new make");
                makeTextBox.Clear();
                cmd.Dispose();
                con.Close();
            }
        }
        
        private void addMakeButton_Click(object sender, EventArgs e)
        {
            addMake();
        }

        private void addModel()
        {
            string model = modelTextBox.Text;
            string make = makeComboBox.GetItemText(makeComboBox.SelectedItem);
            if (model == "" || make == "")
            {
                MessageBox.Show("Please Fill in All Information");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
                string query = "select makeid from make where make = '" + make + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                string makeid = "";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    makeid = reader["makeid"].ToString();
                }
                con.Close();
                con.Open();
                string query1 = "INSERT INTO model values('" + model + "', " + makeid + ");";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.InsertCommand = new SqlCommand(query1, con);
                da1.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("You have added a new model");
                modelTextBox.Clear();
                cmd1.Dispose();
                con.Close();
            }
        }

        private void addModelButton_Click(object sender, EventArgs e)
        {
            addModel();
        }

        private void addColor()
        {
            string color = colorTextBox.Text;
            if (color == "")
            {
                MessageBox.Show("Please Fill in All Information");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
                con.Open();
                string query = "INSERT INTO color values('" + color + "');";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand(query, con);
                da.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("You have added a new color");
                colorTextBox.Clear();
                cmd.Dispose();
                con.Close();
            }
        }

        private void addColorButton_Click(object sender, EventArgs e)
        {
            addColor();
        }
    }
}
