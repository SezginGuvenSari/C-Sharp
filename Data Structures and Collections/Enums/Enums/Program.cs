using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Enums
{

    #region What is the enums ? 
    /*
      In the C# language, enum (also called enumeration) is a user-defined value type used to represent a list of named integer constants.
      It is created using the enum keyword inside a class, structure, or namespace.
      It improves a program’s readability, maintainability and reduces complexity.
     */
    #endregion
    public class Program
    {
        enum Weekday { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        static void Main(string[] args)
        {
            Debug.WriteLine(Enum.GetName(typeof(Weekday),6));
            Debug.WriteLine(" ");
            foreach (string s in Enum.GetNames(typeof(Weekday)))
            {
                Debug.WriteLine(s);
            }
            Debug.WriteLine(" ");
            foreach (int i in Enum.GetValues(typeof(Weekday)))
            {
                Debug.WriteLine(i);
            }
        }
    }
}
