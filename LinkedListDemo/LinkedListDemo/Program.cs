namespace LinkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter 1 for LinkedList Demo");
                Console.WriteLine("Enter 2 for Stack Demo");
                Console.WriteLine("Enter 3 for Coustom Linked List");
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
                        Linked_List linked_List = new Linked_List();
                        linked_List.Add(99);
                        linked_List.Add(999);
                        linked_List.Add(99999);
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