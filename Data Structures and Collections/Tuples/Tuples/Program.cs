using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    #region What is the Tuples?
    // A tuple has specific number and order of elements.
    // Can have anywhere from 1 to 7 elements.
    // Represent a single set of data.
    // To easily access and manipulate data.
    // To return multiple data from a method.
    // Pass multiple values into a method with one parameter.


    #endregion
    class Program
    {

        static void Main(string[] args)
        {
            Tuple<int> tuple = new Tuple<int>(1);
            Tuple<int, int> tuple2 = new Tuple<int, int>(1, 2);
            Tuple<int, int, int> tuple3 = new Tuple<int, int, int>(1, 2, 3);
            Tuple<int, int, int, int> tuple4 = new Tuple<int, int, int, int>(1, 2, 3, 4);
            Tuple<int, int, int, int, int> tuple5 = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
            Tuple<int, int, int, int, int, int> tuple6 = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
            Tuple<int, int, int, int, int, int, int> tuple7 = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);

            Tuple<int, string, bool> mixedTypeTuple = Tuple.Create(1, "Hey , How're you doing?", true);

            Console.WriteLine("Value of item 1 = " + tuple.Item1); 
        }
    }
}
