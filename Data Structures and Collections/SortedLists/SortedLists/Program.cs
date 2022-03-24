using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLists
{
    class Program
    {
        static SortedList<string, int> sortedList = new SortedList<string, int>() { { "key1", 1 }, { "key2", 2 }, { "key3", 3 } };
        static void Main(string[] args)
        {
            sortedList.Capacity = 6;
            Console.WriteLine("The sorted list's  capacity is : " + sortedList.Capacity);
            Console.WriteLine("The sorted list's  count is : " + sortedList.Count);

            sortedList.Add("key4", 4);
            Console.WriteLine("Index of key1 : " + sortedList.IndexOfKey("key1"));
            Console.WriteLine("Index of key2 : " + sortedList.IndexOfKey("key2"));
            Console.WriteLine("Index of key2 : " + sortedList.IndexOfKey("key3"));

            sortedList.Remove("key1");
            sortedList.RemoveAt(1);
            foreach (string key in sortedList.Keys)
            {
                Console.WriteLine(key);       //  We can see all keys.
            }
              foreach (int value in sortedList.Values)
            {
                Console.WriteLine(value);       //  We can see all values.
            }

         


            // sortedList.Clear();

        }
    }
}
