namespace Municipal_Services_Reporting_Application
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.Label lblHeading;
        public System.Windows.Forms.Button btnReportIssues;
        public System.Windows.Forms.Button btnLocalEvents;
        public System.Windows.Forms.Button btnServiceStatus;
        public System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(57, 21);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(483, 41);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "CityConnect – Municipal Services";
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnReportIssues.Location = new System.Drawing.Point(103, 96);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(343, 53);
            this.btnReportIssues.TabIndex = 1;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = true;
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLocalEvents.Location = new System.Drawing.Point(103, 171);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(343, 53);
            this.btnLocalEvents.TabIndex = 2;
            this.btnLocalEvents.Text = "Local Events and Announcements";
            this.btnLocalEvents.UseVisualStyleBackColor = true;
            // 
            // btnServiceStatus
            // 
            this.btnServiceStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnServiceStatus.Location = new System.Drawing.Point(103, 245);
            this.btnServiceStatus.Name = "btnServiceStatus";
            this.btnServiceStatus.Size = new System.Drawing.Size(343, 53);
            this.btnServiceStatus.TabIndex = 3;
            this.btnServiceStatus.Text = "Service Request Status";
            this.btnServiceStatus.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnExit.Location = new System.Drawing.Point(103, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(343, 48);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 405);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnServiceStatus);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "V";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
