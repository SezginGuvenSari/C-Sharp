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


        #region Overloading

        // Can't be achieve the same things by creating multiple functions, each having a different name
        // Sure we can but overloading is best when you want to do the same operation with multiple inputs.


        void Ex() { }

        void Ex(int number) { }

        void Ex(int number,int number2) { }

        void Ex(string name,string name2) { }

        void Ex(int number,string name) { }

        void Ex(string name, int number) { }






        #endregion


        #region Overriding

        public void PrintHelloWorld()
        {
            System.Console.WriteLine("Hello World");
        }




        #endregion



        #region Optional Parameters


        static void PrintMessage(string message = "Hello World")  // We can't use this parameters  string message = "Hello World", int number
                                                                  // Because we don't have a int value. We need to change this code as follows
                                                                  // int number , string message = "Hello World"
        {
            System.Console.WriteLine(message);
        }

        #endregion

        static void Main(string[] args)
        {
            /* Program program = new Program();
             program.Id = "2312312";
             System.Console.WriteLine(program.Id);
             Program pr = new Program(5);
             Program ps = new Program(5, "Guven");
             System.Console.WriteLine(pr.programNumber);*/
            PrintMessage();
            PrintMessage("Other Message");


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


    public class  Program2 : Program
    {

      /*  public static void Main(string[] args)
        {
            Program2 ex = new Program2();
            ex.PrintHelloWorld();
        }*/
    }
}
