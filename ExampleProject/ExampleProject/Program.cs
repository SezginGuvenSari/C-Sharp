using System;
using System.Collections.Generic;

namespace ExampleProject
{

    public class Ex1 { }  // Object oriented programming
    public class Ex2 : Ex1 { }
    

    
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello Example Project!");
            PrintHi();
            PrintMessage("Hey there");


            #region Veriables

            int x = 5;
            int y = 3;
            float z = 4.7f;
            float num = 10.6f;
            string String1 = "First";
            string String2 = "Second";
            char Char1 = 'a';
            char Char2 = 'b';
            bool Complete = false;
            bool incomplete = true;






            #endregion


            #region Conditional Statements

            bool complete = false;
            bool started = true;
            int e;

            if (complete)
            {
                 e = 5;
            }
            else if(started)
            {
                 e = 3;
            }
            else
            {
                e = 1;
            }


            #endregion



            #region Loops : 

            // First Example
            int d = 3;

            while (d > 0)
            {
                Console.WriteLine("Loading");
                d--;
            }

            // Second Example
            List<string> collection = new List<string>() {"a","b","c" };

            for (int i = 0; i <collection.Count; i++)
            {
                Console.WriteLine(collection[i]);
            }



            #endregion


            #region Functions

            void PrintHi()
            {
                Console.WriteLine("Hi");
            }
            static void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }

            #endregion



            #region ModulusOperator


            Console.WriteLine(5 % 4);

            #endregion


            #region Increment and Decrement Operators

            int number = 4;
            number++;
            Console.WriteLine(number);


            #endregion


            #region IS and As Operators

            // Is operators
            bool climp = "Mountain" is string;
            Console.WriteLine(climp);

            Ex2 ex2Object = new Ex2();
            bool h = ex2Object is Ex1;
            Console.WriteLine(h);

            // As Operators
            string s1 = "abc";
            object obj1 = s1;
            string s2 = obj1 as string;

            #endregion


            #region  Ternary Operator

            int ab;
            int value;
            bool isGreater =  ab > value ? true : false;

            


            #endregion

        }
    }
}
