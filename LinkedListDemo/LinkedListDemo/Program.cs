namespace LinkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            bool check = true;
            Linked_List linked_List = new Linked_List();

            while (check)
            {
                Console.WriteLine("Enter 1 for LinkedList Demo");
                Console.WriteLine("Enter 2 for Stack Demo");
                Console.WriteLine("Enter 3 for Adding and Displaying LinkedList data");
                Console.WriteLine("Enter 4 for Adding in Reverse Order");
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
                    default:
                        Console.WriteLine("Enter Valid Choice");
                        break;
                }

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