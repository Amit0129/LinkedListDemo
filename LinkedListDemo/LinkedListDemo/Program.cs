using System.Collections.Generic;

namespace LinkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            bool check = true;
            Linked_List linked_List = new Linked_List();
            StackLinkedlist stackList = new StackLinkedlist();
            Queue_LinkedList queueList = new Queue_LinkedList();
            while (check)
            {
                Console.WriteLine("Enter 1 for LinkedList Demo");
                Console.WriteLine("Enter 2 for Stack Demo");
                Console.WriteLine("Enter 3 for Adding and Displaying LinkedList data");
                Console.WriteLine("Enter 4 for Adding in Reverse Order");
                Console.WriteLine("Enter 5 for Remove First Element");
                Console.WriteLine("Enter 6 for Remove Last Element");
                Console.WriteLine("Enter 7 to get the Size of LinkedList");
                Console.WriteLine("Enter 8 for searching index of a value");
                Console.WriteLine("Enter 9 for adding data to stack");
                Console.WriteLine("Enter 10 for adding data to Queue");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LinkedListBuilder linkedListBuilder = new LinkedListBuilder();
                        linkedListBuilder.LinkList();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Stack Demo And Examples");
                        StackDemo stackDemo = new StackDemo();
                        stackDemo.Stack();
                        break;
                    case 3:
                        linked_List.Add(99);
                        linked_List.Add(999);
                        linked_List.Add(99999);
                        linked_List.Display();
                        break;
                    case 4:
                        linked_List.Reverse_Order(29);
                        linked_List.Reverse_Order(92);
                        linked_List.Reverse_Order(11);
                        linked_List.Display();
                        break;
                    case 5:
                        linked_List.Remove_First();
                        linked_List.Display();
                        break;
                    case 6:
                        linked_List.Remove_Last();
                        linked_List.Display();
                        break;
                    case 7:
                        linked_List.Size();
                        linked_List.Display();
                        break;
                    case 8:
                        int indexValue = linked_List.Search(11);
                        Console.WriteLine(indexValue);
                        break;
                    case 9:
                        stackList.Push(100);
                        stackList.Push(200);
                        stackList.Push(300);
                        stackList.Display();
                        Console.WriteLine("---------------");
                        stackList.Peek();
                        Console.WriteLine("---------------");
                        stackList.Pop();
                        Console.WriteLine("---------------");
                        stackList.Display();
                        break;
                    case 10:
                        queueList.Enqueue(9);
                        queueList.Enqueue(10);
                        queueList.Enqueue(11);
                        Console.WriteLine("---------------");
                        queueList.Dequeue();
                        Console.WriteLine("---------------");
                        queueList.Display();
                        break;
                    default:
                        Console.WriteLine("Enter Valid Choice");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Enter y if you want to do more operation");
                string exitOrNot = Console.ReadLine().ToLower();
                if (exitOrNot == "y")
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
        }
    }
}