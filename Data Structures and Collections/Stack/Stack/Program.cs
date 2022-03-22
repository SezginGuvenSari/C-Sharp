using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{


    public class Program
    {

        #region Information about the Stack

        // -LIFO -Last In, First Out
        //- Capacity - the number of elements the stack can hold
        // -Push(), Pop(), Peek(), Clear() operations
        // Push(): Add an element to stack.
        // Pop() : Remove an element from the stack
        // Peek() : Get the top element, but don't remove it.
        // Clear() : Remove all element from the stack.
        // Count - get the number of stack elements.


        // Balanced Braces Problem

        /* Balanced      Not Balanced
           
             ()               (]
             <>               [[]
             []              ((())
           [[()]]             <[>
        */
        //Given a string of brackets, determine if it is balanced.
        //Return true if it is balanced,return false if it is not balanced.

        #endregion


        public static void Main(string[] args)
        {
            /* Stack<string> s = new Stack<string>();

             s.Push("a");
             s.Push("b");
             Debug.WriteLine("The stack contains " + s.Count +  "elements");
            */

            Debug.WriteLine(IsBalanced("{{[]}}").ToString());
            Debug.WriteLine(IsBalanced("(((]").ToString());
        }

        private static bool IsBalanced(string inputString)
        {
            Stack<char> stackOfClosingBraces = new Stack<char>();
            Stack<char> stackOfOpeningBraces = new Stack<char>();

            foreach (char c in inputString)
            {
                if (c == '}' || c == ']' || c == ')')
                {
                    stackOfClosingBraces.Push(c);
                }
            }

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                if (inputString[i] == '{' || inputString[i] == '[' || inputString[i] == '(')
                {
                    stackOfOpeningBraces.Push(inputString[i]);
                }
            }

            if ((stackOfClosingBraces.Count + stackOfOpeningBraces.Count) % 2 != 0)
            {
                return false;
            }
            while (stackOfClosingBraces.Count != 0)
            {
                char currentClosingBrace = stackOfClosingBraces.Pop();
                char currentOpeningBrace = stackOfOpeningBraces.Pop();

                if ((currentClosingBrace == '}' && currentOpeningBrace == '{') || (currentClosingBrace == ']' && currentOpeningBrace == '[') ||
                    (currentClosingBrace == ')' && currentOpeningBrace == '('))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }
    }
}
