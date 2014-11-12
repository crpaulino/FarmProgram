namespace farmingprogram
{
    partial class MainProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addCropButton = new System.Windows.Forms.Button();
            this.removeCropButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.cropIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cropNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePlantedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedHarvestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cropNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fertilizerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cropStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDoseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextDoseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosedByStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cropStorageTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cropMinMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cropBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmingDataSet = new farmingprogram.FarmingDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.logoutButton = new System.Windows.Forms.Button();
           
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cropTableAdapter = new farmingprogram.FarmingDataSetTableAdapters.CropTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1363, 656);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addCropButton);
            this.tabPage1.Controls.Add(this.removeCropButton);
            this.tabPage1.Controls.Add(this.dataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1355, 630);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crops";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addCropButton
            // 
            this.addCropButton.Location = new System.Drawing.Point(1217, 582);
            this.addCropButton.Name = "addCropButton";
            this.addCropButton.Size = new System.Drawing.Size(116, 23);
            this.addCropButton.TabIndex = 2;
            this.addCropButton.Text = "Add Crop";
            this.addCropButton.UseVisualStyleBackColor = true;
            // 
            // removeCropButton
            // 
            this.removeCropButton.Location = new System.Drawing.Point(1086, 582);
            this.removeCropButton.Name = "removeCropButton";
            this.removeCropButton.Size = new System.Drawing.Size(116, 23);
            this.removeCropButton.TabIndex = 1;
            this.removeCropButton.Text = "Remove Crop";
            this.removeCropButton.UseVisualStyleBackColor = true;
            this.removeCropButton.Click += new System.EventHandler(this.removeCropButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cropIDDataGridViewTextBoxColumn,
            this.cropNameDataGridViewTextBoxColumn,
            this.datePlantedDataGridViewTextBoxColumn,
            this.estimatedHarvestDateDataGridViewTextBoxColumn,
            this.cropNotesDataGridViewTextBoxColumn,
            this.fertilizerIDDataGridViewTextBoxColumn,
            this.cropStatusDataGridViewTextBoxColumn,
            this.lastDoseDataGridViewTextBoxColumn,
            this.nextDoseDataGridViewTextBoxColumn,
            this.dosedByStaffDataGridViewTextBoxColumn,
            this.cropStorageTypeDataGridViewTextBoxColumn,
            this.cropMinMaxDataGridViewTextBoxColumn,
            this.fieldIDDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.cropBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(6, 6);
            this.dataGrid.Name = "dataGridView1";
            this.dataGrid.Size = new System.Drawing.Size(1343, 294);
            this.dataGrid.TabIndex = 0;
            // 
            // cropIDDataGridViewTextBoxColumn
            // 
            this.cropIDDataGridViewTextBoxColumn.DataPropertyName = "CropID";
            this.cropIDDataGridViewTextBoxColumn.HeaderText = "CropID";
            this.cropIDDataGridViewTextBoxColumn.Name = "cropIDDataGridViewTextBoxColumn";
            this.cropIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cropNameDataGridViewTextBoxColumn
            // 
            this.cropNameDataGridViewTextBoxColumn.DataPropertyName = "CropName";
            this.cropNameDataGridViewTextBoxColumn.HeaderText = "CropName";
            this.cropNameDataGridViewTextBoxColumn.Name = "cropNameDataGridViewTextBoxColumn";
            // 
            // datePlantedDataGridViewTextBoxColumn
            // 
            this.datePlantedDataGridViewTextBoxColumn.DataPropertyName = "DatePlanted";
            this.datePlantedDataGridViewTextBoxColumn.HeaderText = "DatePlanted";
            this.datePlantedDataGridViewTextBoxColumn.Name = "datePlantedDataGridViewTextBoxColumn";
            // 
            // estimatedHarvestDateDataGridViewTextBoxColumn
            // 
            this.estimatedHarvestDateDataGridViewTextBoxColumn.DataPropertyName = "EstimatedHarvestDate";
            this.estimatedHarvestDateDataGridViewTextBoxColumn.HeaderText = "EstimatedHarvestDate";
            this.estimatedHarvestDateDataGridViewTextBoxColumn.Name = "estimatedHarvestDateDataGridViewTextBoxColumn";
            // 
            // cropNotesDataGridViewTextBoxColumn
            // 
            this.cropNotesDataGridViewTextBoxColumn.DataPropertyName = "CropNotes";
            this.cropNotesDataGridViewTextBoxColumn.HeaderText = "CropNotes";
            this.cropNotesDataGridViewTextBoxColumn.Name = "cropNotesDataGridViewTextBoxColumn";
            // 
            // fertilizerIDDataGridViewTextBoxColumn
            // 
            this.fertilizerIDDataGridViewTextBoxColumn.DataPropertyName = "FertilizerID";
            this.fertilizerIDDataGridViewTextBoxColumn.HeaderText = "FertilizerID";
            this.fertilizerIDDataGridViewTextBoxColumn.Name = "fertilizerIDDataGridViewTextBoxColumn";
            // 
            // cropStatusDataGridViewTextBoxColumn
            // 
            this.cropStatusDataGridViewTextBoxColumn.DataPropertyName = "CropStatus";
            this.cropStatusDataGridViewTextBoxColumn.HeaderText = "CropStatus";
            this.cropStatusDataGridViewTextBoxColumn.Name = "cropStatusDataGridViewTextBoxColumn";
            // 
            // lastDoseDataGridViewTextBoxColumn
            // 
            this.lastDoseDataGridViewTextBoxColumn.DataPropertyName = "LastDose";
            this.lastDoseDataGridViewTextBoxColumn.HeaderText = "LastDose";
            this.lastDoseDataGridViewTextBoxColumn.Name = "lastDoseDataGridViewTextBoxColumn";
            // 
            // nextDoseDataGridViewTextBoxColumn
            // 
            this.nextDoseDataGridViewTextBoxColumn.DataPropertyName = "NextDose";
            this.nextDoseDataGridViewTextBoxColumn.HeaderText = "NextDose";
            this.nextDoseDataGridViewTextBoxColumn.Name = "nextDoseDataGridViewTextBoxColumn";
            // 
            // dosedByStaffDataGridViewTextBoxColumn
            // 
            this.dosedByStaffDataGridViewTextBoxColumn.DataPropertyName = "DosedByStaff";
            this.dosedByStaffDataGridViewTextBoxColumn.HeaderText = "DosedByStaff";
            this.dosedByStaffDataGridViewTextBoxColumn.Name = "dosedByStaffDataGridViewTextBoxColumn";
            // 
            // cropStorageTypeDataGridViewTextBoxColumn
            // 
            this.cropStorageTypeDataGridViewTextBoxColumn.DataPropertyName = "CropStorageType";
            this.cropStorageTypeDataGridViewTextBoxColumn.HeaderText = "CropStorageType";
            this.cropStorageTypeDataGridViewTextBoxColumn.Name = "cropStorageTypeDataGridViewTextBoxColumn";
            // 
            // cropMinMaxDataGridViewTextBoxColumn
            // 
            this.cropMinMaxDataGridViewTextBoxColumn.DataPropertyName = "CropMinMax";
            this.cropMinMaxDataGridViewTextBoxColumn.HeaderText = "CropMinMax";
            this.cropMinMaxDataGridViewTextBoxColumn.Name = "cropMinMaxDataGridViewTextBoxColumn";
            // 
            // fieldIDDataGridViewTextBoxColumn
            // 
            this.fieldIDDataGridViewTextBoxColumn.DataPropertyName = "FieldID";
            this.fieldIDDataGridViewTextBoxColumn.HeaderText = "FieldID";
            this.fieldIDDataGridViewTextBoxColumn.Name = "fieldIDDataGridViewTextBoxColumn";
            // 
            // cropBindingSource
            // 
            this.cropBindingSource.DataMember = "Crop";
            this.cropBindingSource.DataSource = this.farmingDataSet;
            // 
            // farmingDataSet
            // 
            this.farmingDataSet.DataSetName = "FarmingDataSet";
            this.farmingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1355, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1197, 670);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(178, 23);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // cropTableAdapter
            // 
            this.cropTableAdapter.ClearBeforeFill = true;
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 709);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainProgram";
            this.Text = "MainProgram";
            this.Load += new System.EventHandler(this.MainProgram_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private FarmingDataSet farmingDataSet;
        private System.Windows.Forms.BindingSource cropBindingSource;
        private FarmingDataSetTableAdapters.CropTableAdapter cropTableAdapter;
        private System.Windows.Forms.Button addCropButton;
        private System.Windows.Forms.Button removeCropButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cropIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cropNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePlantedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedHarvestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cropNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fertilizerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cropStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDoseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextDoseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosedByStaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cropStorageTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cropMinMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldIDDataGridViewTextBoxColumn;
    }
}