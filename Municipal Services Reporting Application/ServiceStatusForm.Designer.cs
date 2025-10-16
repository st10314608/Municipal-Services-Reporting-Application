namespace Municipal_Services_Reporting_Application
{
    partial class ServiceStatusForm
    {
        private System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.Label lblHeading;
        public System.Windows.Forms.ListBox listBoxStatus;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button btnMarkInProgress;
        public System.Windows.Forms.Button btnMarkCompleted;
        public System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMarkInProgress = new System.Windows.Forms.Button();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblHeading
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(20, 18);
            this.lblHeading.Text = "Service Request Status";
            // listBoxStatus
            this.listBoxStatus.Location = new System.Drawing.Point(25, 60);
            this.listBoxStatus.Size = new System.Drawing.Size(700, 220);
            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(25, 290);
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.Text = "Refresh";
            // btnMarkInProgress
            this.btnMarkInProgress.Location = new System.Drawing.Point(140, 290);
            this.btnMarkInProgress.Size = new System.Drawing.Size(140, 30);
            this.btnMarkInProgress.Text = "Mark In Progress";
            // btnMarkCompleted
            this.btnMarkCompleted.Location = new System.Drawing.Point(300, 290);
            this.btnMarkCompleted.Size = new System.Drawing.Size(140, 30);
            this.btnMarkCompleted.Text = "Mark Completed";
            // btnBack
            this.btnBack.Location = new System.Drawing.Point(625, 360);
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.Text = "Back";
            // ServiceStatusForm
            this.ClientSize = new System.Drawing.Size(760, 410);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.listBoxStatus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMarkInProgress);
            this.Controls.Add(this.btnMarkCompleted);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ServiceStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Status";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

