namespace LinkedListAssignment
{
    class Program
    {
        public static void  Main(String[] args)
        {
            Console.WriteLine("Welcom to the Linked List Program");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            linkedList.Search(30);
            linkedList.InsertNode(3, 40);
            Console.WriteLine("***************************");

            linkedList.Display();
            Console.WriteLine("40 inserted after 30");

        }
    }
}