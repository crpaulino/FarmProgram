using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Class
{
    public partial class VehicleForm : Form
    {

        public VehicleForm()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1 = textBox1.Text;
        }
    }
}
