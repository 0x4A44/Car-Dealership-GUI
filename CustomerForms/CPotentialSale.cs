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
    public partial class CPotentialSale : UserControl
    {
        public EventHandler backbut;
        public EventHandler removebut;
        public CPotentialSale()
        {
            InitializeComponent();
        }
        public DataGridView getGridView()
        {
            return this.CpotentDataGridView;
        }
        public ComboBox GetComboBox()
        {
            return this.potentComboBox;
        }

        public void fillremovePotentComboBox(string customerid)
        {
            string query = "SELECT potentialsalesid FROM potentialsales where customerid = " + customerid;
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            potentComboBox.DataSource = dt;
            potentComboBox.DisplayMember = ("potentialsalesid");
            potentComboBox.SelectedIndex = -1;
        }

        private void transidLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            backbut.Invoke(this, e);
        }

        private void CRemoveVehicleButton_Click(object sender, EventArgs e)
        {
            removebut.Invoke(this, e);
        }
    }
}
