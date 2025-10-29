namespace Hospital_Management
{
    partial class NurseDashboard
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
            this.NurseDataGridView = new System.Windows.Forms.DataGridView();
            this.PatientInfoBTN = new System.Windows.Forms.Button();
            this.DutyScheduleBTN = new System.Windows.Forms.Button();
            this.NurseDashboardExitBTN = new System.Windows.Forms.Button();
            this.NurseProfileBTN = new System.Windows.Forms.Button();
            this.PatientSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogOutBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NurseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NurseDataGridView
            // 
            this.NurseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NurseDataGridView.Location = new System.Drawing.Point(12, 121);
            this.NurseDataGridView.Name = "NurseDataGridView";
            this.NurseDataGridView.RowHeadersWidth = 51;
            this.NurseDataGridView.RowTemplate.Height = 24;
            this.NurseDataGridView.Size = new System.Drawing.Size(776, 150);
            this.NurseDataGridView.TabIndex = 0;
            // 
            // PatientInfoBTN
            // 
            this.PatientInfoBTN.Location = new System.Drawing.Point(117, 394);
            this.PatientInfoBTN.Name = "PatientInfoBTN";
            this.PatientInfoBTN.Size = new System.Drawing.Size(103, 23);
            this.PatientInfoBTN.TabIndex = 1;
            this.PatientInfoBTN.Text = "Patient Info";
            this.PatientInfoBTN.UseVisualStyleBackColor = true;
            this.PatientInfoBTN.Click += new System.EventHandler(this.PatientInfoBTN_Click);
            // 
            // DutyScheduleBTN
            // 
            this.DutyScheduleBTN.Location = new System.Drawing.Point(278, 394);
            this.DutyScheduleBTN.Name = "DutyScheduleBTN";
            this.DutyScheduleBTN.Size = new System.Drawing.Size(103, 23);
            this.DutyScheduleBTN.TabIndex = 2;
            this.DutyScheduleBTN.Text = "Duty Schedule";
            this.DutyScheduleBTN.UseVisualStyleBackColor = true;
            this.DutyScheduleBTN.Click += new System.EventHandler(this.DutyScheduleBTN_Click);
            // 
            // NurseDashboardExitBTN
            // 
            this.NurseDashboardExitBTN.Location = new System.Drawing.Point(443, 394);
            this.NurseDashboardExitBTN.Name = "NurseDashboardExitBTN";
            this.NurseDashboardExitBTN.Size = new System.Drawing.Size(103, 23);
            this.NurseDashboardExitBTN.TabIndex = 3;
            this.NurseDashboardExitBTN.Text = "Exit";
            this.NurseDashboardExitBTN.UseVisualStyleBackColor = true;
            this.NurseDashboardExitBTN.Click += new System.EventHandler(this.NurseDashboardExitBTN_Click);
            // 
            // NurseProfileBTN
            // 
            this.NurseProfileBTN.Location = new System.Drawing.Point(669, 51);
            this.NurseProfileBTN.Name = "NurseProfileBTN";
            this.NurseProfileBTN.Size = new System.Drawing.Size(108, 23);
            this.NurseProfileBTN.TabIndex = 4;
            this.NurseProfileBTN.Text = "My Profile";
            this.NurseProfileBTN.UseVisualStyleBackColor = true;
            this.NurseProfileBTN.Click += new System.EventHandler(this.NurseProfileBTN_Click);
            // 
            // PatientSearchTextBox
            // 
            this.PatientSearchTextBox.Location = new System.Drawing.Point(170, 51);
            this.PatientSearchTextBox.Name = "PatientSearchTextBox";
            this.PatientSearchTextBox.Size = new System.Drawing.Size(247, 22);
            this.PatientSearchTextBox.TabIndex = 5;
            this.PatientSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PatientSearchTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Patient";
            // 
            // LogOutBTN
            // 
            this.LogOutBTN.Location = new System.Drawing.Point(640, 394);
            this.LogOutBTN.Name = "LogOutBTN";
            this.LogOutBTN.Size = new System.Drawing.Size(75, 23);
            this.LogOutBTN.TabIndex = 7;
            this.LogOutBTN.Text = "Log Out";
            this.LogOutBTN.UseVisualStyleBackColor = true;
            this.LogOutBTN.Click += new System.EventHandler(this.LogOutBTN_Click);
            // 
            // NurseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOutBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientSearchTextBox);
            this.Controls.Add(this.NurseProfileBTN);
            this.Controls.Add(this.NurseDashboardExitBTN);
            this.Controls.Add(this.DutyScheduleBTN);
            this.Controls.Add(this.PatientInfoBTN);
            this.Controls.Add(this.NurseDataGridView);
            this.Name = "NurseDashboard";
            this.Text = "Nurse Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.NurseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NurseDataGridView;
        private System.Windows.Forms.Button PatientInfoBTN;
        private System.Windows.Forms.Button DutyScheduleBTN;
        private System.Windows.Forms.Button NurseDashboardExitBTN;
        private System.Windows.Forms.Button NurseProfileBTN;
        private System.Windows.Forms.TextBox PatientSearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOutBTN;
    }
}