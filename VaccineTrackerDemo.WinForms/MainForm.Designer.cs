
namespace VaccineTrackerDemo.WinForms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.headerControl1 = new VaccineTrackerDemo.WinForms.Controls.HeaderControl();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.pnlRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlMainArea = new System.Windows.Forms.Panel();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtVaccineName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblVaccineName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblRegAddress = new System.Windows.Forms.Label();
            this.lblRegVaccineName = new System.Windows.Forms.Label();
            this.lblRegAge = new System.Windows.Forms.Label();
            this.lblRegContactNumber = new System.Windows.Forms.Label();
            this.lblRegGender = new System.Windows.Forms.Label();
            this.lblRegUsrname = new System.Windows.Forms.Label();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlRefresh.SuspendLayout();
            this.pnlMainArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.headerControl1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1381, 125);
            this.pnlHeader.TabIndex = 0;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.Coral;
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerControl1.Location = new System.Drawing.Point(0, 0);
            this.headerControl1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(1381, 125);
            this.headerControl1.TabIndex = 0;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.listBoxUsers);
            this.pnlNavigation.Controls.Add(this.pnlRefresh);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 125);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(290, 693);
            this.pnlNavigation.TabIndex = 1;
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 30;
            this.listBoxUsers.Location = new System.Drawing.Point(0, 125);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(290, 568);
            this.listBoxUsers.TabIndex = 1;
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.Controls.Add(this.btnRefresh);
            this.pnlRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRefresh.Location = new System.Drawing.Point(0, 0);
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Size = new System.Drawing.Size(290, 125);
            this.pnlRefresh.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(76, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 43);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlMainArea
            // 
            this.pnlMainArea.Controls.Add(this.radioFemale);
            this.pnlMainArea.Controls.Add(this.radioMale);
            this.pnlMainArea.Controls.Add(this.txtAddress);
            this.pnlMainArea.Controls.Add(this.txtVaccineName);
            this.pnlMainArea.Controls.Add(this.txtAge);
            this.pnlMainArea.Controls.Add(this.txtContactNumber);
            this.pnlMainArea.Controls.Add(this.txtUserName);
            this.pnlMainArea.Controls.Add(this.btnSave);
            this.pnlMainArea.Controls.Add(this.lblAddress);
            this.pnlMainArea.Controls.Add(this.lblVaccineName);
            this.pnlMainArea.Controls.Add(this.lblAge);
            this.pnlMainArea.Controls.Add(this.lblContactNumber);
            this.pnlMainArea.Controls.Add(this.lblGender);
            this.pnlMainArea.Controls.Add(this.lblUsername);
            this.pnlMainArea.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainArea.Location = new System.Drawing.Point(290, 125);
            this.pnlMainArea.Name = "pnlMainArea";
            this.pnlMainArea.Size = new System.Drawing.Size(698, 693);
            this.pnlMainArea.TabIndex = 2;
            // 
            // radioFemale
            // 
            this.radioFemale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(359, 124);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(104, 34);
            this.radioFemale.TabIndex = 13;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(225, 124);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(82, 34);
            this.radioMale.TabIndex = 12;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(225, 448);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(338, 36);
            this.txtAddress.TabIndex = 11;
            // 
            // txtVaccineName
            // 
            this.txtVaccineName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVaccineName.Location = new System.Drawing.Point(225, 367);
            this.txtVaccineName.Name = "txtVaccineName";
            this.txtVaccineName.Size = new System.Drawing.Size(338, 36);
            this.txtVaccineName.TabIndex = 10;
            // 
            // txtAge
            // 
            this.txtAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAge.Location = new System.Drawing.Point(225, 286);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(338, 36);
            this.txtAge.TabIndex = 9;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactNumber.Location = new System.Drawing.Point(225, 207);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(338, 36);
            this.txtContactNumber.TabIndex = 8;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(225, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(338, 36);
            this.txtUserName.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(45, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 50);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(45, 453);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(91, 30);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            // 
            // lblVaccineName
            // 
            this.lblVaccineName.AutoSize = true;
            this.lblVaccineName.Location = new System.Drawing.Point(45, 372);
            this.lblVaccineName.Name = "lblVaccineName";
            this.lblVaccineName.Size = new System.Drawing.Size(149, 30);
            this.lblVaccineName.TabIndex = 4;
            this.lblVaccineName.Text = "Vaccine Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(45, 291);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(52, 30);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(45, 212);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(173, 30);
            this.lblContactNumber.TabIndex = 2;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(45, 125);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(85, 30);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gender";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(45, 40);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(111, 30);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblRegAddress);
            this.pnlDetails.Controls.Add(this.lblRegVaccineName);
            this.pnlDetails.Controls.Add(this.lblRegAge);
            this.pnlDetails.Controls.Add(this.lblRegContactNumber);
            this.pnlDetails.Controls.Add(this.lblRegGender);
            this.pnlDetails.Controls.Add(this.lblRegUsrname);
            this.pnlDetails.Controls.Add(this.pnlRegister);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(988, 125);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(393, 693);
            this.pnlDetails.TabIndex = 3;
            // 
            // lblRegAddress
            // 
            this.lblRegAddress.AutoSize = true;
            this.lblRegAddress.Location = new System.Drawing.Point(23, 325);
            this.lblRegAddress.Name = "lblRegAddress";
            this.lblRegAddress.Size = new System.Drawing.Size(131, 30);
            this.lblRegAddress.TabIndex = 6;
            this.lblRegAddress.Text = "{{ Address }}";
            // 
            // lblRegVaccineName
            // 
            this.lblRegVaccineName.AutoSize = true;
            this.lblRegVaccineName.Location = new System.Drawing.Point(23, 274);
            this.lblRegVaccineName.Name = "lblRegVaccineName";
            this.lblRegVaccineName.Size = new System.Drawing.Size(183, 30);
            this.lblRegVaccineName.TabIndex = 5;
            this.lblRegVaccineName.Text = "{{ VaccineName }}";
            // 
            // lblRegAge
            // 
            this.lblRegAge.AutoSize = true;
            this.lblRegAge.Location = new System.Drawing.Point(23, 213);
            this.lblRegAge.Name = "lblRegAge";
            this.lblRegAge.Size = new System.Drawing.Size(92, 30);
            this.lblRegAge.TabIndex = 4;
            this.lblRegAge.Text = "{{ Age }}";
            // 
            // lblRegContactNumber
            // 
            this.lblRegContactNumber.AutoSize = true;
            this.lblRegContactNumber.Location = new System.Drawing.Point(23, 162);
            this.lblRegContactNumber.Name = "lblRegContactNumber";
            this.lblRegContactNumber.Size = new System.Drawing.Size(213, 30);
            this.lblRegContactNumber.TabIndex = 3;
            this.lblRegContactNumber.Text = "{{ Contact Number }}";
            // 
            // lblRegGender
            // 
            this.lblRegGender.AutoSize = true;
            this.lblRegGender.Location = new System.Drawing.Point(23, 108);
            this.lblRegGender.Name = "lblRegGender";
            this.lblRegGender.Size = new System.Drawing.Size(125, 30);
            this.lblRegGender.TabIndex = 2;
            this.lblRegGender.Text = "{{ Gender }}";
            // 
            // lblRegUsrname
            // 
            this.lblRegUsrname.AutoSize = true;
            this.lblRegUsrname.Location = new System.Drawing.Point(23, 45);
            this.lblRegUsrname.Name = "lblRegUsrname";
            this.lblRegUsrname.Size = new System.Drawing.Size(151, 30);
            this.lblRegUsrname.TabIndex = 1;
            this.lblRegUsrname.Text = "{{ Username }}";
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRegister.Location = new System.Drawing.Point(0, 372);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(393, 321);
            this.pnlRegister.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegister.Location = new System.Drawing.Point(23, 35);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(152, 49);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 818);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlMainArea);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlRefresh.ResumeLayout(false);
            this.pnlMainArea.ResumeLayout(false);
            this.pnlMainArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel pnlMainArea;
        private Controls.HeaderControl headerControl1;
        private System.Windows.Forms.Panel pnlRefresh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblVaccineName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtVaccineName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblRegAddress;
        private System.Windows.Forms.Label lblRegVaccineName;
        private System.Windows.Forms.Label lblRegAge;
        private System.Windows.Forms.Label lblRegContactNumber;
        private System.Windows.Forms.Label lblRegGender;
        private System.Windows.Forms.Label lblRegUsrname;
    }
}

