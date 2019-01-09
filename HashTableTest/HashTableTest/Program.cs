using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "홍길동");
            ht.Add(2, "길길동");
            ht.Add(3, "정길동");

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine($"키{d.Key}, 값:{d.Value}");
            }

            SortedList sl = new SortedList(ht);

            foreach (DictionaryEntry d in sl)
            {
                Console.WriteLine($"키{d.Key}, 값:{d.Value}");
            }

            Dictionary<int, string> d2 = new Dictionary<int, string>();
            d2.Add(1, "서울");
            d2.Add(2, "부산");
            d2.Add(3, "대전");

            foreach (KeyValuePair<int, string> k in d2)
            {
                Console.WriteLine($"키{k.Key}, 값:{k.Value}");
            }

        }
    }
}