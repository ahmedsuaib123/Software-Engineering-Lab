namespace Hospital_Management
{
    partial class DoctorDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.hospitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.BloodGroupLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.AvailableLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ProfilePanelExtender = new System.Windows.Forms.Button();
            this.ProfilePanelTimer = new System.Windows.Forms.Timer(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hospitalDataSet8 = new Hospital_Management.HospitalDataSet8();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new Hospital_Management.HospitalDataSet8TableAdapters.AppointmentTableAdapter();
            this.Name1Label = new System.Windows.Forms.Label();
            this.Contact1Label = new System.Windows.Forms.Label();
            this.Age1Label = new System.Windows.Forms.Label();
            this.Gender1Label = new System.Windows.Forms.Label();
            this.BloodGroup1Label = new System.Windows.Forms.Label();
            this.Available1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).BeginInit();
            this.ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearButton.BackgroundImage")));
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(439, 95);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(31, 25);
            this.ClearButton.TabIndex = 33;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchButton.Location = new System.Drawing.Point(404, 95);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(29, 24);
            this.SearchButton.TabIndex = 32;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDLabel.Location = new System.Drawing.Point(729, 50);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(27, 13);
            this.IDLabel.TabIndex = 23;
            this.IDLabel.Text = "ID : ";
            this.IDLabel.Click += new System.EventHandler(this.IDLabel_Click);
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.ProfilePanel.Controls.Add(this.Available1Label);
            this.ProfilePanel.Controls.Add(this.BloodGroup1Label);
            this.ProfilePanel.Controls.Add(this.Gender1Label);
            this.ProfilePanel.Controls.Add(this.Age1Label);
            this.ProfilePanel.Controls.Add(this.Contact1Label);
            this.ProfilePanel.Controls.Add(this.Name1Label);
            this.ProfilePanel.Controls.Add(this.BloodGroupLabel);
            this.ProfilePanel.Controls.Add(this.GenderLabel);
            this.ProfilePanel.Controls.Add(this.AgeLabel);
            this.ProfilePanel.Controls.Add(this.LogoutButton);
            this.ProfilePanel.Controls.Add(this.AvailableLabel);
            this.ProfilePanel.Controls.Add(this.ContactLabel);
            this.ProfilePanel.Controls.Add(this.NameLabel);
            this.ProfilePanel.Location = new System.Drawing.Point(590, 0);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(204, 450);
            this.ProfilePanel.TabIndex = 21;
            this.ProfilePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProfilePanel_Paint);
            // 
            // BloodGroupLabel
            // 
            this.BloodGroupLabel.AutoSize = true;
            this.BloodGroupLabel.Location = new System.Drawing.Point(25, 228);
            this.BloodGroupLabel.Name = "BloodGroupLabel";
            this.BloodGroupLabel.Size = new System.Drawing.Size(75, 13);
            this.BloodGroupLabel.TabIndex = 5;
            this.BloodGroupLabel.Text = "Blood Group : ";
            this.BloodGroupLabel.Click += new System.EventHandler(this.BloodGroupLabel_Click);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(49, 193);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(51, 13);
            this.GenderLabel.TabIndex = 4;
            this.GenderLabel.Text = "Gender : ";
            this.GenderLabel.Click += new System.EventHandler(this.GenderLabel_Click);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(65, 159);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(35, 13);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "Age : ";
            this.AgeLabel.Click += new System.EventHandler(this.AgeLabel_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.White;
            this.LogoutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoutButton.BackgroundImage")));
            this.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.ForeColor = System.Drawing.Color.Snow;
            this.LogoutButton.Location = new System.Drawing.Point(161, 408);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(37, 37);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.Location = new System.Drawing.Point(15, 263);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(85, 13);
            this.AvailableLabel.TabIndex = 2;
            this.AvailableLabel.Text = "Available Time : ";
            this.AvailableLabel.Click += new System.EventHandler(this.AvailableLabel_Click);
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(47, 126);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(53, 13);
            this.ContactLabel.TabIndex = 1;
            this.ContactLabel.Text = "Contact : ";
            this.ContactLabel.Click += new System.EventHandler(this.ContactLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(56, 95);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name : ";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllButton.Location = new System.Drawing.Point(67, 346);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(71, 28);
            this.ShowAllButton.TabIndex = 24;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(367, 346);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(76, 28);
            this.UpdateButton.TabIndex = 30;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(6, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 24);
            this.button4.TabIndex = 29;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchTextBox.Location = new System.Drawing.Point(117, 97);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(278, 23);
            this.SearchTextBox.TabIndex = 28;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(41, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Search";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(267, 346);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(76, 28);
            this.DeleteButton.TabIndex = 26;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ProfilePanelExtender
            // 
            this.ProfilePanelExtender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfilePanelExtender.BackgroundImage")));
            this.ProfilePanelExtender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfilePanelExtender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilePanelExtender.Location = new System.Drawing.Point(732, 12);
            this.ProfilePanelExtender.Name = "ProfilePanelExtender";
            this.ProfilePanelExtender.Size = new System.Drawing.Size(50, 35);
            this.ProfilePanelExtender.TabIndex = 22;
            this.ProfilePanelExtender.UseVisualStyleBackColor = true;
            this.ProfilePanelExtender.Click += new System.EventHandler(this.ProfilePanelExtender_Click);
            // 
            // ProfilePanelTimer
            // 
            this.ProfilePanelTimer.Interval = 15;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(159, 346);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(71, 28);
            this.AddButton.TabIndex = 25;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 214);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hospitalDataSet8
            // 
            this.hospitalDataSet8.DataSetName = "HospitalDataSet8";
            this.hospitalDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.hospitalDataSet8;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // Name1Label
            // 
            this.Name1Label.AutoSize = true;
            this.Name1Label.Location = new System.Drawing.Point(106, 95);
            this.Name1Label.Name = "Name1Label";
            this.Name1Label.Size = new System.Drawing.Size(38, 13);
            this.Name1Label.TabIndex = 6;
            this.Name1Label.Text = "Name:";
            // 
            // Contact1Label
            // 
            this.Contact1Label.AutoSize = true;
            this.Contact1Label.Location = new System.Drawing.Point(106, 126);
            this.Contact1Label.Name = "Contact1Label";
            this.Contact1Label.Size = new System.Drawing.Size(47, 13);
            this.Contact1Label.TabIndex = 7;
            this.Contact1Label.Text = "Contact:";
            // 
            // Age1Label
            // 
            this.Age1Label.AutoSize = true;
            this.Age1Label.Location = new System.Drawing.Point(109, 159);
            this.Age1Label.Name = "Age1Label";
            this.Age1Label.Size = new System.Drawing.Size(29, 13);
            this.Age1Label.TabIndex = 8;
            this.Age1Label.Text = "Age:";
            // 
            // Gender1Label
            // 
            this.Gender1Label.AutoSize = true;
            this.Gender1Label.Location = new System.Drawing.Point(106, 193);
            this.Gender1Label.Name = "Gender1Label";
            this.Gender1Label.Size = new System.Drawing.Size(45, 13);
            this.Gender1Label.TabIndex = 9;
            this.Gender1Label.Text = "Gender:";
            // 
            // BloodGroup1Label
            // 
            this.BloodGroup1Label.AutoSize = true;
            this.BloodGroup1Label.Location = new System.Drawing.Point(109, 228);
            this.BloodGroup1Label.Name = "BloodGroup1Label";
            this.BloodGroup1Label.Size = new System.Drawing.Size(69, 13);
            this.BloodGroup1Label.TabIndex = 10;
            this.BloodGroup1Label.Text = "Blood Group:";
            // 
            // Available1Label
            // 
            this.Available1Label.AutoSize = true;
            this.Available1Label.Location = new System.Drawing.Point(106, 263);
            this.Available1Label.Name = "Available1Label";
            this.Available1Label.Size = new System.Drawing.Size(79, 13);
            this.Available1Label.TabIndex = 11;
            this.Available1Label.Text = "Available Time:";
            // 
            // DoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProfilePanelExtender);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.ProfilePanel);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Name = "DoctorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Dashboard";
            this.Load += new System.EventHandler(this.DoctorDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).EndInit();
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.BindingSource hospitalDataSetBindingSource;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Label BloodGroupLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label AvailableLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ProfilePanelExtender;
        private System.Windows.Forms.Timer ProfilePanelTimer;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalDataSet8 hospitalDataSet8;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private HospitalDataSet8TableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.Label Available1Label;
        private System.Windows.Forms.Label BloodGroup1Label;
        private System.Windows.Forms.Label Gender1Label;
        private System.Windows.Forms.Label Age1Label;
        private System.Windows.Forms.Label Contact1Label;
        private System.Windows.Forms.Label Name1Label;
    }
}