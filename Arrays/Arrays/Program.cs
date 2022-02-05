using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Arrays
{
    class Program
    {

     static string[] strings = new string[3] { "c", "a", "b" };
       static  int[] array = new int[3] {1,2,3};
        //The element one is stored at index zero in the array indexing in C sharp starts at zero.
        // The element two a stored index, one in the array.
        //The element three is stored at index two in the array.


        public static void Main(string[] args)
        {
            Debug.WriteLine(array[0]);
            array[0] = 5;
            Array.Sort(array);
            foreach(int i in array)
            {
                Debug.WriteLine(i);
            }
             Array.Sort(strings);
            foreach (string s in strings)
            {
                Debug.WriteLine(s);
            }
        }
    }
}
