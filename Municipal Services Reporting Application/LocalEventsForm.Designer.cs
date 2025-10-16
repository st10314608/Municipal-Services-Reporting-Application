namespace Municipal_Services_Reporting_Application
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.Label lblHeading;
        public System.Windows.Forms.ComboBox comboCategory;
        public System.Windows.Forms.Button btnRefreshCategories;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.ListBox listBoxEvents;
        public System.Windows.Forms.ListBox listBoxRecommendations;
        public System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.btnRefreshCategories = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxRecommendations = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblHeading
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(20, 18);
            this.lblHeading.Text = "Local Events & Announcements";
            // comboCategory
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.Location = new System.Drawing.Point(25, 60);
            this.comboCategory.Size = new System.Drawing.Size(200, 23);
            // btnRefreshCategories
            this.btnRefreshCategories.Location = new System.Drawing.Point(235, 60);
            this.btnRefreshCategories.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshCategories.Text = "Refresh";
            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(320, 60);
            this.txtSearch.Size = new System.Drawing.Size(200, 23);
            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(530, 60);
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Text = "Search";
            // listBoxEvents
            this.listBoxEvents.Location = new System.Drawing.Point(25, 100);
            this.listBoxEvents.Size = new System.Drawing.Size(580, 200);
            // listBoxRecommendations
            this.listBoxRecommendations.Location = new System.Drawing.Point(25, 320);
            this.listBoxRecommendations.Size = new System.Drawing.Size(580, 100);
            // btnBack
            this.btnBack.Location = new System.Drawing.Point(25, 440);
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.Text = "Back";
            // LocalEventsForm
            this.ClientSize = new System.Drawing.Size(640, 500);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.btnRefreshCategories);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxRecommendations);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LocalEventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Events";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

