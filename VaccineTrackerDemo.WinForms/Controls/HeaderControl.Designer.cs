
namespace VaccineTrackerDemo.WinForms.Controls
{
    partial class HeaderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_Header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_Header
            // 
            this.label1_Header.AutoSize = true;
            this.label1_Header.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1_Header.Location = new System.Drawing.Point(19, 19);
            this.label1_Header.Name = "label1_Header";
            this.label1_Header.Size = new System.Drawing.Size(203, 25);
            this.label1_Header.TabIndex = 0;
            this.label1_Header.Text = "Vaccine Users Tracker";
            // 
            // HeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.label1_Header);
            this.Name = "HeaderControl";
            this.Size = new System.Drawing.Size(746, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Header;
    }
}
