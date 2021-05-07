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
    public partial class EPotentialSale : UserControl
    {
        public EventHandler backbut;
        public EventHandler sellbut;
        public EPotentialSale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backbut.Invoke(this, e);
        }

        public DataGridView getGridView()
        {
            return this.potentDataGridView;
        }

        public void fillPotentialSaleComboBox()
        {
            string query = "SELECT potentialsalesid FROM potentialsales";
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            potentComboBox.DataSource = dt;
            potentComboBox.DisplayMember = ("potentialsalesid");
            potentComboBox.SelectedIndex = -1;
        }

        public ComboBox GetComboBox()
        {
            return this.potentComboBox;
        }
        
        private void EsellVehicleButton_Click(object sender, EventArgs e)
        {
            sellbut.Invoke(this, e);
        }
    }
}
