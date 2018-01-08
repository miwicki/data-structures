using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges.Week_02
{
    public class SLL
    {
        public SLLNode Head = new SLLNode();

        public void AddFirst(int value)
        {
            SLLNode newNode = new SLLNode { Value = value };
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
            return;
        }

        public void AddLast(int value)
        {
            SLLNode newNode = new SLLNode();
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            SLLNode current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void AddBefore(int value, int targetedValue)
        {
            if (Head == null)
            {
                Console.WriteLine("no nodes exist");
                return;
            }

            SLLNode newNode = new SLLNode();
            if (Head.Value == targetedValue)
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            if (Head.Next != null)
            {
                SLLNode current = Head.Next;
                SLLNode previous = Head;
                while (current != null)
                {
                    if (current.Value == targetedValue)
                    {
                        previous.Next = newNode;
                        newNode.Next = current;
                        return;
                    }
                    current = current.Next;
                    previous = previous.Next;
                }
                Console.WriteLine("node doesn't exist");
                return;
            }
        }

        public void AddAfter(int value, int targetedValue)
        {
            if (Head == null)
            {
                Console.WriteLine("Head is null");
                return;
            }

            SLLNode newNode = new SLLNode();
            if (Head.Value == targetedValue)
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            if (Head.Next != null)
            {
                SLLNode current = Head.Next;
                SLLNode previous = Head;
                while (previous != null)
                {
                    if (previous.Value == targetedValue)
                    {
                        previous.Next = newNode;
                        newNode.Next = current;
                        return;
                    }
                    current = current.Next;
                    previous = previous.Next;
                }
            }
            Console.WriteLine("node not found");
        }

        public void RemoveNode(int targetedValue)
        {
            if (Head != null)
            {
                Console.WriteLine("Head is not found");
                return;
            }

            if (Head.Value == targetedValue)
            {
                Head = Head.Next;
                return;
            }
            if (Head.Next != null)
            {
                SLLNode current = Head.Next;
                SLLNode prev = Head;
                while (current != null)
                {
                    if (current.Value == targetedValue)
                    {
                        SLLNode temp = current.Next;
                        current = null;
                        prev.Next = temp;
                        return;
                    }
                    current = current.Next;
                    prev = prev.Next;
                }
            }

            Console.WriteLine("node not found");
        }

        public SLLNode FindMiddle()
        {
            SLLNode midNode = Head;
            SLLNode lastNode = Head;

            while (lastNode.Next != null && lastNode.Next.Next != null)
            {
                midNode = midNode.Next;
                lastNode = lastNode.Next.Next;
                Console.WriteLine($"{midNode} is the middle value for the SLL");
            }

            return midNode;

        }

        //find Nth from the end
        public SLLNode FindNthFromLast(int n)
        {
            SLLNode walker = Head;
            SLLNode sleeper = Head;
            int counter = 1;

            while (walker.Next != null)
            {
                if (counter >= n)
                {
                    sleeper = sleeper.Next;
                }
                walker = walker.Next;
                counter++;
                Console.WriteLine("");
            }
            return sleeper;
        }
    }
}