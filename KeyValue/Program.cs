using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeyValue_Store
{
    public struct KeyValue
    {
        public readonly string key;
        public readonly object value;

        public KeyValue(string key, object value)
        {
            this.key = key;
            this.value = value;
        }


    }
    public class MyDictionary
    {
        private KeyValue[] items = new KeyValue[0];
        private int count = 0;

        public object this[string key]
        {
            get
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i].key == key)
                    {
                        return items[i].value;
                    }
                }
                throw new KeyNotFoundException();
            }
            set
            {
                bool hasValue = false;
                for (int i = 0; i < items.Length && !hasValue; i++)
                {
                    if (items[i].key == key)
                    {
                        hasValue = true;
                        items[i] = new KeyValue(key, value);
                    }
                }
                if (!hasValue)
                {
                    Array.Resize(ref items, items.Length + 1);
                    items[items.Length - 1] = (new KeyValue(key, value));
                    count++;
                }
            }
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                var d = new MyDictionary();
                try
                {
                    Console.WriteLine(d["Cats"]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                d["Cats"] = 42;
                d["Dogs"] = 17;
                Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
            }
        }
    }
}