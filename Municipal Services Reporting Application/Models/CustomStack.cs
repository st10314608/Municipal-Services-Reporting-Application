using System;

namespace Municipal_Services_Reporting_Application
{
    public class CustomStack<T>
    {
        private class Node { public T Data; public Node Next; public Node(T d) { Data = d; Next = null; } }
        private Node top; private int count;
        public CustomStack() { top = null; count = 0; }
        public void Push(T item) { var n = new Node(item); n.Next = top; top = n; count++; }
        public T Pop() { if (top == null) throw new InvalidOperationException("Empty"); var v = top.Data; top = top.Next; count--; return v; }
        public T Peek() { if (top == null) throw new InvalidOperationException("Empty"); return top.Data; }
        public bool IsEmpty() => top == null;
        public void ForEach(Action<T> action) { var cur = top; while (cur != null) { action(cur.Data); cur = cur.Next; } }
    }
}

