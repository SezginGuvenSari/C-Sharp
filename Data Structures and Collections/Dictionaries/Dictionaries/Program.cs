using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Dictionaries
{
    class Program
    {

        #region What is the Dictionary

        /*
          C# Dictionary class constructor takes a key data type and a value data type. 
          Both types are generic so it can be any .NET data type.
          The following Dictionary class is a generic class and can store any data type. 
          This class is defined in the code snippet creates a dictionary where both keys and values are string types.
         */
        #endregion
        static void Main(string[] args)
        {

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("key1", "value1");
            dictionary.Add("key2", "value2");
            dictionary.Add("key3", "value3");
            Debug.WriteLine(dictionary.Count);

            foreach (string key in dictionary.Keys)
            {
                Debug.WriteLine(key);  // We can see all keys.
            }
            foreach (string value in dictionary.Values)
            {
                Debug.WriteLine(value);  // We can see all values.
            }

            dictionary.Remove("key1");
            Debug.WriteLine(dictionary.Count);

        }
    }
}
