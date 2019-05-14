//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace KeyValue
//{
//    public struct KeyValue
//    {
//        public readonly string Key;
//        public readonly object Value;

//        public KeyValue(string key, object value)
//        {
//            Key = key;
//            Value = value;
//        }


//    }
//    public class MyDictionary
//    {
//        private KeyValue[] items = new KeyValue[5];
//        private int count = 0;

//        public object this[string key]
//        {
//            get
//            {
//                if (items.Any(x => x.Key == key))
//                {
//                    return items.FirstOrDefault(x => x.Key == key);
//                }
//                throw new KeyNotFoundException();

//            }
//            set
//            {
//                bool hasValue = false;
//                for (int i = 0; i < items.Length; i++)
//                {
//                    if (items[i].Key == key)
//                    {
//                        hasValue = true;
//                        items[i] = new KeyValue(key, value);
//                    }
//                }
//                if (!hasValue)
//                {
//                    count++;
//                }
//            }
//        }
//        public class Program
//        {
//            public static void Main(string[] args)
//            {
//                var d = new MyDictionary();
//                try
//                {
//                    Console.WriteLine(d["Cats"]);
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex);
//                }
//                d["Cats"] = 42;
//                d["Dogs"] = 17;
//                Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
//            }
//        }
//    }
//}
