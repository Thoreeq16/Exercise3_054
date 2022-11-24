using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Node
    {
        /*creates Nodes for the circular nested list
         * It consist of the information part and links to
         * its succeeding and preceeding nodes
         * in terms of next and previous nodes.*/
        public int rollNumber;
        public string name;
        public Node next;/*points to the suceeding node*/
        public Node prev;/*points to the suceeding node*/
    }
}
