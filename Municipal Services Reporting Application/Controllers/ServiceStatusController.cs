using System;
using System.Windows.Forms;

namespace Municipal_Services_Reporting_Application.Controllers
{
    public class ServiceStatusController
    {
        private readonly ServiceStatusForm form;

        public ServiceStatusController(ServiceStatusForm form)
        {
            this.form = form ?? throw new ArgumentNullException(nameof(form));
            HookEvents();
            LoadIssues();
        }

        private void HookEvents()
        {
            form.btnRefresh.Click += (s, e) => LoadIssues();
            form.btnMarkInProgress.Click += (s, e) => UpdateSelectedStatus("In Progress");
            form.btnMarkCompleted.Click += (s, e) => UpdateSelectedStatus("Completed");
            form.btnBack.Click += (s, e) => { form.Hide(); new MainMenuForm().Show(); };
        }

        private void LoadIssues()
        {
            form.listBoxStatus.Items.Clear();
            IssueStore.Instance.ForEach(issue =>
            {
                form.listBoxStatus.Items.Add(issue); 
            });
            if (form.listBoxStatus.Items.Count == 0) form.listBoxStatus.Items.Add("No issues reported.");
        }

        private void UpdateSelectedStatus(string status)
        {
            if (form.listBoxStatus.SelectedItem is Issue issue)
            {
                issue.Status = status;
                MessageBox.Show($"Issue updated to {status}", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIssues();
            }
            else
            {
                MessageBox.Show("Please select an issue to update.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

