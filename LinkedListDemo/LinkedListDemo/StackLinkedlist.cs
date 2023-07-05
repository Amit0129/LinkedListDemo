using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class StackLinkedlist
    {
        public Node top;
        public StackLinkedlist()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top= node;
            Console.WriteLine("Element in the stack " + data);
        }
        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        //Will return Top value but not delete
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine(top.data);
        }
    }
}
