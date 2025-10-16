namespace Municipal_Services_Reporting_Application
{
    partial class ReportIssuesForm
    {
        private System.ComponentModel.IContainer components = null;

        public System.Windows.Forms.Label lblHeading;
        public System.Windows.Forms.TextBox txtLocation;
        public System.Windows.Forms.ComboBox cmbCategory;
        public System.Windows.Forms.RichTextBox rtbDescription;
        public System.Windows.Forms.Button btnAttach;
        public System.Windows.Forms.Button btnSubmit;
        public System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Label lblAttachCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAttachCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(20, 20);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(139, 25);
            this.lblHeading.Text = "Report Issues";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(25, 70);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(480, 23);
            this.txtLocation.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Location = new System.Drawing.Point(25, 110);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(250, 23);
            this.cmbCategory.TabIndex = 1;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(25, 150);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(480, 150);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(25, 315);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(120, 30);
            this.btnAttach.TabIndex = 3;
            this.btnAttach.Text = "Attach Files";
            this.btnAttach.UseVisualStyleBackColor = true;
            // 
            // lblAttachCount
            // 
            this.lblAttachCount.Location = new System.Drawing.Point(155, 320);
            this.lblAttachCount.Name = "lblAttachCount";
            this.lblAttachCount.Size = new System.Drawing.Size(200, 20);
            this.lblAttachCount.Text = "0 files attached";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(330, 315);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 30);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(420, 315);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 30);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 370);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.lblAttachCount);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReportIssuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Issues";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

