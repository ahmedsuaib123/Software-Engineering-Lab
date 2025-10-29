namespace Hospital_Management
{
    partial class NurseManagement
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nurseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseShiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet5 = new Hospital_Management.HospitalDataSet5();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_ManagementDataSet5 = new Hospital_Management.Hospital_ManagementDataSet5();
            this.nurseTableAdapter = new Hospital_Management.Hospital_ManagementDataSet5TableAdapters.NurseTableAdapter();
            this.nurseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nurseTableAdapter1 = new Hospital_Management.HospitalDataSet5TableAdapters.NurseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ManagementDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(166, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.TabStop = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(83, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(220, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(357, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(611, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 35);
            this.button4.TabIndex = 10;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nurseIDDataGridViewTextBoxColumn,
            this.nurseNameDataGridViewTextBoxColumn,
            this.nurseAgeDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.nurseContactDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.nurseShiftDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nurseBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(83, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 269);
            this.dataGridView1.TabIndex = 11;
            // 
            // nurseIDDataGridViewTextBoxColumn
            // 
            this.nurseIDDataGridViewTextBoxColumn.DataPropertyName = "NurseID";
            this.nurseIDDataGridViewTextBoxColumn.HeaderText = "NurseID";
            this.nurseIDDataGridViewTextBoxColumn.Name = "nurseIDDataGridViewTextBoxColumn";
            this.nurseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nurseNameDataGridViewTextBoxColumn
            // 
            this.nurseNameDataGridViewTextBoxColumn.DataPropertyName = "NurseName";
            this.nurseNameDataGridViewTextBoxColumn.HeaderText = "NurseName";
            this.nurseNameDataGridViewTextBoxColumn.Name = "nurseNameDataGridViewTextBoxColumn";
            // 
            // nurseAgeDataGridViewTextBoxColumn
            // 
            this.nurseAgeDataGridViewTextBoxColumn.DataPropertyName = "NurseAge";
            this.nurseAgeDataGridViewTextBoxColumn.HeaderText = "NurseAge";
            this.nurseAgeDataGridViewTextBoxColumn.Name = "nurseAgeDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // nurseContactDataGridViewTextBoxColumn
            // 
            this.nurseContactDataGridViewTextBoxColumn.DataPropertyName = "NurseContact";
            this.nurseContactDataGridViewTextBoxColumn.HeaderText = "NurseContact";
            this.nurseContactDataGridViewTextBoxColumn.Name = "nurseContactDataGridViewTextBoxColumn";
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            // 
            // nurseShiftDataGridViewTextBoxColumn
            // 
            this.nurseShiftDataGridViewTextBoxColumn.DataPropertyName = "NurseShift";
            this.nurseShiftDataGridViewTextBoxColumn.HeaderText = "NurseShift";
            this.nurseShiftDataGridViewTextBoxColumn.Name = "nurseShiftDataGridViewTextBoxColumn";
            // 
            // nurseBindingSource2
            // 
            this.nurseBindingSource2.DataMember = "Nurse";
            this.nurseBindingSource2.DataSource = this.hospitalDataSet5BindingSource;
            // 
            // hospitalDataSet5BindingSource
            // 
            this.hospitalDataSet5BindingSource.DataSource = this.hospitalDataSet5;
            this.hospitalDataSet5BindingSource.Position = 0;
            // 
            // hospitalDataSet5
            // 
            this.hospitalDataSet5.DataSetName = "HospitalDataSet5";
            this.hospitalDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataMember = "Nurse";
            this.nurseBindingSource.DataSource = this.hospital_ManagementDataSet5;
            // 
            // hospital_ManagementDataSet5
            // 
            this.hospital_ManagementDataSet5.DataSetName = "Hospital_ManagementDataSet5";
            this.hospital_ManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nurseTableAdapter
            // 
            this.nurseTableAdapter.ClearBeforeFill = true;
            // 
            // nurseBindingSource1
            // 
            this.nurseBindingSource1.DataMember = "Nurse";
            this.nurseBindingSource1.DataSource = this.hospitalDataSet5;
            // 
            // nurseTableAdapter1
            // 
            this.nurseTableAdapter1.ClearBeforeFill = true;
            // 
            // NurseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "NurseManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nurse Management";
            this.Load += new System.EventHandler(this.NurseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_ManagementDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Hospital_ManagementDataSet5 hospital_ManagementDataSet5;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private Hospital_ManagementDataSet5TableAdapters.NurseTableAdapter nurseTableAdapter;
        private HospitalDataSet5 hospitalDataSet5;
        private System.Windows.Forms.BindingSource nurseBindingSource1;
        private HospitalDataSet5TableAdapters.NurseTableAdapter nurseTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseShiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nurseBindingSource2;
        private System.Windows.Forms.BindingSource hospitalDataSet5BindingSource;
    }
}