using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace test
{
    public partial class ColorChart : UserControl
    {
        public EventHandler backbut;
        public ColorChart()
        {
            InitializeComponent();
        }

        public Chart getChart()
        {
            return chart1;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backbut.Invoke(this, e);
        }
    }
}
