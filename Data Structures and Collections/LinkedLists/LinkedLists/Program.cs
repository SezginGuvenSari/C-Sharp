using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    #region What is the Linked Lists ?
    // There are several types of linked lists : 
    // Simple Linked List : Only Forward navigation
    // Doubly Linked List : Forward and backward navigation 
    // Circular Linked List : Last element links to the first element.
    #endregion
    class Program
    {
        #region Simple Linked List Class
        public class LinkedList
        {
            public class Node
            {
                public Node next;
                public object data;
            }
            private Node root;

            public Node First { get { return root; } }

            public Node Last
            {
                get
                {
                    Node currentNode = root;
                    if (currentNode == null)
                    {
                        return null;
                    }

                    while (currentNode.next != null)
                    {
                        currentNode = currentNode.next;
                    }
                    return currentNode;
                }
            }

            public void Append(object value)
            {
                Node node = new Node { data = value };
                if (root == null)
                {
                    root = node;
                }
                else
                {
                    Last.next = node;
                }
            }

            public void Delete(Node node)
            {
                if (root == node)
                {
                    root = node.next;
                    node.next = null;
                }
                else
                {
                    Node current = root;
                    while (current.next != null)
                    {
                        if (current.next == node)
                        {
                            current.next = node.next;
                            node.next = null;
                            break;
                        }
                        current = current.next;
                    }
                }
            }
        }
        #endregion

       static LinkedList<string> linkedList = new LinkedList<string>();
        static void Main(string[] args)
        {
            linkedList.AddFirst("root");
            linkedList.AddAfter(linkedList.First, "element");
            linkedList.AddBefore(linkedList.First, "new root");
            linkedList.AddLast("last element");

            Console.WriteLine(linkedList.Count);
            Console.WriteLine(linkedList.First.Value);

            linkedList.Remove("root");
            linkedList.RemoveFirst();
        }
    }
}
