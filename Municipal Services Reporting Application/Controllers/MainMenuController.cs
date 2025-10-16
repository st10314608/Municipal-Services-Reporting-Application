using System;
using System.Windows.Forms;

namespace Municipal_Services_Reporting_Application.Controllers
{
    public class MainMenuController
    {
        private readonly MainMenuForm form;

        public MainMenuController(MainMenuForm form)
        {
            this.form = form ?? throw new ArgumentNullException(nameof(form));
            HookEvents();
        }

        private void HookEvents()
        {
            
            form.btnReportIssues.Click += BtnReportIssues_Click;
            form.btnLocalEvents.Click += BtnLocalEvents_Click;
            form.btnServiceStatus.Click += BtnServiceStatus_Click;
            form.btnExit.Click += BtnExit_Click;
        }

        private void BtnReportIssues_Click(object sender, EventArgs e)
        {
            var f = new ReportIssuesForm();
            new Controllers.ReportIssuesController(f);
            f.Show();
            form.Hide();
        }

        private void BtnLocalEvents_Click(object sender, EventArgs e)
        {
            var f = new LocalEventsForm();
            new Controllers.LocalEventsController(f);
            f.Show();
            form.Hide();
        }

        private void BtnServiceStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feauture is coming in a later release.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

