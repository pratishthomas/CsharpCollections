using System;
using System.Linq;
using System.Collections.Generic;
using Collections.LinkedList;
using System.Threading;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = "pratish";
            string c1 = c;
            c1 = "ppt";

            Console.WriteLine(c);
            Console.WriteLine(c1);
            Console.WriteLine(c);
            Console.Read();

            LinkedList.LinkedList<int> linkedList = new LinkedList.LinkedList<int>
            {
                Head = null,
                Tail = null
            };

            LinkedList.Node<int> node1 = new Collections.LinkedList.Node<int>
            {
                Value = 10
            };

            LinkedList.Node<int> node2 = new Collections.LinkedList.Node<int>
            {
                Value = 8
            };

            LinkedList.Node<int> node3 = new Collections.LinkedList.Node<int>
            {
                Value = 7
            };

            linkedList.AddFirst(node1);
            linkedList.AddFirst(node2);
            linkedList.AddFirst(node3);

            PrintList(linkedList);

            Console.ReadLine();

            
            
        }

        async void LongRunningMethod()
        {
          await Task.Run(() => Thread.Sleep(3000));

        }

        private static void PrintList(LinkedList.LinkedList<int> linkedList)
        {
            if(linkedList.Head != null)
            {
                Node<int> node = linkedList.Head.Next;
                Console.WriteLine(linkedList.Head.Value);
                while(node != null)
                {
                    Console.WriteLine(node.Value);
                    node = node.Next; 
                };
            }

        }
    }



    class StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
                
    }
}
