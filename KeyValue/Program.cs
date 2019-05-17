﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVStore
{
   
    //Create a struct named `KeyValue` which contains one `string` "key" and one `object` "value" as `public readonly` instance fields
    struct KeyValue<T>
    {
        
        public readonly string key;
        public readonly T value;
        



        //Implement a constructor for `KeyValue` which sets the instance fields
        public KeyValue(string key, T value)
        {
            this.key = key;
            this.value = value;
        }
    }

    //Create a class named `MyDictionary` which contains one array of KeyValue structs and one `int` to keep track of the number of stored values as private instance fields.You may choose a reasonable fixed size for the array. 
    class MyDictionary<T>
    {
        List<KeyValue<T>> kvs = new List<KeyValue<T>>();
        int storedValues = 0;

        //Implement an indexer which takes a string (key) and returns an object (value).
        public T this[string searchKey]
        {
            //The `set` property should search the array for the given key and replace the KeyValue with a `new KeyValue(...)` if it exists.If the key does not exist, it should be added as a `new KeyValue(...)`.
            set
            {
                bool found = false;

                for (int i = 0; i < storedValues && !found; ++i)
                {
                    if (kvs[i].key == searchKey)
                    {
                        found = true;
                        kvs[i] = new KeyValue<T>(searchKey, value);
                    }
                }

                //if (!found)
                //{
                //    kvs[storedValues++] = new KeyValue<T>(searchKey, value);

                //    if (storedValues >= kvs.Count)
                //    {
                //        kv(ref kvs, kvs.Count << 1);
                //    }
                //}
            }


            //The `get` property should search the array for the given key and return the associated value if it exists.If the key does not exist, the property should throw a KeyNotFoundException.
            get
            {
                for (int i = 0; i < storedValues; ++i)
                {
                    if (kvs[i].key == searchKey)
                        return kvs[i].value;
                }

                throw new KeyNotFoundException($"Didn't find \"{searchKey}\" in MyDictionary");
            }
        }
    }


    public class Program
    {
        //Your code should compile against the following `Main` method and print a KeyNotFoundException followed by the line "42, 17" to the command line.
        static void Main()
        {
            var d = new MyDictionary<int>();
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