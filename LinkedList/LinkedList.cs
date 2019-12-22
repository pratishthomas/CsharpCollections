using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.LinkedList
{
    class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

       public void AddFirst(Node<T> node)
        {
            if(Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }

        public void AddLast(Node<T> node)
        {
            if(Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }

    }
}
