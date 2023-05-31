namespace BankAccount
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.SecurityPic = new System.Windows.Forms.PictureBox();
            this.UNameTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ResetLbl = new System.Windows.Forms.Label();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecurityPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 456);
            this.panel1.TabIndex = 0;
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EmployeeLabel.Location = new System.Drawing.Point(446, 38);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(119, 32);
            this.EmployeeLabel.TabIndex = 1;
            this.EmployeeLabel.Text = "Employee";
            this.EmployeeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SecurityPic
            // 
            this.SecurityPic.Image = ((System.Drawing.Image)(resources.GetObject("SecurityPic.Image")));
            this.SecurityPic.Location = new System.Drawing.Point(446, 73);
            this.SecurityPic.Name = "SecurityPic";
            this.SecurityPic.Size = new System.Drawing.Size(119, 72);
            this.SecurityPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SecurityPic.TabIndex = 2;
            this.SecurityPic.TabStop = false;
            this.SecurityPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UNameTb
            // 
            this.UNameTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UNameTb.Location = new System.Drawing.Point(379, 215);
            this.UNameTb.Name = "UNameTb";
            this.UNameTb.Size = new System.Drawing.Size(264, 29);
            this.UNameTb.TabIndex = 3;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTb.Location = new System.Drawing.Point(379, 308);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(264, 29);
            this.PasswordTb.TabIndex = 4;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UserNameLabel.Location = new System.Drawing.Point(379, 182);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(88, 21);
            this.UserNameLabel.TabIndex = 5;
            this.UserNameLabel.Text = "User Name";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PasswordLabel.Location = new System.Drawing.Point(379, 273);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 21);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginBtn.Location = new System.Drawing.Point(425, 371);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(159, 36);
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ResetLbl
            // 
            this.ResetLbl.AutoSize = true;
            this.ResetLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ResetLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ResetLbl.Location = new System.Drawing.Point(480, 426);
            this.ResetLbl.Name = "ResetLbl";
            this.ResetLbl.Size = new System.Drawing.Size(48, 21);
            this.ResetLbl.TabIndex = 8;
            this.ResetLbl.Text = "Reset";
            this.ResetLbl.Click += new System.EventHandler(this.ResetLbl_Click);
            // 
            // ProfilePic
            // 
            this.ProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePic.Image")));
            this.ProfilePic.Location = new System.Drawing.Point(657, 0);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(91, 58);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePic.TabIndex = 9;
            this.ProfilePic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 456);
            this.Controls.Add(this.ProfilePic);
            this.Controls.Add(this.ResetLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UNameTb);
            this.Controls.Add(this.SecurityPic);
            this.Controls.Add(this.EmployeeLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecurityPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label EmployeeLabel;
        private PictureBox SecurityPic;
        private TextBox UNameTb;
        private TextBox PasswordTb;
        private Label UserNameLabel;
        private Label PasswordLabel;
        private Button LoginBtn;
        private Label ResetLbl;
        private PictureBox ProfilePic;
        private PictureBox pictureBox1;
    }
}