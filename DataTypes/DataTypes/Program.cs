﻿using System;

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

            #region Characters and Strings

            string s1 = "Hi";
            string emptyString = "";
            string emptyString2 = String.Empty;

            string s2 = "Hey";
            string s3 = "There";
            string s4 = s2 + " " + s3;
            s4 += "!";
            System.Console.WriteLine(s4);

           // char char1 = "a";
            //char char2 = "/n";
            string s5 = "abc";

            #endregion


        }





    }

    
}
