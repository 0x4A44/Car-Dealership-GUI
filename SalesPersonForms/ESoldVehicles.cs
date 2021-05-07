using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class ESoldVehicles : UserControl
    {
        public EventHandler backbut;
        public ESoldVehicles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backbut.Invoke(this, e);
        }

        public DataGridView getGridView()
        {
            return this.dataGridView1;
        }
    }
}
