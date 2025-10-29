namespace Hospital_Management
{
    partial class BookApointment
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
            this.DoctorIDComboBox = new System.Windows.Forms.ComboBox();
            this.DoctorIDLabel = new System.Windows.Forms.Label();
            this.DoctorNameLabel = new System.Windows.Forms.Label();
            this.AvailableSlotLlabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.DiagnosisLabel = new System.Windows.Forms.Label();
            this.AppointmentDateLabel = new System.Windows.Forms.Label();
            this.DocNameTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.DiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.AvailableSlotComboBox = new System.Windows.Forms.ComboBox();
            this.AppointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BookButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoctorIDComboBox
            // 
            this.DoctorIDComboBox.FormattingEnabled = true;
            this.DoctorIDComboBox.Location = new System.Drawing.Point(210, 63);
            this.DoctorIDComboBox.Name = "DoctorIDComboBox";
            this.DoctorIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.DoctorIDComboBox.TabIndex = 0;
            this.DoctorIDComboBox.SelectedIndexChanged += new System.EventHandler(this.DoctorIDComboBox_SelectedIndexChanged);
            // 
            // DoctorIDLabel
            // 
            this.DoctorIDLabel.AutoSize = true;
            this.DoctorIDLabel.Location = new System.Drawing.Point(102, 63);
            this.DoctorIDLabel.Name = "DoctorIDLabel";
            this.DoctorIDLabel.Size = new System.Drawing.Size(62, 13);
            this.DoctorIDLabel.TabIndex = 1;
            this.DoctorIDLabel.Text = "Doctor ID : ";
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.AutoSize = true;
            this.DoctorNameLabel.Location = new System.Drawing.Point(102, 115);
            this.DoctorNameLabel.Name = "DoctorNameLabel";
            this.DoctorNameLabel.Size = new System.Drawing.Size(79, 13);
            this.DoctorNameLabel.TabIndex = 2;
            this.DoctorNameLabel.Text = "Doctor Name : ";
            // 
            // AvailableSlotLlabel
            // 
            this.AvailableSlotLlabel.AutoSize = true;
            this.AvailableSlotLlabel.Location = new System.Drawing.Point(102, 235);
            this.AvailableSlotLlabel.Name = "AvailableSlotLlabel";
            this.AvailableSlotLlabel.Size = new System.Drawing.Size(80, 13);
            this.AvailableSlotLlabel.TabIndex = 3;
            this.AvailableSlotLlabel.Text = "Available Slot : ";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(102, 176);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(71, 13);
            this.DepartmentLabel.TabIndex = 4;
            this.DepartmentLabel.Text = "Department : ";
            // 
            // DiagnosisLabel
            // 
            this.DiagnosisLabel.AutoSize = true;
            this.DiagnosisLabel.Location = new System.Drawing.Point(102, 294);
            this.DiagnosisLabel.Name = "DiagnosisLabel";
            this.DiagnosisLabel.Size = new System.Drawing.Size(62, 13);
            this.DiagnosisLabel.TabIndex = 5;
            this.DiagnosisLabel.Text = "Diagnosis : ";
            // 
            // AppointmentDateLabel
            // 
            this.AppointmentDateLabel.AutoSize = true;
            this.AppointmentDateLabel.Location = new System.Drawing.Point(102, 354);
            this.AppointmentDateLabel.Name = "AppointmentDateLabel";
            this.AppointmentDateLabel.Size = new System.Drawing.Size(95, 13);
            this.AppointmentDateLabel.TabIndex = 6;
            this.AppointmentDateLabel.Text = "Apointment Date : ";
            // 
            // DocNameTextBox
            // 
            this.DocNameTextBox.Location = new System.Drawing.Point(210, 115);
            this.DocNameTextBox.Name = "DocNameTextBox";
            this.DocNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.DocNameTextBox.TabIndex = 7;
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Location = new System.Drawing.Point(210, 173);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.DepartmentTextBox.TabIndex = 8;
            // 
            // DiagnosisTextBox
            // 
            this.DiagnosisTextBox.Location = new System.Drawing.Point(210, 294);
            this.DiagnosisTextBox.Name = "DiagnosisTextBox";
            this.DiagnosisTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiagnosisTextBox.TabIndex = 11;
            // 
            // AvailableSlotComboBox
            // 
            this.AvailableSlotComboBox.FormattingEnabled = true;
            this.AvailableSlotComboBox.Location = new System.Drawing.Point(210, 232);
            this.AvailableSlotComboBox.Name = "AvailableSlotComboBox";
            this.AvailableSlotComboBox.Size = new System.Drawing.Size(121, 21);
            this.AvailableSlotComboBox.TabIndex = 12;
            // 
            // AppointmentDatePicker
            // 
            this.AppointmentDatePicker.Location = new System.Drawing.Point(210, 354);
            this.AppointmentDatePicker.Name = "AppointmentDatePicker";
            this.AppointmentDatePicker.Size = new System.Drawing.Size(200, 20);
            this.AppointmentDatePicker.TabIndex = 13;
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(713, 415);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(75, 23);
            this.BookButton.TabIndex = 14;
            this.BookButton.Text = "Book Now";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(2, 415);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // BookApointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.AppointmentDatePicker);
            this.Controls.Add(this.AvailableSlotComboBox);
            this.Controls.Add(this.DiagnosisTextBox);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.DocNameTextBox);
            this.Controls.Add(this.AppointmentDateLabel);
            this.Controls.Add(this.DiagnosisLabel);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.AvailableSlotLlabel);
            this.Controls.Add(this.DoctorNameLabel);
            this.Controls.Add(this.DoctorIDLabel);
            this.Controls.Add(this.DoctorIDComboBox);
            this.Name = "BookApointment";
            this.Text = "BookApointment";
            this.Load += new System.EventHandler(this.BookApointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DoctorIDComboBox;
        private System.Windows.Forms.Label DoctorIDLabel;
        private System.Windows.Forms.Label DoctorNameLabel;
        private System.Windows.Forms.Label AvailableSlotLlabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label DiagnosisLabel;
        private System.Windows.Forms.Label AppointmentDateLabel;
        private System.Windows.Forms.TextBox DocNameTextBox;
        private System.Windows.Forms.TextBox DepartmentTextBox;
        private System.Windows.Forms.TextBox DiagnosisTextBox;
        private System.Windows.Forms.ComboBox AvailableSlotComboBox;
        private System.Windows.Forms.DateTimePicker AppointmentDatePicker;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button BackButton;
    }
}