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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.containerStorageType = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmingDataSet = new farmingprogram.FarmingDataSet();
            this.fieldId = new System.Windows.Forms.ComboBox();
            this.fieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dosedBy = new System.Windows.Forms.ComboBox();
            this.cropMinMax = new System.Windows.Forms.TextBox();
            this.datePlanted = new System.Windows.Forms.DateTimePicker();
            this.estimatedHarvest = new System.Windows.Forms.DateTimePicker();
            this.cropNotes = new System.Windows.Forms.TextBox();
            this.fertilizerId = new System.Windows.Forms.ComboBox();
            this.fertilizerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nextDose = new System.Windows.Forms.DateTimePicker();
            this.lastDose = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cropStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cropName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cropBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addCropButton = new System.Windows.Forms.Button();
            this.removeCropButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.cropTableAdapter = new farmingprogram.FarmingDataSetTableAdapters.CropTableAdapter();
            this.fertilizerTableAdapter = new farmingprogram.FarmingDataSetTableAdapters.FertilizerTableAdapter();
            this.staffTableAdapter = new farmingprogram.FarmingDataSetTableAdapters.StaffTableAdapter();
            this.fieldTableAdapter = new farmingprogram.FarmingDataSetTableAdapters.FieldTableAdapter();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.containerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.containerTableAdapter = new farmingprogram.FarmingDataSetTableAdapters.ContainerTableAdapter();
            this.cropNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePlantedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedHarvestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cropNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fertilizerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cropStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDoseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextDoseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosedByStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cropStorageTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cropMinMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fertilizerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1355, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.containerStorageType);
            this.tabPage1.Controls.Add(this.fieldId);
            this.tabPage1.Controls.Add(this.dosedBy);
            this.tabPage1.Controls.Add(this.cropMinMax);
            this.tabPage1.Controls.Add(this.datePlanted);
            this.tabPage1.Controls.Add(this.estimatedHarvest);
            this.tabPage1.Controls.Add(this.cropNotes);
            this.tabPage1.Controls.Add(this.fertilizerId);
            this.tabPage1.Controls.Add(this.nextDose);
            this.tabPage1.Controls.Add(this.lastDose);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cropStatus);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cropName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.addCropButton);
            this.tabPage1.Controls.Add(this.removeCropButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1355, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crops";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // containerStorageType
            // 
            this.containerStorageType.DataSource = this.containerBindingSource;
            this.containerStorageType.DisplayMember = "contName";
            this.containerStorageType.FormattingEnabled = true;
            this.containerStorageType.Location = new System.Drawing.Point(285, 603);
            this.containerStorageType.Name = "containerStorageType";
            this.containerStorageType.Size = new System.Drawing.Size(124, 21);
            this.containerStorageType.TabIndex = 45;
            this.containerStorageType.ValueMember = "ContainerID";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.farmingDataSetBindingSource;
            // 
            // farmingDataSetBindingSource
            // 
            this.farmingDataSetBindingSource.DataSource = this.farmingDataSet;
            this.farmingDataSetBindingSource.Position = 0;
            // 
            // farmingDataSet
            // 
            this.farmingDataSet.DataSetName = "FarmingDataSet";
            this.farmingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldId
            // 
            this.fieldId.DataSource = this.fieldBindingSource;
            this.fieldId.DisplayMember = "FieldName";
            this.fieldId.FormattingEnabled = true;
            this.fieldId.Location = new System.Drawing.Point(554, 603);
            this.fieldId.Name = "fieldId";
            this.fieldId.Size = new System.Drawing.Size(124, 21);
            this.fieldId.TabIndex = 44;
            this.fieldId.ValueMember = "FieldID";
            // 
            // fieldBindingSource
            // 
            this.fieldBindingSource.DataMember = "Field";
            this.fieldBindingSource.DataSource = this.farmingDataSetBindingSource;
            // 
            // dosedBy
            // 
            this.dosedBy.DataSource = this.staffBindingSource;
            this.dosedBy.DisplayMember = "FirstName";
            this.dosedBy.FormattingEnabled = true;
            this.dosedBy.Location = new System.Drawing.Point(155, 604);
            this.dosedBy.Name = "dosedBy";
            this.dosedBy.Size = new System.Drawing.Size(124, 21);
            this.dosedBy.TabIndex = 43;
            this.dosedBy.ValueMember = "StaffID";
            // 
            // cropMinMax
            // 
            this.cropMinMax.Location = new System.Drawing.Point(417, 604);
            this.cropMinMax.Name = "cropMinMax";
            this.cropMinMax.Size = new System.Drawing.Size(125, 20);
            this.cropMinMax.TabIndex = 41;
            // 
            // datePlanted
            // 
            this.datePlanted.Location = new System.Drawing.Point(128, 553);
            this.datePlanted.Name = "datePlanted";
            this.datePlanted.Size = new System.Drawing.Size(127, 20);
            this.datePlanted.TabIndex = 38;
            // 
            // estimatedHarvest
            // 
            this.estimatedHarvest.Location = new System.Drawing.Point(261, 554);
            this.estimatedHarvest.Name = "estimatedHarvest";
            this.estimatedHarvest.Size = new System.Drawing.Size(127, 20);
            this.estimatedHarvest.TabIndex = 37;
            // 
            // cropNotes
            // 
            this.cropNotes.Location = new System.Drawing.Point(394, 553);
            this.cropNotes.Name = "cropNotes";
            this.cropNotes.Size = new System.Drawing.Size(125, 20);
            this.cropNotes.TabIndex = 36;
            // 
            // fertilizerId
            // 
            this.fertilizerId.DataSource = this.fertilizerBindingSource;
            this.fertilizerId.DisplayMember = "fertName";
            this.fertilizerId.FormattingEnabled = true;
            this.fertilizerId.Location = new System.Drawing.Point(525, 553);
            this.fertilizerId.Name = "fertilizerId";
            this.fertilizerId.Size = new System.Drawing.Size(124, 21);
            this.fertilizerId.TabIndex = 35;
            this.fertilizerId.ValueMember = "FertilizerID";
            // 
            // fertilizerBindingSource
            // 
            this.fertilizerBindingSource.DataMember = "Fertilizer";
            this.fertilizerBindingSource.DataSource = this.farmingDataSetBindingSource;
            // 
            // nextDose
            // 
            this.nextDose.Location = new System.Drawing.Point(26, 605);
            this.nextDose.Name = "nextDose";
            this.nextDose.Size = new System.Drawing.Size(123, 20);
            this.nextDose.TabIndex = 34;
            // 
            // lastDose
            // 
            this.lastDose.Location = new System.Drawing.Point(786, 556);
            this.lastDose.Name = "lastDose";
            this.lastDose.Size = new System.Drawing.Size(127, 20);
            this.lastDose.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(551, 589);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Field Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 589);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Crop Min Max";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 589);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Crop Storage Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 589);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Dosed By Staff";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 589);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Next Dose";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(783, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Last Dose";
            // 
            // cropStatus
            // 
            this.cropStatus.Location = new System.Drawing.Point(655, 554);
            this.cropStatus.Name = "cropStatus";
            this.cropStatus.Size = new System.Drawing.Size(125, 20);
            this.cropStatus.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Crop Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fertilizer Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Crop Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Estimated Harvest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date Planted";
            // 
            // cropName
            // 
            this.cropName.Location = new System.Drawing.Point(22, 554);
            this.cropName.Name = "cropName";
            this.cropName.Size = new System.Drawing.Size(100, 20);
            this.cropName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Crop Name";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView.DataSource = this.cropBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(6, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1245, 500);
            this.dataGridView.TabIndex = 4;
            // 
            // cropBindingSource
            // 
            this.cropBindingSource.DataMember = "Crop";
            this.cropBindingSource.DataSource = this.farmingDataSetBindingSource;
            // 
            // addCropButton
            // 
            this.addCropButton.Location = new System.Drawing.Point(1220, 630);
            this.addCropButton.Name = "addCropButton";
            this.addCropButton.Size = new System.Drawing.Size(116, 23);
            this.addCropButton.TabIndex = 2;
            this.addCropButton.Text = "Add Crop";
            this.addCropButton.UseVisualStyleBackColor = true;
            // 
            // removeCropButton
            // 
            this.removeCropButton.Location = new System.Drawing.Point(1085, 630);
            this.removeCropButton.Name = "removeCropButton";
            this.removeCropButton.Size = new System.Drawing.Size(116, 23);
            this.removeCropButton.TabIndex = 1;
            this.removeCropButton.Text = "Remove Crop";
            this.removeCropButton.UseVisualStyleBackColor = true;
            this.removeCropButton.Click += new System.EventHandler(this.removeCropButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1363, 685);
            this.tabControl.TabIndex = 0;
            // 
            // cropTableAdapter
            // 
            this.cropTableAdapter.ClearBeforeFill = true;
            // 
            // fertilizerTableAdapter
            // 
            this.fertilizerTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // fieldTableAdapter
            // 
            this.fieldTableAdapter.ClearBeforeFill = true;
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.farmingDataSetBindingSource;
            // 
            // containerBindingSource
            // 
            this.containerBindingSource.DataMember = "Container";
            this.containerBindingSource.DataSource = this.farmingDataSetBindingSource;
            // 
            // containerTableAdapter
            // 
            this.containerTableAdapter.ClearBeforeFill = true;
            // 
            // cropNameDataGridViewTextBoxColumn
            // 
            this.cropNameDataGridViewTextBoxColumn.DataPropertyName = "CropName";
            this.cropNameDataGridViewTextBoxColumn.HeaderText = "Crop Name";
            this.cropNameDataGridViewTextBoxColumn.Name = "cropNameDataGridViewTextBoxColumn";
            // 
            // datePlantedDataGridViewTextBoxColumn
            // 
            this.datePlantedDataGridViewTextBoxColumn.DataPropertyName = "DatePlanted";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.datePlantedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.datePlantedDataGridViewTextBoxColumn.HeaderText = "Date Planted";
            this.datePlantedDataGridViewTextBoxColumn.Name = "datePlantedDataGridViewTextBoxColumn";
            // 
            // estimatedHarvestDateDataGridViewTextBoxColumn
            // 
            this.estimatedHarvestDateDataGridViewTextBoxColumn.DataPropertyName = "EstimatedHarvestDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.estimatedHarvestDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.estimatedHarvestDateDataGridViewTextBoxColumn.HeaderText = "Harvest Date";
            this.estimatedHarvestDateDataGridViewTextBoxColumn.Name = "estimatedHarvestDateDataGridViewTextBoxColumn";
            // 
            // cropNotesDataGridViewTextBoxColumn
            // 
            this.cropNotesDataGridViewTextBoxColumn.DataPropertyName = "CropNotes";
            this.cropNotesDataGridViewTextBoxColumn.HeaderText = "Crop Notes";
            this.cropNotesDataGridViewTextBoxColumn.Name = "cropNotesDataGridViewTextBoxColumn";
            // 
            // fertilizerIDDataGridViewTextBoxColumn
            // 
            this.fertilizerIDDataGridViewTextBoxColumn.DataPropertyName = "FertilizerID";
            this.fertilizerIDDataGridViewTextBoxColumn.DataSource = this.fertilizerBindingSource;
            this.fertilizerIDDataGridViewTextBoxColumn.DisplayMember = "fertName";
            this.fertilizerIDDataGridViewTextBoxColumn.HeaderText = "Fertilizer";
            this.fertilizerIDDataGridViewTextBoxColumn.Name = "fertilizerIDDataGridViewTextBoxColumn";
            this.fertilizerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fertilizerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fertilizerIDDataGridViewTextBoxColumn.ValueMember = "FertilizerID";
            // 
            // cropStatusDataGridViewTextBoxColumn
            // 
            this.cropStatusDataGridViewTextBoxColumn.DataPropertyName = "CropStatus";
            this.cropStatusDataGridViewTextBoxColumn.HeaderText = "Crop Status";
            this.cropStatusDataGridViewTextBoxColumn.Name = "cropStatusDataGridViewTextBoxColumn";
            // 
            // lastDoseDataGridViewTextBoxColumn
            // 
            this.lastDoseDataGridViewTextBoxColumn.DataPropertyName = "LastDose";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.lastDoseDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.lastDoseDataGridViewTextBoxColumn.HeaderText = "Last Dose";
            this.lastDoseDataGridViewTextBoxColumn.Name = "lastDoseDataGridViewTextBoxColumn";
            // 
            // nextDoseDataGridViewTextBoxColumn
            // 
            this.nextDoseDataGridViewTextBoxColumn.DataPropertyName = "NextDose";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.nextDoseDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.nextDoseDataGridViewTextBoxColumn.HeaderText = "Next Dose";
            this.nextDoseDataGridViewTextBoxColumn.Name = "nextDoseDataGridViewTextBoxColumn";
            // 
            // dosedByStaffDataGridViewTextBoxColumn
            // 
            this.dosedByStaffDataGridViewTextBoxColumn.DataPropertyName = "DosedByStaff";
            this.dosedByStaffDataGridViewTextBoxColumn.DataSource = this.staffBindingSource;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.dosedByStaffDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.dosedByStaffDataGridViewTextBoxColumn.DisplayMember = "FirstName";
            this.dosedByStaffDataGridViewTextBoxColumn.HeaderText = "Dosed By";
            this.dosedByStaffDataGridViewTextBoxColumn.Name = "dosedByStaffDataGridViewTextBoxColumn";
            this.dosedByStaffDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dosedByStaffDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dosedByStaffDataGridViewTextBoxColumn.ValueMember = "StaffID";
            // 
            // cropStorageTypeDataGridViewTextBoxColumn
            // 
            this.cropStorageTypeDataGridViewTextBoxColumn.DataPropertyName = "CropStorageType";
            this.cropStorageTypeDataGridViewTextBoxColumn.DataSource = this.containerBindingSource;
            this.cropStorageTypeDataGridViewTextBoxColumn.DisplayMember = "contName";
            this.cropStorageTypeDataGridViewTextBoxColumn.HeaderText = "Storage Type";
            this.cropStorageTypeDataGridViewTextBoxColumn.Name = "cropStorageTypeDataGridViewTextBoxColumn";
            this.cropStorageTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cropStorageTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cropStorageTypeDataGridViewTextBoxColumn.ValueMember = "ContainerID";
            // 
            // cropMinMaxDataGridViewTextBoxColumn
            // 
            this.cropMinMaxDataGridViewTextBoxColumn.DataPropertyName = "CropMinMax";
            this.cropMinMaxDataGridViewTextBoxColumn.HeaderText = "Crop Min Max";
            this.cropMinMaxDataGridViewTextBoxColumn.Name = "cropMinMaxDataGridViewTextBoxColumn";
            // 
            // fieldIDDataGridViewTextBoxColumn
            // 
            this.fieldIDDataGridViewTextBoxColumn.DataPropertyName = "FieldID";
            this.fieldIDDataGridViewTextBoxColumn.DataSource = this.fieldBindingSource;
            this.fieldIDDataGridViewTextBoxColumn.DisplayMember = "FieldName";
            this.fieldIDDataGridViewTextBoxColumn.HeaderText = "Field";
            this.fieldIDDataGridViewTextBoxColumn.Name = "fieldIDDataGridViewTextBoxColumn";
            this.fieldIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fieldIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fieldIDDataGridViewTextBoxColumn.ValueMember = "FieldID";
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 709);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainProgram";
            this.Text = "MainProgram";
            this.Load += new System.EventHandler(this.MainProgram_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fertilizerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button addCropButton;
        private System.Windows.Forms.Button removeCropButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.BindingSource farmingDataSetBindingSource;
        private FarmingDataSet farmingDataSet;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource cropBindingSource;
        private FarmingDataSetTableAdapters.CropTableAdapter cropTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cropStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cropName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker nextDose;
        private System.Windows.Forms.DateTimePicker lastDose;
        private System.Windows.Forms.ComboBox fertilizerId;
        private System.Windows.Forms.BindingSource fertilizerBindingSource;
        private FarmingDataSetTableAdapters.FertilizerTableAdapter fertilizerTableAdapter;
        private System.Windows.Forms.TextBox cropMinMax;
        private System.Windows.Forms.DateTimePicker datePlanted;
        private System.Windows.Forms.DateTimePicker estimatedHarvest;
        private System.Windows.Forms.TextBox cropNotes;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private FarmingDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource fieldBindingSource;
        private FarmingDataSetTableAdapters.FieldTableAdapter fieldTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private System.Windows.Forms.ComboBox dosedBy;
        private System.Windows.Forms.ComboBox containerStorageType;
        private System.Windows.Forms.ComboBox fieldId;
        private System.Windows.Forms.BindingSource containerBindingSource;
        private FarmingDataSetTableAdapters.ContainerTableAdapter containerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cropNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePlantedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedHarvestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cropNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fertilizerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cropStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDoseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextDoseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dosedByStaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cropStorageTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cropMinMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fieldIDDataGridViewTextBoxColumn;

    }
}