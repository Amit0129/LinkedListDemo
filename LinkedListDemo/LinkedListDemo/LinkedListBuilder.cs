using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    //LinkedList is an linear DataStructure which store the data in a Non-contigus way.
    //The node or Element are linked with each other using pointer.
    //LinkedList class Allow Insertion and Deletion of element from a list very fastly. 
    //Node-node will be your exact value.
    //Next-isreference of the next node.
    public class LinkedListBuilder
    {
        public void LinkList()
        {
            LinkedList<int> demo = new LinkedList<int>();
            demo.AddLast(23);
            demo.AddLast(20);
            demo.AddLast(45);
            demo.AddLast(55);
            demo.AddFirst(100);
            foreach (var item in demo)
            {
                Console.WriteLine("Element in Linked List: " +item);
            }
            Console.WriteLine("=======================================================================");
            Console.WriteLine("No. of element in Linked list is " + demo.Count);
            Console.WriteLine("Element Removed " + demo.Remove(55));
            

            foreach (var item in demo)
            {
                Console.WriteLine("Element in Linked List: " + item);
            }
            Console.WriteLine("========================================================================");
            demo.Remove(demo.First());
            foreach (var item in demo)
            {
                Console.WriteLine("Element in Linked List: " + item);
            }
            Console.WriteLine("Count is "+ demo.Count);
            Console.WriteLine("===========================================================================");
            demo.Remove(demo.Last());
            foreach (var item in demo)
            {
                Console.WriteLine("Element in Linked List: " + item);
            }
            Console.WriteLine("================================================================================");
            demo.Clear();
            Console.WriteLine("Linked List Clear");
            foreach (var item in demo)
            {
                Console.WriteLine("Element in Linked List: " + item);
            }
            Console.WriteLine("Count is " + demo.Count);
            Console.WriteLine("=================================================================================");
            if (demo.Contains(55)==true)
            {
                Console.WriteLine("The Element is present in Linked List");
            }
            else
            {
                Console.WriteLine("The Element is not found");
            }
        }
    }
}
