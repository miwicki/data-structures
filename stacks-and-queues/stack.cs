using System;
using System.Collections.Generic;
using System.Text;

namespace Stack.Classes
{
    class Stack
    {
        public Node Head { get; set; }
        public Node Runner { get; set; }

        public int Peek()
        {
            return Head.Value;
        }

        public void Push(int Val)
        {
            Head = new Node { Value = Val, Next = Head };
        }
        
        public void Pop()
        {
            Head = Head.Next;
        }
    }
}