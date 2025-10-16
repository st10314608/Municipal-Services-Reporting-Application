using System;
using System.Windows.Forms;
using System.Linq;

namespace Municipal_Services_Reporting_Application.Controllers
{
    public class LocalEventsController
    {
        private readonly LocalEventsForm form;
        private readonly EventManager manager;

        public LocalEventsController(LocalEventsForm form)
        {
            this.form = form ?? throw new ArgumentNullException(nameof(form));
            manager = new EventManager();
            manager.AddSampleData();
            HookEvents();
            RefreshCategories();
            DisplayAll();
            ShowRecommendations();
        }

        private void HookEvents()
        {
            form.btnRefreshCategories.Click += (s, e) => { RefreshCategories(); };
            form.btnSearch.Click += (s, e) => { DoSearch(); };
            form.comboCategory.SelectedIndexChanged += (s, e) => { DoSearch(); };
            form.btnBack.Click += (s, e) => { form.Hide(); new MainMenuForm().Show(); };
        }

        private void RefreshCategories()
        {
            form.comboCategory.Items.Clear();
            form.comboCategory.Items.Add("(All)");
            manager.GetAllCategories(cat => form.comboCategory.Items.Add(cat));
            form.comboCategory.SelectedIndex = 0;
        }

        private void DisplayAll()
        {
            form.listBoxEvents.Items.Clear();
            manager.GetAllEvents(ev => form.listBoxEvents.Items.Add(ev.ToString()));
        }

        private void DoSearch()
        {
            string category = form.comboCategory.SelectedItem?.ToString();
            if (category == "(All)") category = null;
            string keyword = form.txtSearch.Text?.Trim();
            form.listBoxEvents.Items.Clear();
            
            manager.Search(category, DateTime.Now.AddYears(-1), DateTime.Now.AddYears(5), ev =>
            {
                if (string.IsNullOrEmpty(keyword) || ev.Title.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    ev.Description.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    form.listBoxEvents.Items.Add(ev.ToString());
                }
            });
            ShowRecommendations();
        }

        private void ShowRecommendations()
        {
            form.listBoxRecommendations.Items.Clear();
            var recs = manager.Recommend();
            foreach (var r in recs) form.listBoxRecommendations.Items.Add(r.ToString());
        }
    }
}

