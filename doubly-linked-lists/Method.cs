using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Methods
    {
        public Node Head { get; set; }
        private int Counter { get; set; }

        public Methods(Node node)
        {
            Head = node;

            Counter = 1;
        }

        
        public void AddFirst(Node first)
        {
            if (Head == null)
            {
                Head = first;
            }
            else
            {
                first.Next = Head;

                Head = first;

                Head.Next.Prev = Head;
            }

            Counter++;
        }

        public void AddLast(Node last)
        {
            if (Head == null)
            {
                Head = last;
            }
            else
            {
                Node Current = Head;

                while (Current.Next != null)
                {
                    Current = Current.Next;
                }

                Current.Next = last;

                Current.Next.Prev = Current;
            }
            Counter++;
        }

        public void AddBefore(Node targetNode, Node newNode)
        {
            if (Head == null)
            {
                return;
            }

            Node Current = Head;

            while (Current.Next != targetNode)
            {
                if (Current.Next != null)
                {
                    Current = Current.Next;
                }
                else
                {
                    return;
                }
            }

            newNode.Next = Current.Next;

            Current.Next.Prev = newNode;

            Current.Next = newNode;

            newNode.Prev = Current;

            Counter++;
        }

        public void AddAfter(Node targetNode, Node newNode)
        {
            if (Head == null)
            {
                return;
            }

            Node Current = Head;

            while (Current != targetNode)
            {
                if (Current.Next != null)
                {
                    Current = Current.Next;
                }
                else
                {
                    return;
                }
            }
            newNode.Next = Current.Next;

            Current.Next.Prev = newNode;

            Current.Next = newNode;

            newNode.Prev = Current;

            Counter++;
        }

    }
}