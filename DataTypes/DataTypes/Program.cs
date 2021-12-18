using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BasicDataTypes

            int example = 1;  // System.Int32 example = 1;

            Type sType = typeof(string);
            Console.WriteLine(sType.FullName);

          
       

            #endregion



            #region Numbers

            int i = 0;
            i = 5;
            Console.WriteLine(i);
            Console.WriteLine(i++);
            Console.WriteLine(++i);
            Console.WriteLine(--i);
            Console.WriteLine(3 * 2);
            Console.WriteLine(10 / 2);
            Console.WriteLine(10 % 3);
            Console.WriteLine(6.6f + 2.1f);

            #endregion

            #region MathClass

            System.Console.WriteLine(Math.Abs(-3));
            System.Console.WriteLine(Math.Abs(-3.5f));
            System.Console.WriteLine(Math.Round(3.7f));
            System.Console.WriteLine(Math.Round(3.2f));
            System.Console.WriteLine(Math.Ceiling(3.2f));
            System.Console.WriteLine(Math.Floor(5.9f));
            System.Console.WriteLine(Math.Min(1,3));
            System.Console.WriteLine(Math.Max(1,3));
            

            #endregion

        }
       
    }

    
}
