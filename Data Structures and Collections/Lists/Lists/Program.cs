using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{     
   public class Program
    {
        
        static List<int> numbers = new List<int>() { 1, 3, 5, 4, 2 };
          
        public static void Main(string[] args)
        {
            #region Example Lists
            /*  System.Console.WriteLine(numbers.Count);
              numbers.Capacity = 10;
              numbers.Add(6);
              List<int> subList = new List<int>() {7,8};
              numbers.AddRange(subList);
              numbers.Sort();
              System.Console.WriteLine("Index of element 5 is : " + numbers.BinarySearch(5));
              numbers.Clear();
              System.Console.WriteLine(numbers.Contains(3));
              System.Console.WriteLine(numbers.Contains(20));*/



            #endregion

            #region Insert Lists

            /*List<int> subList = new List<int>() { 0, 1, 2 };
            numbers.InsertRange(1, subList);
            foreach  (int i  in numbers)
            {
                System.Console.WriteLine(i);
            }*/
            #endregion

            #region Removing an element from the list

            /*
            numbers.Remove(3);
            numbers.RemoveAt(0);
            numbers.RemoveRange(0, 3);
            */


            #endregion

            #region Capacity from the list

         /*   numbers.Capacity = 10;

            Debug.WriteLine("Capacity before trim : " + numbers.Capacity);
            numbers.TrimExcess();
            Debug.WriteLine("Capacity after trim : " + numbers.Capacity);
         */
            #endregion


        }
    }
}
