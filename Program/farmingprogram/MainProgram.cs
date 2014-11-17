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

        #region Crop Tab
        private void removeCropButton_Click(object sender, EventArgs e)
        {
            if (cropGridView.SelectedRows.Count > 0)
            {
                int toDelete = cropGridView.SelectedRows.Count;
                while (toDelete-- > 0)
                {
                    FarmingDataSet.CropRow row = ((FarmingDataSet.CropRow)(cropGridView.Rows[cropGridView.SelectedRows[toDelete].Index].DataBoundItem as DataRowView).Row);
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
            if (handleNullOrWhitespace(cropName) || handleNullOrWhitespace(cropStatus) || handleNullOrWhitespace(cropMinMax))
            {
                return;
            }
            cropTableAdapter.Insert(cropName.Text, datePlanted.Value, estimatedHarvest.Value, cropNotes.Text, Int32.Parse(fertilizerId.SelectedValue.ToString()), cropStatus.Text, lastDose.Value, nextDose.Value, Int32.Parse(dosedBy.SelectedValue.ToString()), Int32.Parse(containerStorageType.SelectedValue.ToString()), cropMinMax.Text, Int32.Parse(fieldId.SelectedValue.ToString()));
            this.cropTableAdapter.Fill(this.farmingDataSet.Crop);
            cropGridView.Refresh();
        }
        #endregion

        #region Fertilizer tab
        private void removeFertilizer_Click(object sender, EventArgs e)
        {
            if (fertilizerGridView.SelectedRows.Count > 0)
            {
                int toDelete = fertilizerGridView.SelectedRows.Count;
                while (toDelete-- > 0)
                {
                    FarmingDataSet.FertilizerRow row = ((FarmingDataSet.FertilizerRow)(fertilizerGridView.Rows[fertilizerGridView.SelectedRows[toDelete].Index].DataBoundItem as DataRowView).Row);
                    fertilizerTableAdapter.Delete(row.FertilizerID, row.fertName, row.fertDose, row.fertNote);
                    farmingDataSet.Fertilizer.RemoveFertilizerRow(row);
                    fertilizerTableAdapter.Update(farmingDataSet.Fertilizer);
                }
            }
            else
            {
                MessageBox.Show("You have nothing selected to delete");
            }
        }

        private void addFertilizer_Click(object sender, EventArgs e)
        {
            if (handleNullOrWhitespace(fertilizerName) || handleNullOrWhitespace(fertilizerNote) || handleNullOrWhitespace(fertilizerDose))
            {
                return;
            }
            fertilizerTableAdapter.Insert(fertilizerName.Text, fertilizerDose.Text, fertilizerNote.Text);
            this.fertilizerTableAdapter.Fill(this.farmingDataSet.Fertilizer);
            fertilizerGridView.Refresh();
        }
        #endregion

        public Boolean handleNullOrWhitespace(TextBox box)
        {
            if (String.IsNullOrWhiteSpace(box.Text))
            {
                MessageBox.Show(box.Name + " cannot be empty.");
                return true;
            }
            return false;
        }
    }
}
