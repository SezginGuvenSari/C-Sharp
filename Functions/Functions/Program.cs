using System;

namespace Functions
{
    public class Program
    {


        #region Constructors

        int programNumber;
        string exampleName;

        public  Program(int num)

            {

            programNumber = num;

            }

        public Program(int num,string name)

        {

            programNumber = num;
            exampleName = name;

        }



        #endregion



        static void Main(string[] args)
        {

            Program pr = new Program(5);
            Program ps = new Program(5, "Guven");
            System.Console.WriteLine(pr.programNumber);



        }
    }
}
