using System;
using System.Collections.Generic;
using System.Text;

namespace Nodes
{

    public class Node
    {
        public object Value { get; set; }

        public Node Next { get; set; }

        public Node Prev { get; set; }
    }
}