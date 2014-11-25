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
//            FarmingDataSet.initializeContainerSet();
            FarmingDataSet.initializeFieldSet();
            FarmingDataSet.initializeFertilizerSet();
            FarmingDataSet.initializeCropSet();
            DataSet dsCrops= FarmingDataSet.initializeCropSet();
            DataSet dsFertilizer = FarmingDataSet.initializeFertilizerSet(); //1307211
            DataSet dsField = FarmingDataSet.initializeFieldSet(); //1311808
            DataTable dtCrops = dsCrops.Tables[0];
            DataTable dtFertilizer = dsFertilizer.Tables[0];
            DataTable dtField = dsField.Tables[0];
            cropGridView.DataSource = dtCrops;//cropBindingSource;
            fertilizerGridView.DataSource = dtFertilizer; //fertilizer binding source
            //fieldGridView.DataSource = dtField; 
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

        private void addCropButton_Click(object sender, EventArgs e)
        {
            if (handleNullOrWhitespace(cropName) || handleNullOrWhitespace(cropStatus) || handleNullOrWhitespace(cropMinMax))
            {
                return;
            }
           
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
    }
}
