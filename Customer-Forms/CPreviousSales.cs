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
    public partial class CPreviousSales : UserControl
    {
        public EventHandler backbut;
        public CPreviousSales()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backbut.Invoke(this, e);
        }

        public DataGridView getGridView()
        {
            return this.CprevDataGridView;
        }

        public Label getTotalMoneyLabel()
        {
            return totalMoneyLabel;
        }
    }
}
