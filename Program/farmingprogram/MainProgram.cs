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
            programInstance = this; //Sets the program instance
        }

        static MainProgram programInstance = null; //Program instance to grab binding sources from


        public static MainProgram getSingleton() //Singleton pattern followed 'http://www.yoda.arachsys.com/csharp/singleton.html'
        {
            return programInstance;
        }

        //On the load of the main program all datasets are initilialized.
        private void MainProgram_Load(object sender, EventArgs e)
        {
            try
            {
                //All datasets initialized
                FarmingDataSet.initializeFieldSet();
                FarmingDataSet.initializeStaffSet();
                FarmingDataSet.initializeFertilizerSet();
                FarmingDataSet.initializeContainerSet();
                FarmingDataSet.initializeHarvestSet();
                FarmingDataSet.initializeCropSet();
                FarmingDataSet.initializeVehicleSet();
            }
            catch (Exception er) //If not show error
            {
                MessageBox.Show(er.ToString());
            }
            this.Refresh();
        }

        #region Crop Tab
        private void removeCropButton_Click(object sender, EventArgs e) //Remove a crop
        {
            removeRow(cropGridView, "@CropID", 0, FarmingDataSet.cropDataAdapter); //Remove the crop via cropId from the database and GUI
        }

        private void addCropButton_Click(object sender, EventArgs e) //Add a crop
        {
            if (handleNullOrWhitespace(cropName) || handleNullOrWhitespace(cropStatus) || handleNullOrWhitespace(cropMinMax)) //Do not allow nulls of cropName or cropStatus or cropMinMax
            {
                return;
            }
            //New crop object created from user input
            Crop crop  = new Crop(0, cropName.Text, datePlanted.Value, estimatedHarvest.Value, cropNotes.Text, Int32.Parse(fertilizerId.SelectedValue.ToString()), cropStatus.Text, lastDose.Value, nextDose.Value, Int32.Parse(dosedBy.SelectedValue.ToString()), Int32.Parse(containerStorageType.SelectedValue.ToString()), cropMinMax.Text, Int32.Parse(fieldId.SelectedValue.ToString()));
           
            //Add the crop to database
            FarmingDataSet.addCrop(crop);

            //Reinitialize crop data set
            FarmingDataSet.initializeCropSet();
        }

        private void cropRowEdited(object sender, DataGridViewCellEventArgs e) //Called when a row is edited
        {
            updateRow(cropBindingSource, FarmingDataSet.cropDataAdapter, FarmingDataSet.cropDataTable); //Update the database when a row is edited
        }
        #endregion

        #region Fertilizer tab
        private void removeFertilizer_Click(object sender, EventArgs e) //Remove a fertilizer
        {
            removeRow(fertilizerGridView, "@FertilizerID", 0, FarmingDataSet.fertilizerAdapter); //Remove fertilizer from the database and UI
        }

        private void addFertilizer_Click(object sender, EventArgs e) //Add a fertilizer
        {
            if (handleNullOrWhitespace(fertilizerName) || handleNullOrWhitespace(fertilizerNote) || handleNullOrWhitespace(fertilizerDose)) //Do not allow nulls of fertilizerName fertilizerNote and fertilizerDose
            {
                return;
            }
            Fertilizer fertilizer = new Fertilizer(0, fertilizerName.Text, fertilizerDose.Text, fertilizerNote.Text);  //Create new fertilizer object with given user input
            FarmingDataSet.addFertilizer(fertilizer); //Add fertilizer to database
            FarmingDataSet.initializeFertilizerSet(); //Reinit the fertilizer set
        }

        private void fertilizerRowEdited(object sender, DataGridViewCellEventArgs e) //Edited a fertilizer
        {
            updateRow(fertilizerBindingSource, FarmingDataSet.fertilizerAdapter, FarmingDataSet.fertilizerDataTable); //Update the row in the database
        }
        #endregion

        #region Field Tab
        private void addFieldButton_Click(object sender, EventArgs e) //Add a field
        {
            if (handleNullOrWhitespace(fieldNameBox) || handleNullOrWhitespace(fieldStatusBox)) //fieldName and fieldStatus cannot be null
            {
                return;
            }
            Field field = new Field(0, fieldNameBox.Text, fieldStatusBox.Text, fieldNotesBox.Text); //Field object is created
            FarmingDataSet.addField(field); //Field is then added to the database
            FarmingDataSet.initializeFieldSet(); //Field data set is reinitialized
        }

        private void removeFieldButton_Click(object sender, EventArgs e) //Remove a field
        {
            removeRow(fieldGridView, "@FieldID", 0, FarmingDataSet.fieldAdapter); //Remove field from the database
        }

        private void fieldRowEdited(object sender, DataGridViewCellEventArgs e) //Edit a field
        {
            updateRow(fieldBindingSource, FarmingDataSet.fieldAdapter, FarmingDataSet.fieldDataTable); //Update field and update database
        }
        #endregion
        
        #region Container tab
        private void addContainerButton_Click(object sender, EventArgs e)
        {
            if (handleNullOrWhitespace(containerNameBox) || handleNullOrWhitespace(containerSizeBox) || handleNullOrWhitespace(containerTypeBox)) //containerName, containerSize, containerType cannot be null
            {
                return;
            }

            //Parse container size to check if it is a int
            int containerSize; 
            Boolean isInteger = int.TryParse(containerSizeBox.Text, out containerSize);
            
            if(!isInteger) { //If containerSize is not a integer then prompt and edit
                MessageBox.Show("The container size field should be an integer.");
                return;
            }
                
            Container container = new Container(0, containerNameBox.Text, containerTypeBox.Text, containerSize); //Create a new container object
            FarmingDataSet.addContainer(container); //Add the container to the database
            FarmingDataSet.initializeContainerSet(); //Initialize the container dataset again
        }

        private void removeContainerButton_Click(object sender, EventArgs e) //Remove container
        {
            removeRow(containerGridView, "@ContainerID", 0, FarmingDataSet.cropDataAdapter); //Remove the container from the database
        }

        private void containerRowEdited(object sender, DataGridViewCellEventArgs e)
        {
            updateRow(containerBindingSource, FarmingDataSet.containerAdapter, FarmingDataSet.containerDataTable); //Update the container from the database
        }
        #endregion

        #region Harvest tab
        private void addHarvestButton_Click(object sender, EventArgs e) //Add a harvest
        {
            Harvest harvest = new Harvest(0, startDateBox.Value, endDateBox.Value, (int)staffOperatorComboBox.SelectedValue, (int)containerComboBox.SelectedValue, (int)cropComboBox.SelectedValue, (int)fieldComboBox.SelectedValue, (int)vehicleComboBox.SelectedValue); //A harvest object is created
            FarmingDataSet.addHarvest(harvest); //Add a harvest
            FarmingDataSet.initializeHarvestSet(); //Initialize the harvest dataset
        }
        private void harvestRowEdited(object sender, DataGridViewCellEventArgs e) //Edit the harvest row
        {
            updateRow(harvestBindingSource, FarmingDataSet.harvestAdapter, FarmingDataSet.harvestDataTable); //Updates changes to database
        }

        private void removeHarvestButton_Click(object sender, EventArgs e) //Remove the harvest
        {
            removeRow(harvestGridView, "@HarvestID", 0, FarmingDataSet.harvestAdapter); //Removes harvest based on ID
        }
        #endregion

        //Updates via database any modifications to existing data
        private void updateRow(BindingSource bindingSource, SqlDataAdapter adapter, DataTable table) 
        {
            try
            {
                SqlConnector.getConnection().Open(); //Open connection
                Validate(); //Validate edit
                bindingSource.EndEdit(); //Finish editing
                adapter.Update(table); //Update the existing data with new data.
                SqlConnector.getConnection().Close(); //Close connection
            }
            catch (Exception ignore)
            {
            }
        }

        //Removes a row from DataGridView dgv, where the idParam is the parameter string, and the idCell is the id row index of the dataGridView
        private static void removeRow(DataGridView dgv, String idParam, int idCell, SqlDataAdapter adapter)
        {
            Boolean notifyDelete = false; //If data was deleted this flag will turn true
            if (dgv.SelectedRows.Count > 0) //More than 1 selected row
            {
                int toDelete = dgv.SelectedRows.Count; //The amount to delete
                while (toDelete-- > 0) //Whilst there is more to delete
                {
                    int indexToDelete = dgv.SelectedRows[toDelete].Index; //Find index to delete
                    if (FarmingDataSet.deleteFromTable(adapter, idParam, (int)dgv.Rows[indexToDelete].Cells[idCell].Value) == 1) //Delete from database
                    {
                        dgv.Rows.Remove(dgv.Rows[indexToDelete]); //Remove from GUI
                        notifyDelete = true; //notify user
                    }
                }
                if (notifyDelete) //Notify user
                {
                    MessageBox.Show("The data was deleted sucessfully.");
                }
            }
            else //No selected rows
            {
                MessageBox.Show("You have nothing selected to delete"); 
            }
        }

        //Checks for empty text boxes
        public Boolean handleNullOrWhitespace(TextBox box)
        {
            if (String.IsNullOrWhiteSpace(box.Text)) //If the text box is empty notify user
            {
                MessageBox.Show(box.Name + " cannot be empty.");
                return true; //Return true if empty
            }
            return false; //Return false if not empty
        }
    }
}
