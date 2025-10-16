using System;
using System.Collections.Generic;

namespace Municipal_Services_Reporting_Application
{
    public class EventManager
    {
        private SortedDictionary<DateTime, List<EventItem>> byDate = new SortedDictionary<DateTime, List<EventItem>>();
        private CustomSet<string> categories = new CustomSet<string>();
        private EventHashTable searchCounts = new EventHashTable();
        private int idCounter = 1;

        public EventManager() { }

        public void AddEvent(EventItem ev)
        {
            if (ev == null) return;
            if (ev.Id == 0) ev.Id = idCounter++;
            DateTime key = ev.EventDate.Date;
            if (!byDate.ContainsKey(key)) byDate[key] = new List<EventItem>();
            byDate[key].Add(ev);
            categories.Add(ev.Category);
        }

        public void AddSampleData()
        {
            AddEvent(new EventItem(0, "Ward 5 Cleanup", "Community", DateTime.Now.AddDays(2), "Park cleanup", "Central Park"));
            AddEvent(new EventItem(0, "Roadworks Main St", "Infrastructure", DateTime.Now.AddDays(3), "Road repairs", "Main St"));
            AddEvent(new EventItem(0, "Water Interruption", "Utilities", DateTime.Now.AddDays(1), "Planned outage", "Ward 2"));
            AddEvent(new EventItem(0, "Business Expo", "Economic", DateTime.Now.AddDays(10), "Local businesses", "Town Hall"));
            AddEvent(new EventItem(0, "Health Clinic", "Health", DateTime.Now.AddDays(5), "Free checkups", "Community Center"));
            AddEvent(new EventItem(0, "Youth Sports Day", "Recreation", DateTime.Now.AddDays(12), "Sports for youth", "Sports Ground"));
            AddEvent(new EventItem(0, "Budget Meeting", "Government", DateTime.Now.AddDays(20), "Public meeting", "Municipal Hall"));
            AddEvent(new EventItem(0, "Vaccination Drive", "Health", DateTime.Now.AddDays(7), "Vaccination clinic", "Clinic A"));
            AddEvent(new EventItem(0, "Street Lighting", "Infrastructure", DateTime.Now.AddDays(4), "New lights", "Ward 3"));
            AddEvent(new EventItem(0, "Recycling Info Day", "Environment", DateTime.Now.AddDays(8), "How to recycle", "Library"));
            AddEvent(new EventItem(0, "Family Fun Fair", "Recreation", DateTime.Now.AddDays(15), "Family activities", "Market Square"));
            AddEvent(new EventItem(0, "Water Talk", "Environment", DateTime.Now.AddDays(9), "Water conservation", "Community Hall"));
            AddEvent(new EventItem(0, "Road Safety Workshop", "Education", DateTime.Now.AddDays(6), "Driver safety", "Training Center"));
            AddEvent(new EventItem(0, "Emergency Drill", "Government", DateTime.Now.AddDays(11), "Civil drill", "Station"));
            AddEvent(new EventItem(0, "Transport Survey", "Transport", DateTime.Now.AddDays(14), "Routes survey", "Town Hall"));
        }

        public void GetAllEvents(Action<EventItem> action)
        {
            foreach (var kv in byDate)
            {
                foreach (var e in kv.Value) action(e);
            }
        }

        public void Search(string category, DateTime from, DateTime to, Action<EventItem> action)
        {
            if (!string.IsNullOrEmpty(category)) searchCounts.Increment(category);
            foreach (var kv in byDate)
            {
                if (kv.Key < from.Date || kv.Key > to.Date) continue;
                foreach (var e in kv.Value)
                {
                    if (string.IsNullOrEmpty(category) || e.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                        action(e);
                }
            }
        }

        public List<EventItem> Recommend(int max = 6)
        {
            string topCat = null; int topCount = 0;
            searchCounts.ForEach((k, v) => { if (v > topCount) { topCount = v; topCat = k; } });
            var list = new List<EventItem>();
            foreach (var kv in byDate)
                foreach (var e in kv.Value)
                {
                    if (topCat != null && e.Category.Equals(topCat, StringComparison.OrdinalIgnoreCase)) list.Add(e);
                }
            
            if (list.Count < max)
            {
                foreach (var kv in byDate)
                    foreach (var e in kv.Value) if (!list.Contains(e)) list.Add(e);
            }
            
            list.Sort((a, b) => a.EventDate.CompareTo(b.EventDate));
            return list.GetRange(0, Math.Min(max, list.Count));
        }

        public void GetAllCategories(Action<string> action)
        {
            categories.ForEach(k => action(k));
        }
    }
}

