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
            FarmingDataSet.initializeFieldSet();
            FarmingDataSet.initializeStaffSet();
            FarmingDataSet.initializeFertilizerSet();
            FarmingDataSet.initializeContainerSet();
            FarmingDataSet.initializeCropSet();
            cropGridView.DataSource = cropBindingSource;
            this.cropGridView.DataError += new DataGridViewDataErrorEventHandler(DataGridView1_DataError);
            this.Refresh();
        }

        #region Crop Tab
        private void removeCropButton_Click(object sender, EventArgs e)
        {
            Boolean notifyDelete = false;
            if (cropGridView.SelectedRows.Count > 0)
            {
                int toDelete = cropGridView.SelectedRows.Count;
                while (toDelete-- > 0)
                {
                    int indexToDelete = cropGridView.SelectedRows[toDelete].Index;
                    if (FarmingDataSet.deleteCrop((int)cropGridView.Rows[indexToDelete].Cells["CropID"].Value) == 1)
                    {
                        this.cropGridView.Rows.Remove(cropGridView.Rows[indexToDelete]);
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

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

            MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
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
        #endregion

        #region Fertilizer tab
        private void removeFertilizer_Click(object sender, EventArgs e)
        {
            if (fertilizerGridView.SelectedRows.Count > 0)
            {
                int toDelete = fertilizerGridView.SelectedRows.Count;
                while (toDelete-- > 0)
                {
                   
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
            /*fertilizerTableAdapter.Insert(fertilizerName.Text, fertilizerDose.Text, fertilizerNote.Text);
            this.fertilizerTableAdapter.Fill(this.farmingDataSet.Fertilizer);*/
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

        private void cropRowEdited(object sender, DataGridViewCellEventArgs e)
        {
            //SqlConnector.getConnection().Open();
            //List<DataGridViewRow> editedRows = new List<DataGridViewRow>();

            //FarmingDataSet.cropDataAdapter.Update(cropGridView.Rows, "Crop");
            
            //SqlConnector.getConnection().Close();
        }
    }
}
