using System;
using System.Collections.Generic;

namespace Municipal_Services_Reporting_Application
{
    public class CustomSet<T>
    {
        public class Node { public T Data; public Node Next; public Node(T d) { Data = d; Next = null; } }
        private Node head; private int count;
        public CustomSet() { head = null; count = 0; }
        public void Add(T item) { if (Contains(item)) return; var n = new Node(item); n.Next = head; head = n; count++; }
        public bool Contains(T item) { var cur = head; while (cur != null) { if (object.Equals(cur.Data, item)) return true; cur = cur.Next; } return false; }
        public void ForEach(Action<T> action) { var cur = head; while (cur != null) { action(cur.Data); cur = cur.Next; } }
        public T[] GetAll() { var tmp = new List<T>(); var cur = head; while (cur != null) { tmp.Add(cur.Data); cur = cur.Next; } return tmp.ToArray(); }
    }
}
