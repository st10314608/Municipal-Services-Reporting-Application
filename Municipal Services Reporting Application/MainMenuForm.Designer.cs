namespace Municipal_Services_Reporting_Application
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.grpReportIssues = new System.Windows.Forms.GroupBox();
            this.lblReportDesc = new System.Windows.Forms.Label();
            this.btnOpenReport = new System.Windows.Forms.Button();
            this.grpEvents = new System.Windows.Forms.GroupBox();
            this.lblEventsDesc = new System.Windows.Forms.Label();
            this.btnEvents = new System.Windows.Forms.Button();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.lblStatusDesc = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.grpReportIssues.SuspendLayout();
            this.grpEvents.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Red;
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(600, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 30);
            this.lblTitle.Text = "CityConnect — Municipal Services";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 45);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(550, 25);
            this.lblSubtitle.Text = "Report issues, view updates and stay connected with your local municipality.";
            // 
            // grpReportIssues
            // 
            this.grpReportIssues.Controls.Add(this.btnOpenReport);
            this.grpReportIssues.Controls.Add(this.lblReportDesc);
            this.grpReportIssues.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpReportIssues.Location = new System.Drawing.Point(20, 100);
            this.grpReportIssues.Name = "grpReportIssues";
            this.grpReportIssues.Size = new System.Drawing.Size(560, 80);
            this.grpReportIssues.TabIndex = 1;
            this.grpReportIssues.TabStop = false;
            this.grpReportIssues.Text = "Report Issues";
            // 
            // lblReportDesc
            // 
            this.lblReportDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReportDesc.Location = new System.Drawing.Point(10, 30);
            this.lblReportDesc.Size = new System.Drawing.Size(400, 40);
            this.lblReportDesc.Text = "Report potholes, broken lights, sanitation problems and more.";
            // 
            // btnOpenReport
            // 
            this.btnOpenReport.Location = new System.Drawing.Point(440, 30);
            this.btnOpenReport.Name = "btnOpenReport";
            this.btnOpenReport.Size = new System.Drawing.Size(100, 30);
            this.btnOpenReport.Text = "Open";
            this.btnOpenReport.UseVisualStyleBackColor = true;
            this.btnOpenReport.Click += new System.EventHandler(this.btnOpenReport_Click);
            // 
            // grpEvents
            // 
            this.grpEvents.Controls.Add(this.btnEvents);
            this.grpEvents.Controls.Add(this.lblEventsDesc);
            this.grpEvents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpEvents.Location = new System.Drawing.Point(20, 200);
            this.grpEvents.Name = "grpEvents";
            this.grpEvents.Size = new System.Drawing.Size(560, 80);
            this.grpEvents.TabIndex = 2;
            this.grpEvents.TabStop = false;
            this.grpEvents.Text = "Local Events Announcements";
            // 
            // lblEventsDesc
            // 
            this.lblEventsDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEventsDesc.Location = new System.Drawing.Point(10, 30);
            this.lblEventsDesc.Size = new System.Drawing.Size(400, 40);
            this.lblEventsDesc.Text = "View upcoming local events and official announcements.";
            // 
            // btnEvents
            // 
            this.btnEvents.Enabled = false;
            this.btnEvents.BackColor = System.Drawing.Color.LightGray;
            this.btnEvents.Location = new System.Drawing.Point(440, 30);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(100, 30);
            this.btnEvents.Text = "Coming Soon";
            this.btnEvents.UseVisualStyleBackColor = false;
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.btnStatus);
            this.grpStatus.Controls.Add(this.lblStatusDesc);
            this.grpStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpStatus.Location = new System.Drawing.Point(20, 300);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(560, 80);
            this.grpStatus.TabIndex = 3;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Service Request Status";
            // 
            // lblStatusDesc
            // 
            this.lblStatusDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusDesc.Location = new System.Drawing.Point(10, 30);
            this.lblStatusDesc.Size = new System.Drawing.Size(400, 40);
            this.lblStatusDesc.Text = "Check status of previously submitted requests.";
            // 
            // btnStatus
            // 
            this.btnStatus.Enabled = false;
            this.btnStatus.BackColor = System.Drawing.Color.LightGray;
            this.btnStatus.Location = new System.Drawing.Point(440, 30);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(100, 30);
            this.btnStatus.Text = "Coming Soon";
            this.btnStatus.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.grpEvents);
            this.Controls.Add(this.grpReportIssues);
            this.Controls.Add(this.panelHeader);
            this.Name = "MainMenuForm";
            this.Text = "Municipal Services Portal";
            this.panelHeader.ResumeLayout(false);
            this.grpReportIssues.ResumeLayout(false);
            this.grpEvents.ResumeLayout(false);
            this.grpStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpReportIssues;
        private System.Windows.Forms.Label lblReportDesc;
        private System.Windows.Forms.Button btnOpenReport;
        private System.Windows.Forms.GroupBox grpEvents;
        private System.Windows.Forms.Label lblEventsDesc;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.Label lblStatusDesc;
        private System.Windows.Forms.Button btnStatus;
    }
}