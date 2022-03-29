using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSets
{
    class Program
    {
        static SortedSet<int> sortedSet = new SortedSet<int>();
        static SortedSet<int> sortedSet1 = new SortedSet<int>() { 1,2,3,4,5};

        static void Main(string[] args)
        {
            #region Main
            sortedSet.Add(3);
            sortedSet.Add(1);
            Console.WriteLine(sortedSet.Overlaps(new List<int>() { 1, 2, 3 }));
            foreach (int i in sortedSet)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            sortedSet.Remove(3);
            foreach (int i in sortedSet1.Reverse())
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            sortedSet1.RemoveWhere(x => x > 2);
            foreach (int i in sortedSet1)
            {
                Console.WriteLine(i);
            }
            #endregion
            Console.WriteLine("");
            List<int> list = new List<int>() { 6, 7, 8 };
            sortedSet1.UnionWith(list);
            foreach  (int i  in sortedSet1)
            {
                Console.WriteLine(i);
            }

        }
    }
}
