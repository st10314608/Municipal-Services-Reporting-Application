using System;
using System.Collections.Generic;

namespace Municipal_Services_Reporting_Application
{
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> Attachments { get; set; } = new List<string>();
        public string Status { get; set; } = "Pending";
        public DateTime ReportedAt { get; set; } = DateTime.Now;

        public Issue() { }
        public Issue(string location, string category, string description)
        {
            Location = location; Category = category; Description = description;
            Status = "Pending";
            ReportedAt = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{ReportedAt:yyyy-MM-dd HH:mm} | {Location} | {Category} | {Status}";
        }
    }
}
