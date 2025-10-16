using System;

namespace Municipal_Services_Reporting_Application
{
    public class EventPriorityQueue
    {
        private class Node { public EventItem Item; public Node Next; public Node(EventItem it) { Item = it; Next = null; } }
        private Node head;
        private int count;
        public EventPriorityQueue() { head = null; count = 0; }

        
        public void Enqueue(EventItem item)
        {
            var n = new Node(item);
            if (head == null || item.EventDate < head.Item.EventDate) { n.Next = head; head = n; }
            else
            {
                var cur = head;
                while (cur.Next != null && cur.Next.Item.EventDate <= item.EventDate) cur = cur.Next;
                n.Next = cur.Next; cur.Next = n;
            }
            count++;
        }

        public EventItem Dequeue()
        {
            if (head == null) return null;
            var it = head.Item;
            head = head.Next; count--;
            return it;
        }

        public int Count => count;
    }
}
