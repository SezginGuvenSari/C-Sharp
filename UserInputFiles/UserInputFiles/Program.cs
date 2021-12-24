using System;

namespace UserInputFiles
{
    class Program
    {
        static void Main(string[] args)
        {


            #region ReadLine()


            Console.WriteLine("Type some text: ");

            string userInput = Console.ReadLine();

            System.Console.WriteLine(userInput);

            #endregion



            #region Read()

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

            #endregion
           

            #region ReadKey()


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

            #endregion



        }
    }
}
