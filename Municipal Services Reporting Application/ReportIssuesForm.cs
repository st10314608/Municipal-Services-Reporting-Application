using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Services_Reporting_Application
{
    public partial class ReportIssuesForm : Form
    {
        private List<string> attachments = new List<string>();

        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                attachments.AddRange(ofd.FileNames);
                MessageBox.Show("Files attached successfully!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) ||
                cmbCategory.SelectedItem == null ||
                string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please fill in all fields before submitting.");
                return;
            }

            Issue newIssue = new Issue
            {
                Location = txtLocation.Text,
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rtbDescription.Text,
                Attachments = new List<string>(attachments)
            };

            IssuesList.Issues.Add(newIssue);

            MessageBox.Show("Issue submitted successfully!");
            lblEngagement.Text = "Your report helps improve our community. Thank you!";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the form and returns to MainMenuForm
        }
    }
}
