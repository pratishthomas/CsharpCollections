using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class NodeChain
    {
       public static void CreateNodes()
        {
            Node first = new Node { Value = 1 };

            Node middle = new Node { Value = 2 };

            first.Next = middle;

            Node last = new Node { Value = 3 };

            middle.Next = last;

            PrintList(first);

        }

        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
