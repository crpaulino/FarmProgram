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
            this.FertilizerTab = new System.Windows.Forms.TabPage();
            this.addFertilizer = new System.Windows.Forms.Button();
            this.removeFertilizer = new System.Windows.Forms.Button();
            this.fertilizerNote = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.fertilizerDose = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.fertilizerName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.fertilizerGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fertNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fertDoseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fertNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fertilizerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CropTab = new System.Windows.Forms.TabPage();
            this.cropGridView = new System.Windows.Forms.DataGridView();
            this.CropID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cropNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePlantedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedHarvestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cropNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fertilizerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cropStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDoseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextDoseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosedByStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cropStorageTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.containerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cropMinMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cropBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.containerStorageType = new System.Windows.Forms.ComboBox();
            this.fieldId = new System.Windows.Forms.ComboBox();
            this.dosedBy = new System.Windows.Forms.ComboBox();
            this.cropMinMax = new System.Windows.Forms.TextBox();
            this.datePlanted = new System.Windows.Forms.DateTimePicker();
            this.estimatedHarvest = new System.Windows.Forms.DateTimePicker();
            this.cropNotes = new System.Windows.Forms.TextBox();
            this.fertilizerId = new System.Windows.Forms.ComboBox();
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
            this.addCropButton = new System.Windows.Forms.Button();
            this.removeCropButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.FieldTab = new System.Windows.Forms.TabPage();
            this.removeFieldButton = new System.Windows.Forms.Button();
            this.addFieldButton = new System.Windows.Forms.Button();
            this.fieldStatusBox = new System.Windows.Forms.TextBox();
            this.fieldNotesBox = new System.Windows.Forms.TextBox();
            this.fieldNameBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.fieldGridView = new System.Windows.Forms.DataGridView();
            this.fieldIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HarvestTab = new System.Windows.Forms.TabPage();
            this.harvestGridView = new System.Windows.Forms.DataGridView();
            this.harvestStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harvestEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffRequiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.containerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cropIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fieldIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harvestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.vehicleGridView = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.containerGridView = new System.Windows.Forms.DataGridView();
            this.containerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
<<<<<<< HEAD
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.containerNameBox = new System.Windows.Forms.TextBox();
            this.containerTypeBox = new System.Windows.Forms.TextBox();
            this.containerSizeBox = new System.Windows.Forms.TextBox();
            this.removeContainerButton = new System.Windows.Forms.Button();
            this.addContainerButton = new System.Windows.Forms.Button();
=======
            this.containerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
>>>>>>> origin/master
            this.FertilizerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fertilizerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fertilizerBindingSource)).BeginInit();
            this.CropTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cropGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.FieldTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldGridView)).BeginInit();
            this.HarvestTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.harvestGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harvestBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FertilizerTab
            // 
            this.FertilizerTab.Controls.Add(this.addFertilizer);
            this.FertilizerTab.Controls.Add(this.removeFertilizer);
            this.FertilizerTab.Controls.Add(this.fertilizerNote);
            this.FertilizerTab.Controls.Add(this.label15);
            this.FertilizerTab.Controls.Add(this.fertilizerDose);
            this.FertilizerTab.Controls.Add(this.label14);
            this.FertilizerTab.Controls.Add(this.fertilizerName);
            this.FertilizerTab.Controls.Add(this.label13);
            this.FertilizerTab.Controls.Add(this.fertilizerGridView);
            this.FertilizerTab.Location = new System.Drawing.Point(4, 22);
            this.FertilizerTab.Name = "FertilizerTab";
            this.FertilizerTab.Padding = new System.Windows.Forms.Padding(3);
            this.FertilizerTab.Size = new System.Drawing.Size(1355, 659);
            this.FertilizerTab.TabIndex = 1;
            this.FertilizerTab.Text = "Fertilizers";
            this.FertilizerTab.UseVisualStyleBackColor = true;
            // 
            // addFertilizer
            // 
            this.addFertilizer.Location = new System.Drawing.Point(1224, 617);
            this.addFertilizer.Name = "addFertilizer";
            this.addFertilizer.Size = new System.Drawing.Size(116, 23);
            this.addFertilizer.TabIndex = 8;
            this.addFertilizer.Text = "Add Fertilizer";
            this.addFertilizer.UseVisualStyleBackColor = true;
            this.addFertilizer.Click += new System.EventHandler(this.addFertilizer_Click);
            // 
            // removeFertilizer
            // 
            this.removeFertilizer.Location = new System.Drawing.Point(1102, 617);
            this.removeFertilizer.Name = "removeFertilizer";
            this.removeFertilizer.Size = new System.Drawing.Size(116, 23);
            this.removeFertilizer.TabIndex = 7;
            this.removeFertilizer.Text = "Remove Fertilizer";
            this.removeFertilizer.UseVisualStyleBackColor = true;
            this.removeFertilizer.Click += new System.EventHandler(this.removeFertilizer_Click);
            // 
            // fertilizerNote
            // 
            this.fertilizerNote.Location = new System.Drawing.Point(270, 584);
            this.fertilizerNote.Name = "fertilizerNote";
            this.fertilizerNote.Size = new System.Drawing.Size(100, 20);
            this.fertilizerNote.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(267, 568);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Fertilizer Note";
            // 
            // fertilizerDose
            // 
            this.fertilizerDose.Location = new System.Drawing.Point(164, 584);
            this.fertilizerDose.Name = "fertilizerDose";
            this.fertilizerDose.Size = new System.Drawing.Size(100, 20);
            this.fertilizerDose.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(161, 568);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Fertilizer Dose";
            // 
            // fertilizerName
            // 
            this.fertilizerName.Location = new System.Drawing.Point(49, 584);
            this.fertilizerName.Name = "fertilizerName";
            this.fertilizerName.Size = new System.Drawing.Size(109, 20);
            this.fertilizerName.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 568);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Fertilizer Name";
            // 
            // fertilizerGridView
            // 
            this.fertilizerGridView.AutoGenerateColumns = false;
            this.fertilizerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fertilizerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.fertNameDataGridViewTextBoxColumn,
            this.fertDoseDataGridViewTextBoxColumn,
            this.fertNoteDataGridViewTextBoxColumn});
            this.fertilizerGridView.DataSource = this.fertilizerBindingSource;
            this.fertilizerGridView.Location = new System.Drawing.Point(37, 41);
            this.fertilizerGridView.Name = "fertilizerGridView";
            this.fertilizerGridView.RowHeadersWidth = 45;
            this.fertilizerGridView.Size = new System.Drawing.Size(1245, 500);
            this.fertilizerGridView.TabIndex = 0;
            this.fertilizerGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.fertilizerRowEdited);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fertilizerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "fertilizerId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // fertNameDataGridViewTextBoxColumn
            // 
            this.fertNameDataGridViewTextBoxColumn.DataPropertyName = "fertName";
            this.fertNameDataGridViewTextBoxColumn.HeaderText = "Fertiliser Name";
            this.fertNameDataGridViewTextBoxColumn.Name = "fertNameDataGridViewTextBoxColumn";
            this.fertNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // fertDoseDataGridViewTextBoxColumn
            // 
            this.fertDoseDataGridViewTextBoxColumn.DataPropertyName = "fertDose";
            this.fertDoseDataGridViewTextBoxColumn.HeaderText = "Fertiliser Dose";
            this.fertDoseDataGridViewTextBoxColumn.Name = "fertDoseDataGridViewTextBoxColumn";
            // 
            // fertNoteDataGridViewTextBoxColumn
            // 
            this.fertNoteDataGridViewTextBoxColumn.DataPropertyName = "fertNote";
            this.fertNoteDataGridViewTextBoxColumn.HeaderText = "Fertiliser Note";
            this.fertNoteDataGridViewTextBoxColumn.Name = "fertNoteDataGridViewTextBoxColumn";
            // 
            // fertilizerBindingSource
            // 
            this.fertilizerBindingSource.DataSource = typeof(farmingprogram.Fertilizer);
            // 
            // CropTab
            // 
            this.CropTab.Controls.Add(this.cropGridView);
            this.CropTab.Controls.Add(this.containerStorageType);
            this.CropTab.Controls.Add(this.fieldId);
            this.CropTab.Controls.Add(this.dosedBy);
            this.CropTab.Controls.Add(this.cropMinMax);
            this.CropTab.Controls.Add(this.datePlanted);
            this.CropTab.Controls.Add(this.estimatedHarvest);
            this.CropTab.Controls.Add(this.cropNotes);
            this.CropTab.Controls.Add(this.fertilizerId);
            this.CropTab.Controls.Add(this.nextDose);
            this.CropTab.Controls.Add(this.lastDose);
            this.CropTab.Controls.Add(this.label12);
            this.CropTab.Controls.Add(this.label11);
            this.CropTab.Controls.Add(this.label10);
            this.CropTab.Controls.Add(this.label9);
            this.CropTab.Controls.Add(this.label8);
            this.CropTab.Controls.Add(this.label7);
            this.CropTab.Controls.Add(this.cropStatus);
            this.CropTab.Controls.Add(this.label6);
            this.CropTab.Controls.Add(this.label5);
            this.CropTab.Controls.Add(this.label4);
            this.CropTab.Controls.Add(this.label3);
            this.CropTab.Controls.Add(this.label2);
            this.CropTab.Controls.Add(this.cropName);
            this.CropTab.Controls.Add(this.label1);
            this.CropTab.Controls.Add(this.addCropButton);
            this.CropTab.Controls.Add(this.removeCropButton);
            this.CropTab.Location = new System.Drawing.Point(4, 22);
            this.CropTab.Name = "CropTab";
            this.CropTab.Padding = new System.Windows.Forms.Padding(3);
            this.CropTab.Size = new System.Drawing.Size(1355, 659);
            this.CropTab.TabIndex = 0;
            this.CropTab.Text = "Crops";
            this.CropTab.UseVisualStyleBackColor = true;
            // 
            // cropGridView
            // 
            this.cropGridView.AllowUserToAddRows = false;
            this.cropGridView.AllowUserToDeleteRows = false;
            this.cropGridView.AutoGenerateColumns = false;
            this.cropGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cropGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CropID,
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
            this.cropGridView.DataSource = this.cropBindingSource;
            this.cropGridView.Location = new System.Drawing.Point(52, 58);
            this.cropGridView.Name = "cropGridView";
            this.cropGridView.Size = new System.Drawing.Size(1243, 466);
            this.cropGridView.TabIndex = 46;
            this.cropGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.cropRowEdited);
            // 
            // CropID
            // 
            this.CropID.DataPropertyName = "cropId";
            this.CropID.HeaderText = "cropId";
            this.CropID.Name = "CropID";
            this.CropID.ReadOnly = true;
            this.CropID.Visible = false;
            // 
            // cropNameDataGridViewTextBoxColumn
            // 
            this.cropNameDataGridViewTextBoxColumn.DataPropertyName = "cropName";
            this.cropNameDataGridViewTextBoxColumn.HeaderText = "Crop Name";
            this.cropNameDataGridViewTextBoxColumn.Name = "cropNameDataGridViewTextBoxColumn";
            // 
            // datePlantedDataGridViewTextBoxColumn
            // 
            this.datePlantedDataGridViewTextBoxColumn.DataPropertyName = "datePlanted";
            this.datePlantedDataGridViewTextBoxColumn.HeaderText = "Date Planted";
            this.datePlantedDataGridViewTextBoxColumn.Name = "datePlantedDataGridViewTextBoxColumn";
            // 
            // estimatedHarvestDateDataGridViewTextBoxColumn
            // 
            this.estimatedHarvestDateDataGridViewTextBoxColumn.DataPropertyName = "estimatedHarvestDate";
            this.estimatedHarvestDateDataGridViewTextBoxColumn.HeaderText = "Harvest Date";
            this.estimatedHarvestDateDataGridViewTextBoxColumn.Name = "estimatedHarvestDateDataGridViewTextBoxColumn";
            // 
            // cropNotesDataGridViewTextBoxColumn
            // 
            this.cropNotesDataGridViewTextBoxColumn.DataPropertyName = "cropNotes";
            this.cropNotesDataGridViewTextBoxColumn.HeaderText = "Crop Notes";
            this.cropNotesDataGridViewTextBoxColumn.Name = "cropNotesDataGridViewTextBoxColumn";
            // 
            // fertilizerIDDataGridViewTextBoxColumn
            // 
            this.fertilizerIDDataGridViewTextBoxColumn.DataPropertyName = "fertilizerID";
            this.fertilizerIDDataGridViewTextBoxColumn.DataSource = this.fertilizerBindingSource;
            this.fertilizerIDDataGridViewTextBoxColumn.DisplayMember = "fertName";
            this.fertilizerIDDataGridViewTextBoxColumn.HeaderText = "Fertilizer";
            this.fertilizerIDDataGridViewTextBoxColumn.Name = "fertilizerIDDataGridViewTextBoxColumn";
            this.fertilizerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fertilizerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fertilizerIDDataGridViewTextBoxColumn.ValueMember = "fertilizerId";
            // 
            // cropStatusDataGridViewTextBoxColumn
            // 
            this.cropStatusDataGridViewTextBoxColumn.DataPropertyName = "cropStatus";
            this.cropStatusDataGridViewTextBoxColumn.HeaderText = "Crop Status";
            this.cropStatusDataGridViewTextBoxColumn.Name = "cropStatusDataGridViewTextBoxColumn";
            // 
            // lastDoseDataGridViewTextBoxColumn
            // 
            this.lastDoseDataGridViewTextBoxColumn.DataPropertyName = "lastDose";
            this.lastDoseDataGridViewTextBoxColumn.HeaderText = "Last Dose";
            this.lastDoseDataGridViewTextBoxColumn.Name = "lastDoseDataGridViewTextBoxColumn";
            // 
            // nextDoseDataGridViewTextBoxColumn
            // 
            this.nextDoseDataGridViewTextBoxColumn.DataPropertyName = "nextDose";
            this.nextDoseDataGridViewTextBoxColumn.HeaderText = "Next Dose";
            this.nextDoseDataGridViewTextBoxColumn.Name = "nextDoseDataGridViewTextBoxColumn";
            // 
            // dosedByStaffDataGridViewTextBoxColumn
            // 
            this.dosedByStaffDataGridViewTextBoxColumn.DataPropertyName = "dosedByStaff";
            this.dosedByStaffDataGridViewTextBoxColumn.DataSource = this.staffBindingSource;
            this.dosedByStaffDataGridViewTextBoxColumn.DisplayMember = "FirstName";
            this.dosedByStaffDataGridViewTextBoxColumn.HeaderText = "Dosed By";
            this.dosedByStaffDataGridViewTextBoxColumn.Name = "dosedByStaffDataGridViewTextBoxColumn";
            this.dosedByStaffDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dosedByStaffDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dosedByStaffDataGridViewTextBoxColumn.ValueMember = "StaffID";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(farmingprogram.Staff);
            // 
            // cropStorageTypeDataGridViewTextBoxColumn
            // 
            this.cropStorageTypeDataGridViewTextBoxColumn.DataPropertyName = "cropStorageType";
            this.cropStorageTypeDataGridViewTextBoxColumn.DataSource = this.containerBindingSource;
            this.cropStorageTypeDataGridViewTextBoxColumn.DisplayMember = "contName";
            this.cropStorageTypeDataGridViewTextBoxColumn.HeaderText = "Storage";
            this.cropStorageTypeDataGridViewTextBoxColumn.Name = "cropStorageTypeDataGridViewTextBoxColumn";
            this.cropStorageTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cropStorageTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cropStorageTypeDataGridViewTextBoxColumn.ValueMember = "ContainerID";
            // 
            // containerBindingSource
            // 
            this.containerBindingSource.DataSource = typeof(farmingprogram.Container);
            // 
            // cropMinMaxDataGridViewTextBoxColumn
            // 
            this.cropMinMaxDataGridViewTextBoxColumn.DataPropertyName = "cropMinMax";
            this.cropMinMaxDataGridViewTextBoxColumn.HeaderText = "Min/Max";
            this.cropMinMaxDataGridViewTextBoxColumn.Name = "cropMinMaxDataGridViewTextBoxColumn";
            // 
            // fieldIDDataGridViewTextBoxColumn
            // 
            this.fieldIDDataGridViewTextBoxColumn.DataPropertyName = "fieldID";
            this.fieldIDDataGridViewTextBoxColumn.DataSource = this.fieldBindingSource;
            this.fieldIDDataGridViewTextBoxColumn.DisplayMember = "fieldName";
            this.fieldIDDataGridViewTextBoxColumn.HeaderText = "Field";
            this.fieldIDDataGridViewTextBoxColumn.Name = "fieldIDDataGridViewTextBoxColumn";
            this.fieldIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fieldIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fieldIDDataGridViewTextBoxColumn.ValueMember = "fieldID";
            // 
            // fieldBindingSource
            // 
            this.fieldBindingSource.DataSource = typeof(farmingprogram.Field);
            // 
            // cropBindingSource
            // 
            this.cropBindingSource.DataSource = typeof(farmingprogram.Crop);
            // 
            // containerStorageType
            // 
            this.containerStorageType.DataSource = this.containerBindingSource;
            this.containerStorageType.DisplayMember = "contName";
            this.containerStorageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.containerStorageType.FormattingEnabled = true;
            this.containerStorageType.Location = new System.Drawing.Point(311, 592);
            this.containerStorageType.Name = "containerStorageType";
            this.containerStorageType.Size = new System.Drawing.Size(124, 21);
            this.containerStorageType.TabIndex = 45;
            this.containerStorageType.ValueMember = "ContainerID";
            // 
            // fieldId
            // 
            this.fieldId.DataSource = this.fieldBindingSource;
            this.fieldId.DisplayMember = "fieldName";
            this.fieldId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldId.FormattingEnabled = true;
            this.fieldId.Location = new System.Drawing.Point(580, 592);
            this.fieldId.Name = "fieldId";
            this.fieldId.Size = new System.Drawing.Size(124, 21);
            this.fieldId.TabIndex = 44;
            this.fieldId.ValueMember = "FieldID";
            // 
            // dosedBy
            // 
            this.dosedBy.DataSource = this.staffBindingSource;
            this.dosedBy.DisplayMember = "FirstName";
            this.dosedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dosedBy.FormattingEnabled = true;
            this.dosedBy.Location = new System.Drawing.Point(181, 593);
            this.dosedBy.Name = "dosedBy";
            this.dosedBy.Size = new System.Drawing.Size(124, 21);
            this.dosedBy.TabIndex = 43;
            this.dosedBy.ValueMember = "StaffID";
            // 
            // cropMinMax
            // 
            this.cropMinMax.Location = new System.Drawing.Point(443, 593);
            this.cropMinMax.Name = "cropMinMax";
            this.cropMinMax.Size = new System.Drawing.Size(125, 20);
            this.cropMinMax.TabIndex = 41;
            // 
            // datePlanted
            // 
            this.datePlanted.Location = new System.Drawing.Point(154, 542);
            this.datePlanted.Name = "datePlanted";
            this.datePlanted.Size = new System.Drawing.Size(127, 20);
            this.datePlanted.TabIndex = 38;
            // 
            // estimatedHarvest
            // 
            this.estimatedHarvest.Location = new System.Drawing.Point(287, 543);
            this.estimatedHarvest.Name = "estimatedHarvest";
            this.estimatedHarvest.Size = new System.Drawing.Size(127, 20);
            this.estimatedHarvest.TabIndex = 37;
            // 
            // cropNotes
            // 
            this.cropNotes.Location = new System.Drawing.Point(420, 542);
            this.cropNotes.Name = "cropNotes";
            this.cropNotes.Size = new System.Drawing.Size(125, 20);
            this.cropNotes.TabIndex = 36;
            // 
            // fertilizerId
            // 
            this.fertilizerId.DataSource = this.fertilizerBindingSource;
            this.fertilizerId.DisplayMember = "fertName";
            this.fertilizerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fertilizerId.FormattingEnabled = true;
            this.fertilizerId.Location = new System.Drawing.Point(551, 542);
            this.fertilizerId.Name = "fertilizerId";
            this.fertilizerId.Size = new System.Drawing.Size(124, 21);
            this.fertilizerId.TabIndex = 35;
            this.fertilizerId.ValueMember = "FertilizerID";
            // 
            // nextDose
            // 
            this.nextDose.Location = new System.Drawing.Point(52, 594);
            this.nextDose.Name = "nextDose";
            this.nextDose.Size = new System.Drawing.Size(123, 20);
            this.nextDose.TabIndex = 34;
            // 
            // lastDose
            // 
            this.lastDose.Location = new System.Drawing.Point(812, 545);
            this.lastDose.Name = "lastDose";
            this.lastDose.Size = new System.Drawing.Size(127, 20);
            this.lastDose.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(577, 578);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Field Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Crop Min Max";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Crop Storage Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Dosed By Staff";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Next Dose";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(809, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Last Dose";
            // 
            // cropStatus
            // 
            this.cropStatus.Location = new System.Drawing.Point(681, 543);
            this.cropStatus.Name = "cropStatus";
            this.cropStatus.Size = new System.Drawing.Size(125, 20);
            this.cropStatus.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(678, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Crop Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fertilizer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Crop Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Estimated Harvest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date Planted";
            // 
            // cropName
            // 
            this.cropName.Location = new System.Drawing.Point(48, 543);
            this.cropName.Name = "cropName";
            this.cropName.Size = new System.Drawing.Size(100, 20);
            this.cropName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Crop Name";
            // 
            // addCropButton
            // 
            this.addCropButton.Location = new System.Drawing.Point(1219, 630);
            this.addCropButton.Name = "addCropButton";
            this.addCropButton.Size = new System.Drawing.Size(116, 23);
            this.addCropButton.TabIndex = 2;
            this.addCropButton.Text = "Add Crop";
            this.addCropButton.UseVisualStyleBackColor = true;
            this.addCropButton.Click += new System.EventHandler(this.addCropButton_Click);
            // 
            // removeCropButton
            // 
            this.removeCropButton.Location = new System.Drawing.Point(1097, 630);
            this.removeCropButton.Name = "removeCropButton";
            this.removeCropButton.Size = new System.Drawing.Size(116, 23);
            this.removeCropButton.TabIndex = 1;
            this.removeCropButton.Text = "Remove Crop";
            this.removeCropButton.UseVisualStyleBackColor = true;
            this.removeCropButton.Click += new System.EventHandler(this.removeCropButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.CropTab);
            this.tabControl.Controls.Add(this.FertilizerTab);
            this.tabControl.Controls.Add(this.FieldTab);
            this.tabControl.Controls.Add(this.HarvestTab);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1363, 685);
            this.tabControl.TabIndex = 0;
            // 
            // FieldTab
            // 
            this.FieldTab.Controls.Add(this.removeFieldButton);
            this.FieldTab.Controls.Add(this.addFieldButton);
            this.FieldTab.Controls.Add(this.fieldStatusBox);
            this.FieldTab.Controls.Add(this.fieldNotesBox);
            this.FieldTab.Controls.Add(this.fieldNameBox);
            this.FieldTab.Controls.Add(this.label18);
            this.FieldTab.Controls.Add(this.label17);
            this.FieldTab.Controls.Add(this.label16);
            this.FieldTab.Controls.Add(this.fieldGridView);
            this.FieldTab.Location = new System.Drawing.Point(4, 22);
            this.FieldTab.Name = "FieldTab";
            this.FieldTab.Padding = new System.Windows.Forms.Padding(3);
            this.FieldTab.Size = new System.Drawing.Size(1355, 659);
            this.FieldTab.TabIndex = 2;
            this.FieldTab.Text = "Fields";
            this.FieldTab.UseVisualStyleBackColor = true;
            // 
            // removeFieldButton
            // 
            this.removeFieldButton.Location = new System.Drawing.Point(1227, 613);
            this.removeFieldButton.Name = "removeFieldButton";
            this.removeFieldButton.Size = new System.Drawing.Size(116, 23);
            this.removeFieldButton.TabIndex = 10;
            this.removeFieldButton.Text = "Remove Field";
            this.removeFieldButton.UseVisualStyleBackColor = true;
            this.removeFieldButton.Click += new System.EventHandler(this.removeFieldButton_Click);
            // 
            // addFieldButton
            // 
            this.addFieldButton.Location = new System.Drawing.Point(1105, 613);
            this.addFieldButton.Name = "addFieldButton";
            this.addFieldButton.Size = new System.Drawing.Size(116, 23);
            this.addFieldButton.TabIndex = 9;
            this.addFieldButton.Text = "Add Field";
            this.addFieldButton.UseVisualStyleBackColor = true;
            this.addFieldButton.Click += new System.EventHandler(this.addFieldButton_Click);
            // 
            // fieldStatusBox
            // 
            this.fieldStatusBox.Location = new System.Drawing.Point(318, 574);
            this.fieldStatusBox.Name = "fieldStatusBox";
            this.fieldStatusBox.Size = new System.Drawing.Size(100, 20);
            this.fieldStatusBox.TabIndex = 5;
            // 
            // fieldNotesBox
            // 
            this.fieldNotesBox.Location = new System.Drawing.Point(183, 574);
            this.fieldNotesBox.Name = "fieldNotesBox";
            this.fieldNotesBox.Size = new System.Drawing.Size(100, 20);
            this.fieldNotesBox.TabIndex = 4;
            // 
            // fieldNameBox
            // 
            this.fieldNameBox.Location = new System.Drawing.Point(41, 575);
            this.fieldNameBox.Name = "fieldNameBox";
            this.fieldNameBox.Size = new System.Drawing.Size(100, 20);
            this.fieldNameBox.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(315, 559);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Field Status";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(180, 558);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Field Notes";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 558);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Field Name";
            // 
            // fieldGridView
            // 
            this.fieldGridView.AutoGenerateColumns = false;
            this.fieldGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fieldGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldIDDataGridViewTextBoxColumn1,
            this.fieldNameDataGridViewTextBoxColumn,
            this.fieldNotesDataGridViewTextBoxColumn,
            this.fieldStatusDataGridViewTextBoxColumn});
            this.fieldGridView.DataSource = this.fieldBindingSource;
            this.fieldGridView.Location = new System.Drawing.Point(32, 37);
            this.fieldGridView.Name = "fieldGridView";
            this.fieldGridView.RowHeadersWidth = 45;
            this.fieldGridView.Size = new System.Drawing.Size(1245, 500);
            this.fieldGridView.TabIndex = 1;
            this.fieldGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.fieldRowEdited);
            // 
            // fieldIDDataGridViewTextBoxColumn1
            // 
            this.fieldIDDataGridViewTextBoxColumn1.DataPropertyName = "fieldID";
            this.fieldIDDataGridViewTextBoxColumn1.HeaderText = "fieldID";
            this.fieldIDDataGridViewTextBoxColumn1.Name = "fieldIDDataGridViewTextBoxColumn1";
            this.fieldIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // fieldNameDataGridViewTextBoxColumn
            // 
            this.fieldNameDataGridViewTextBoxColumn.DataPropertyName = "fieldName";
            this.fieldNameDataGridViewTextBoxColumn.HeaderText = "Field Name";
            this.fieldNameDataGridViewTextBoxColumn.Name = "fieldNameDataGridViewTextBoxColumn";
            // 
            // fieldNotesDataGridViewTextBoxColumn
            // 
            this.fieldNotesDataGridViewTextBoxColumn.DataPropertyName = "fieldNotes";
            this.fieldNotesDataGridViewTextBoxColumn.HeaderText = "Field Notes";
            this.fieldNotesDataGridViewTextBoxColumn.Name = "fieldNotesDataGridViewTextBoxColumn";
            // 
            // fieldStatusDataGridViewTextBoxColumn
            // 
            this.fieldStatusDataGridViewTextBoxColumn.DataPropertyName = "fieldStatus";
            this.fieldStatusDataGridViewTextBoxColumn.HeaderText = "Field Status";
            this.fieldStatusDataGridViewTextBoxColumn.Name = "fieldStatusDataGridViewTextBoxColumn";
            // 
            // HarvestTab
            // 
            this.HarvestTab.Controls.Add(this.harvestGridView);
            this.HarvestTab.Location = new System.Drawing.Point(4, 22);
            this.HarvestTab.Name = "HarvestTab";
            this.HarvestTab.Padding = new System.Windows.Forms.Padding(3);
            this.HarvestTab.Size = new System.Drawing.Size(1355, 659);
            this.HarvestTab.TabIndex = 3;
            this.HarvestTab.Text = "Harvest";
            this.HarvestTab.UseVisualStyleBackColor = true;
            // 
            // harvestGridView
            // 
            this.harvestGridView.AutoGenerateColumns = false;
            this.harvestGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.harvestGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.harvestStartDateDataGridViewTextBoxColumn,
            this.harvestEndDateDataGridViewTextBoxColumn,
            this.staffRequiredDataGridViewTextBoxColumn,
            this.containerIDDataGridViewTextBoxColumn,
            this.cropIDDataGridViewTextBoxColumn,
            this.fieldIDDataGridViewTextBoxColumn2,
            this.staffIDDataGridViewTextBoxColumn,
            this.vehicleDataGridViewTextBoxColumn,
            this.storageIDDataGridViewTextBoxColumn});
            this.harvestGridView.DataSource = this.harvestBindingSource;
            this.harvestGridView.Location = new System.Drawing.Point(36, 45);
            this.harvestGridView.Name = "harvestGridView";
            this.harvestGridView.RowHeadersWidth = 45;
            this.harvestGridView.Size = new System.Drawing.Size(1245, 500);
            this.harvestGridView.TabIndex = 1;
            // 
            // harvestStartDateDataGridViewTextBoxColumn
            // 
            this.harvestStartDateDataGridViewTextBoxColumn.DataPropertyName = "harvestStartDate";
            this.harvestStartDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.harvestStartDateDataGridViewTextBoxColumn.Name = "harvestStartDateDataGridViewTextBoxColumn";
            // 
            // harvestEndDateDataGridViewTextBoxColumn
            // 
            this.harvestEndDateDataGridViewTextBoxColumn.DataPropertyName = "harvestEndDate";
            this.harvestEndDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.harvestEndDateDataGridViewTextBoxColumn.Name = "harvestEndDateDataGridViewTextBoxColumn";
            // 
            // staffRequiredDataGridViewTextBoxColumn
            // 
            this.staffRequiredDataGridViewTextBoxColumn.DataPropertyName = "staffRequired";
            this.staffRequiredDataGridViewTextBoxColumn.DataSource = this.staffBindingSource;
            this.staffRequiredDataGridViewTextBoxColumn.DisplayMember = "FirstName";
            this.staffRequiredDataGridViewTextBoxColumn.HeaderText = "Staff Operator";
            this.staffRequiredDataGridViewTextBoxColumn.Name = "staffRequiredDataGridViewTextBoxColumn";
            this.staffRequiredDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.staffRequiredDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.staffRequiredDataGridViewTextBoxColumn.ValueMember = "StaffID";
            // 
            // containerIDDataGridViewTextBoxColumn
            // 
            this.containerIDDataGridViewTextBoxColumn.DataPropertyName = "containerID";
            this.containerIDDataGridViewTextBoxColumn.DataSource = this.containerBindingSource;
            this.containerIDDataGridViewTextBoxColumn.DisplayMember = "contName";
            this.containerIDDataGridViewTextBoxColumn.HeaderText = "Container";
            this.containerIDDataGridViewTextBoxColumn.Name = "containerIDDataGridViewTextBoxColumn";
            this.containerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.containerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.containerIDDataGridViewTextBoxColumn.ValueMember = "ContainerID";
            // 
            // cropIDDataGridViewTextBoxColumn
            // 
            this.cropIDDataGridViewTextBoxColumn.DataPropertyName = "cropID";
            this.cropIDDataGridViewTextBoxColumn.DataSource = this.cropBindingSource;
            this.cropIDDataGridViewTextBoxColumn.DisplayMember = "cropName";
            this.cropIDDataGridViewTextBoxColumn.HeaderText = "cropID";
            this.cropIDDataGridViewTextBoxColumn.Name = "cropIDDataGridViewTextBoxColumn";
            this.cropIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cropIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cropIDDataGridViewTextBoxColumn.ValueMember = "cropId";
            // 
            // fieldIDDataGridViewTextBoxColumn2
            // 
            this.fieldIDDataGridViewTextBoxColumn2.DataPropertyName = "fieldID";
            this.fieldIDDataGridViewTextBoxColumn2.DataSource = this.fieldBindingSource;
            this.fieldIDDataGridViewTextBoxColumn2.DisplayMember = "fieldName";
            this.fieldIDDataGridViewTextBoxColumn2.HeaderText = "Field";
            this.fieldIDDataGridViewTextBoxColumn2.Name = "fieldIDDataGridViewTextBoxColumn2";
            this.fieldIDDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fieldIDDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fieldIDDataGridViewTextBoxColumn2.ValueMember = "fieldID";
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "staffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "staffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // vehicleDataGridViewTextBoxColumn
            // 
            this.vehicleDataGridViewTextBoxColumn.DataPropertyName = "vehicle";
            this.vehicleDataGridViewTextBoxColumn.HeaderText = "Vehicle";
            this.vehicleDataGridViewTextBoxColumn.Name = "vehicleDataGridViewTextBoxColumn";
            this.vehicleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // storageIDDataGridViewTextBoxColumn
            // 
            this.storageIDDataGridViewTextBoxColumn.DataPropertyName = "storageID";
            this.storageIDDataGridViewTextBoxColumn.HeaderText = "storageID";
            this.storageIDDataGridViewTextBoxColumn.Name = "storageIDDataGridViewTextBoxColumn";
            // 
            // harvestBindingSource
            // 
            this.harvestBindingSource.DataSource = typeof(farmingprogram.Harvest);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.vehicleGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1355, 659);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Vehicles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // vehicleGridView
            // 
            this.vehicleGridView.AutoGenerateColumns = false;
            this.vehicleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn});
            this.vehicleGridView.DataSource = this.vehicleBindingSource;
            this.vehicleGridView.Location = new System.Drawing.Point(29, 41);
            this.vehicleGridView.Name = "vehicleGridView";
            this.vehicleGridView.RowHeadersWidth = 45;
            this.vehicleGridView.Size = new System.Drawing.Size(1245, 500);
            this.vehicleGridView.TabIndex = 1;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(farmingprogram.Vehicle);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.removeContainerButton);
            this.tabPage2.Controls.Add(this.addContainerButton);
            this.tabPage2.Controls.Add(this.containerSizeBox);
            this.tabPage2.Controls.Add(this.containerTypeBox);
            this.tabPage2.Controls.Add(this.containerNameBox);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.containerGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1355, 659);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Containers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // containerGridView
            // 
            this.containerGridView.AutoGenerateColumns = false;
            this.containerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.containerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.containerIDDataGridViewTextBoxColumn1,
            this.contNameDataGridViewTextBoxColumn,
            this.contTypeDataGridViewTextBoxColumn,
            this.contSizeDataGridViewTextBoxColumn});
            this.containerGridView.DataSource = this.containerBindingSource;
            this.containerGridView.Location = new System.Drawing.Point(30, 40);
            this.containerGridView.Name = "containerGridView";
            this.containerGridView.RowHeadersWidth = 45;
            this.containerGridView.Size = new System.Drawing.Size(1245, 500);
            this.containerGridView.TabIndex = 1;
            // 
            // containerIDDataGridViewTextBoxColumn1
            // 
            this.containerIDDataGridViewTextBoxColumn1.DataPropertyName = "ContainerID";
            this.containerIDDataGridViewTextBoxColumn1.HeaderText = "ContainerID";
            this.containerIDDataGridViewTextBoxColumn1.Name = "containerIDDataGridViewTextBoxColumn1";
            this.containerIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // contNameDataGridViewTextBoxColumn
            // 
            this.contNameDataGridViewTextBoxColumn.DataPropertyName = "contName";
            this.contNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.contNameDataGridViewTextBoxColumn.Name = "contNameDataGridViewTextBoxColumn";
            // 
            // contTypeDataGridViewTextBoxColumn
            // 
            this.contTypeDataGridViewTextBoxColumn.DataPropertyName = "contType";
            this.contTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.contTypeDataGridViewTextBoxColumn.Name = "contTypeDataGridViewTextBoxColumn";
            // 
            // contSizeDataGridViewTextBoxColumn
            // 
            this.contSizeDataGridViewTextBoxColumn.DataPropertyName = "contSize";
            this.contSizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.contSizeDataGridViewTextBoxColumn.Name = "contSizeDataGridViewTextBoxColumn";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 553);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Container name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(161, 553);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Container type";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(303, 553);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Container size";
            // 
            // containerNameBox
            // 
            this.containerNameBox.Location = new System.Drawing.Point(30, 569);
            this.containerNameBox.Name = "containerNameBox";
            this.containerNameBox.Size = new System.Drawing.Size(100, 20);
            this.containerNameBox.TabIndex = 5;
            // 
            // containerTypeBox
            // 
            this.containerTypeBox.Location = new System.Drawing.Point(164, 569);
            this.containerTypeBox.Name = "containerTypeBox";
            this.containerTypeBox.Size = new System.Drawing.Size(100, 20);
            this.containerTypeBox.TabIndex = 6;
            // 
            // containerSizeBox
            // 
            this.containerSizeBox.Location = new System.Drawing.Point(306, 569);
            this.containerSizeBox.Name = "containerSizeBox";
            this.containerSizeBox.Size = new System.Drawing.Size(100, 20);
            this.containerSizeBox.TabIndex = 7;
            // 
            // removeContainerButton
            // 
            this.removeContainerButton.Location = new System.Drawing.Point(1233, 610);
            this.removeContainerButton.Name = "removeContainerButton";
            this.removeContainerButton.Size = new System.Drawing.Size(116, 23);
            this.removeContainerButton.TabIndex = 12;
            this.removeContainerButton.Text = "Remove Container";
            this.removeContainerButton.UseVisualStyleBackColor = true;
            this.removeContainerButton.Click += new System.EventHandler(this.removeContainerButton_Click);
            // 
            // addContainerButton
            // 
            this.addContainerButton.Location = new System.Drawing.Point(1111, 610);
            this.addContainerButton.Name = "addContainerButton";
            this.addContainerButton.Size = new System.Drawing.Size(116, 23);
            this.addContainerButton.TabIndex = 11;
            this.addContainerButton.Text = "Add Container";
            this.addContainerButton.UseVisualStyleBackColor = true;
            this.addContainerButton.Click += new System.EventHandler(this.addContainerButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1355, 659);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1355, 659);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.rightsDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.staffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(1245, 500);
            this.dataGridView1.TabIndex = 2;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // rightsDataGridViewTextBoxColumn
            // 
            this.rightsDataGridViewTextBoxColumn.DataPropertyName = "Rights";
            this.rightsDataGridViewTextBoxColumn.HeaderText = "Rights";
            this.rightsDataGridViewTextBoxColumn.Name = "rightsDataGridViewTextBoxColumn";
            // 
            // staffIDDataGridViewTextBoxColumn1
            // 
            this.staffIDDataGridViewTextBoxColumn1.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.Name = "staffIDDataGridViewTextBoxColumn1";
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
            this.FertilizerTab.ResumeLayout(false);
            this.FertilizerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fertilizerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fertilizerBindingSource)).EndInit();
            this.CropTab.ResumeLayout(false);
            this.CropTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cropGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.FieldTab.ResumeLayout(false);
            this.FieldTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldGridView)).EndInit();
            this.HarvestTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.harvestGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harvestBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage FertilizerTab;
        private System.Windows.Forms.TabPage CropTab;
        private System.Windows.Forms.Button addCropButton;
        private System.Windows.Forms.Button removeCropButton;
        private System.Windows.Forms.TabControl tabControl;
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
        private System.Windows.Forms.TextBox cropMinMax;
        private System.Windows.Forms.DateTimePicker datePlanted;
        private System.Windows.Forms.DateTimePicker estimatedHarvest;
        private System.Windows.Forms.TextBox cropNotes;
        private System.Windows.Forms.ComboBox dosedBy;
        private System.Windows.Forms.ComboBox containerStorageType;
        private System.Windows.Forms.ComboBox fieldId;
        private System.Windows.Forms.Button addFertilizer;
        private System.Windows.Forms.Button removeFertilizer;
        private System.Windows.Forms.TextBox fertilizerNote;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox fertilizerDose;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox fertilizerName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView fertilizerGridView;
        private System.Windows.Forms.DataGridView cropGridView;
        public System.Windows.Forms.BindingSource cropBindingSource;
        public System.Windows.Forms.BindingSource vehicleBindingSource;
        public System.Windows.Forms.BindingSource fieldBindingSource;
        public System.Windows.Forms.BindingSource containerBindingSource;
        public System.Windows.Forms.BindingSource fertilizerBindingSource;
        public System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.TabPage FieldTab;
        private System.Windows.Forms.DataGridView fieldGridView;
        private System.Windows.Forms.TabPage HarvestTab;
        private System.Windows.Forms.DataGridView harvestGridView;
        private System.Windows.Forms.BindingSource harvestBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView vehicleGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView containerGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn harvestStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harvestEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn staffRequiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn containerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cropIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fieldIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox fieldStatusBox;
        private System.Windows.Forms.TextBox fieldNotesBox;
        private System.Windows.Forms.TextBox fieldNameBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button removeFieldButton;
        private System.Windows.Forms.Button addFieldButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fertNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fertDoseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fertNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CropID;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldStatusDataGridViewTextBoxColumn;
<<<<<<< HEAD
        private System.Windows.Forms.DataGridViewTextBoxColumn containerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox containerSizeBox;
        private System.Windows.Forms.TextBox containerTypeBox;
        private System.Windows.Forms.TextBox containerNameBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button removeContainerButton;
        private System.Windows.Forms.Button addContainerButton;
=======
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage4;
>>>>>>> origin/master

    }
}