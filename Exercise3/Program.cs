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
    class CircularList
    {
        Node LAST;
        public CircularList()
        {
            LAST = null;
        }
        public bool Search(int rollNo, ref Node previous, ref Node current)/*Searches for the specified node */
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current.next)
            {
                if (rollNo == current.rollNumber)
                    return (true);/*returns true if the node is found*/
            }
            if (rollNo == current.rollNumber)/*if the node is present at the end*/
                return true;
            else
                return (false);/*returns fals if the node is not found*/
        }
        public bool listEmpty()
        {
            if (LAST == null)
                return true ;
            else
                return false ;
        }
        public void traverse()/*Traverses all the nodes of the list*/
        {
            if (!listEmpty())
                Console.WriteLine("\nList id Empty");
            else
            {
                Console.WriteLine("\nRecords in the list are:\n");
                Node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + " " + currentNode.name +"\n");
                    currentNode = currentNode.next;
                }
                Console.WriteLine(LAST.rollNumber + " " + LAST.name +"\n");
            }
        }
        public void firstNode()
        {
            if (listEmpty())
                Console.WriteLine("\nList is Empty");
            else
                Console.WriteLine("\nThe first record in the last list is: \n\n " + LAST.next.rollNumber + "  " + LAST.next.name);
        }
    }
}
