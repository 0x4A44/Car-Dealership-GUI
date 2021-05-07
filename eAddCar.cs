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
    public partial class eAddCar : UserControl
    {
        public EventHandler addBut;
        public EventHandler refreshBut;
        public eAddCar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void fillMakeComboBox()
        {
            string query = "SELECT * FROM make order by make";
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            makeComboBox.DataSource = dt;
            makeComboBox.DisplayMember = ("make");
            makeComboBox.ValueMember = ("makeid");
            makeComboBox.SelectedIndex = -1;
        }

        public void fillModelComboBox()
        {
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            string make = makeComboBox.GetItemText(makeComboBox.SelectedItem);
            string makeQuery = "SELECT makeid from make where make = '" + make + "'";
            
            string makeid = "";
            SqlCommand cmd = new SqlCommand(makeQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                makeid = reader["makeid"].ToString();
            }
            con.Close();
            string query = "SELECT * FROM model where makeid = '" + makeid + "' order by model";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            modelComboBox.DataSource = dt;
            modelComboBox.DisplayMember = ("model");
            modelComboBox.ValueMember = ("modelid");
            modelComboBox.SelectedIndex = -1;
        }

        public void fillColorComboBox()
        {
            string query = "SELECT * FROM color order by color";
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            colorComboBox.DataSource = dt;
            colorComboBox.DisplayMember = ("color");
            colorComboBox.SelectedIndex = -1;
        }

        public void fillLotComboBox()
        {
            string query = "SELECT streetName, lotid FROM lot order by streetName";
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lotComboBox.DataSource = dt;
            lotComboBox.DisplayMember = ("streetName");
            lotComboBox.ValueMember = ("lotid");
            lotComboBox.SelectedIndex = -1;
        }

        public ComboBox getmakeCombo()
        {
            return this.makeComboBox;
        }

        public ComboBox getmodelCombo()
        {
            return this.modelComboBox;
        }

        public ComboBox getcolorCombo()
        {
            return this.colorComboBox;
        }

        public ComboBox getyearCombo()
        {
            return this.yearComboBox;
        }

        public ComboBox getLotCombo()
        {
            return this.lotComboBox;
        }

        public TextBox getPriceBox()
        {
            return this.priceTextBox;
        }

        public TextBox getMileageBox()
        {
            return this.mileageTextBox;
        }

        public DataGridView getGridView()
        {
            return this.dataGridView1;
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            addBut.Invoke(this, e);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshBut.Invoke(this, e);
        }

        private void makeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillModelComboBox();
        }
    }
}
