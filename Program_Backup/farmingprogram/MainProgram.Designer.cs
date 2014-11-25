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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addFertilizer = new System.Windows.Forms.Button();
            this.removeFertilizer = new System.Windows.Forms.Button();
            this.fertilizerNote = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.fertilizerDose = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.fertilizerName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.fertilizerGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cropGridView = new System.Windows.Forms.DataGridView();
            this.CropID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.fertilizerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.containerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cropBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fertilizerGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cropGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fertilizerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addFertilizer);
            this.tabPage2.Controls.Add(this.removeFertilizer);
            this.tabPage2.Controls.Add(this.fertilizerNote);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.fertilizerDose);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.fertilizerName);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.fertilizerGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1809, 814);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fertilizers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addFertilizer
            // 
            this.addFertilizer.Location = new System.Drawing.Point(1632, 759);
            this.addFertilizer.Margin = new System.Windows.Forms.Padding(4);
            this.addFertilizer.Name = "addFertilizer";
            this.addFertilizer.Size = new System.Drawing.Size(155, 28);
            this.addFertilizer.TabIndex = 8;
            this.addFertilizer.Text = "Add Fertilizer";
            this.addFertilizer.UseVisualStyleBackColor = true;
            this.addFertilizer.Click += new System.EventHandler(this.addFertilizer_Click);
            // 
            // removeFertilizer
            // 
            this.removeFertilizer.Location = new System.Drawing.Point(1469, 759);
            this.removeFertilizer.Margin = new System.Windows.Forms.Padding(4);
            this.removeFertilizer.Name = "removeFertilizer";
            this.removeFertilizer.Size = new System.Drawing.Size(155, 28);
            this.removeFertilizer.TabIndex = 7;
            this.removeFertilizer.Text = "Remove Fertilizer";
            this.removeFertilizer.UseVisualStyleBackColor = true;
            this.removeFertilizer.Click += new System.EventHandler(this.removeFertilizer_Click);
            // 
            // fertilizerNote
            // 
            this.fertilizerNote.Location = new System.Drawing.Point(359, 677);
            this.fertilizerNote.Margin = new System.Windows.Forms.Padding(4);
            this.fertilizerNote.Name = "fertilizerNote";
            this.fertilizerNote.Size = new System.Drawing.Size(132, 22);
            this.fertilizerNote.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(355, 657);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Fertilizer Note";
            // 
            // fertilizerDose
            // 
            this.fertilizerDose.Location = new System.Drawing.Point(217, 677);
            this.fertilizerDose.Margin = new System.Windows.Forms.Padding(4);
            this.fertilizerDose.Name = "fertilizerDose";
            this.fertilizerDose.Size = new System.Drawing.Size(132, 22);
            this.fertilizerDose.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(213, 657);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Fertilizer Dose";
            // 
            // fertilizerName
            // 
            this.fertilizerName.Location = new System.Drawing.Point(64, 677);
            this.fertilizerName.Margin = new System.Windows.Forms.Padding(4);
            this.fertilizerName.Name = "fertilizerName";
            this.fertilizerName.Size = new System.Drawing.Size(144, 22);
            this.fertilizerName.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 657);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Fertilizer Name";
            // 
            // fertilizerGridView
            // 
            this.fertilizerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fertilizerGridView.Location = new System.Drawing.Point(64, 25);
            this.fertilizerGridView.Margin = new System.Windows.Forms.Padding(4);
            this.fertilizerGridView.Name = "fertilizerGridView";
            this.fertilizerGridView.RowHeadersWidth = 45;
            this.fertilizerGridView.Size = new System.Drawing.Size(1660, 615);
            this.fertilizerGridView.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cropGridView);
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
            this.tabPage1.Controls.Add(this.addCropButton);
            this.tabPage1.Controls.Add(this.removeCropButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1809, 814);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crops";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cropGridView
            // 
            this.cropGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cropGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CropID});
            this.cropGridView.Location = new System.Drawing.Point(69, 71);
            this.cropGridView.Margin = new System.Windows.Forms.Padding(4);
            this.cropGridView.Name = "cropGridView";
            this.cropGridView.Size = new System.Drawing.Size(1657, 574);
            this.cropGridView.TabIndex = 46;
            // 
            // CropID
            // 
            this.CropID.DataPropertyName = "cropId";
            this.CropID.HeaderText = "cropId";
            this.CropID.Name = "CropID";
            this.CropID.ReadOnly = true;
            this.CropID.Visible = false;
            // 
            // containerStorageType
            // 
            this.containerStorageType.DisplayMember = "ContainerID";
            this.containerStorageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.containerStorageType.FormattingEnabled = true;
            this.containerStorageType.Location = new System.Drawing.Point(415, 729);
            this.containerStorageType.Margin = new System.Windows.Forms.Padding(4);
            this.containerStorageType.Name = "containerStorageType";
            this.containerStorageType.Size = new System.Drawing.Size(164, 24);
            this.containerStorageType.TabIndex = 45;
            this.containerStorageType.ValueMember = "ContainerID";
            // 
            // fieldId
            // 
            this.fieldId.DisplayMember = "FieldID";
            this.fieldId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldId.FormattingEnabled = true;
            this.fieldId.Location = new System.Drawing.Point(773, 729);
            this.fieldId.Margin = new System.Windows.Forms.Padding(4);
            this.fieldId.Name = "fieldId";
            this.fieldId.Size = new System.Drawing.Size(164, 24);
            this.fieldId.TabIndex = 44;
            this.fieldId.ValueMember = "FieldID";
            // 
            // dosedBy
            // 
            this.dosedBy.DisplayMember = "StaffID";
            this.dosedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dosedBy.FormattingEnabled = true;
            this.dosedBy.Location = new System.Drawing.Point(241, 730);
            this.dosedBy.Margin = new System.Windows.Forms.Padding(4);
            this.dosedBy.Name = "dosedBy";
            this.dosedBy.Size = new System.Drawing.Size(164, 24);
            this.dosedBy.TabIndex = 43;
            this.dosedBy.ValueMember = "StaffID";
            // 
            // cropMinMax
            // 
            this.cropMinMax.Location = new System.Drawing.Point(591, 730);
            this.cropMinMax.Margin = new System.Windows.Forms.Padding(4);
            this.cropMinMax.Name = "cropMinMax";
            this.cropMinMax.Size = new System.Drawing.Size(165, 22);
            this.cropMinMax.TabIndex = 41;
            // 
            // datePlanted
            // 
            this.datePlanted.Location = new System.Drawing.Point(205, 667);
            this.datePlanted.Margin = new System.Windows.Forms.Padding(4);
            this.datePlanted.Name = "datePlanted";
            this.datePlanted.Size = new System.Drawing.Size(168, 22);
            this.datePlanted.TabIndex = 38;
            // 
            // estimatedHarvest
            // 
            this.estimatedHarvest.Location = new System.Drawing.Point(383, 668);
            this.estimatedHarvest.Margin = new System.Windows.Forms.Padding(4);
            this.estimatedHarvest.Name = "estimatedHarvest";
            this.estimatedHarvest.Size = new System.Drawing.Size(168, 22);
            this.estimatedHarvest.TabIndex = 37;
            // 
            // cropNotes
            // 
            this.cropNotes.Location = new System.Drawing.Point(560, 667);
            this.cropNotes.Margin = new System.Windows.Forms.Padding(4);
            this.cropNotes.Name = "cropNotes";
            this.cropNotes.Size = new System.Drawing.Size(165, 22);
            this.cropNotes.TabIndex = 36;
            // 
            // fertilizerId
            // 
            this.fertilizerId.DisplayMember = "FertilizerID";
            this.fertilizerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fertilizerId.FormattingEnabled = true;
            this.fertilizerId.Location = new System.Drawing.Point(735, 667);
            this.fertilizerId.Margin = new System.Windows.Forms.Padding(4);
            this.fertilizerId.Name = "fertilizerId";
            this.fertilizerId.Size = new System.Drawing.Size(164, 24);
            this.fertilizerId.TabIndex = 35;
            this.fertilizerId.ValueMember = "FertilizerID";
            // 
            // nextDose
            // 
            this.nextDose.Location = new System.Drawing.Point(69, 731);
            this.nextDose.Margin = new System.Windows.Forms.Padding(4);
            this.nextDose.Name = "nextDose";
            this.nextDose.Size = new System.Drawing.Size(163, 22);
            this.nextDose.TabIndex = 34;
            // 
            // lastDose
            // 
            this.lastDose.Location = new System.Drawing.Point(1083, 671);
            this.lastDose.Margin = new System.Windows.Forms.Padding(4);
            this.lastDose.Name = "lastDose";
            this.lastDose.Size = new System.Drawing.Size(168, 22);
            this.lastDose.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(769, 711);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Field Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(591, 711);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Crop Min Max";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 711);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Crop Storage Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 711);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Dosed By Staff";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 711);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Next Dose";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1079, 651);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Last Dose";
            // 
            // cropStatus
            // 
            this.cropStatus.Location = new System.Drawing.Point(908, 668);
            this.cropStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cropStatus.Name = "cropStatus";
            this.cropStatus.Size = new System.Drawing.Size(165, 22);
            this.cropStatus.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(904, 651);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Crop Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 651);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fertilizer Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 651);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Crop Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 651);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Estimated Harvest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 651);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date Planted";
            // 
            // cropName
            // 
            this.cropName.Location = new System.Drawing.Point(64, 668);
            this.cropName.Margin = new System.Windows.Forms.Padding(4);
            this.cropName.Name = "cropName";
            this.cropName.Size = new System.Drawing.Size(132, 22);
            this.cropName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 649);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Crop Name";
            // 
            // addCropButton
            // 
            this.addCropButton.Location = new System.Drawing.Point(1625, 775);
            this.addCropButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCropButton.Name = "addCropButton";
            this.addCropButton.Size = new System.Drawing.Size(155, 28);
            this.addCropButton.TabIndex = 2;
            this.addCropButton.Text = "Add Crop";
            this.addCropButton.UseVisualStyleBackColor = true;
            this.addCropButton.Click += new System.EventHandler(this.addCropButton_Click);
            // 
            // removeCropButton
            // 
            this.removeCropButton.Location = new System.Drawing.Point(1463, 775);
            this.removeCropButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeCropButton.Name = "removeCropButton";
            this.removeCropButton.Size = new System.Drawing.Size(155, 28);
            this.removeCropButton.TabIndex = 1;
            this.removeCropButton.Text = "Remove Crop";
            this.removeCropButton.UseVisualStyleBackColor = true;
            this.removeCropButton.Click += new System.EventHandler(this.removeCropButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(16, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1817, 843);
            this.tabControl.TabIndex = 0;
            // 
            // fertilizerBindingSource
            // 
            this.fertilizerBindingSource.DataSource = typeof(farmingprogram.Fertilizer);
            // 
            // containerBindingSource
            // 
            this.containerBindingSource.DataSource = typeof(farmingprogram.Container);
            // 
            // fieldBindingSource
            // 
            this.fieldBindingSource.DataSource = typeof(farmingprogram.Field);
            // 
            // cropBindingSource1
            // 
            this.cropBindingSource1.DataSource = typeof(farmingprogram.Crop);
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(farmingprogram.Vehicle);
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 873);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainProgram";
            this.Text = "MainProgram";
            this.Load += new System.EventHandler(this.MainProgram_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fertilizerGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cropGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fertilizerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
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
        public System.Windows.Forms.BindingSource cropBindingSource1;
        public System.Windows.Forms.BindingSource vehicleBindingSource;
        public System.Windows.Forms.BindingSource fieldBindingSource;
        public System.Windows.Forms.BindingSource containerBindingSource;
        public System.Windows.Forms.BindingSource fertilizerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CropID;

    }
}