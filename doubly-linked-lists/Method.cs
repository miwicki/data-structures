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
                Node Runner = Head;

                while (Runner.Next != null)
                {
                    Runner = Runner.Next;
                }

                Runner.Next = last;

                Runner.Next.Prev = Runner;
            }
            Counter++;
        }

        public void AddBefore(Node targetNode, Node newNode)
        {
            if (Head == null)
            {
                return;
            }

            Node Runner = Head;

            while (Runner.Next != targetNode)
            {
                if (Runner.Next != null)
                {
                    Runner = Runner.Next;
                }
                else
                {
                    return;
                }
            }

            newNode.Next = Runner.Next;

            Runner.Next.Prev = newNode;

            Runner.Next = newNode;

            newNode.Prev = Runner;

            Counter++;
        }

        public void AddAfter(Node targetNode, Node newNode)
        {
            if (Head == null)
            {
                return;
            }

            Node Runner = Head;

            while (Runner != targetNode)
            {
                if (Runner.Next != null)
                {
                    Runner = Runner.Next;
                }
                else
                {
                    return;
                }
            }
            newNode.Next = Runner.Next;

            Runner.Next.Prev = newNode;

            Runner.Next = newNode;

            newNode.Prev = Runner;

            Counter++;
        }

        public void Remove(Node targetNode)
        {
            if (Head == null)
            {
                return;
            }

            Node Runner = Head;

            while (Runner != targetNode)
            {
                if (Runner.Next != null)
                {
                    Runner = Runner.Next;
                }
                else
                {
                    return;
                }
            }

            if (Counter == 1)
            {
                Head = null;
            }

            else if (Runner.Prev == null)
            {
                Head = Runner.Next;
                Runner.Next.Prev = null;
            }

            else if (Runner.Next == null)
            {
                Runner.Prev.Next = null;
            }

            else
            {
                Runner.Prev.Next = Runner.Next;
                Runner.Next.Prev = Runner.Prev;
            }

            Runner = null;
            Counter--;

        }
    }
}

