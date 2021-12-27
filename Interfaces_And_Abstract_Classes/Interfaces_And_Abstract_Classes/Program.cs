using System;
using System.ComponentModel;
using System.Collections;
namespace Interfaces_And_Abstract_Classes
{
    class Program : IExample, ISecondExample, INotifyPropertyChanged, IComparable,IComparer
    {
        #region IComparable
        public int exampleLength;
        Program ex1 = new Program() { exampleLength = 2 };
        #endregion
        

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

        public int CompareTo(object obj)
        {
            Program ex2 = (Program)obj;

            if (ex1.exampleLength == ex2.exampleLength)
            {
                return 0;
            }
            else if(ex1.exampleLength > ex2.exampleLength)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }

        public int Compare(object x, object y)
        {
            Employee employee1 = (Employee)x;
            Employee employee2 = (Employee)y;
            return employee1.id.CompareTo(employee2.id);
        }


        #endregion

    }

    #region IComparer

    class Employee
    {
        public int id;
    }

    #endregion
   


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
