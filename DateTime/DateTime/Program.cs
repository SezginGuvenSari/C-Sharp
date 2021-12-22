using System;

namespace DateTimes
{
    class Program
    {
       public static void Main(string[] args)
        {

            #region DateTime

            System.Console.WriteLine(DateTime.Now);

            DateTime date = new DateTime(2020,1,9);

            System.Console.WriteLine(date);


            #endregion

            #region TimeSpan

            TimeSpan timeSpan = new TimeSpan(1,2,0);
            System.Console.WriteLine(timeSpan.Hours);
            System.Console.WriteLine(timeSpan.Minutes);
            System.Console.WriteLine(timeSpan.Seconds);

            #endregion



        }
    }
}
