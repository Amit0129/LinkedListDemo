using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class StackDemo
    {
        public void Stack() 
        {
            Stack stack = new Stack();
            stack.Push("Amit");
            stack.Push(2);  
            stack.Push("Kumar");
            stack.Push(4);
            stack.Push("Nayak");

            foreach (var item in stack)
            {
                Console.WriteLine("Element " + item);
            }
            Console.WriteLine("No of element is "+stack.Count);
            Console.WriteLine(stack.Contains(2));
            Console.WriteLine(stack.Contains(10));
            Console.WriteLine();
            Console.WriteLine("Using Peek Method");
            Console.WriteLine(stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine("Element " + item);
            }
            Console.WriteLine();
            Console.WriteLine("Using Pop method");
            Console.WriteLine(stack.Pop());
            foreach (var item in stack)
            {
                Console.WriteLine("Element " + item);
            }
        }
    }
}
