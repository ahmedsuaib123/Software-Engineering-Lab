namespace Hospital_Management
{
    partial class PatientManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet2 = new Hospital_Management.HospitalDataSet2();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_ManagementDataSet3 = new Hospital_Management.Hospital_ManagementDataSet3();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_ManagementDataSet2 = new Hospital_Management.Hospital_ManagementDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.patientTableAdapter = new Hospital_Management.Hospital_ManagementDataSet2TableAdapters.PatientTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.patientTableAdapter1 = new Hospital_Management.Hospital_ManagementDataSet3TableAdapters.PatientTableAdapter();
            this.hospital_ManagementDataSet6 = new Hospital_Management.Hospital_ManagementDataSet6();
            this.patientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter2 = new Hospital_Management.Hospital_ManagementDataSet6TableAdapters.PatientTableAdapter();
            this.hospitalDataSet = new Hospital_Management.HospitalDataSet();
            this.patientBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter3 = new Hospital_Management.HospitalDataSetTableAdapters.PatientTableAdapter();
            this.hospitalDataSet1 = new Hospital_Management.HospitalDataSet1();
            this.patientBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter4 = new Hospital_Management.HospitalDataSet1TableAdapters.PatientTableAdapter();
            this.patientTableAdapter5 = new Hospital_Management.HospitalDataSet2TableAdapters.PatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ManagementDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ManagementDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ManagementDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(157, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patientAgeDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.patientContactDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.patientAddressDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.patientUsernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(60, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 275);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            // 
            // patientAgeDataGridViewTextBoxColumn
            // 
            this.patientAgeDataGridViewTextBoxColumn.DataPropertyName = "PatientAge";
            this.patientAgeDataGridViewTextBoxColumn.HeaderText = "PatientAge";
            this.patientAgeDataGridViewTextBoxColumn.Name = "patientAgeDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // patientContactDataGridViewTextBoxColumn
            // 
            this.patientContactDataGridViewTextBoxColumn.DataPropertyName = "PatientContact";
            this.patientContactDataGridViewTextBoxColumn.HeaderText = "PatientContact";
            this.patientContactDataGridViewTextBoxColumn.Name = "patientContactDataGridViewTextBoxColumn";
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            // 
            // patientAddressDataGridViewTextBoxColumn
            // 
            this.patientAddressDataGridViewTextBoxColumn.DataPropertyName = "PatientAddress";
            this.patientAddressDataGridViewTextBoxColumn.HeaderText = "PatientAddress";
            this.patientAddressDataGridViewTextBoxColumn.Name = "patientAddressDataGridViewTextBoxColumn";
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            // 
            // patientUsernameDataGridViewTextBoxColumn
            // 
            this.patientUsernameDataGridViewTextBoxColumn.DataPropertyName = "PatientUsername";
            this.patientUsernameDataGridViewTextBoxColumn.HeaderText = "PatientUsername";
            this.patientUsernameDataGridViewTextBoxColumn.Name = "patientUsernameDataGridViewTextBoxColumn";
            // 
            // patientBindingSource5
            // 
            this.patientBindingSource5.DataMember = "Patient";
            this.patientBindingSource5.DataSource = this.hospitalDataSet2;
            // 
            // hospitalDataSet2
            // 
            this.hospitalDataSet2.DataSetName = "HospitalDataSet2";
            this.hospitalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.hospital_ManagementDataSet3;
            // 
            // hospital_ManagementDataSet3
            // 
            this.hospital_ManagementDataSet3.DataSetName = "Hospital_ManagementDataSet3";
            this.hospital_ManagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.hospital_ManagementDataSet2;
            // 
            // hospital_ManagementDataSet2
            // 
            this.hospital_ManagementDataSet2.DataSetName = "Hospital_ManagementDataSet2";
            this.hospital_ManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(179, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(299, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 33);
            this.button3.TabIndex = 10;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(433, 386);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 33);
            this.button5.TabIndex = 11;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(636, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 13;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // hospital_ManagementDataSet6
            // 
            this.hospital_ManagementDataSet6.DataSetName = "Hospital_ManagementDataSet6";
            this.hospital_ManagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource2
            // 
            this.patientBindingSource2.DataMember = "Patient";
            this.patientBindingSource2.DataSource = this.hospital_ManagementDataSet6;
            // 
            // patientTableAdapter2
            // 
            this.patientTableAdapter2.ClearBeforeFill = true;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource3
            // 
            this.patientBindingSource3.DataMember = "Patient";
            this.patientBindingSource3.DataSource = this.hospitalDataSet;
            // 
            // patientTableAdapter3
            // 
            this.patientTableAdapter3.ClearBeforeFill = true;
            // 
            // hospitalDataSet1
            // 
            this.hospitalDataSet1.DataSetName = "HospitalDataSet1";
            this.hospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource4
            // 
            this.patientBindingSource4.DataMember = "Patient";
            this.patientBindingSource4.DataSource = this.hospitalDataSet1;
            // 
            // patientTableAdapter4
            // 
            this.patientTableAdapter4.ClearBeforeFill = true;
            // 
            // patientTableAdapter5
            // 
            this.patientTableAdapter5.ClearBeforeFill = true;
            // 
            // PatientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Name = "PatientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Management";
            this.Load += new System.EventHandler(this.PatientManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ManagementDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ManagementDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ManagementDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private Hospital_ManagementDataSet2 hospital_ManagementDataSet2;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private Hospital_ManagementDataSet2TableAdapters.PatientTableAdapter patientTableAdapter;
        private Hospital_ManagementDataSet3 hospital_ManagementDataSet3;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private Hospital_ManagementDataSet3TableAdapters.PatientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private Hospital_ManagementDataSet6 hospital_ManagementDataSet6;
        private System.Windows.Forms.BindingSource patientBindingSource2;
        private Hospital_ManagementDataSet6TableAdapters.PatientTableAdapter patientTableAdapter2;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource3;
        private HospitalDataSetTableAdapters.PatientTableAdapter patientTableAdapter3;
        private HospitalDataSet1 hospitalDataSet1;
        private System.Windows.Forms.BindingSource patientBindingSource4;
        private HospitalDataSet1TableAdapters.PatientTableAdapter patientTableAdapter4;
        private HospitalDataSet2 hospitalDataSet2;
        private System.Windows.Forms.BindingSource patientBindingSource5;
        private HospitalDataSet2TableAdapters.PatientTableAdapter patientTableAdapter5;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientUsernameDataGridViewTextBoxColumn;
    }
}