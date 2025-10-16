using System;

namespace Municipal_Services_Reporting_Application
{
    public class CustomQueue<T>
    {
        private class Node { public T Data; public Node Next; public Node(T d) { Data = d; Next = null; } }
        private Node head, tail; private int count;
        public CustomQueue() { head = tail = null; count = 0; }
        public void Enqueue(T item) { var n = new Node(item); if (tail == null) head = tail = n; else { tail.Next = n; tail = n; } count++; }
        public T Dequeue() { if (head == null) throw new InvalidOperationException("Empty"); var v = head.Data; head = head.Next; if (head == null) tail = null; count--; return v; }
        public bool IsEmpty() => head == null;
        public T[] GetAll() { var arr = new T[count]; int i = 0; var cur = head; while (cur != null) { arr[i++] = cur.Data; cur = cur.Next; } return arr; }
        public void ForEach(Action<T> action) { var cur = head; while (cur != null) { action(cur.Data); cur = cur.Next; } }
    }
}
