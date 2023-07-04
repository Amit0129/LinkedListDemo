using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class Linked_List
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"{node.data} Inserted to Linked List");
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("The LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

        }
        public void Reverse_Order(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.next = temp;
            }
        }
        public void Remove_First()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            head = head.next;
            Console.WriteLine("First element run Sucessfully");
        }
        public void Remove_Last()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            if (head.next == null)
            {
                Console.WriteLine("The LinkedList Only contain one element");
                head = null;
            }
            else
            {
                Node temp = head.next;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }
        public void Size()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            Node temp = head;
            int count = 1;
            while (temp.next != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("The lengtn of the LinkedList is " + count);
        }

    }
}
