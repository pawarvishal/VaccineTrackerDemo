
namespace VaccineTrackerDemo.WinForms
{
    partial class ConfirmationForm
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
            this.pnlConfirmation = new System.Windows.Forms.Panel();
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblSms = new System.Windows.Forms.Label();
            this.lblVaccine = new System.Windows.Forms.Label();
            this.pnlConfirmation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConfirmation
            // 
            this.pnlConfirmation.Controls.Add(this.lblVaccine);
            this.pnlConfirmation.Controls.Add(this.lblSms);
            this.pnlConfirmation.Controls.Add(this.lblThanks);
            this.pnlConfirmation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfirmation.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlConfirmation.Location = new System.Drawing.Point(0, 0);
            this.pnlConfirmation.Name = "pnlConfirmation";
            this.pnlConfirmation.Size = new System.Drawing.Size(800, 251);
            this.pnlConfirmation.TabIndex = 0;
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Location = new System.Drawing.Point(33, 53);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(120, 30);
            this.lblThanks.TabIndex = 0;
            this.lblThanks.Text = "{{ Thanks }}";
            // 
            // lblSms
            // 
            this.lblSms.AutoSize = true;
            this.lblSms.Location = new System.Drawing.Point(33, 115);
            this.lblSms.Name = "lblSms";
            this.lblSms.Size = new System.Drawing.Size(93, 30);
            this.lblSms.TabIndex = 1;
            this.lblSms.Text = "{{ Sms }}";
            // 
            // lblVaccine
            // 
            this.lblVaccine.AutoSize = true;
            this.lblVaccine.Location = new System.Drawing.Point(33, 179);
            this.lblVaccine.Name = "lblVaccine";
            this.lblVaccine.Size = new System.Drawing.Size(183, 30);
            this.lblVaccine.TabIndex = 2;
            this.lblVaccine.Text = "{{ VaccineName }}";
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.Controls.Add(this.pnlConfirmation);
            this.Name = "ConfirmationForm";
            this.Text = "ConfirmationForm";
            this.pnlConfirmation.ResumeLayout(false);
            this.pnlConfirmation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfirmation;
        private System.Windows.Forms.Label lblVaccine;
        private System.Windows.Forms.Label lblSms;
        private System.Windows.Forms.Label lblThanks;
    }
}