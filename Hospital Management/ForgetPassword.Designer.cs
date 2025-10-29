namespace PrototypeOfAll
{
    partial class ForgetPassword
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PhonenumberLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PhonenumberTextBox = new System.Windows.Forms.TextBox();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.VerifyButton2 = new System.Windows.Forms.Button();
            this.NewPassTextBox = new System.Windows.Forms.TextBox();
            this.NewPassLabel = new System.Windows.Forms.Label();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(187, 157);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(92, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Enter Username : ";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // PhonenumberLabel
            // 
            this.PhonenumberLabel.AutoSize = true;
            this.PhonenumberLabel.Location = new System.Drawing.Point(166, 201);
            this.PhonenumberLabel.Name = "PhonenumberLabel";
            this.PhonenumberLabel.Size = new System.Drawing.Size(113, 13);
            this.PhonenumberLabel.TabIndex = 1;
            this.PhonenumberLabel.Text = "Enter Phone number : ";
            this.PhonenumberLabel.Visible = false;
            this.PhonenumberLabel.Click += new System.EventHandler(this.PhonenumberLabel_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(362, 150);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // PhonenumberTextBox
            // 
            this.PhonenumberTextBox.Location = new System.Drawing.Point(362, 198);
            this.PhonenumberTextBox.Name = "PhonenumberTextBox";
            this.PhonenumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhonenumberTextBox.TabIndex = 3;
            this.PhonenumberTextBox.Visible = false;
            this.PhonenumberTextBox.TextChanged += new System.EventHandler(this.PhonenumberTextBox_TextChanged);
            // 
            // VerifyButton
            // 
            this.VerifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.VerifyButton.Location = new System.Drawing.Point(497, 150);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(50, 20);
            this.VerifyButton.TabIndex = 4;
            this.VerifyButton.Text = "Verify";
            this.VerifyButton.UseVisualStyleBackColor = true;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // VerifyButton2
            // 
            this.VerifyButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.VerifyButton2.Location = new System.Drawing.Point(497, 198);
            this.VerifyButton2.Name = "VerifyButton2";
            this.VerifyButton2.Size = new System.Drawing.Size(50, 20);
            this.VerifyButton2.TabIndex = 5;
            this.VerifyButton2.Text = "Verify";
            this.VerifyButton2.UseVisualStyleBackColor = true;
            this.VerifyButton2.Visible = false;
            this.VerifyButton2.Click += new System.EventHandler(this.VerifyButton2_Click);
            // 
            // NewPassTextBox
            // 
            this.NewPassTextBox.Location = new System.Drawing.Point(362, 248);
            this.NewPassTextBox.Name = "NewPassTextBox";
            this.NewPassTextBox.Size = new System.Drawing.Size(100, 20);
            this.NewPassTextBox.TabIndex = 7;
            this.NewPassTextBox.Visible = false;
            this.NewPassTextBox.TextChanged += new System.EventHandler(this.NewPassTextBox_TextChanged);
            // 
            // NewPassLabel
            // 
            this.NewPassLabel.AutoSize = true;
            this.NewPassLabel.Location = new System.Drawing.Point(164, 255);
            this.NewPassLabel.Name = "NewPassLabel";
            this.NewPassLabel.Size = new System.Drawing.Size(115, 13);
            this.NewPassLabel.TabIndex = 8;
            this.NewPassLabel.Text = "Enter New Password : ";
            this.NewPassLabel.Visible = false;
            this.NewPassLabel.Click += new System.EventHandler(this.NewPassLabel_Click);
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Location = new System.Drawing.Point(154, 302);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(125, 13);
            this.ConfirmPassLabel.TabIndex = 10;
            this.ConfirmPassLabel.Text = "Confirm New Password : ";
            this.ConfirmPassLabel.Visible = false;
            this.ConfirmPassLabel.Click += new System.EventHandler(this.ConfirmPassLabel_Click);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(362, 295);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConfirmPasswordTextBox.TabIndex = 9;
            this.ConfirmPasswordTextBox.Visible = false;
            this.ConfirmPasswordTextBox.TextChanged += new System.EventHandler(this.ConfirmPasswordTextBox_TextChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ConfirmButton.Location = new System.Drawing.Point(497, 294);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(50, 20);
            this.ConfirmButton.TabIndex = 11;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Visible = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ConfirmPassLabel);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.NewPassLabel);
            this.Controls.Add(this.NewPassTextBox);
            this.Controls.Add(this.VerifyButton2);
            this.Controls.Add(this.VerifyButton);
            this.Controls.Add(this.PhonenumberTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PhonenumberLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PhonenumberLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PhonenumberTextBox;
        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.Button VerifyButton2;
        private System.Windows.Forms.TextBox NewPassTextBox;
        private System.Windows.Forms.Label NewPassLabel;
        private System.Windows.Forms.Label ConfirmPassLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button button1;
    }
}