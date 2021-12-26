using System;

namespace Functions
{
    public class Program
    {


        #region Constructors

      /*  int programNumber;
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


        */
        #endregion


        #region Properties
        /*

        // public string Id { get; set; } 
        private string id;


        public string Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        */
        #endregion


        static void Main(string[] args)
        {
            /* Program program = new Program();
             program.Id = "2312312";
             System.Console.WriteLine(program.Id);
             Program pr = new Program(5);
             Program ps = new Program(5, "Guven");
             System.Console.WriteLine(pr.programNumber);*/


            #region Anonymus Functions and  Lambda Expressions

            Action debug = () => System.Console.WriteLine("Hello World");
            debug();

            Action<string> debug2 = (s) => System.Console.WriteLine(s);
            debug2("Example");


            #endregion


            #region Func<TResult>

            Func<int, int, int> multiply = (x, y) => { return x * y; };
            System.Console.WriteLine(multiply(3, 2));

            #endregion


        }
    }
}
