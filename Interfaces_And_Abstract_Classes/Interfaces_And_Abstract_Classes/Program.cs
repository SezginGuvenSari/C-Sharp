using System;
using System.ComponentModel;
namespace Interfaces_And_Abstract_Classes
{
    class Program : IExample,ISecondExample, INotifyPropertyChanged
    {


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;


        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
            }
        }


        #endregion
       


        static void Main(string[] args)
        {

            


        }
        #region Implementing an Interface

        public void Example()
        {
            System.Console.WriteLine("Hello World");
        }

        public int Example2()
        {
            return 1;
        }

        public string Example3(string string1, string string2)
        {
            return string1 + " " + string2;
        }


        #endregion

    }



    #region  Creating an Interface 


    interface IExample
    {

        void Example();
        int Example2();
        string Example3(string string1, string string2);


    }

    interface ISecondExample
    {

    }


    #endregion
}
