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
            programInstance = this;
        }

        static MainProgram programInstance = null;


        public static MainProgram getSingleton()
        {
            return programInstance;
        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
            try
            {
                FarmingDataSet.initializeFieldSet();
                FarmingDataSet.initializeStaffSet();
                FarmingDataSet.initializeFertilizerSet();
                FarmingDataSet.initializeContainerSet();
                FarmingDataSet.initializeHarvestSet();
                FarmingDataSet.initializeCropSet();
                FarmingDataSet.initializeVehicleSet();
                FarmingDataSet.initializeStorageSet();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            this.Refresh();
        }

        #region Crop Tab
        private void removeCropButton_Click(object sender, EventArgs e)
        {
            removeRow(cropGridView, "@CropID", 0, FarmingDataSet.cropDataAdapter);
        }

        private void addCropButton_Click(object sender, EventArgs e)
        {
            if (handleNullOrWhitespace(cropName) || handleNullOrWhitespace(cropStatus) || handleNullOrWhitespace(cropMinMax))
            {
                return;
            }
            Crop crop  = new Crop(0, cropName.Text, datePlanted.Value, estimatedHarvest.Value, cropNotes.Text, Int32.Parse(fertilizerId.SelectedValue.ToString()), cropStatus.Text, lastDose.Value, nextDose.Value, Int32.Parse(dosedBy.SelectedValue.ToString()), Int32.Parse(containerStorageType.SelectedValue.ToString()), cropMinMax.Text, Int32.Parse(fieldId.SelectedValue.ToString()));
            FarmingDataSet.addCrop(crop);
            FarmingDataSet.initializeCropSet();
        }

        private void cropRowEdited(object sender, DataGridViewCellEventArgs e)
        {
            updateRow(cropBindingSource, FarmingDataSet.cropDataAdapter, FarmingDataSet.cropDataTable);
        }
        #endregion

        #region Fertilizer tab
        private void removeFertilizer_Click(object sender, EventArgs e)
        {
            removeRow(fertilizerGridView, "@FertilizerID", 0, FarmingDataSet.fertilizerAdapter);
        }

        private void addFertilizer_Click(object sender, EventArgs e)
        {
            if (handleNullOrWhitespace(fertilizerName) || handleNullOrWhitespace(fertilizerNote) || handleNullOrWhitespace(fertilizerDose))
            {
                return;
            }
            Fertilizer fertilizer = new Fertilizer(0, fertilizerName.Text, fertilizerDose.Text, fertilizerNote.Text);
            FarmingDataSet.addFertilizer(fertilizer);
            FarmingDataSet.initializeFertilizerSet();
        }

        private void fertilizerRowEdited(object sender, DataGridViewCellEventArgs e)
        {
            updateRow(fertilizerBindingSource, FarmingDataSet.fertilizerAdapter, FarmingDataSet.fertilizerDataTable);
        }
        #endregion

        #region Field Tab
        private void addFieldButton_Click(object sender, EventArgs e)
        {
            if (handleNullOrWhitespace(fieldNameBox) || handleNullOrWhitespace(fieldStatusBox))
            {
                return;
            }
            Field field = new Field(0, fieldNameBox.Text, fieldStatusBox.Text, fieldNotesBox.Text);
            FarmingDataSet.addField(field);
            FarmingDataSet.initializeFieldSet();
        }

        private void removeFieldButton_Click(object sender, EventArgs e)
        {
            removeRow(fieldGridView, "@FieldID", 0, FarmingDataSet.fieldAdapter);
        }

        private void fieldRowEdited(object sender, DataGridViewCellEventArgs e)
        {
            updateRow(fieldBindingSource, FarmingDataSet.fieldAdapter, FarmingDataSet.fieldDataTable);
        }
        #endregion
        
        #region Container tab
        private void addContainerButton_Click(object sender, EventArgs e)
        {
            if (handleNullOrWhitespace(containerNameBox) || handleNullOrWhitespace(containerSizeBox) || handleNullOrWhitespace(containerTypeBox))
            {
                return;
            }
            int containerSize;
            Boolean isInteger = int.TryParse(containerSizeBox.Text, out containerSize);
            
            if(!isInteger) {
                MessageBox.Show("The container size field should be an integer.");
                return;
            }
                
            Container container = new Container(0, containerNameBox.Text, containerTypeBox.Text, containerSize);
            FarmingDataSet.addContainer(container);
            FarmingDataSet.initializeContainerSet();
        }

        private void removeContainerButton_Click(object sender, EventArgs e)
        {
            removeRow(containerGridView, "@ContainerID", 0, FarmingDataSet.cropDataAdapter);
        }

        private void containerRowEdited(object sender, DataGridViewCellEventArgs e)
        {
            updateRow(containerBindingSource, FarmingDataSet.containerAdapter, FarmingDataSet.containerDataTable);
        }
        #endregion

        #region Harvest tab
        private void addHarvestButton_Click(object sender, EventArgs e)
        {
            Harvest harvest = new Harvest(0, startDateBox.Value, endDateBox.Value, (int)staffOperatorComboBox.SelectedValue, (int)containerComboBox.SelectedValue, (int)cropComboBox.SelectedValue, (int)fieldComboBox.SelectedValue, (int)vehicleComboBox.SelectedValue);
            FarmingDataSet.addHarvest(harvest);
            FarmingDataSet.initializeHarvestSet();
        }
        private void harvestRowEdited(object sender, DataGridViewCellEventArgs e)
        {
            updateRow(harvestBindingSource, FarmingDataSet.harvestAdapter, FarmingDataSet.harvestDataTable);
        }

        private void removeHarvestButton_Click(object sender, EventArgs e)
        {
            removeRow(harvestGridView, "@HarvestID", 0, FarmingDataSet.harvestAdapter);
        }
        #endregion

        private void updateRow(BindingSource bindingSource, SqlDataAdapter adapter, DataTable table)
        {
            try
            {
                SqlConnector.getConnection().Open();
                Validate();
                bindingSource.EndEdit();
                adapter.Update(table);
                SqlConnector.getConnection().Close();
            }
            catch (Exception ignore)
            {
            }
        }

        private static void removeRow(DataGridView dgv, String idParam, int idCell, SqlDataAdapter adapter)
        {
            Boolean notifyDelete = false;
            if (dgv.SelectedRows.Count > 0)
            {
                int toDelete = dgv.SelectedRows.Count;
                while (toDelete-- > 0)
                {
                    int indexToDelete = dgv.SelectedRows[toDelete].Index;
                    if (FarmingDataSet.deleteFromTable(adapter, idParam, (int)dgv.Rows[indexToDelete].Cells[idCell].Value) == 1)
                    {
                        dgv.Rows.Remove(dgv.Rows[indexToDelete]);
                        notifyDelete = true;
                    }
                }
                if (notifyDelete)
                {
                    MessageBox.Show("The data was deleted sucessfully.");
                }
            }
            else
            {
                MessageBox.Show("You have nothing selected to delete");
            }
        }

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
