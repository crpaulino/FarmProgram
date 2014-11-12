using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using farmingprogram.FarmingDataSetTableAdapters;
//SP1062
namespace farmingprogram
{
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();
        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmingDataSet.Crop' table. You can move, or remove it, as needed.
            this.cropTableAdapter.Fill(this.farmingDataSet.Crop);
        }

        private void removeCropButton_Click(object sender, EventArgs e)
        {
        }
    }
}
