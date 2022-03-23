using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace HashSets
{
    class Program
    {

        #region What is the HashSets
        /*
         * A HashSet — represented by the HashSet<T> class pertaining to the System.Collections.
         * Generic namespace — is a high-performance, unordered collection of unique elements.
         * Hence a HashSet is not sorted and doesn’t contain any duplicate elements.
         * A HashSet also doesn’t support indices — you can use enumerators only. 
         * A HashSet is usually used for high-performance operations involving a set of unique data. 
         */

        #endregion
        static void Main(string[] args)
        {
            HashSet<string> letters1 = new HashSet<string>() { "a", "b", "c" };
            HashSet<string> letters2 = new HashSet<string>() { "d", "e", "f" };

            letters1.UnionWith(letters2);     // The UnionWith operation combined these tow sets into one set.
            letters1.IntersectWith(letters2); // The Intersectwith method lets us perform an Intersection operation.
            foreach (string s in letters1)
            {
                Debug.WriteLine(s);
            }

        }
    }
}
