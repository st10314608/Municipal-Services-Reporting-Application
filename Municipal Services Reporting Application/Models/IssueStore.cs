using System;
using System.Collections.Generic;

namespace Municipal_Services_Reporting_Application
{
    public class IssueStore
    {
        private static IssueStore _instance;
        public static IssueStore Instance => _instance ?? (_instance = new IssueStore());

        private CustomQueue<Issue> queue = new CustomQueue<Issue>();
        private CustomSet<string> keys = new CustomSet<string>();

        private IssueStore() { }

        public void AddIssue(Issue issue)
        {
            if (issue == null) return;
            string key = $"{issue.Location}-{issue.Category}-{issue.ReportedAt:yyyyMMddHHmmss}";
            if (!keys.Contains(key))
            {
                queue.Enqueue(issue);
                keys.Add(key);
            }
        }

        public void ForEach(Action<Issue> action)
        {
            foreach (var i in queue.GetAll()) action(i);
        }
    }
}
