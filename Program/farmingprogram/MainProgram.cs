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
using System.Data.SqlClient;

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
            // TODO: This line of code loads data into the 'farmingDataSet.Container' table. You can move, or remove it, as needed.
            this.containerTableAdapter.Fill(this.farmingDataSet.Container);
            // TODO: This line of code loads data into the 'farmingDataSet.Field' table. You can move, or remove it, as needed.
            this.fieldTableAdapter.Fill(this.farmingDataSet.Field);
            // TODO: This line of code loads data into the 'farmingDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.farmingDataSet.Staff);
            // TODO: This line of code loads data into the 'farmingDataSet.Fertilizer' table. You can move, or remove it, as needed.
            this.fertilizerTableAdapter.Fill(this.farmingDataSet.Fertilizer);
            // TODO: This line of code loads data into the 'farmingDataSet.Crop' table. You can move, or remove it, as needed.
            this.cropTableAdapter.Fill(this.farmingDataSet.Crop);            
        }   
        private void removeCropButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int toDelete = dataGridView.SelectedRows.Count;
                while (toDelete-- > 0)
                {
                    FarmingDataSet.CropRow row = ((FarmingDataSet.CropRow)(dataGridView.Rows[dataGridView.SelectedRows[toDelete].Index].DataBoundItem as DataRowView).Row);
                    cropTableAdapter.Delete(row.CropID, row.CropName, row.DatePlanted, row.EstimatedHarvestDate, row.CropNotes, row.FertilizerID, row.CropStatus, row.LastDose, row.NextDose, row.DosedByStaff, row.CropStorageType, row.CropMinMax, row.FieldID);
                    farmingDataSet.Crop.RemoveCropRow(row);
                    cropTableAdapter.Update(farmingDataSet.Crop);
                }
            }
            else
            {
                MessageBox.Show("You have nothing selected to delete");
            }
        }

        private void addCropButton_Click(object sender, EventArgs e)
        {
            cropTableAdapter.Insert(cropName.Text, datePlanted.Value, estimatedHarvest.Value, cropNotes.Text, Int32.Parse(fertilizerId.ValueMember), cropStatus.Text, lastDose.Value, nextDose.Value, Int32.Parse(dosedBy.ValueMember), Int32.Parse(containerStorageType.ValueMember), cropMinMax.Text, Int32.Parse(fieldId.ValueMember));
            this.cropTableAdapter.Fill(this.farmingDataSet.Crop);
            dataGridView.Refresh();
        }        
    }
}
