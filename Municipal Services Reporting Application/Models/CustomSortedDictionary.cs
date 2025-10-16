using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services_Reporting_Application.Models
{
    public class CustomSortedDictionary<TKey, TValue> where TKey : System.IComparable<TKey>
    {
        private List<KeyValuePair<TKey, TValue>> items = new List<KeyValuePair<TKey, TValue>>();

        public void Add(TKey key, TValue value)
        {
            items.Add(new KeyValuePair<TKey, TValue>(key, value));
            items = items.OrderBy(i => i.Key).ToList();
        }

        public TValue Get(TKey key)
        {
            foreach (var item in items)
                if (item.Key.CompareTo(key) == 0)
                    return item.Value;
            return default;
        }

        public IEnumerable<KeyValuePair<TKey, TValue>> GetAll() => items;
    }
}