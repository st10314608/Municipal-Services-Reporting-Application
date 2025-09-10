using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services_Reporting_Application
{
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        // Add this to fix the error
        public List<string> Attachments { get; set; } = new List<string>();
    }
}