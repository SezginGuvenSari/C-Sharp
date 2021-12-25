using System;
using System.IO;
using System.Text;

namespace UserInputFiles
{
    class Program
    {
        static void Main(string[] args)
        {


            #region ReadLine()
            /*

            Console.WriteLine("Type some text: ");

            string userInput = Console.ReadLine();

            System.Console.WriteLine(userInput);
            */
            #endregion



            #region Read()
            /*
            //Example 1
            Console.WriteLine("Hit a key: ");

            int x = Console.Read();

            System.Console.WriteLine(x);
            System.Console.WriteLine(Convert.ToChar(x)); // We can see character


            //Example 2
            Console.WriteLine("g = green, r = red, b = blue, w = white ");
            int y = Console.Read();

            char userInputs = Convert.ToChar(y);

            while (userInputs != 'z')

            {

                switch (userInputs)
                {
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case 'r':
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case 'w':
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;
                }

                Console.Clear();

                Console.WriteLine("g = green, r = red, b = blue, w = white ");
                y = Console.Read();
                userInputs = Convert.ToChar(y);
            }
            */
            #endregion


            #region ReadKey()

            /*
            ConsoleKeyInfo keyInfo;
            Console.TreatControlCAsInput = true;

            do
            {
                keyInfo = Console.ReadKey();

                if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
                    Console.Write("ALT+");
                if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
                    Console.Write("SHIFT+");
                if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
                    Console.Write("CTL+");

            } while (keyInfo.Key !=ConsoleKey.Escape );
            */
            #endregion


            #region Obtaining numeric user input
            /*
            Console.WriteLine("\n Please enter a number: ");

            do
            {
                string userInput = Console.ReadLine();
                int number;

                if(!int.TryParse(userInput,out number))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You entered invalid Input! ");
                    Console.ResetColor();
                    Console.WriteLine("\n Please enter a number: ");

                }
                else
                {
                    Console.WriteLine("\n Thanks! Enter another number: ");
                }

            } while (true);

            */
            #endregion


            #region Working with files 

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            FileStream fs = File.Open(path, FileMode.Append);
            byte[] info = new UTF8Encoding(true).GetBytes("Hello World!");

            fs.Write(info, 0, info.Length);
            fs.Close();

            StreamReader sr = new StreamReader(path);
            string fileText = sr.ReadToEnd();
            System.Console.WriteLine(fileText);

            #endregion


        }
    }
}
