using System;

namespace ControlFlowStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IF,else if,else

            /* if (3 < 5)
             {
                 System.Console.WriteLine("3 is less than 5");
             }*/
            if (5 < 3)
            {
                System.Console.WriteLine("3 is less than 5");
            }

            else if (2 < 4)

                System.Console.WriteLine("2 is less than 4");



            #endregion


            #region SwitchStatement

            int value = 11;   // For example int value = 2; You can change value.

            switch (value)
            {
                case 1:
                    System.Console.WriteLine("1");
                    break;
                case 2:
                    System.Console.WriteLine("2");
                    break;
                case 3:
                    System.Console.WriteLine("3");
                    break;
                case 4:
                    System.Console.WriteLine("4");
                    break;
                case 5:
                    System.Console.WriteLine("5");
                    break;
                case 6:
                    System.Console.WriteLine("6");
                    break;

                default:
                    System.Console.WriteLine("Other");
                    break;

            }



            #endregion


            #region For Loops

            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Hello World");
            }

            string example = "abc";

            for (int i = 0; i < example.Length; i++)
            {
                System.Console.WriteLine(example[i]);
            }

            
            int a = 0;
            for (; ; )
            {
                if (a < 4)
                {
                    System.Console.WriteLine(a.ToString());
                    a++;
                }
            }



            #endregion


            #region Foreach Loops

            foreach (char s in "abc")
            {
                System.Console.WriteLine(s);
            }

            #endregion



            #region While loops

            int g = 0;
            while (g<4)
            {
                System.Console.WriteLine(g.ToString());
                g++;
            }
            #endregion

        }
    }
}

