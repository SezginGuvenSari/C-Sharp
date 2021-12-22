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

            #region Formatting Dates And Times

            System.Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
            System.Console.WriteLine(DateTime.Now.ToString("ddd,dd MMMM yyyy"));
            System.Console.WriteLine(DateTime.Now.ToString("ddd,dd MMMM yyyy HH:mm:ss"));
            System.Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));

            #endregion

            #region UTC Time

            System.Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));
            System.Console.WriteLine(DateTime.UtcNow.ToString("MM/dd/yyyy hh:mm tt"));
            System.Console.WriteLine(DateTime.Now.ToUniversalTime().ToString("MM/dd/yyyy hh:mm tt"));

            #endregion

        }
    }
}
