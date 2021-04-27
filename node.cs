using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkList
{
    class node
    {
        public string name;
        public node next;
        public node previous;
        public node(node previous,string name, node next)
        {
            this.name = name;
            this.next = next;
            this.previous = previous;
        }
    }
}
