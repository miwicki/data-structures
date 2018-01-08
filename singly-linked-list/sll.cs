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
