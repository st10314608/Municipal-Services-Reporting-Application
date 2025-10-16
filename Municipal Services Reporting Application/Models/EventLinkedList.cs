using System;

namespace Municipal_Services_Reporting_Application.Models
{
    public class EventLinkedList
    {
        private EventNode head;
        private EventNode tail;
        private int count;

        public EventLinkedList() { head = null; tail = null; count = 0; }

        public void Add(EventItem item)
        {
            var n = new EventNode(item);
            if (head == null) head = tail = n;
            else { tail.Next = n; tail = n; }
            count++;
        }

        public int Count => count;

        public void ForEach(Action<EventItem> action)
        {
            var cur = head;
            while (cur != null) { action(cur.Data); cur = cur.Next; }
        }

        
        public EventItem FindFirst(Func<EventItem, bool> predicate)
        {
            var cur = head;
            while (cur != null)
            {
                if (predicate(cur.Data)) return cur.Data;
                cur = cur.Next;
            }
            return null;
        }
    }
}