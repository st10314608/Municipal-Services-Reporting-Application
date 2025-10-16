using System;
using System.Linq;
using System.Windows.Forms;

namespace Municipal_Services_Reporting_Application.Controllers
{
    public class ReportIssuesController
    {
        private readonly ReportIssuesForm form;

        public ReportIssuesController(ReportIssuesForm form)
        {
            this.form = form ?? throw new ArgumentNullException(nameof(form));
            HookEvents();
            PopulateCategories();
        }

        private void HookEvents()
        {
            form.btnAttach.Click += BtnAttach_Click;
            form.btnSubmit.Click += BtnSubmit_Click;
            form.btnBack.Click += BtnBack_Click;
        }

        private void PopulateCategories()
        {
            form.cmbCategory.Items.Clear();
            form.cmbCategory.Items.Add("Sanitation");
            form.cmbCategory.Items.Add("Roads");
            form.cmbCategory.Items.Add("Utilities");
            form.cmbCategory.Items.Add("Other");
            if (form.cmbCategory.Items.Count > 0) form.cmbCategory.SelectedIndex = 0;
        }

        private void BtnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "Images and Documents|*.jpg;*.jpeg;*.png;*.pdf;*.docx;*.xlsx|All files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    
                    var existing = form.Tag as System.Collections.Generic.List<string>;
                    if (existing == null) existing = new System.Collections.Generic.List<string>();
                    existing.AddRange(ofd.FileNames);
                    form.Tag = existing;
                    form.lblAttachCount.Text = $"{existing.Count} files attached";
                }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var attachments = (form.Tag as System.Collections.Generic.List<string>) ?? new System.Collections.Generic.List<string>();
            var issue = new Issue(form.txtLocation.Text ?? "", form.cmbCategory.SelectedItem?.ToString() ?? "Other", form.rtbDescription.Text ?? "");
            
            foreach (var p in attachments) issue.Attachments.Add(p);
            IssueStore.Instance.AddIssue(issue);
            MessageBox.Show("Issue submitted. Thank you.", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            form.txtLocation.Clear();
            form.rtbDescription.Clear();
            form.Tag = null;
            form.lblAttachCount.Text = "0 files attached";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            form.Hide();
            var menu = new MainMenuForm();
            menu.Show();
        }
    }
}
