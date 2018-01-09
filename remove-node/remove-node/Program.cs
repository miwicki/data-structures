using System;

namespace remove_node
{
    class Program
    {

        public void Remove (int start, int end)
        {
            Node previousNode = null;
            Node currentNode = head;
            
            while (currentNode != null)
            {
                if (currentNode >= start && currentNode <= end)
                {
                    if (previousNode = null)
                    {
                        currentNode.Next = head;
                    }
                    else (previousNode.Next = currentNode.Next);
                }
                else (previousNode = currentNode);
            }
            currentNode = currentNode.Next;
        }
    }
}
