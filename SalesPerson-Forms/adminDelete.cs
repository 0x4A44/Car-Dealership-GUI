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
    public partial class adminDelete : UserControl
    {
        public EventHandler backbut;
        public EventHandler deletebut;
        public adminDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backbut.Invoke(this, e);
        }

        public void filldeleteVComboBox()
        {
            string query = "select vehicleid from vehicle";
            SqlConnection con = new SqlConnection("server=localhost;database=CarDealership;Trusted_Connection=Yes;");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            deleteVComboBox.DataSource = dt;
            deleteVComboBox.DisplayMember = ("vehicleid");
            deleteVComboBox.SelectedIndex = -1;
        }

        public ComboBox GetComboBox()
        {
            return this.deleteVComboBox;
        }

        public DataGridView getGridView()
        {
            return this.deleteVDataGridView;
        }

        private void EdeleteVehicleButton_Click(object sender, EventArgs e)
        {
            deletebut.Invoke(this, e);
        }
    }
}
