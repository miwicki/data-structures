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
    }
}