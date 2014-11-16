using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace farmingprogram
{
    //Created by 1333187
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

     

        private Crop dataGridToCrop(DataGridViewRow row)
        {
            int columnSize = row.Cells.Count;
            object[] data = new object[13];
            for (int i = 0; i < row.Cells.Count; i++)
            {

                data[0] = row.Cells[i].Value;
            }

            Crop crop;


            crop = new Crop((int)row.Cells[0].Value,
                row.Cells[1].Value.ToString(),
                (DateTime)row.Cells[2].Value,
                (DateTime)row.Cells[3].Value,
                row.Cells[4].Value.ToString(),
                (int)row.Cells[5].Value,
                row.Cells[6].Value.ToString(),
                (DateTime)row.Cells[7].Value,
                (DateTime)row.Cells[8].Value,
                row.Cells[9].Value.ToString(),
                row.Cells[10].Value.ToString(),
                row.Cells[11].Value.ToString(),
                (int)row.Cells[12].Value);       
           
            return crop;
        }

        private void removeCropButton_Click(object sender, EventArgs e)
        {
            Crop crop = dataGridToCrop(dataGridView1.Rows[0]);

            Clipboard.SetText(cropTableAdapter.Adapter.DeleteCommand.CommandText, TextDataFormat.Text);
            MessageBox.Show(cropTableAdapter.Adapter.DeleteCommand.CommandText);


            farmingDataSet.Crop.RemoveCropRow(farmingDataSet.Crop.FindByCropID(10)); ;

            cropTableAdapter.Delete(crop.cropId, crop.cropName, crop.datePlanted, crop.estimatedHarvestDate, crop.cropNotes, crop.fertilizerID, crop.cropStatus, crop.lastDose, crop.nextDose, crop.dosedByStaff, crop.cropStorageType, crop.cropMinMax, crop.fieldID);

           // cropTableAdapter.Update(farmingDataSet.Crop);
        }

    }
}
