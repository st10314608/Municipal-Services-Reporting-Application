using System;

namespace Municipal_Services_Reporting_Application
{
    public class EventNode
    {
        public EventItem Data;
        public EventNode Next;
        public EventNode(EventItem it) { Data = it; Next = null; }
    }
}