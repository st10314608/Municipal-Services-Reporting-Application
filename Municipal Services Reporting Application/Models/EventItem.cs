using System;

namespace Municipal_Services_Reporting_Application
{
    public class EventItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime EventDate { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        public EventItem() { }
        public EventItem(int id, string title, string category, DateTime date, string description, string location)
        {
            Id = id; Title = title; Category = category; EventDate = date; Description = description; Location = location;
        }

        public override string ToString()
        {
            return $"{EventDate:yyyy-MM-dd} | {Category} | {Title} — {Location}";
        }
    }
}

