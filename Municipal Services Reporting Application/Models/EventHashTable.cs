using System;

namespace Municipal_Services_Reporting_Application
{
    public class EventHashTable
    {
        private class Entry { public string Key; public int Value; public Entry Next; public Entry(string k, int v) { Key = k; Value = v; Next = null; } }
        private Entry[] buckets;
        public EventHashTable(int size = 97) { buckets = new Entry[size]; }
        private int Index(string key) => Math.Abs(key.GetHashCode()) % buckets.Length;
        public void Increment(string key) { if (key == null) return; int i = Index(key); var cur = buckets[i]; while (cur != null) { if (cur.Key == key) { cur.Value++; return; } cur = cur.Next; } var e = new Entry(key, 1); e.Next = buckets[i]; buckets[i] = e; }
        public int Get(string key) { int i = Index(key); var cur = buckets[i]; while (cur != null) { if (cur.Key == key) return cur.Value; cur = cur.Next; } return 0; }
        public void ForEach(Action<string, int> action) { for (int i = 0; i < buckets.Length; i++) { var cur = buckets[i]; while (cur != null) { action(cur.Key, cur.Value); cur = cur.Next; } } }
    }
}

